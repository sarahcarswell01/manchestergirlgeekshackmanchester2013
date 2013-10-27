using System;
using System.Collections.Generic;
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
using ManchesterGirlGeeks2013.Views;
using System.ComponentModel;
using manchestergirlgeekshackmanchester2013.HackImages;
using System.Collections.Specialized;

namespace ManchesterGirlGeeks2013
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page, INotifyPropertyChanged
    {
        #region Fields
        private Timer _timerView = new Timer();
        public Trello _trello = new Trello();
        public GitHub _gitHub = new GitHub();
        public Delbert _dilbert = new Delbert();
        public Twitter _twitter = new Twitter();
        HackDayImageProvider _images = new HackDayImageProvider();
        #endregion

        #region Properties
        public TimeSpan CountDown
        {
            get {return _timerView.CountDown  ;}
            set { ;}
        }

        public List<string> Images
        {
            get 
            {
                string[] strArray = new string[_images.Images.Count];

                 (_images.Images).CopyTo(strArray, 0);
                 return strArray.ToList() ;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainWindow()
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
        private void _timer_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _dash.NavigationService.Navigate(_timerView);
            
        }

        private void _trello_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _dash.NavigationService.Navigate(_trello);
        }

        private void _git_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _dash.NavigationService.Navigate(_gitHub);

        }
        private void _dilbert_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(_dilbert);
        }
        private void _hac_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(_dilbert);
        }
        private void _twitter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(_twitter);
        }
        #endregion
             
    }    
}
