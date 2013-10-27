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
using manchestergirlgeekshackmanchester2013.TwitterFeed;

namespace ManchesterGirlGeeks2013.Views
{
    /// <summary>
    /// Interaction logic for Twitter.xaml
    /// </summary>
    public partial class Twitter : Page
    {
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
        }
        #endregion
        #region Event Handlers
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.GoBack();
        }
        #endregion
    }
}
