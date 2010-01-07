namespace Topical_Memory_System
{
	partial class LearnVerses
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
			VerseLabel = new System.Windows.Forms.Label();
			this.VerseEntryBox = new System.Windows.Forms.TextBox();
			this.CompareButton = new System.Windows.Forms.Button();
			this.MatchingBox = new System.Windows.Forms.RichTextBox();
			this.OriginalVerseBox = new System.Windows.Forms.RichTextBox();
			this.NextVerseButton = new System.Windows.Forms.Button();
			this.RedLabel = new System.Windows.Forms.Label();
			this.GreenLabel = new System.Windows.Forms.Label();
			this.PreviousVerseButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.BlankLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// VerseLabel
			// 
			VerseLabel.AutoSize = true;
			VerseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			VerseLabel.Location = new System.Drawing.Point(76, 19);
			VerseLabel.Name = "VerseLabel";
			VerseLabel.Size = new System.Drawing.Size(58, 18);
			VerseLabel.TabIndex = 0;
			VerseLabel.Text = "Verse:  ";
			// 
			// VerseEntryBox
			// 
			this.VerseEntryBox.Location = new System.Drawing.Point(79, 52);
			this.VerseEntryBox.Multiline = true;
			this.VerseEntryBox.Name = "VerseEntryBox";
			this.VerseEntryBox.Size = new System.Drawing.Size(479, 83);
			this.VerseEntryBox.TabIndex = 1;
			this.VerseEntryBox.Text = "Type the verse here";
			this.VerseEntryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
			this.VerseEntryBox.Enter += new System.EventHandler(this.EntryBoxEntered);
			// 
			// CompareButton
			// 
			this.CompareButton.Enabled = false;
			this.CompareButton.Location = new System.Drawing.Point(405, 17);
			this.CompareButton.Name = "CompareButton";
			this.CompareButton.Size = new System.Drawing.Size(153, 25);
			this.CompareButton.TabIndex = 4;
			this.CompareButton.Text = "Compare to original verse";
			this.CompareButton.UseVisualStyleBackColor = true;
			this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
			// 
			// MatchingBox
			// 
			this.MatchingBox.BackColor = System.Drawing.SystemColors.Control;
			this.MatchingBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MatchingBox.Location = new System.Drawing.Point(79, 279);
			this.MatchingBox.Name = "MatchingBox";
			this.MatchingBox.ReadOnly = true;
			this.MatchingBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
			this.MatchingBox.Size = new System.Drawing.Size(479, 83);
			this.MatchingBox.TabIndex = 5;
			this.MatchingBox.Text = "";
			// 
			// OriginalVerseBox
			// 
			this.OriginalVerseBox.BackColor = System.Drawing.SystemColors.Control;
			this.OriginalVerseBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OriginalVerseBox.Location = new System.Drawing.Point(79, 166);
			this.OriginalVerseBox.Name = "OriginalVerseBox";
			this.OriginalVerseBox.ReadOnly = true;
			this.OriginalVerseBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
			this.OriginalVerseBox.Size = new System.Drawing.Size(479, 83);
			this.OriginalVerseBox.TabIndex = 6;
			this.OriginalVerseBox.Text = "";
			// 
			// NextVerseButton
			// 
			this.NextVerseButton.Location = new System.Drawing.Point(455, 375);
			this.NextVerseButton.Name = "NextVerseButton";
			this.NextVerseButton.Size = new System.Drawing.Size(103, 25);
			this.NextVerseButton.TabIndex = 7;
			this.NextVerseButton.Text = "Next Verse";
			this.NextVerseButton.UseVisualStyleBackColor = true;
			this.NextVerseButton.Click += new System.EventHandler(this.NextVerseButton_Click);
			// 
			// RedLabel
			// 
			this.RedLabel.AutoSize = true;
			this.RedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RedLabel.ForeColor = System.Drawing.Color.Red;
			this.RedLabel.Location = new System.Drawing.Point(234, 371);
			this.RedLabel.Name = "RedLabel";
			this.RedLabel.Size = new System.Drawing.Size(141, 13);
			this.RedLabel.TabIndex = 8;
			this.RedLabel.Text = "Red:     text you missed";
			this.RedLabel.Visible = false;
			// 
			// GreenLabel
			// 
			this.GreenLabel.AutoSize = true;
			this.GreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GreenLabel.ForeColor = System.Drawing.Color.Green;
			this.GreenLabel.Location = new System.Drawing.Point(234, 389);
			this.GreenLabel.Name = "GreenLabel";
			this.GreenLabel.Size = new System.Drawing.Size(169, 13);
			this.GreenLabel.TabIndex = 9;
			this.GreenLabel.Text = "Green:  extra text you added";
			this.GreenLabel.Visible = false;
			// 
			// PreviousVerseButton
			// 
			this.PreviousVerseButton.Enabled = false;
			this.PreviousVerseButton.Location = new System.Drawing.Point(79, 375);
			this.PreviousVerseButton.Name = "PreviousVerseButton";
			this.PreviousVerseButton.Size = new System.Drawing.Size(103, 25);
			this.PreviousVerseButton.TabIndex = 10;
			this.PreviousVerseButton.Text = "Previous Verse";
			this.PreviousVerseButton.UseVisualStyleBackColor = true;
			this.PreviousVerseButton.Click += new System.EventHandler(this.PreviousVerseButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(227, 258);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(182, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Side-by-side comparison with original:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(281, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Original verse:";
			// 
			// BlankLabel
			// 
			this.BlankLabel.AutoSize = true;
			this.BlankLabel.Location = new System.Drawing.Point(16, 258);
			this.BlankLabel.Name = "BlankLabel";
			this.BlankLabel.Size = new System.Drawing.Size(0, 13);
			this.BlankLabel.TabIndex = 13;
			// 
			// LearnVerses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.BlankLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.PreviousVerseButton);
			this.Controls.Add(this.GreenLabel);
			this.Controls.Add(this.RedLabel);
			this.Controls.Add(this.NextVerseButton);
			this.Controls.Add(this.OriginalVerseBox);
			this.Controls.Add(this.MatchingBox);
			this.Controls.Add(this.CompareButton);
			this.Controls.Add(this.VerseEntryBox);
			this.Controls.Add(VerseLabel);
			this.Name = "LearnVerses";
			this.Size = new System.Drawing.Size(637, 411);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private static System.Windows.Forms.Label VerseLabel;
		private System.Windows.Forms.TextBox VerseEntryBox;
		private System.Windows.Forms.Button CompareButton;
		private System.Windows.Forms.RichTextBox MatchingBox;
		private System.Windows.Forms.RichTextBox OriginalVerseBox;
		private System.Windows.Forms.Button NextVerseButton;
		private System.Windows.Forms.Label RedLabel;
		private System.Windows.Forms.Label GreenLabel;
		private System.Windows.Forms.Button PreviousVerseButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label BlankLabel;

	}
}
