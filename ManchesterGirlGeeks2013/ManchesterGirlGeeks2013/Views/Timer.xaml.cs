using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ManchesterGirlGeeks2013.Views
{
    /// <summary>
    /// Interaction logic for Timer.xaml
    /// </summary>
    public partial class Timer : Page, INotifyPropertyChanged
    {
        #region Fields
        private TimeSpan _countDown;
        #endregion

        #region Properties
        public TimeSpan CountDown
        {
            get
            {
                return _countDown;
            }
            set
            {
                _countDown = value;
                NotifyPropertyChanged("CountDown");
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Timer()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        /// <summary>
        /// Event for when an observable property is updated
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Internal Event Generator for property changes
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Event Handlers
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            ttbCountDown.IsStarted = true;
            ttbCountDown.TimeSpan = TimeSpan.FromHours(24);
        }
        

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            ttbCountDown.IsStarted = false;
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            ttbCountDown.Reset();
            ttbCountDown.Background = Brushes.LightGray;
            ttbCountDown.Foreground = Brushes.Black;
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            ttbCountDown.TimeSpan = TimeSpan.FromSeconds(59);
            ttbCountDown.Background = Brushes.LightGray;
            ttbCountDown.Foreground = Brushes.Black;
        }

        private void btnSetTimer_Click(object sender, RoutedEventArgs e)
        {
            ttbTimer.TimeSpan = TimeSpan.FromMinutes(5);
        }
        private void btnStartTimer_Click(object sender, RoutedEventArgs e)
        {
            ttbTimer.IsStarted = true;
        }

        private void btnStopTimer_Click(object sender, RoutedEventArgs e)
        {
            ttbTimer.IsStarted = false;
        }

        private void btnResetTimer_Click(object sender, RoutedEventArgs e)
        {
            ttbTimer.Reset();
        }

        private void ttbCountDown_OnCountDownComplete(object sender, EventArgs e)
        {
            ttbCountDown.Background = Brushes.Red;
            ttbCountDown.Foreground = Brushes.White;
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _timer.NavigationService.GoBack();
        }
        #endregion

       
    }
}
