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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupNames = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SaveGroupNameButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupNames);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "1.  Select custom group pack:";
            // 
            // groupNames
            // 
            this.groupNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupNames.FormattingEnabled = true;
            this.groupNames.Location = new System.Drawing.Point(164, 41);
            this.groupNames.Name = "groupNames";
            this.groupNames.Size = new System.Drawing.Size(168, 21);
            this.groupNames.TabIndex = 0;
            this.groupNames.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 304);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.SaveGroupNameButton);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.groupName);
            this.panel4.Location = new System.Drawing.Point(14, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(469, 57);
            this.panel4.TabIndex = 3;
            // 
            // SaveGroupNameButton
            // 
            this.SaveGroupNameButton.Enabled = false;
            this.SaveGroupNameButton.Location = new System.Drawing.Point(360, 14);
            this.SaveGroupNameButton.Name = "SaveGroupNameButton";
            this.SaveGroupNameButton.Size = new System.Drawing.Size(50, 23);
            this.SaveGroupNameButton.TabIndex = 2;
            this.SaveGroupNameButton.Text = "Save";
            this.SaveGroupNameButton.UseVisualStyleBackColor = true;
            this.SaveGroupNameButton.Click += new System.EventHandler(this.SaveGroupNameButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Edit custom group name:";
            // 
            // groupName
            // 
            this.groupName.Location = new System.Drawing.Point(185, 16);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(155, 20);
            this.groupName.TabIndex = 0;
            this.groupName.TextChanged += new System.EventHandler(this.GroupNameChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.UpdateVerseButton);
            this.panel3.Controls.Add(this.DeleteVerseButton);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.verseDataBox);
            this.panel3.Controls.Add(this.verseReferenceBox);
            this.panel3.Controls.Add(this.verseNameBox);
            this.panel3.Controls.Add(this.versesListBox);
            this.panel3.Location = new System.Drawing.Point(14, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 172);
            this.panel3.TabIndex = 2;
            // 
            // UpdateVerseButton
            // 
            this.UpdateVerseButton.Enabled = false;
            this.UpdateVerseButton.Location = new System.Drawing.Point(18, 132);
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
            this.DeleteVerseButton.Location = new System.Drawing.Point(18, 103);
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
            this.label5.Location = new System.Drawing.Point(15, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Select a verse:";
            // 
            // verseDataBox
            // 
            this.verseDataBox.Location = new System.Drawing.Point(157, 67);
            this.verseDataBox.Multiline = true;
            this.verseDataBox.Name = "verseDataBox";
            this.verseDataBox.Size = new System.Drawing.Size(292, 88);
            this.verseDataBox.TabIndex = 6;
            this.verseDataBox.TextChanged += new System.EventHandler(this.VerseValueChanged);
            // 
            // verseReferenceBox
            // 
            this.verseReferenceBox.Location = new System.Drawing.Point(375, 37);
            this.verseReferenceBox.Name = "verseReferenceBox";
            this.verseReferenceBox.Size = new System.Drawing.Size(74, 20);
            this.verseReferenceBox.TabIndex = 5;
            this.verseReferenceBox.TextChanged += new System.EventHandler(this.VerseValueChanged);
            // 
            // verseNameBox
            // 
            this.verseNameBox.Location = new System.Drawing.Point(157, 37);
            this.verseNameBox.Name = "verseNameBox";
            this.verseNameBox.Size = new System.Drawing.Size(159, 20);
            this.verseNameBox.TabIndex = 4;
            this.verseNameBox.TextChanged += new System.EventHandler(this.VerseValueChanged);
            // 
            // versesListBox
            // 
            this.versesListBox.FormattingEnabled = true;
            this.versesListBox.Location = new System.Drawing.Point(18, 35);
            this.versesListBox.Name = "versesListBox";
            this.versesListBox.Size = new System.Drawing.Size(120, 56);
            this.versesListBox.TabIndex = 0;
            this.versesListBox.SelectedIndexChanged += new System.EventHandler(this.VerseSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.  Edit desired fields";
            // 
            // EditCustomVerses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 425);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCustomVerses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Custom Verses";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox groupNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SaveGroupNameButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox groupName;
        private System.Windows.Forms.ListBox versesListBox;
        private System.Windows.Forms.TextBox verseDataBox;
        private System.Windows.Forms.TextBox verseReferenceBox;
        private System.Windows.Forms.TextBox verseNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UpdateVerseButton;
        private System.Windows.Forms.Button DeleteVerseButton;

    }
}