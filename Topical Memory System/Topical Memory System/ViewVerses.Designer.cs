namespace Topical_Memory_System
{
	partial class ViewVerses
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
			VersePacksBox = new System.Windows.Forms.ListBox();
			VersesBox = new System.Windows.Forms.ListBox();
			VerseDataBox = new System.Windows.Forms.RichTextBox();
			this.BlankLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			ViewInContextButton = new System.Windows.Forms.Button();
			HearVerseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// VersePacksBox
			// 
			VersePacksBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			VersePacksBox.FormattingEnabled = true;
			VersePacksBox.ItemHeight = 15;
			VersePacksBox.Location = new System.Drawing.Point(50, 61);
			VersePacksBox.Name = "VersePacksBox";
			VersePacksBox.Size = new System.Drawing.Size(186, 79);
			VersePacksBox.TabIndex = 0;
			VersePacksBox.SelectedIndexChanged += new System.EventHandler(PackSelected);
			// 
			// VersesBox
			// 
			VersesBox.FormattingEnabled = true;
			VersesBox.Location = new System.Drawing.Point(76, 219);
			VersesBox.Name = "VersesBox";
			VersesBox.Size = new System.Drawing.Size(130, 160);
			VersesBox.TabIndex = 1;
			VersesBox.SelectedIndexChanged += new System.EventHandler(VerseSelected);
			// 
			// VerseDataBox
			// 
			VerseDataBox.BackColor = System.Drawing.SystemColors.Control;
			VerseDataBox.Cursor = System.Windows.Forms.Cursors.Default;
			VerseDataBox.Location = new System.Drawing.Point(306, 143);
			VerseDataBox.Name = "VerseDataBox";
			VerseDataBox.ReadOnly = true;
			VerseDataBox.Size = new System.Drawing.Size(281, 99);
			VerseDataBox.TabIndex = 2;
			VerseDataBox.Text = "";
			// 
			// BlankLabel
			// 
			this.BlankLabel.AutoSize = true;
			this.BlankLabel.Location = new System.Drawing.Point(4, 4);
			this.BlankLabel.Name = "BlankLabel";
			this.BlankLabel.Size = new System.Drawing.Size(0, 13);
			this.BlankLabel.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(73, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "1) Select verse pack";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(88, 191);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 18);
			this.label2.TabIndex = 5;
			this.label2.Text = "2) Select verse";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(390, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 18);
			this.label3.TabIndex = 6;
			this.label3.Text = "3) View verse";
			// 
			// ViewInContextButton
			// 
			ViewInContextButton.Enabled = false;
			ViewInContextButton.Location = new System.Drawing.Point(321, 266);
			ViewInContextButton.Name = "ViewInContextButton";
			ViewInContextButton.Size = new System.Drawing.Size(108, 30);
			ViewInContextButton.TabIndex = 7;
			ViewInContextButton.Text = "View in context";
			ViewInContextButton.UseVisualStyleBackColor = true;
			ViewInContextButton.Click += new System.EventHandler(ViewInContextButton_Click);
			// 
			// HearVerseButton
			// 
			HearVerseButton.Enabled = false;
			HearVerseButton.Location = new System.Drawing.Point(459, 266);
			HearVerseButton.Name = "HearVerseButton";
			HearVerseButton.Size = new System.Drawing.Size(108, 30);
			HearVerseButton.TabIndex = 8;
			HearVerseButton.Text = "Hear verse";
			HearVerseButton.UseVisualStyleBackColor = true;
			HearVerseButton.Click += new System.EventHandler(HearVerseButton_Click);
			// 
			// ViewVerses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(HearVerseButton);
			this.Controls.Add(ViewInContextButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BlankLabel);
			this.Controls.Add(VerseDataBox);
			this.Controls.Add(VersesBox);
			this.Controls.Add(VersePacksBox);
			this.Name = "ViewVerses";
			this.Size = new System.Drawing.Size(637, 411);
			this.Click += new System.EventHandler(this.Refocus);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label BlankLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private static System.Windows.Forms.ListBox VersePacksBox;
		private static System.Windows.Forms.ListBox VersesBox;
		private static System.Windows.Forms.RichTextBox VerseDataBox;
		private static System.Windows.Forms.Button ViewInContextButton;
		private static System.Windows.Forms.Button HearVerseButton;
	}
}
