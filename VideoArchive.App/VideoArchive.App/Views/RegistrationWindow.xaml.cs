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
using VideoArchive.App.ViewModel;
using VideoArchive.ViewModel;

namespace VideoArchive.App.Views
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        RegistrationViewModel reg = new RegistrationViewModel();

        public RegistrationWindow()
        {
            InitializeComponent();
            DataContext = reg;
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
           
            reg.PasswordTmp = passw.Password;
        }
    }
}
