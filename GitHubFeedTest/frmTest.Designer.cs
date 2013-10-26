namespace GitHubFeedTest
{
    partial class frmTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResults = new System.Windows.Forms.TextBox();
            this.cmTestSummary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(103, 16);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(158, 194);
            this.txtResults.TabIndex = 0;
            // 
            // cmTestSummary
            // 
            this.cmTestSummary.Location = new System.Drawing.Point(13, 13);
            this.cmTestSummary.Name = "cmTestSummary";
            this.cmTestSummary.Size = new System.Drawing.Size(75, 23);
            this.cmTestSummary.TabIndex = 1;
            this.cmTestSummary.Text = "Summary";
            this.cmTestSummary.UseVisualStyleBackColor = true;
            this.cmTestSummary.Click += new System.EventHandler(this.cmTestSummary_Click);
            // 
            // frmTest
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmTestSummary);
            this.Controls.Add(this.txtResults);
            this.Name = "frmTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdTestSummary;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button cmTestSummary;
    }
}

