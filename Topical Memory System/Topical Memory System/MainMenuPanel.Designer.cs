namespace Topical_Memory_System
{
	partial class MainMenuPanel
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
			this.reviewVersesButton = new System.Windows.Forms.Button();
			this.matchVerseButton = new System.Windows.Forms.Button();
			this.LearnVersesButton = new System.Windows.Forms.Button();
			this.ViewVersesButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.BlankLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// reviewVersesButton
			// 
			this.reviewVersesButton.Location = new System.Drawing.Point(89, 134);
			this.reviewVersesButton.Name = "reviewVersesButton";
			this.reviewVersesButton.Size = new System.Drawing.Size(143, 46);
			this.reviewVersesButton.TabIndex = 1;
			this.reviewVersesButton.Text = "Review";
			this.reviewVersesButton.UseVisualStyleBackColor = true;
			this.reviewVersesButton.Click += new System.EventHandler(this.ReviewVersesButton_Click);
			// 
			// matchVerseButton
			// 
			this.matchVerseButton.Location = new System.Drawing.Point(89, 230);
			this.matchVerseButton.Name = "matchVerseButton";
			this.matchVerseButton.Size = new System.Drawing.Size(143, 46);
			this.matchVerseButton.TabIndex = 2;
			this.matchVerseButton.Text = "Match";
			this.matchVerseButton.UseVisualStyleBackColor = true;
			this.matchVerseButton.Click += new System.EventHandler(this.MatchVersesButton_Click);
			// 
			// LearnVersesButton
			// 
			this.LearnVersesButton.Location = new System.Drawing.Point(89, 326);
			this.LearnVersesButton.Name = "LearnVersesButton";
			this.LearnVersesButton.Size = new System.Drawing.Size(143, 46);
			this.LearnVersesButton.TabIndex = 4;
			this.LearnVersesButton.Text = "Learn";
			this.LearnVersesButton.UseVisualStyleBackColor = true;
			this.LearnVersesButton.Click += new System.EventHandler(this.LearnVersesButton_Click);
			// 
			// ViewVersesButton
			// 
			this.ViewVersesButton.Location = new System.Drawing.Point(89, 38);
			this.ViewVersesButton.Name = "ViewVersesButton";
			this.ViewVersesButton.Size = new System.Drawing.Size(143, 46);
			this.ViewVersesButton.TabIndex = 0;
			this.ViewVersesButton.Text = "View";
			this.ViewVersesButton.UseVisualStyleBackColor = true;
			this.ViewVersesButton.Click += new System.EventHandler(this.ViewVersesButton_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Control;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.textBox1.Location = new System.Drawing.Point(301, 55);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(246, 16);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "An easy way to view any verse(s).";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.Control;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
			this.textBox2.Location = new System.Drawing.Point(301, 151);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(246, 16);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "Test your memory with digital flip cards.";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.Control;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
			this.textBox3.Location = new System.Drawing.Point(301, 337);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(246, 27);
			this.textBox3.TabIndex = 8;
			this.textBox3.Text = "Memorize a verse\'s reference, or type out a verse, given its reference.  The ulti" +
				"mate memory test!";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.SystemColors.Control;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
			this.textBox4.Location = new System.Drawing.Point(301, 247);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(246, 16);
			this.textBox4.TabIndex = 7;
			this.textBox4.Text = "Match a reference to its verse or vice versa.";
			// 
			// BlankLabel
			// 
			this.BlankLabel.AutoSize = true;
			this.BlankLabel.Location = new System.Drawing.Point(14, 21);
			this.BlankLabel.Name = "BlankLabel";
			this.BlankLabel.Size = new System.Drawing.Size(0, 13);
			this.BlankLabel.TabIndex = 9;
			// 
			// MainMenuPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.BlankLabel);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.ViewVersesButton);
			this.Controls.Add(this.LearnVersesButton);
			this.Controls.Add(this.matchVerseButton);
			this.Controls.Add(this.reviewVersesButton);
			this.Name = "MainMenuPanel";
			this.Size = new System.Drawing.Size(637, 411);
			this.Click += new System.EventHandler(this.Refocus);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button reviewVersesButton;
        private System.Windows.Forms.Button matchVerseButton;
		private System.Windows.Forms.Button LearnVersesButton;
		private System.Windows.Forms.Button ViewVersesButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label BlankLabel;
	}
}
