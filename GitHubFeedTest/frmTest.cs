using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestSharp;
using manchestergirlgeekshackmanchester2013.GitHubFeed;
namespace GitHubFeedTest
{
    public partial class frmTest : Form
    {
        /// <summary>
        /// Tests the properties on GitHubFeed
        /// </summary>
        public frmTest()
        {
            InitializeComponent();
        }


        private void cmTestSummary_Click(object sender, EventArgs e)
        {
            GitConnection connection;
            connection = new GitConnection();
            SummaryDetail SummaryDetail;
            SummaryDetail = new SummaryDetail();
            txtResults.Text = "";
            txtResults.Text = "Commit Count " + SummaryDetail.CommitCount;
        }
    }
}
