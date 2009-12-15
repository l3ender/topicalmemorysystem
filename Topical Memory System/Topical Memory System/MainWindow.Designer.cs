﻿namespace Topical_Memory_System
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
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.translationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.esvStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nivStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			mainPanel = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.translationToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(661, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.MenuExitClick);
			// 
			// translationToolStripMenuItem
			// 
			this.translationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esvStripMenuItem,
            this.nivStripMenuItem});
			this.translationToolStripMenuItem.Name = "translationToolStripMenuItem";
			this.translationToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
			this.translationToolStripMenuItem.Text = "Translation";
			// 
			// esvStripMenuItem
			// 
			this.esvStripMenuItem.Name = "esvStripMenuItem";
			this.esvStripMenuItem.Size = new System.Drawing.Size(240, 22);
			this.esvStripMenuItem.Tag = "esv";
			this.esvStripMenuItem.Text = "English Standard Version (ESV)";
			this.esvStripMenuItem.Click += new System.EventHandler(this.TranslationChanged);
			// 
			// nivStripMenuItem
			// 
			this.nivStripMenuItem.Checked = true;
			this.nivStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.nivStripMenuItem.Name = "nivStripMenuItem";
			this.nivStripMenuItem.Size = new System.Drawing.Size(240, 22);
			this.nivStripMenuItem.Tag = "niv";
			this.nivStripMenuItem.Text = "New International Version (NIV)";
			this.nivStripMenuItem.Click += new System.EventHandler(this.TranslationChanged);
			// 
			// mainPanel
			// 
			mainPanel.Location = new System.Drawing.Point(12, 27);
			mainPanel.Name = "mainPanel";
			mainPanel.Size = new System.Drawing.Size(637, 411);
			mainPanel.TabIndex = 1;
			// 
			// MenuExit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(661, 450);
			this.Controls.Add(mainPanel);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MenuExit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Topical Memory System Assistant";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esvStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nivStripMenuItem;
		private static System.Windows.Forms.Panel mainPanel;
    }
}

