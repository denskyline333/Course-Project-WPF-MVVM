using DevExpress.Mvvm;
using Microsoft.Win32;
using Newtonsoft.Json;
using NReco.VideoInfo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
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
using VideoArchive.App.Views.SmallWindows;
namespace VideoArchive.App.Views
{
    public partial class AdminWindow : Window
    {
        
        UsersEntities db;
        public AdminWindow()
        {
            InitializeComponent();         
            db = new UsersEntities();
            db.Users.Load();
            usersGrid.ItemsSource = db.Users.Local.ToBindingList();
        }
        
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();         
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
                      
            if (usersGrid.SelectedItems.Count == 0)
            {
                UserNotChecked user = new UserNotChecked();
                user.ShowDialog();
            }
            if (usersGrid.SelectedItems.Count > 0)
            {                
                for (int i = 0; i < usersGrid.SelectedItems.Count; i++)
                {
                    User user = usersGrid.SelectedItems[i] as User;
                    if (user != null)
                    {
                        db.Users.Remove(user);
                    }
                }
            }
            db.SaveChanges();
        }
    }
}
