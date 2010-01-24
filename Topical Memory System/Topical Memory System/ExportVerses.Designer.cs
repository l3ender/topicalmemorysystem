namespace Topical_Memory_System
{
	partial class ExportVerses
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.VersePackBox = new System.Windows.Forms.ListBox();
			this.VersesBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SelectedVersesBox = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.AddVerseButton = new System.Windows.Forms.Button();
			this.AddAllButton = new System.Windows.Forms.Button();
			this.RemoveVerseButton = new System.Windows.Forms.Button();
			this.RemoveAllButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.SaveButton);
			this.panel1.Controls.Add(this.RemoveVerseButton);
			this.panel1.Controls.Add(this.RemoveAllButton);
			this.panel1.Controls.Add(this.AddAllButton);
			this.panel1.Controls.Add(this.AddVerseButton);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.SelectedVersesBox);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.VersesBox);
			this.panel1.Controls.Add(this.VersePackBox);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(508, 395);
			this.panel1.TabIndex = 0;
			// 
			// VersePackBox
			// 
			this.VersePackBox.FormattingEnabled = true;
			this.VersePackBox.Location = new System.Drawing.Point(19, 44);
			this.VersePackBox.Name = "VersePackBox";
			this.VersePackBox.Size = new System.Drawing.Size(184, 108);
			this.VersePackBox.TabIndex = 1;
			this.VersePackBox.SelectedIndexChanged += new System.EventHandler(this.VersePackSelected);
			// 
			// VersesBox
			// 
			this.VersesBox.FormattingEnabled = true;
			this.VersesBox.Location = new System.Drawing.Point(19, 207);
			this.VersesBox.Name = "VersesBox";
			this.VersesBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.VersesBox.Size = new System.Drawing.Size(184, 147);
			this.VersesBox.TabIndex = 3;
			this.VersesBox.SelectedIndexChanged += new System.EventHandler(this.VerseSelected);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "1) Select custom group";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(55, 185);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "2) Select verses";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(26, 360);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "(Hold Ctrl to select multiple verses)";
			// 
			// SelectedVersesBox
			// 
			this.SelectedVersesBox.FormattingEnabled = true;
			this.SelectedVersesBox.Location = new System.Drawing.Point(361, 90);
			this.SelectedVersesBox.Name = "SelectedVersesBox";
			this.SelectedVersesBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.SelectedVersesBox.Size = new System.Drawing.Size(128, 212);
			this.SelectedVersesBox.TabIndex = 7;
			this.SelectedVersesBox.SelectedIndexChanged += new System.EventHandler(this.SelectedFromTotalBox);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(233, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "3) Add/remove";
			// 
			// AddVerseButton
			// 
			this.AddVerseButton.Enabled = false;
			this.AddVerseButton.Location = new System.Drawing.Point(228, 226);
			this.AddVerseButton.Name = "AddVerseButton";
			this.AddVerseButton.Size = new System.Drawing.Size(107, 23);
			this.AddVerseButton.TabIndex = 9;
			this.AddVerseButton.Text = "Add Verses >>";
			this.AddVerseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AddVerseButton.UseVisualStyleBackColor = true;
			this.AddVerseButton.Click += new System.EventHandler(this.AddVerseButton_Click);
			// 
			// AddAllButton
			// 
			this.AddAllButton.Enabled = false;
			this.AddAllButton.Location = new System.Drawing.Point(228, 265);
			this.AddAllButton.Name = "AddAllButton";
			this.AddAllButton.Size = new System.Drawing.Size(107, 23);
			this.AddAllButton.TabIndex = 10;
			this.AddAllButton.Text = "Add All >>";
			this.AddAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AddAllButton.UseVisualStyleBackColor = true;
			this.AddAllButton.Click += new System.EventHandler(this.AddAllButton_Click);
			// 
			// RemoveVerseButton
			// 
			this.RemoveVerseButton.Enabled = false;
			this.RemoveVerseButton.Location = new System.Drawing.Point(228, 99);
			this.RemoveVerseButton.Name = "RemoveVerseButton";
			this.RemoveVerseButton.Size = new System.Drawing.Size(107, 23);
			this.RemoveVerseButton.TabIndex = 12;
			this.RemoveVerseButton.Text = "<< Remove Verses";
			this.RemoveVerseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.RemoveVerseButton.UseVisualStyleBackColor = true;
			this.RemoveVerseButton.Click += new System.EventHandler(this.RemoveVerseButton_Click);
			// 
			// RemoveAllButton
			// 
			this.RemoveAllButton.Enabled = false;
			this.RemoveAllButton.Location = new System.Drawing.Point(228, 138);
			this.RemoveAllButton.Name = "RemoveAllButton";
			this.RemoveAllButton.Size = new System.Drawing.Size(107, 23);
			this.RemoveAllButton.TabIndex = 11;
			this.RemoveAllButton.Text = "<< Remove All";
			this.RemoveAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.RemoveAllButton.UseVisualStyleBackColor = true;
			this.RemoveAllButton.Click += new System.EventHandler(this.RemoveAllButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Enabled = false;
			this.SaveButton.Location = new System.Drawing.Point(310, 360);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(92, 30);
			this.SaveButton.TabIndex = 13;
			this.SaveButton.Text = "Save to file";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(304, 338);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 16);
			this.label5.TabIndex = 14;
			this.label5.Text = "4) Export verses";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(380, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 15);
			this.label6.TabIndex = 15;
			this.label6.Text = "Verses to save";
			// 
			// ExportVerses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 419);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "ExportVerses";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Export Custom Verses";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox VersesBox;
		private System.Windows.Forms.ListBox VersePackBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox SelectedVersesBox;
		private System.Windows.Forms.Button AddAllButton;
		private System.Windows.Forms.Button AddVerseButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button RemoveVerseButton;
		private System.Windows.Forms.Button RemoveAllButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Label label6;

	}
}