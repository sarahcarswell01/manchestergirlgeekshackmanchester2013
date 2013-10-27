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
using System.Windows.Threading;
using manchestergirlgeekshackmanchester2013.TwitterFeed;

namespace ManchesterGirlGeeks2013.Views
{
    /// <summary>
    /// Interaction logic for Twitter.xaml
    /// </summary>
    public partial class Twitter : Page
    {
        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        TwitterConnection twitter = new TwitterConnection();

        #region Properties
        public List<TwitterStatusResponse> TwitterFeed
        {
            get
            {
                return twitter.Tweets();
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Twitter()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 30);
            dispatcherTimer.Start();
        }
        #endregion
        #region Event Handlers
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
        }

        #endregion
    }
}
