using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HackImagesTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmTestSummary_Click(object sender, EventArgs e)
        {
            StringBuilder sb;
            manchestergirlgeekshackmanchester2013.HackImages.HackDayImageProvider Provider;
                Provider=new manchestergirlgeekshackmanchester2013.HackImages.HackDayImageProvider();
                sb = new StringBuilder();
            sb.AppendLine("Count " + Provider.Images.Count.ToString());
            foreach (string image in Provider.Images)
            {
                sb.AppendLine(image);
            }
            txtResults.Text = sb.ToString();
        }

        private void txtResults_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
