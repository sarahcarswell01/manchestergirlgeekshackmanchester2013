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
using manchestergirlgeekshackmanchester2013.GitHubFeed;

namespace ManchesterGirlGeeks2013.Views
{
    /// <summary>
    /// Interaction logic for GitHub.xaml
    /// </summary>
    public partial class GitHub : Page
    {
        
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
        }
        #endregion

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
