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
            this.groupNames = new System.Windows.Forms.ComboBox();
            this.groupName = new System.Windows.Forms.TextBox();
            this.versesListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.versesListBox);
            this.panel1.Controls.Add(this.groupName);
            this.panel1.Controls.Add(this.groupNames);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 338);
            this.panel1.TabIndex = 0;
            // 
            // groupNames
            // 
            this.groupNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupNames.FormattingEnabled = true;
            this.groupNames.Location = new System.Drawing.Point(57, 48);
            this.groupNames.Name = "groupNames";
            this.groupNames.Size = new System.Drawing.Size(168, 21);
            this.groupNames.TabIndex = 0;
            this.groupNames.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // groupName
            // 
            this.groupName.Location = new System.Drawing.Point(288, 48);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(168, 20);
            this.groupName.TabIndex = 1;
            // 
            // versesListBox
            // 
            this.versesListBox.FormattingEnabled = true;
            this.versesListBox.Location = new System.Drawing.Point(57, 137);
            this.versesListBox.Name = "versesListBox";
            this.versesListBox.Size = new System.Drawing.Size(168, 95);
            this.versesListBox.TabIndex = 2;
            // 
            // EditCustomVerses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 362);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCustomVerses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Custom Verses";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox groupNames;
        private System.Windows.Forms.TextBox groupName;
        private System.Windows.Forms.ListBox versesListBox;

    }
}