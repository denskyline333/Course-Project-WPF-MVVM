﻿using DevExpress.Mvvm;
using Microsoft.Win32;
using Newtonsoft.Json;
using NReco.VideoInfo;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using VideoArchive.App;
using VideoArchive.App.Model;
using VideoArchive.App.ViewModel;
using VideoArchive.App.Views;
using VideoArchive.Model;

namespace VideoArchive.ViewModel
{
    public class MainViewModel : Notify
    {
        public ObservableCollection<Video> Videos { get; set; }  
        public ICollectionView VideosView { get; set; }  
        public Video SelectedVideo { get; set; } 

        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private string _SearchText { get; set; }

        public string SearchText
        {
            get => _SearchText;
            set
            {
                _SearchText = value;
                VideosView.Filter = (obj) =>
                {
                    if (obj is Video video)
                    {
                        switch (SearchText.FirstOrDefault())
                        {
                            case '@': return video.KeyWords.FirstOrDefault(s => s.Value.ToLower().Contains(SearchText.Remove(0, 1).ToLower())) != null;
                            case '#': return video.Tematic?.ToLower().Contains(SearchText.Remove(0, 1).ToLower()) == true;
                            case '!': return video.Channel?.ToLower().Contains(SearchText.Remove(0, 1).ToLower()) == true;
                            default: return video.Name.ToLower().Contains(SearchText.ToLower());
                        }
                    }

                    return false;
                };
               VideosView.Refresh();

            }
        }
        public MainViewModel()
        {
            OverlayService.GetInstance().Show = (str) =>
            {
                OverlayService.GetInstance().Text = str;
            };
           
            Name = "";
            Surname = "";
            Login = "";
            if (CurrentUser.currentUser != null)
            {
                Name = CurrentUser.currentUser.firstName;
                Surname = CurrentUser.currentUser.secondName;
                Login = CurrentUser.currentUser.login;
            }
            
            Videos = File.Exists("VideosData.json") ? JsonConvert.DeserializeObject<ObservableCollection<Video>>(File.ReadAllText("VideosData.json")) : new ObservableCollection<Video>();
            Videos.CollectionChanged += (s, e) =>
            {
                File.WriteAllText("VideosData.json", JsonConvert.SerializeObject(Videos));
            };
            BindingOperations.EnableCollectionSynchronization(Videos, new object());
            VideosView = CollectionViewSource.GetDefaultView(Videos);

        }
        public DelegateCommand<Window> ExitFromMain
        {
            get
            {
                return new DelegateCommand<Window>((w) =>
                {
                    AuthWindow auth = new AuthWindow();
                    auth.Show();
                    w?.Close();
                });
            }
        }

        public ICommand Sort
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (VideosView.SortDescriptions.Count > 0)
                    {
                        VideosView.SortDescriptions.Clear();                      
                    }
                    else
                    {
                        VideosView.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
                    }
                });
            }
        }
        public ICommand DeleteVideo
        {
            get
            {
                return new DelegateCommand<Video>((video) =>
                {
                    Videos.Remove(video);
                    SelectedVideo = Videos.FirstOrDefault();

                }, (video) => video != null);
            }
        }
        public ICommand AddItem
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    var opd = new OpenFileDialog();
                    opd.Multiselect = true;
                    if (opd.ShowDialog() == true)
                    {
                        await Task.Factory.StartNew(() =>
                        {
                            OverlayService.GetInstance().Show("Загрузка информации о видео...");

                            IVideoHostApi api = new YouTubeAPI();

                            for (int i = 0; i < opd.FileNames.Length; i++)
                            {
                                OverlayService.GetInstance().Show($"Загрузка информации о видео...{Environment.NewLine}{i}/{opd.FileNames.Length}");
                                var file = opd.FileNames[i];
                                var info = api.getVideoInfo(Path.GetFileNameWithoutExtension(file)); //***

                                Videos.Add(new Video
                                {
                                    Path = file,
                                    Name = Path.GetFileNameWithoutExtension(file),
                                    Size = (new FileInfo(file).Length / 1024.0) / 1024.0,
                                    Duration = new FFProbe().GetMediaInfo(file).Duration,
                                    Channel = info.Channel,
                                    Description = info.Description,
                                    PublishData = info?.PublicDate ?? new DateTime(),
                                    Url = info.Url,
                                });

                                Task.Delay(500).Wait();
                            }
                            SelectedVideo = Videos.FirstOrDefault(s => s.Path == opd.FileNames.FirstOrDefault());
                            OverlayService.GetInstance().Close();
                        });
                    }

                });
            }
        }
        public ICommand TematicClick
        {
            get
            {
                return new DelegateCommand<string>((tematic) =>
                {
                    if (tematic != null)
                    {
                        SearchText = "#" + tematic;
                    }
                });
            }
        }
        public ICommand GoToUrl
        {
            get
            {
                return new DelegateCommand<string>((url) =>
                {
                    if (new Uri(url).IsFile)
                    {
                        Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + url));
                    }
                    else
                    {
                        Process.Start(url);
                    }
                });
            }
        }
        public ICommand EditVideo
        {
            get
            {
                return new DelegateCommand<Video>((video) =>
                {
                    var w = new EditVideoWindow();
                    var vm = new EditVideoViewModel
                    {
                        VideoInfo = video,
                    };
                    w.DataContext = vm;
                    w.ShowDialog();
                    File.WriteAllText("VideosData.json", JsonConvert.SerializeObject(Videos));

                }, (video) => video != null);
            }
        }

        public ICommand KeyWordClick
        {
            get
            {
                return new DelegateCommand<KeyWordItem>((word) =>
                {
                    if (word != null)
                    {
                        SearchText = "@" + word.Value;
                    }
                });
            }
        }
        public ICommand ChannelClick
        {
            get
            {
                return new DelegateCommand<string>((channel) =>
                {
                    if (channel != null)
                    {
                        SearchText = "!" + channel;
                    }
                });
            }
        }

    }
}

