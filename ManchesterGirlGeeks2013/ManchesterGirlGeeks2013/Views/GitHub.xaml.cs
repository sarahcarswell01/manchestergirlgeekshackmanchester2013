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
using manchestergirlgeekshackmanchester2013.GitHubFeed;

namespace ManchesterGirlGeeks2013.Views
{
    /// <summary>
    /// Interaction logic for GitHub.xaml
    /// </summary>
    public partial class GitHub : Page
    {
        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        //GitConnection connection = new GitConnection();
        SummaryDetail detail = new SummaryDetail();
        #region Properties
        public int CommitCount
        {
            get 
            {
                return detail.CommitCount;
            }
        }
        public CommitDetail LastCommitdetail
        {
            get
            {
                return detail.LastCommit;
            }
        }
        #endregion
        #region Constructors
        public GitHub()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 20, 0);
            dispatcherTimer.Start();
        }
        #endregion

        #region event handlers
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
