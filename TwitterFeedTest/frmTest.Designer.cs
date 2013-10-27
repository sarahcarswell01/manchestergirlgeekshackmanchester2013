namespace TwitterFeedTest
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
            this.cmTestSummary = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmTestSummary
            // 
            this.cmTestSummary.Location = new System.Drawing.Point(18, 33);
            this.cmTestSummary.Name = "cmTestSummary";
            this.cmTestSummary.Size = new System.Drawing.Size(75, 23);
            this.cmTestSummary.TabIndex = 3;
            this.cmTestSummary.Text = "Summary";
            this.cmTestSummary.UseVisualStyleBackColor = true;
            this.cmTestSummary.Click += new System.EventHandler(this.cmTestSummary_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(108, 36);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(158, 194);
            this.txtResults.TabIndex = 2;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmTestSummary);
            this.Controls.Add(this.txtResults);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmTestSummary;
        private System.Windows.Forms.TextBox txtResults;
    }
}