using DevExpress.Mvvm;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using VideoArchive.App.Model;
using VideoArchive.Model;

namespace VideoArchive.App.ViewModel
{
    class EditVideoViewModel : Notify
    {
        public Video VideoInfo { get; set; }

        public DelegateCommand AddKeyWord
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    VideoInfo.KeyWords.Add(new KeyWordItem(""));
                });
            }
        }

        public DelegateCommand<KeyWordItem> DeleteKeyWord
        {
            get
            {
                return new DelegateCommand<KeyWordItem>((keyword) =>
                {
                    if (keyword != null)
                    {
                        VideoInfo.KeyWords.Remove(keyword);
                    }
                });
            }
        }

        public DelegateCommand<Window> Save
        {
            get
            {
                return new DelegateCommand<Window>((w) =>
                {
                    foreach (var key in VideoInfo.KeyWords)
                    {
                        if (JsonBase.GetInstance().KeyWords.FirstOrDefault(s => key.Value == s) == null)
                        {
                            JsonBase.GetInstance().KeyWords.Add(key.Value);
                        }
                    }
                    w?.Close();
                });
            }
        }


        public ICommand UpdateVideoInfo
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var info = new YouTubeAPI().getVideoInfo(VideoInfo.Name);

                    if (info != null)
                    {
                        VideoInfo.Channel = info.Channel;
                        VideoInfo.Description = info.Description;
                        VideoInfo.PublishData = info.PublicDate;
                        VideoInfo.Url = info.Url;
                    }

                });
            }
        }

    }
}
