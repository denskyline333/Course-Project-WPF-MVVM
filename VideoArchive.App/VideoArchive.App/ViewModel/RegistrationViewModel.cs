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
using VideoArchive.App;
using VideoArchive.App.Model;
using VideoArchive.App.Views;
using VideoArchive.Model;
using VideoArchive.App.ViewModel;
using VideoArchive.App.Views.SmallWindows;
namespace VideoArchive.App.ViewModel
{
    class RegistrationViewModel : Notify
    {
        UsersRepository users = new UsersRepository();
        public string LoginTmp { get; set; }
        public string PasswordTmp { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public ICommand Registration
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (users.IsExist(LoginTmp) != null || LoginTmp=="admin")
                    {
                        IsLoginBusy isLoginBusy = new IsLoginBusy();
                        isLoginBusy.ShowDialog();                        
                    }
                    else if (LoginTmp != null && PasswordTmp !=null && FirstName != null && SecondName != null)
                    {
                        string hashPass = User.getHash(PasswordTmp);
                        User tmp = new User(FirstName, SecondName, LoginTmp, hashPass);
                        users.AddUser(tmp);
                        Success success = new Success();
                        success.ShowDialog();
                        
                    }
                    else
                    {
                        Incorrect incorrect = new Incorrect();
                        incorrect.ShowDialog();
                    }
                });
            }
        }

        public DelegateCommand<Window> Back
        {
            get
            {
                return new DelegateCommand<Window>((w) =>
                {
                    w?.Close();
                });

            }
        }
    }
}
