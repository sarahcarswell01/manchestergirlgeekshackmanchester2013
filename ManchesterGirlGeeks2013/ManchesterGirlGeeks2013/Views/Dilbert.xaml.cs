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
using manchestergirlgeekshackmanchester2013.DilbertFeed;

namespace ManchesterGirlGeeks2013.Views
{
    /// <summary>
    /// Interaction logic for Delbert.xaml
    /// </summary>
    public partial class Delbert : Page
    {
        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        Dilbert _dilbert = new Dilbert();

        #region Properties
        public Uri DilbertURL
        {
            get
            {
                return _dilbert.GetDilbert();
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Delbert()
        {
            InitializeComponent();

            _browser.Source = DilbertURL;

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 20, 0);
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
        }

        #endregion
    }
}
