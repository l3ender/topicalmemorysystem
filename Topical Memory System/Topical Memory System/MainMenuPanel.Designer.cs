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
			this.SuspendLayout();
			// 
			// reviewVersesButton
			// 
			this.reviewVersesButton.Location = new System.Drawing.Point(247, 112);
			this.reviewVersesButton.Name = "reviewVersesButton";
			this.reviewVersesButton.Size = new System.Drawing.Size(143, 46);
			this.reviewVersesButton.TabIndex = 0;
			this.reviewVersesButton.Text = "Review Verses";
			this.reviewVersesButton.UseVisualStyleBackColor = true;
			this.reviewVersesButton.Click += new System.EventHandler(this.ReviewVersesButton_Click);
			// 
			// matchVerseButton
			// 
			this.matchVerseButton.Location = new System.Drawing.Point(247, 183);
			this.matchVerseButton.Name = "matchVerseButton";
			this.matchVerseButton.Size = new System.Drawing.Size(143, 46);
			this.matchVerseButton.TabIndex = 1;
			this.matchVerseButton.Text = "Match Verses";
			this.matchVerseButton.UseVisualStyleBackColor = true;
			this.matchVerseButton.Click += new System.EventHandler(this.MatchVersesButton_Click);
			// 
			// LearnVersesButton
			// 
			this.LearnVersesButton.Location = new System.Drawing.Point(247, 253);
			this.LearnVersesButton.Name = "LearnVersesButton";
			this.LearnVersesButton.Size = new System.Drawing.Size(143, 46);
			this.LearnVersesButton.TabIndex = 2;
			this.LearnVersesButton.Text = "Learn Verses";
			this.LearnVersesButton.UseVisualStyleBackColor = true;
			this.LearnVersesButton.Click += new System.EventHandler(this.LearnVersesButton_Click);
			// 
			// MainMenuPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.LearnVersesButton);
			this.Controls.Add(this.matchVerseButton);
			this.Controls.Add(this.reviewVersesButton);
			this.Name = "MainMenuPanel";
			this.Size = new System.Drawing.Size(637, 411);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button reviewVersesButton;
        private System.Windows.Forms.Button matchVerseButton;
		private System.Windows.Forms.Button LearnVersesButton;
	}
}
