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
			this.frontReference = new System.Windows.Forms.TextBox();
			this.hearButton = new System.Windows.Forms.Button();
			this.verseData = new System.Windows.Forms.TextBox();
			this.packInformation = new System.Windows.Forms.Label();
			this.translation = new System.Windows.Forms.Label();
			this.reference = new System.Windows.Forms.Label();
			this.theme = new System.Windows.Forms.Label();
			this.flipButton = new System.Windows.Forms.Button();
			this.nextVerseButton = new System.Windows.Forms.Button();
			this.previousVerseButton = new System.Windows.Forms.Button();
			this.titleLabel = new System.Windows.Forms.Label();
			this.versePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// versePanel
			// 
			this.versePanel.BackColor = System.Drawing.Color.White;
			this.versePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.versePanel.Controls.Add(this.frontReference);
			this.versePanel.Controls.Add(this.hearButton);
			this.versePanel.Controls.Add(this.verseData);
			this.versePanel.Controls.Add(this.packInformation);
			this.versePanel.Controls.Add(this.translation);
			this.versePanel.Controls.Add(this.reference);
			this.versePanel.Controls.Add(this.theme);
			this.versePanel.Location = new System.Drawing.Point(148, 84);
			this.versePanel.Name = "versePanel";
			this.versePanel.Size = new System.Drawing.Size(340, 233);
			this.versePanel.TabIndex = 0;
			// 
			// frontReference
			// 
			this.frontReference.BackColor = System.Drawing.Color.White;
			this.frontReference.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.frontReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.frontReference.Location = new System.Drawing.Point(98, 113);
			this.frontReference.Name = "frontReference";
			this.frontReference.ReadOnly = true;
			this.frontReference.Size = new System.Drawing.Size(137, 17);
			this.frontReference.TabIndex = 6;
			this.frontReference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// hearButton
			// 
			this.hearButton.Location = new System.Drawing.Point(261, 187);
			this.hearButton.Name = "hearButton";
			this.hearButton.Size = new System.Drawing.Size(53, 23);
			this.hearButton.TabIndex = 5;
			this.hearButton.Text = "Hear it!";
			this.hearButton.UseVisualStyleBackColor = true;
			this.hearButton.Click += new System.EventHandler(this.hearButton_Click);
			// 
			// verseData
			// 
			this.verseData.BackColor = System.Drawing.Color.White;
			this.verseData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.verseData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.verseData.Location = new System.Drawing.Point(24, 73);
			this.verseData.Multiline = true;
			this.verseData.Name = "verseData";
			this.verseData.ReadOnly = true;
			this.verseData.Size = new System.Drawing.Size(290, 115);
			this.verseData.TabIndex = 4;
			// 
			// packInformation
			// 
			this.packInformation.AutoSize = true;
			this.packInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.packInformation.Location = new System.Drawing.Point(21, 192);
			this.packInformation.Name = "packInformation";
			this.packInformation.Size = new System.Drawing.Size(35, 13);
			this.packInformation.TabIndex = 3;
			this.packInformation.Text = "label1";
			// 
			// translation
			// 
			this.translation.AutoSize = true;
			this.translation.Location = new System.Drawing.Point(279, 22);
			this.translation.Name = "translation";
			this.translation.Size = new System.Drawing.Size(35, 13);
			this.translation.TabIndex = 2;
			this.translation.Text = "label1";
			this.translation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// reference
			// 
			this.reference.AutoSize = true;
			this.reference.Cursor = System.Windows.Forms.Cursors.Default;
			this.reference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reference.Location = new System.Drawing.Point(21, 48);
			this.reference.Name = "reference";
			this.reference.Size = new System.Drawing.Size(41, 15);
			this.reference.TabIndex = 1;
			this.reference.Text = "label1";
			// 
			// theme
			// 
			this.theme.AutoSize = true;
			this.theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.theme.Location = new System.Drawing.Point(21, 20);
			this.theme.Name = "theme";
			this.theme.Size = new System.Drawing.Size(51, 16);
			this.theme.TabIndex = 0;
			this.theme.Text = "label1";
			// 
			// flipButton
			// 
			this.flipButton.Location = new System.Drawing.Point(271, 341);
			this.flipButton.Name = "flipButton";
			this.flipButton.Size = new System.Drawing.Size(95, 30);
			this.flipButton.TabIndex = 1;
			this.flipButton.Text = "Flip";
			this.flipButton.UseVisualStyleBackColor = true;
			this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
			// 
			// nextVerseButton
			// 
			this.nextVerseButton.Location = new System.Drawing.Point(513, 193);
			this.nextVerseButton.Name = "nextVerseButton";
			this.nextVerseButton.Size = new System.Drawing.Size(95, 30);
			this.nextVerseButton.TabIndex = 2;
			this.nextVerseButton.Text = "Next Verse";
			this.nextVerseButton.UseVisualStyleBackColor = true;
			this.nextVerseButton.Click += new System.EventHandler(this.nextVerseButton_Click);
			// 
			// previousVerseButton
			// 
			this.previousVerseButton.Location = new System.Drawing.Point(26, 193);
			this.previousVerseButton.Name = "previousVerseButton";
			this.previousVerseButton.Size = new System.Drawing.Size(95, 30);
			this.previousVerseButton.TabIndex = 3;
			this.previousVerseButton.Text = "Previous Verse";
			this.previousVerseButton.UseVisualStyleBackColor = true;
			this.previousVerseButton.Click += new System.EventHandler(this.previousVerseButton_Click);
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
			// ReviewVerses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
		private System.Windows.Forms.Label theme;
		private System.Windows.Forms.Label translation;
		private System.Windows.Forms.Label reference;
		private System.Windows.Forms.Label packInformation;
		private System.Windows.Forms.TextBox verseData;
		private System.Windows.Forms.Button hearButton;
		private System.Windows.Forms.Button flipButton;
		private System.Windows.Forms.TextBox frontReference;
		private System.Windows.Forms.Button nextVerseButton;
		private System.Windows.Forms.Button previousVerseButton;
		private System.Windows.Forms.Label titleLabel;


	}
}
