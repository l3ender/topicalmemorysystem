using System.Windows.Forms;
namespace Topical_Memory_System
{
    partial class MenuExit
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.addVerseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editCustomVersesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			translationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.esvStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nivStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nbvStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.onlineBibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blueLetterBibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			bibleGatewayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			esvOnlineStudyBibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			openBibleInApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openBibleInWebBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			mainPanel = new System.Windows.Forms.Panel();
			loadingBox = new System.Windows.Forms.PictureBox();
			biblijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(loadingBox)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            translationToolStripMenuItem,
            this.onlineBibleToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(661, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuStrip,
			new ToolStripSeparator(),
            this.addVerseToolStripMenuItem,
            this.editCustomVersesToolStripMenuItem,
			new ToolStripSeparator(),
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(175, 22);
			this.mainMenuStrip.Text = "Main Menu";
			this.mainMenuStrip.Click += new System.EventHandler(this.MainMenuStripClick);
			// 
			// addVerseToolStripMenuItem
			// 
			this.addVerseToolStripMenuItem.Name = "addVerseToolStripMenuItem";
			this.addVerseToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.addVerseToolStripMenuItem.Text = "Add Custom Verse";
			this.addVerseToolStripMenuItem.Click += new System.EventHandler(this.addVerseToolStripMenuItem_Click);
			// 
			// editCustomVersesToolStripMenuItem
			// 
			this.editCustomVersesToolStripMenuItem.Name = "editCustomVersesToolStripMenuItem";
			this.editCustomVersesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.editCustomVersesToolStripMenuItem.Text = "Edit Custom Verses";
			this.editCustomVersesToolStripMenuItem.Click += new System.EventHandler(this.editCustomVersesToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.MenuExitClick);
			// 
			// translationToolStripMenuItem
			// 
			translationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esvStripMenuItem,
            this.nivStripMenuItem,
            this.nbvStripMenuItem});
			translationToolStripMenuItem.Name = "translationToolStripMenuItem";
			translationToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
			translationToolStripMenuItem.Text = "Translation";
			// 
			// esvStripMenuItem
			// 
			this.esvStripMenuItem.Name = "esvStripMenuItem";
			this.esvStripMenuItem.Size = new System.Drawing.Size(243, 22);
			this.esvStripMenuItem.Tag = "ESV";
			this.esvStripMenuItem.Text = "English Standard Version (ESV)";
			this.esvStripMenuItem.Click += new System.EventHandler(this.TranslationChanged);
			// 
			// nivStripMenuItem
			// 
			this.nivStripMenuItem.Checked = true;
			this.nivStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.nivStripMenuItem.Name = "nivStripMenuItem";
			this.nivStripMenuItem.Size = new System.Drawing.Size(243, 22);
			this.nivStripMenuItem.Tag = "NIV";
			this.nivStripMenuItem.Text = "New International Version (NIV)";
			this.nivStripMenuItem.Click += new System.EventHandler(this.TranslationChanged);
			// 
			// nbvStripMenuItem
			// 
			this.nbvStripMenuItem.Name = "nbvStripMenuItem";
			this.nbvStripMenuItem.Size = new System.Drawing.Size(243, 22);
			this.nbvStripMenuItem.Tag = "NBV";
			this.nbvStripMenuItem.Text = "De Nieuwe Bijbelvertaling (NBV)";
			this.nbvStripMenuItem.Click += new System.EventHandler(this.TranslationChanged);
			// 
			// onlineBibleToolStripMenuItem
			// 
			this.onlineBibleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueLetterBibleToolStripMenuItem,
            bibleGatewayToolStripMenuItem,
            esvOnlineStudyBibleToolStripMenuItem,
            biblijaToolStripMenuItem,
			new ToolStripSeparator(),
            openBibleInApplicationToolStripMenuItem,
            this.openBibleInWebBrowserToolStripMenuItem});
			this.onlineBibleToolStripMenuItem.Name = "onlineBibleToolStripMenuItem";
			this.onlineBibleToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
			this.onlineBibleToolStripMenuItem.Text = "Online Bible";
			// 
			// blueLetterBibleToolStripMenuItem
			// 
			this.blueLetterBibleToolStripMenuItem.Checked = true;
			this.blueLetterBibleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.blueLetterBibleToolStripMenuItem.Name = "blueLetterBibleToolStripMenuItem";
			this.blueLetterBibleToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.blueLetterBibleToolStripMenuItem.Tag = "one";
			this.blueLetterBibleToolStripMenuItem.Text = "Blue Letter Bible";
			this.blueLetterBibleToolStripMenuItem.Click += new System.EventHandler(this.BibleSelected);
			// 
			// bibleGatewayToolStripMenuItem
			// 
			bibleGatewayToolStripMenuItem.Name = "bibleGatewayToolStripMenuItem";
			bibleGatewayToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			bibleGatewayToolStripMenuItem.Tag = "one";
			bibleGatewayToolStripMenuItem.Text = "BibleGateway.com";
			bibleGatewayToolStripMenuItem.Click += new System.EventHandler(this.BibleSelected);
			// 
			// esvOnlineStudyBibleToolStripMenuItem
			// 
			esvOnlineStudyBibleToolStripMenuItem.Name = "esvOnlineStudyBibleToolStripMenuItem";
			esvOnlineStudyBibleToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			esvOnlineStudyBibleToolStripMenuItem.Tag = "one";
			esvOnlineStudyBibleToolStripMenuItem.Text = "ESV Online Study Bible";
			esvOnlineStudyBibleToolStripMenuItem.Click += new System.EventHandler(this.BibleSelected);
			// 
			// openBibleInApplicationToolStripMenuItem
			// 
			openBibleInApplicationToolStripMenuItem.Checked = true;
			openBibleInApplicationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			openBibleInApplicationToolStripMenuItem.Name = "openBibleInApplicationToolStripMenuItem";
			openBibleInApplicationToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			openBibleInApplicationToolStripMenuItem.Tag = "two";
			openBibleInApplicationToolStripMenuItem.Text = "Open bible in application";
			openBibleInApplicationToolStripMenuItem.Click += new System.EventHandler(this.BibleSelected);
			// 
			// openBibleInWebBrowserToolStripMenuItem
			// 
			this.openBibleInWebBrowserToolStripMenuItem.Name = "openBibleInWebBrowserToolStripMenuItem";
			this.openBibleInWebBrowserToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.openBibleInWebBrowserToolStripMenuItem.Tag = "two";
			this.openBibleInWebBrowserToolStripMenuItem.Text = "Open bible in web browser";
			this.openBibleInWebBrowserToolStripMenuItem.Click += new System.EventHandler(this.BibleSelected);
			// 
			// mainPanel
			// 
			mainPanel.Location = new System.Drawing.Point(12, 27);
			mainPanel.Name = "mainPanel";
			mainPanel.Size = new System.Drawing.Size(637, 411);
			mainPanel.TabIndex = 1;
			// 
			// loadingBox
			// 
			loadingBox.Image = global::Topical_Memory_System.Properties.Resources.loading;
			loadingBox.InitialImage = global::Topical_Memory_System.Properties.Resources.loading;
			loadingBox.Location = new System.Drawing.Point(630, 4);
			loadingBox.Name = "loadingBox";
			loadingBox.Size = new System.Drawing.Size(18, 18);
			loadingBox.TabIndex = 2;
			loadingBox.TabStop = false;
			loadingBox.Visible = false;
			// 
			// biblijaToolStripMenuItem
			// 
			biblijaToolStripMenuItem.Name = "biblijaToolStripMenuItem";
			biblijaToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			biblijaToolStripMenuItem.Text = "Biblija.net";
			biblijaToolStripMenuItem.Tag = "one";
			biblijaToolStripMenuItem.Click += new System.EventHandler(this.BibleSelected);
			// 
			// MenuExit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(661, 450);
			this.Controls.Add(loadingBox);
			this.Controls.Add(mainPanel);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MenuExit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TMS Assistant";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(loadingBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private static System.Windows.Forms.ToolStripMenuItem voiceToolStripMenuItem;
        private static System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem esvStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineBibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBibleInWebBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueLetterBibleToolStripMenuItem;
        private ToolStripMenuItem addVerseToolStripMenuItem;
		private ToolStripMenuItem editCustomVersesToolStripMenuItem;
		private ToolStripMenuItem nbvStripMenuItem;
		public static PictureBox loadingBox;
		private static ToolStripMenuItem bibleGatewayToolStripMenuItem;
		private static ToolStripMenuItem esvOnlineStudyBibleToolStripMenuItem;
		private static ToolStripMenuItem biblijaToolStripMenuItem;
		private static ToolStripMenuItem openBibleInApplicationToolStripMenuItem;
		private static ToolStripMenuItem translationToolStripMenuItem;
		private static Panel mainPanel;
    }
}

