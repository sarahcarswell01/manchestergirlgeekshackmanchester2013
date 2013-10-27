using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using manchestergirlgeekshackmanchester2013.TwitterFeed;
namespace TwitterFeedTest
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void cmTestSummary_Click(object sender, EventArgs e)
        {
            TwitterConnection Connection;
            Connection = new TwitterConnection();
            Connection.Tweets();
            Connection.Favourites();
        }
    }
}
