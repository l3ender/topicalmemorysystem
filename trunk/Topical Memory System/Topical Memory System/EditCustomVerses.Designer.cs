namespace Topical_Memory_System
{
    partial class EditCustomVerses
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomVerses));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			groupNames = new System.Windows.Forms.ComboBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.UpdateVerseButton = new System.Windows.Forms.Button();
			this.DeleteVerseButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.verseDataBox = new System.Windows.Forms.TextBox();
			this.verseReferenceBox = new System.Windows.Forms.TextBox();
			this.verseNameBox = new System.Windows.Forms.TextBox();
			this.versesListBox = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(groupNames);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(499, 68);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(157, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "1 - Select custom group pack:";
			// 
			// groupNames
			// 
			groupNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			groupNames.FormattingEnabled = true;
			groupNames.Location = new System.Drawing.Point(164, 37);
			groupNames.Name = "groupNames";
			groupNames.Size = new System.Drawing.Size(168, 21);
			groupNames.TabIndex = 0;
			groupNames.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(12, 96);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(499, 230);
			this.panel2.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.UpdateVerseButton);
			this.panel3.Controls.Add(this.DeleteVerseButton);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.verseDataBox);
			this.panel3.Controls.Add(this.verseReferenceBox);
			this.panel3.Controls.Add(this.verseNameBox);
			this.panel3.Controls.Add(this.versesListBox);
			this.panel3.Location = new System.Drawing.Point(14, 25);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(469, 199);
			this.panel3.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(357, 30);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Reference:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(154, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Book:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(154, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Verse:";
			// 
			// UpdateVerseButton
			// 
			this.UpdateVerseButton.Enabled = false;
			this.UpdateVerseButton.Location = new System.Drawing.Point(18, 159);
			this.UpdateVerseButton.Name = "UpdateVerseButton";
			this.UpdateVerseButton.Size = new System.Drawing.Size(120, 23);
			this.UpdateVerseButton.TabIndex = 9;
			this.UpdateVerseButton.Text = "Update verse";
			this.UpdateVerseButton.UseVisualStyleBackColor = true;
			this.UpdateVerseButton.Click += new System.EventHandler(this.UpdateVerseButton_Click);
			// 
			// DeleteVerseButton
			// 
			this.DeleteVerseButton.Enabled = false;
			this.DeleteVerseButton.Location = new System.Drawing.Point(18, 130);
			this.DeleteVerseButton.Name = "DeleteVerseButton";
			this.DeleteVerseButton.Size = new System.Drawing.Size(120, 23);
			this.DeleteVerseButton.TabIndex = 8;
			this.DeleteVerseButton.Text = "Delete verse";
			this.DeleteVerseButton.UseVisualStyleBackColor = true;
			this.DeleteVerseButton.Click += new System.EventHandler(this.DeleteVerseButton_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Select a verse:";
			// 
			// verseDataBox
			// 
			this.verseDataBox.Location = new System.Drawing.Point(157, 94);
			this.verseDataBox.Multiline = true;
			this.verseDataBox.Name = "verseDataBox";
			this.verseDataBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.verseDataBox.Size = new System.Drawing.Size(292, 88);
			this.verseDataBox.TabIndex = 6;
			this.verseDataBox.TextChanged += new System.EventHandler(this.VerseValueChanged);
			// 
			// verseReferenceBox
			// 
			this.verseReferenceBox.Location = new System.Drawing.Point(360, 45);
			this.verseReferenceBox.Name = "verseReferenceBox";
			this.verseReferenceBox.Size = new System.Drawing.Size(89, 20);
			this.verseReferenceBox.TabIndex = 5;
			this.verseReferenceBox.TextChanged += new System.EventHandler(this.VerseValueChanged);
			// 
			// verseNameBox
			// 
			this.verseNameBox.Location = new System.Drawing.Point(157, 45);
			this.verseNameBox.Name = "verseNameBox";
			this.verseNameBox.Size = new System.Drawing.Size(159, 20);
			this.verseNameBox.TabIndex = 4;
			this.verseNameBox.TextChanged += new System.EventHandler(this.VerseValueChanged);
			// 
			// versesListBox
			// 
			this.versesListBox.FormattingEnabled = true;
			this.versesListBox.Location = new System.Drawing.Point(18, 27);
			this.versesListBox.Name = "versesListBox";
			this.versesListBox.Size = new System.Drawing.Size(120, 95);
			this.versesListBox.TabIndex = 0;
			this.versesListBox.SelectedIndexChanged += new System.EventHandler(this.VerseSelected);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(181, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "2 - Edit desired fields:";
			// 
			// EditCustomVerses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 341);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditCustomVerses";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Custom Verses";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox versesListBox;
        private System.Windows.Forms.TextBox verseDataBox;
        private System.Windows.Forms.TextBox verseReferenceBox;
        private System.Windows.Forms.TextBox verseNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UpdateVerseButton;
		private System.Windows.Forms.Button DeleteVerseButton;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private static System.Windows.Forms.ComboBox groupNames;

    }
}