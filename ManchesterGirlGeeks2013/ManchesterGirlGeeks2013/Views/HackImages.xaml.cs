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
using manchestergirlgeekshackmanchester2013.HackImages;

namespace ManchesterGirlGeeks2013.Views
{
    /// <summary>
    /// Interaction logic for HackImages.xaml
    /// </summary>
    public partial class HackImages : Page
    {
        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        HackDayImageProvider _HackProvider = new HackDayImageProvider();

        #region Properties
        public Uri HackURL
        {
            get
            {
                Uri url;
                url = new System.Uri(_HackProvider.NextImageURL);
                return url;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public HackImages()
        {
            InitializeComponent();

            _browser.Source = HackURL;

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0,0, 0, 10);
            dispatcherTimer.Start();
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Handler for back button being clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            _browser.Source = HackURL;
            _browser.Refresh();
        }

        #endregion
    }
}
