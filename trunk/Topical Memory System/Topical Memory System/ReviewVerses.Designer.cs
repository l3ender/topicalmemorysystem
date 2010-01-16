namespace Topical_Memory_System
{
	partial class ReviewVerses
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
			this.versePanel = new System.Windows.Forms.Panel();
			this.viewVerseInContextButton = new System.Windows.Forms.Button();
			frontReference = new System.Windows.Forms.TextBox();
			this.hearButton = new System.Windows.Forms.Button();
			verseData = new System.Windows.Forms.TextBox();
			packInformation = new System.Windows.Forms.Label();
			translation = new System.Windows.Forms.Label();
			reference = new System.Windows.Forms.Label();
			theme = new System.Windows.Forms.Label();
			this.flipButton = new System.Windows.Forms.Button();
			this.nextVerseButton = new System.Windows.Forms.Button();
			this.previousVerseButton = new System.Windows.Forms.Button();
			this.titleLabel = new System.Windows.Forms.Label();
			this.blankLabel = new System.Windows.Forms.Label();
			this.versePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// versePanel
			// 
			this.versePanel.BackColor = System.Drawing.Color.White;
			this.versePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.versePanel.Controls.Add(this.viewVerseInContextButton);
			this.versePanel.Controls.Add(frontReference);
			this.versePanel.Controls.Add(this.hearButton);
			this.versePanel.Controls.Add(verseData);
			this.versePanel.Controls.Add(packInformation);
			this.versePanel.Controls.Add(translation);
			this.versePanel.Controls.Add(reference);
			this.versePanel.Controls.Add(theme);
			this.versePanel.Location = new System.Drawing.Point(148, 84);
			this.versePanel.Name = "versePanel";
			this.versePanel.Size = new System.Drawing.Size(340, 233);
			this.versePanel.TabIndex = 0;
			// 
			// viewVerseInContextButton
			// 
			this.viewVerseInContextButton.BackColor = System.Drawing.SystemColors.Control;
			this.viewVerseInContextButton.Enabled = false;
			this.viewVerseInContextButton.Location = new System.Drawing.Point(236, 43);
			this.viewVerseInContextButton.Name = "viewVerseInContextButton";
			this.viewVerseInContextButton.Size = new System.Drawing.Size(87, 23);
			this.viewVerseInContextButton.TabIndex = 7;
			this.viewVerseInContextButton.Text = "View in context";
			this.viewVerseInContextButton.UseVisualStyleBackColor = true;
			this.viewVerseInContextButton.Visible = false;
			this.viewVerseInContextButton.Click += new System.EventHandler(this.ViewVerseInContextButton_Click);
			// 
			// frontReference
			// 
			frontReference.BackColor = System.Drawing.Color.White;
			frontReference.BorderStyle = System.Windows.Forms.BorderStyle.None;
			frontReference.Cursor = System.Windows.Forms.Cursors.Default;
			frontReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			frontReference.Location = new System.Drawing.Point(43, 99);
			frontReference.Multiline = true;
			frontReference.Name = "frontReference";
			frontReference.ReadOnly = true;
			frontReference.Size = new System.Drawing.Size(253, 32);
			frontReference.TabIndex = 6;
			frontReference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			frontReference.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
			frontReference.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
			frontReference.MouseEnter += new System.EventHandler(this.MainUnfocus);
			// 
			// hearButton
			// 
			this.hearButton.BackColor = System.Drawing.SystemColors.Control;
			this.hearButton.Location = new System.Drawing.Point(270, 190);
			this.hearButton.Name = "hearButton";
			this.hearButton.Size = new System.Drawing.Size(53, 23);
			this.hearButton.TabIndex = 5;
			this.hearButton.Text = "Hear it";
			this.hearButton.UseVisualStyleBackColor = true;
			this.hearButton.Click += new System.EventHandler(this.HearButton_Click);
			// 
			// verseData
			// 
			verseData.BackColor = System.Drawing.Color.White;
			verseData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			verseData.Cursor = System.Windows.Forms.Cursors.Default;
			verseData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			verseData.Location = new System.Drawing.Point(24, 73);
			verseData.Multiline = true;
			verseData.Name = "verseData";
			verseData.ReadOnly = true;
			verseData.Size = new System.Drawing.Size(290, 115);
			verseData.TabIndex = 4;
			verseData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
			verseData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
			verseData.MouseEnter += new System.EventHandler(this.MainUnfocus);
			// 
			// packInformation
			// 
			packInformation.AutoSize = true;
			packInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			packInformation.Location = new System.Drawing.Point(21, 200);
			packInformation.Name = "packInformation";
			packInformation.Size = new System.Drawing.Size(35, 13);
			packInformation.TabIndex = 3;
			packInformation.Text = "label1";
			// 
			// translation
			// 
			translation.AutoSize = true;
			translation.Location = new System.Drawing.Point(279, 22);
			translation.Name = "translation";
			translation.Size = new System.Drawing.Size(35, 13);
			translation.TabIndex = 2;
			translation.Text = "label1";
			translation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// reference
			// 
			reference.AutoSize = true;
			reference.Cursor = System.Windows.Forms.Cursors.Default;
			reference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			reference.Location = new System.Drawing.Point(21, 48);
			reference.Name = "reference";
			reference.Size = new System.Drawing.Size(41, 15);
			reference.TabIndex = 1;
			reference.Text = "label1";
			// 
			// theme
			// 
			theme.AutoSize = true;
			theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			theme.Location = new System.Drawing.Point(21, 20);
			theme.Name = "theme";
			theme.Size = new System.Drawing.Size(51, 16);
			theme.TabIndex = 0;
			theme.Text = "label1";
			// 
			// flipButton
			// 
			this.flipButton.Location = new System.Drawing.Point(271, 341);
			this.flipButton.Name = "flipButton";
			this.flipButton.Size = new System.Drawing.Size(95, 30);
			this.flipButton.TabIndex = 1;
			this.flipButton.Text = "Flip";
			this.flipButton.UseVisualStyleBackColor = true;
			this.flipButton.Click += new System.EventHandler(this.FlipButton_Click);
			// 
			// nextVerseButton
			// 
			this.nextVerseButton.Location = new System.Drawing.Point(513, 190);
			this.nextVerseButton.Name = "nextVerseButton";
			this.nextVerseButton.Size = new System.Drawing.Size(95, 30);
			this.nextVerseButton.TabIndex = 2;
			this.nextVerseButton.Text = "Next Verse";
			this.nextVerseButton.UseVisualStyleBackColor = true;
			this.nextVerseButton.Click += new System.EventHandler(this.NextVerseButton_Click);
			// 
			// previousVerseButton
			// 
			this.previousVerseButton.Location = new System.Drawing.Point(26, 190);
			this.previousVerseButton.Name = "previousVerseButton";
			this.previousVerseButton.Size = new System.Drawing.Size(95, 30);
			this.previousVerseButton.TabIndex = 3;
			this.previousVerseButton.Text = "Previous Verse";
			this.previousVerseButton.UseVisualStyleBackColor = true;
			this.previousVerseButton.Click += new System.EventHandler(this.PreviousVerseButton_Click);
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(224, 24);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(196, 31);
			this.titleLabel.TabIndex = 4;
			this.titleLabel.Text = "Review Verses";
			// 
			// blankLabel
			// 
			this.blankLabel.AutoSize = true;
			this.blankLabel.Location = new System.Drawing.Point(40, 41);
			this.blankLabel.Name = "blankLabel";
			this.blankLabel.Size = new System.Drawing.Size(0, 13);
			this.blankLabel.TabIndex = 5;
			// 
			// ReviewVerses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.blankLabel);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.previousVerseButton);
			this.Controls.Add(this.nextVerseButton);
			this.Controls.Add(this.flipButton);
			this.Controls.Add(this.versePanel);
			this.Name = "ReviewVerses";
			this.Size = new System.Drawing.Size(637, 411);
			this.versePanel.ResumeLayout(false);
			this.versePanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Panel versePanel;
		private System.Windows.Forms.Button hearButton;
        private System.Windows.Forms.Button flipButton;
		private System.Windows.Forms.Button nextVerseButton;
		private System.Windows.Forms.Button previousVerseButton;
		private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button viewVerseInContextButton;
		private System.Windows.Forms.Label blankLabel;
		private static System.Windows.Forms.Label theme;
		private static System.Windows.Forms.Label translation;
		private static System.Windows.Forms.Label reference;
		private static System.Windows.Forms.Label packInformation;
		private static System.Windows.Forms.TextBox verseData;
		private static System.Windows.Forms.TextBox frontReference;


	}
}
