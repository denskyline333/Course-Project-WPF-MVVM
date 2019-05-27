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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace VideoArchive.App
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (myMediaElement.Source != null)
            {
                if (myMediaElement.NaturalDuration.HasTimeSpan)
                    lblStatus.Content = String.Format("{0} / {1}", myMediaElement.Position.ToString(@"hh\:mm\:ss"), myMediaElement.NaturalDuration.TimeSpan.ToString(@"hh\:mm\:ss"));
            }
            else
                lblStatus.Content = "Not playing";
        }
//
        private void Element_MediaOpened(object sender, EventArgs e)
        {
            myMediaElement.Pause();
            timelineSlider.Maximum = myMediaElement.NaturalDuration.TimeSpan.TotalMilliseconds;      
        }

        private void SeekToMediaPosition(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            int SliderValue = (int)timelineSlider.Value;
            if (myMediaElement.Source != null)
            {
             
                TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
                myMediaElement.Position = ts;
            }
        }
  //    
        
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myMediaElement.Play();
            stop.Width = 54;
            stop.Height = 46;
        }
        private void OnMouseDownStopMedia(object sender, MouseButtonEventArgs e)
        {
            myMediaElement.Pause();
            stop.Height = 36;
            stop.Width = 44;
        }

        private void ContentControl_MouseDoubleClick2(object sender, MouseButtonEventArgs e)
        {

            myMediaElement.MaxWidth = 500;
            myMediaElement.MaxHeight = 200;
            myMediaElement.Width = 500;
            myMediaElement.Height = 200;
            WindowState = WindowState.Normal;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myMediaElement.MaxWidth = 1200;
            myMediaElement.MaxHeight = 550;
            myMediaElement.Width = 1200;
            myMediaElement.Height = 550;
            WindowState = WindowState.Maximized;
        }

    }
}
