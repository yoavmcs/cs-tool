namespace WIX_SITE_REVIEW
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cbSiteMetaTags = new System.Windows.Forms.CheckBox();
            this.cbPageMetaTags = new System.Windows.Forms.CheckBox();
            this.cbSocialMetaTags = new System.Windows.Forms.CheckBox();
            this.cbH1 = new System.Windows.Forms.CheckBox();
            this.cbSocialBar = new System.Windows.Forms.CheckBox();
            this.cbImageAlt = new System.Windows.Forms.CheckBox();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbFile = new System.Windows.Forms.CheckBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.btnAbout = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSiteMetaTags
            // 
            this.cbSiteMetaTags.AutoSize = true;
            this.cbSiteMetaTags.Checked = true;
            this.cbSiteMetaTags.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSiteMetaTags.Enabled = false;
            this.cbSiteMetaTags.Location = new System.Drawing.Point(12, 40);
            this.cbSiteMetaTags.Name = "cbSiteMetaTags";
            this.cbSiteMetaTags.Size = new System.Drawing.Size(93, 17);
            this.cbSiteMetaTags.TabIndex = 1;
            this.cbSiteMetaTags.Text = "Site meta-tags";
            this.cbSiteMetaTags.UseVisualStyleBackColor = true;
            // 
            // cbPageMetaTags
            // 
            this.cbPageMetaTags.AutoSize = true;
            this.cbPageMetaTags.Checked = true;
            this.cbPageMetaTags.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPageMetaTags.Enabled = false;
            this.cbPageMetaTags.Location = new System.Drawing.Point(12, 64);
            this.cbPageMetaTags.Name = "cbPageMetaTags";
            this.cbPageMetaTags.Size = new System.Drawing.Size(100, 17);
            this.cbPageMetaTags.TabIndex = 2;
            this.cbPageMetaTags.Text = "Page meta-tags";
            this.cbPageMetaTags.UseVisualStyleBackColor = true;
            // 
            // cbSocialMetaTags
            // 
            this.cbSocialMetaTags.AutoSize = true;
            this.cbSocialMetaTags.Enabled = false;
            this.cbSocialMetaTags.Location = new System.Drawing.Point(12, 88);
            this.cbSocialMetaTags.Name = "cbSocialMetaTags";
            this.cbSocialMetaTags.Size = new System.Drawing.Size(105, 17);
            this.cbSocialMetaTags.TabIndex = 3;
            this.cbSocialMetaTags.Text = "Social Meta-tags";
            this.cbSocialMetaTags.UseVisualStyleBackColor = true;
            // 
            // cbH1
            // 
            this.cbH1.AutoSize = true;
            this.cbH1.Enabled = false;
            this.cbH1.Location = new System.Drawing.Point(130, 40);
            this.cbH1.Name = "cbH1";
            this.cbH1.Size = new System.Drawing.Size(83, 17);
            this.cbH1.TabIndex = 4;
            this.cbH1.Text = "H1 headline";
            this.cbH1.UseVisualStyleBackColor = true;
            // 
            // cbSocialBar
            // 
            this.cbSocialBar.AutoSize = true;
            this.cbSocialBar.Enabled = false;
            this.cbSocialBar.Location = new System.Drawing.Point(130, 64);
            this.cbSocialBar.Name = "cbSocialBar";
            this.cbSocialBar.Size = new System.Drawing.Size(74, 17);
            this.cbSocialBar.TabIndex = 5;
            this.cbSocialBar.Text = "Social Bar";
            this.cbSocialBar.UseVisualStyleBackColor = true;
            // 
            // cbImageAlt
            // 
            this.cbImageAlt.AutoSize = true;
            this.cbImageAlt.Enabled = false;
            this.cbImageAlt.Location = new System.Drawing.Point(130, 88);
            this.cbImageAlt.Name = "cbImageAlt";
            this.cbImageAlt.Size = new System.Drawing.Size(74, 17);
            this.cbImageAlt.TabIndex = 6;
            this.cbImageAlt.Text = "Image title";
            this.cbImageAlt.UseVisualStyleBackColor = true;
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(12, 170);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(200, 30);
            this.btnReview.TabIndex = 7;
            this.btnReview.Text = "Review site";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 204);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Test URL formatting";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbFile
            // 
            this.cbFile.AutoSize = true;
            this.cbFile.Checked = true;
            this.cbFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFile.Enabled = false;
            this.cbFile.Location = new System.Drawing.Point(130, 147);
            this.cbFile.Name = "cbFile";
            this.cbFile.Size = new System.Drawing.Size(74, 17);
            this.cbFile.TabIndex = 11;
            this.cbFile.Text = "Simulation";
            this.cbFile.UseVisualStyleBackColor = true;
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(12, 14);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(199, 20);
            this.tbURL.TabIndex = 12;
            this.tbURL.Text = "yoavmag.wix.com/reviewtool";
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(219, 14);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(360, 290);
            this.tbLog.TabIndex = 13;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 306);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(580, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(11, 273);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(200, 30);
            this.btnAbout.TabIndex = 15;
            this.btnAbout.Text = "V2 GUI DEMO";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.button3_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(291, 40);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(241, 241);
            this.webBrowser1.TabIndex = 16;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 328);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.cbFile);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.cbImageAlt);
            this.Controls.Add(this.cbSocialBar);
            this.Controls.Add(this.cbH1);
            this.Controls.Add(this.cbSocialMetaTags);
            this.Controls.Add(this.cbPageMetaTags);
            this.Controls.Add(this.cbSiteMetaTags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "WIX VIP REVIEW TOOL";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSiteMetaTags;
        private System.Windows.Forms.CheckBox cbPageMetaTags;
        private System.Windows.Forms.CheckBox cbSocialMetaTags;
        private System.Windows.Forms.CheckBox cbH1;
        private System.Windows.Forms.CheckBox cbSocialBar;
        private System.Windows.Forms.CheckBox cbImageAlt;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbFile;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        public System.Windows.Forms.TextBox tbLog;
    }
}

