namespace Topical_Memory_System
{
    partial class MatchVerses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toMatchBox = new System.Windows.Forms.TextBox();
            match1 = new System.Windows.Forms.TextBox();
            match2 = new System.Windows.Forms.TextBox();
            match3 = new System.Windows.Forms.TextBox();
            match4 = new System.Windows.Forms.TextBox();
            match5 = new System.Windows.Forms.TextBox();
            this.nextVerseButton = new System.Windows.Forms.Button();
            this.versesLeftLabel = new System.Windows.Forms.Label();
            this.blankLabel = new System.Windows.Forms.Label();
            this.viewStatsButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toMatchBox
            // 
            toMatchBox.BackColor = System.Drawing.SystemColors.Control;
            toMatchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            toMatchBox.Cursor = System.Windows.Forms.Cursors.Default;
            toMatchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toMatchBox.Location = new System.Drawing.Point(14, 172);
            toMatchBox.Multiline = true;
            toMatchBox.Name = "toMatchBox";
            toMatchBox.ReadOnly = true;
            toMatchBox.Size = new System.Drawing.Size(192, 223);
            toMatchBox.TabIndex = 0;
            toMatchBox.Text = "holder";
            toMatchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            toMatchBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
            toMatchBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
            toMatchBox.MouseEnter += new System.EventHandler(this.MainUnfocus);
            // 
            // match1
            // 
            match1.BackColor = System.Drawing.SystemColors.Control;
            match1.Cursor = System.Windows.Forms.Cursors.Default;
            match1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            match1.Location = new System.Drawing.Point(229, 17);
            match1.Multiline = true;
            match1.Name = "match1";
            match1.ReadOnly = true;
            match1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            match1.Size = new System.Drawing.Size(402, 63);
            match1.TabIndex = 1;
            match1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            match1.Click += new System.EventHandler(this.BoxSelected);
            match1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
            match1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
            match1.MouseEnter += new System.EventHandler(this.MainUnfocus);
            // 
            // match2
            // 
            match2.BackColor = System.Drawing.SystemColors.Control;
            match2.Cursor = System.Windows.Forms.Cursors.Default;
            match2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            match2.Location = new System.Drawing.Point(229, 95);
            match2.Multiline = true;
            match2.Name = "match2";
            match2.ReadOnly = true;
            match2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            match2.Size = new System.Drawing.Size(402, 63);
            match2.TabIndex = 2;
            match2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            match2.Click += new System.EventHandler(this.BoxSelected);
            match2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
            match2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
            match2.MouseEnter += new System.EventHandler(this.MainUnfocus);
            // 
            // match3
            // 
            match3.BackColor = System.Drawing.SystemColors.Control;
            match3.Cursor = System.Windows.Forms.Cursors.Default;
            match3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            match3.Location = new System.Drawing.Point(229, 173);
            match3.Multiline = true;
            match3.Name = "match3";
            match3.ReadOnly = true;
            match3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            match3.Size = new System.Drawing.Size(402, 63);
            match3.TabIndex = 3;
            match3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            match3.Click += new System.EventHandler(this.BoxSelected);
            match3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
            match3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
            match3.MouseEnter += new System.EventHandler(this.MainUnfocus);
            // 
            // match4
            // 
            match4.BackColor = System.Drawing.SystemColors.Control;
            match4.Cursor = System.Windows.Forms.Cursors.Default;
            match4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            match4.Location = new System.Drawing.Point(229, 252);
            match4.Multiline = true;
            match4.Name = "match4";
            match4.ReadOnly = true;
            match4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            match4.Size = new System.Drawing.Size(402, 63);
            match4.TabIndex = 4;
            match4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            match4.Click += new System.EventHandler(this.BoxSelected);
            match4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
            match4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
            match4.MouseEnter += new System.EventHandler(this.MainUnfocus);
            // 
            // match5
            // 
            match5.BackColor = System.Drawing.SystemColors.Control;
            match5.Cursor = System.Windows.Forms.Cursors.Default;
            match5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            match5.Location = new System.Drawing.Point(229, 332);
            match5.Multiline = true;
            match5.Name = "match5";
            match5.ReadOnly = true;
            match5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            match5.Size = new System.Drawing.Size(402, 63);
            match5.TabIndex = 5;
            match5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            match5.Click += new System.EventHandler(this.BoxSelected);
            match5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
            match5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
            match5.MouseEnter += new System.EventHandler(this.MainUnfocus);
            // 
            // nextVerseButton
            // 
            this.nextVerseButton.Location = new System.Drawing.Point(74, 35);
            this.nextVerseButton.Name = "nextVerseButton";
            this.nextVerseButton.Size = new System.Drawing.Size(75, 23);
            this.nextVerseButton.TabIndex = 6;
            this.nextVerseButton.Text = "Next Verse";
            this.nextVerseButton.UseVisualStyleBackColor = true;
            this.nextVerseButton.Click += new System.EventHandler(this.NextVerseButton_Click);
            // 
            // versesLeftLabel
            // 
            this.versesLeftLabel.AutoSize = true;
            this.versesLeftLabel.Location = new System.Drawing.Point(74, 77);
            this.versesLeftLabel.Name = "versesLeftLabel";
            this.versesLeftLabel.Size = new System.Drawing.Size(55, 13);
            this.versesLeftLabel.TabIndex = 7;
            this.versesLeftLabel.Text = "verses left";
            // 
            // blankLabel
            // 
            this.blankLabel.AutoSize = true;
            this.blankLabel.Location = new System.Drawing.Point(33, 114);
            this.blankLabel.Name = "blankLabel";
            this.blankLabel.Size = new System.Drawing.Size(0, 13);
            this.blankLabel.TabIndex = 8;
            // 
            // viewStatsButton
            // 
            this.viewStatsButton.Enabled = false;
            this.viewStatsButton.Location = new System.Drawing.Point(22, 109);
            this.viewStatsButton.Name = "viewStatsButton";
            this.viewStatsButton.Size = new System.Drawing.Size(75, 23);
            this.viewStatsButton.TabIndex = 9;
            this.viewStatsButton.Text = "View Stats";
            this.viewStatsButton.UseVisualStyleBackColor = true;
            this.viewStatsButton.Visible = false;
            this.viewStatsButton.Click += new System.EventHandler(this.ViewStatsButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Enabled = false;
            this.restartButton.Location = new System.Drawing.Point(120, 109);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 10;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // MatchVerses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.viewStatsButton);
            this.Controls.Add(this.blankLabel);
            this.Controls.Add(this.versesLeftLabel);
            this.Controls.Add(this.nextVerseButton);
            this.Controls.Add(match5);
            this.Controls.Add(match4);
            this.Controls.Add(match3);
            this.Controls.Add(match2);
            this.Controls.Add(match1);
            this.Controls.Add(toMatchBox);
            this.Name = "MatchVerses";
            this.Size = new System.Drawing.Size(637, 411);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private static System.Windows.Forms.TextBox toMatchBox;
        private static System.Windows.Forms.TextBox match1;
        private static System.Windows.Forms.TextBox match2;
        private static System.Windows.Forms.TextBox match3;
        private static System.Windows.Forms.TextBox match4;
        private static System.Windows.Forms.TextBox match5;
        private System.Windows.Forms.Button nextVerseButton;
        private System.Windows.Forms.Label versesLeftLabel;
        private System.Windows.Forms.Label blankLabel;
        private System.Windows.Forms.Button viewStatsButton;
        private System.Windows.Forms.Button restartButton;
    }
}
