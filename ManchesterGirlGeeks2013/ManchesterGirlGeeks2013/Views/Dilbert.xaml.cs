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
using manchestergirlgeekshackmanchester2013.DilbertFeed;

namespace ManchesterGirlGeeks2013.Views
{
    /// <summary>
    /// Interaction logic for Delbert.xaml
    /// </summary>
    public partial class Delbert : Page
    {
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
        #endregion
    }
}
