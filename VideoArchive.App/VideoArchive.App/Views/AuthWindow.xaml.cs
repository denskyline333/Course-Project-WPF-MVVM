using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VideoArchive.App;
using VideoArchive.App.Model;
using VideoArchive.App.Views;
using VideoArchive.Model;
using VideoArchive.App.Views.SmallWindows;
using VideoArchive.ViewModel;

namespace VideoArchive.App.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        AuthViewModel auth = new AuthViewModel();
        
        public AuthWindow()
        {
            InitializeComponent();
            DataContext = auth;
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            auth.Password = passw.Password;         
        }
    }
}
