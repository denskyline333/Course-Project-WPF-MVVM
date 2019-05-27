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
using VideoArchive.App.Views.SmallWindows;
namespace VideoArchive.ViewModel
{
    class AuthViewModel : Notify
    {

        UsersRepository users = new UsersRepository();
        public string Login { get; set; }
        public string Password { get; set; }


        public DelegateCommand<Window> Auth
        { 
            get
            {
                return new DelegateCommand<Window>((w) =>
                {
                    
                    if (Login=="admin" && Password == "admin")
                    {
                        CurrentUser.currentUser = users.GetUsersByLogin(Login);
                        AdminWindow adminWindow = new AdminWindow();
                        adminWindow.ShowDialog();                       
                    }

                    else if (users.IsUser(Login, User.getHash(Password)) != null)
                    {
                        
                        CurrentUser.currentUser = users.GetUsersByLogin(Login);
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        w?.Close();
                    }
                    else
                    {
                        EnterAnother enterAnother = new EnterAnother();
                        enterAnother.ShowDialog();
                       
                    }
                    
                });
            }
        }

        public ICommand CreateRegistration
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    RegistrationWindow registrationWindow = new RegistrationWindow();
                    registrationWindow.ShowDialog();

                });
            }
        }
    }
}
