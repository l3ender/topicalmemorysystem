namespace Topical_Memory_System
{
	partial class LearnReferences
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
			this.VerseBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ReferenceBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.BookBox = new System.Windows.Forms.ComboBox();
			this.GuessButton = new System.Windows.Forms.Button();
			this.NextVerseButton = new System.Windows.Forms.Button();
			this.PreviousVerseButton = new System.Windows.Forms.Button();
			this.BookAnswerLabel1 = new System.Windows.Forms.Label();
			this.BookAnswerLabel2 = new System.Windows.Forms.Label();
			this.ChapterAnswerLabel2 = new System.Windows.Forms.Label();
			this.ChapterAnswerLabel1 = new System.Windows.Forms.Label();
			this.VerseAnswerLabel2 = new System.Windows.Forms.Label();
			this.VerseAnswerLabel1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// VerseBox
			// 
			this.VerseBox.BackColor = System.Drawing.SystemColors.Control;
			this.VerseBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.VerseBox.Location = new System.Drawing.Point(204, 76);
			this.VerseBox.Multiline = true;
			this.VerseBox.Name = "VerseBox";
			this.VerseBox.ReadOnly = true;
			this.VerseBox.Size = new System.Drawing.Size(316, 169);
			this.VerseBox.TabIndex = 50;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(117, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 15);
			this.label1.TabIndex = 51;
			this.label1.Text = "Verse:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(347, 283);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 51;
			this.label2.Text = "Reference:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(151, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(335, 20);
			this.label3.TabIndex = 50;
			this.label3.Text = "Given the following verse, name the reference:";
			// 
			// ReferenceBox
			// 
			this.ReferenceBox.Location = new System.Drawing.Point(350, 302);
			this.ReferenceBox.Name = "ReferenceBox";
			this.ReferenceBox.Size = new System.Drawing.Size(98, 20);
			this.ReferenceBox.TabIndex = 1;
			this.ReferenceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ReferenceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReferenceKeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(117, 283);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 15);
			this.label4.TabIndex = 51;
			this.label4.Text = "Book:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(179, 285);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 13);
			this.label5.TabIndex = 52;
			this.label5.Text = "(ex: 1 Corinthians)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(424, 285);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 13);
			this.label6.TabIndex = 53;
			this.label6.Text = "(ex: 15:3 or 15:3,4)";
			// 
			// BookBox
			// 
			this.BookBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.BookBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.BookBox.FormattingEnabled = true;
			this.BookBox.Location = new System.Drawing.Point(120, 301);
			this.BookBox.Name = "BookBox";
			this.BookBox.Size = new System.Drawing.Size(198, 21);
			this.BookBox.TabIndex = 0;
			// 
			// GuessButton
			// 
			this.GuessButton.Location = new System.Drawing.Point(281, 371);
			this.GuessButton.Name = "GuessButton";
			this.GuessButton.Size = new System.Drawing.Size(75, 23);
			this.GuessButton.TabIndex = 2;
			this.GuessButton.Text = "Guess";
			this.GuessButton.UseVisualStyleBackColor = true;
			this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
			// 
			// NextVerseButton
			// 
			this.NextVerseButton.Location = new System.Drawing.Point(519, 371);
			this.NextVerseButton.Name = "NextVerseButton";
			this.NextVerseButton.Size = new System.Drawing.Size(90, 23);
			this.NextVerseButton.TabIndex = 3;
			this.NextVerseButton.Text = "Next Verse";
			this.NextVerseButton.UseVisualStyleBackColor = true;
			this.NextVerseButton.Click += new System.EventHandler(this.NextVerseButton_Click);
			// 
			// PreviousVerseButton
			// 
			this.PreviousVerseButton.Enabled = false;
			this.PreviousVerseButton.Location = new System.Drawing.Point(28, 371);
			this.PreviousVerseButton.Name = "PreviousVerseButton";
			this.PreviousVerseButton.Size = new System.Drawing.Size(90, 23);
			this.PreviousVerseButton.TabIndex = 56;
			this.PreviousVerseButton.Text = "Previous Verse";
			this.PreviousVerseButton.UseVisualStyleBackColor = true;
			this.PreviousVerseButton.Click += new System.EventHandler(this.PreviousVerseButton_Click);
			// 
			// BookAnswerLabel1
			// 
			this.BookAnswerLabel1.AutoSize = true;
			this.BookAnswerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookAnswerLabel1.Location = new System.Drawing.Point(120, 340);
			this.BookAnswerLabel1.Name = "BookAnswerLabel1";
			this.BookAnswerLabel1.Size = new System.Drawing.Size(38, 15);
			this.BookAnswerLabel1.TabIndex = 57;
			this.BookAnswerLabel1.Text = "Book:";
			this.BookAnswerLabel1.Visible = false;
			// 
			// BookAnswerLabel2
			// 
			this.BookAnswerLabel2.AutoSize = true;
			this.BookAnswerLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookAnswerLabel2.Location = new System.Drawing.Point(164, 340);
			this.BookAnswerLabel2.Name = "BookAnswerLabel2";
			this.BookAnswerLabel2.Size = new System.Drawing.Size(53, 15);
			this.BookAnswerLabel2.TabIndex = 58;
			this.BookAnswerLabel2.Text = "Correct";
			this.BookAnswerLabel2.Visible = false;
			// 
			// ChapterAnswerLabel2
			// 
			this.ChapterAnswerLabel2.AutoSize = true;
			this.ChapterAnswerLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChapterAnswerLabel2.Location = new System.Drawing.Point(323, 340);
			this.ChapterAnswerLabel2.Name = "ChapterAnswerLabel2";
			this.ChapterAnswerLabel2.Size = new System.Drawing.Size(53, 15);
			this.ChapterAnswerLabel2.TabIndex = 60;
			this.ChapterAnswerLabel2.Text = "Correct";
			this.ChapterAnswerLabel2.Visible = false;
			// 
			// ChapterAnswerLabel1
			// 
			this.ChapterAnswerLabel1.AutoSize = true;
			this.ChapterAnswerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChapterAnswerLabel1.Location = new System.Drawing.Point(264, 340);
			this.ChapterAnswerLabel1.Name = "ChapterAnswerLabel1";
			this.ChapterAnswerLabel1.Size = new System.Drawing.Size(53, 15);
			this.ChapterAnswerLabel1.TabIndex = 59;
			this.ChapterAnswerLabel1.Text = "Chapter:";
			this.ChapterAnswerLabel1.Visible = false;
			// 
			// VerseAnswerLabel2
			// 
			this.VerseAnswerLabel2.AutoSize = true;
			this.VerseAnswerLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VerseAnswerLabel2.Location = new System.Drawing.Point(476, 340);
			this.VerseAnswerLabel2.Name = "VerseAnswerLabel2";
			this.VerseAnswerLabel2.Size = new System.Drawing.Size(53, 15);
			this.VerseAnswerLabel2.TabIndex = 62;
			this.VerseAnswerLabel2.Text = "Correct";
			this.VerseAnswerLabel2.Visible = false;
			// 
			// VerseAnswerLabel1
			// 
			this.VerseAnswerLabel1.AutoSize = true;
			this.VerseAnswerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VerseAnswerLabel1.Location = new System.Drawing.Point(415, 340);
			this.VerseAnswerLabel1.Name = "VerseAnswerLabel1";
			this.VerseAnswerLabel1.Size = new System.Drawing.Size(55, 15);
			this.VerseAnswerLabel1.TabIndex = 61;
			this.VerseAnswerLabel1.Text = "Verse(s):";
			this.VerseAnswerLabel1.Visible = false;
			// 
			// LearnReferences
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.VerseAnswerLabel2);
			this.Controls.Add(this.VerseAnswerLabel1);
			this.Controls.Add(this.ChapterAnswerLabel2);
			this.Controls.Add(this.ChapterAnswerLabel1);
			this.Controls.Add(this.BookAnswerLabel2);
			this.Controls.Add(this.BookAnswerLabel1);
			this.Controls.Add(this.PreviousVerseButton);
			this.Controls.Add(this.NextVerseButton);
			this.Controls.Add(this.GuessButton);
			this.Controls.Add(this.BookBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ReferenceBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.VerseBox);
			this.Name = "LearnReferences";
			this.Size = new System.Drawing.Size(637, 411);
			this.Load += new System.EventHandler(this.PanelLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox VerseBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ReferenceBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox BookBox;
		private System.Windows.Forms.Button GuessButton;
		private System.Windows.Forms.Button NextVerseButton;
		private System.Windows.Forms.Button PreviousVerseButton;
		private System.Windows.Forms.Label BookAnswerLabel1;
		private System.Windows.Forms.Label BookAnswerLabel2;
		private System.Windows.Forms.Label ChapterAnswerLabel2;
		private System.Windows.Forms.Label ChapterAnswerLabel1;
		private System.Windows.Forms.Label VerseAnswerLabel2;
		private System.Windows.Forms.Label VerseAnswerLabel1;
	}
}
