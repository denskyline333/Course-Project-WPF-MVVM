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


namespace VideoArchive.App.ViewModel
{
    class AdminViewModel:Notify
    {
        //public List<User> UsersGrid { get; set; }
        //UsersEntities db;
        //public AdminViewModel()
        //{
        //    db = new UsersEntities();
        //    db.Users.Load();
        //    UsersGrid = db.Users.ToList();
        //}
       
        public DelegateCommand<Window> CloseAdmin
        {
            get
            {
                return new DelegateCommand<Window>((w) =>
                {
                    w?.Close();
                });

            }
        }
        //public ICommand UpdateUser
        //{
        //    get
        //    {
        //        return new DelegateCommand(() =>
        //        {
        //            db.SaveChanges();
        //        });
        //    }
        //}
        //public ICommand RemoveUser
        //{
        //    get
        //    {
        //        return new DelegateCommand(() =>
        //        {
        //            if (UsersGrid.SelectedItems.Count > 0)
        //            {
        //                for (int i = 0; i < UsersGrid.SelectedItems.Count; i++)
        //                {
        //                    User user = UsersGrid.SelectedItems[i] as User;
        //                    if (phone != null)
        //                    {
        //                        db.Users.Remove(user);
        //                    }
        //                }
        //            }

        //        });
        //    }
        //}
       

    }
}
