namespace Topical_Memory_System
{
	partial class ImportVerses
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportVerses));
			this.panel1 = new System.Windows.Forms.Panel();
			this.ShowHelpButton = new System.Windows.Forms.Button();
			this.GroupStatsBox = new System.Windows.Forms.ListBox();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.RemoveAllButton = new System.Windows.Forms.Button();
			this.AddAllButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.PlacedVersesBox = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.GroupNamesDropDown = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.VersesBox = new System.Windows.Forms.ListBox();
			this.SaveButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ShowHelpButton);
			this.panel1.Controls.Add(this.GroupStatsBox);
			this.panel1.Controls.Add(this.RemoveButton);
			this.panel1.Controls.Add(this.RemoveAllButton);
			this.panel1.Controls.Add(this.AddAllButton);
			this.panel1.Controls.Add(this.AddButton);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.PlacedVersesBox);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.GroupNamesDropDown);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.VersesBox);
			this.panel1.Controls.Add(this.SaveButton);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(561, 359);
			this.panel1.TabIndex = 0;
			// 
			// ShowHelpButton
			// 
			this.ShowHelpButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ShowHelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ShowHelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ShowHelpButton.Location = new System.Drawing.Point(4, 325);
			this.ShowHelpButton.Name = "ShowHelpButton";
			this.ShowHelpButton.Size = new System.Drawing.Size(35, 31);
			this.ShowHelpButton.TabIndex = 36;
			this.ShowHelpButton.Text = "?";
			this.ShowHelpButton.UseVisualStyleBackColor = false;
			this.ShowHelpButton.Click += new System.EventHandler(this.ShowHelpButton_Click);
			// 
			// GroupStatsBox
			// 
			this.GroupStatsBox.BackColor = System.Drawing.SystemColors.Control;
			this.GroupStatsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.GroupStatsBox.FormattingEnabled = true;
			this.GroupStatsBox.Location = new System.Drawing.Point(349, 280);
			this.GroupStatsBox.Name = "GroupStatsBox";
			this.GroupStatsBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.GroupStatsBox.Size = new System.Drawing.Size(186, 78);
			this.GroupStatsBox.TabIndex = 35;
			// 
			// RemoveButton
			// 
			this.RemoveButton.Enabled = false;
			this.RemoveButton.Location = new System.Drawing.Point(227, 141);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(107, 23);
			this.RemoveButton.TabIndex = 34;
			this.RemoveButton.Text = "<< Remove Verses";
			this.RemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveVerseButton_Click);
			// 
			// RemoveAllButton
			// 
			this.RemoveAllButton.Enabled = false;
			this.RemoveAllButton.Location = new System.Drawing.Point(227, 171);
			this.RemoveAllButton.Name = "RemoveAllButton";
			this.RemoveAllButton.Size = new System.Drawing.Size(107, 23);
			this.RemoveAllButton.TabIndex = 33;
			this.RemoveAllButton.Text = "<< Remove All";
			this.RemoveAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.RemoveAllButton.UseVisualStyleBackColor = true;
			this.RemoveAllButton.Click += new System.EventHandler(this.RemoveAllButton_Click);
			// 
			// AddAllButton
			// 
			this.AddAllButton.Enabled = false;
			this.AddAllButton.Location = new System.Drawing.Point(227, 252);
			this.AddAllButton.Name = "AddAllButton";
			this.AddAllButton.Size = new System.Drawing.Size(107, 23);
			this.AddAllButton.TabIndex = 32;
			this.AddAllButton.Text = "Add All >>";
			this.AddAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AddAllButton.UseVisualStyleBackColor = true;
			this.AddAllButton.Click += new System.EventHandler(this.AddAllButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Enabled = false;
			this.AddButton.Location = new System.Drawing.Point(227, 223);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(107, 23);
			this.AddButton.TabIndex = 31;
			this.AddButton.Text = "Add Verses >>";
			this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddVerseButton_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(346, 109);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(148, 16);
			this.label5.TabIndex = 30;
			this.label5.Text = "Verses in current group:";
			// 
			// PlacedVersesBox
			// 
			this.PlacedVersesBox.FormattingEnabled = true;
			this.PlacedVersesBox.Location = new System.Drawing.Point(349, 128);
			this.PlacedVersesBox.Name = "PlacedVersesBox";
			this.PlacedVersesBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.PlacedVersesBox.Size = new System.Drawing.Size(186, 147);
			this.PlacedVersesBox.TabIndex = 29;
			this.PlacedVersesBox.SelectedIndexChanged += new System.EventHandler(this.VerseBox_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(346, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 16);
			this.label4.TabIndex = 28;
			this.label4.Text = "Group to add verses to:";
			// 
			// GroupNamesDropDown
			// 
			this.GroupNamesDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.GroupNamesDropDown.FormattingEnabled = true;
			this.GroupNamesDropDown.Location = new System.Drawing.Point(349, 76);
			this.GroupNamesDropDown.Name = "GroupNamesDropDown";
			this.GroupNamesDropDown.Size = new System.Drawing.Size(186, 21);
			this.GroupNamesDropDown.TabIndex = 27;
			this.GroupNamesDropDown.SelectedIndexChanged += new System.EventHandler(this.GroupNamesDropDown_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(31, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 16);
			this.label3.TabIndex = 26;
			this.label3.Text = "Verses to import:";
			// 
			// VersesBox
			// 
			this.VersesBox.FormattingEnabled = true;
			this.VersesBox.Location = new System.Drawing.Point(33, 76);
			this.VersesBox.Name = "VersesBox";
			this.VersesBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.VersesBox.Size = new System.Drawing.Size(177, 199);
			this.VersesBox.TabIndex = 25;
			this.VersesBox.SelectedIndexChanged += new System.EventHandler(this.VersesBox_SelectedIndexChanged);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(228, 312);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(104, 35);
			this.SaveButton.TabIndex = 24;
			this.SaveButton.Text = "Finalize Import";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 278);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Hold Ctrl to select multiple verses";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(41, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(479, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Select verses on the left and add to the desired groups on the right";
			// 
			// ImportVerses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(585, 383);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ImportVerses";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Import Custom Verses";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.ListBox VersesBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox GroupNamesDropDown;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox PlacedVersesBox;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.Button RemoveAllButton;
		private System.Windows.Forms.Button AddAllButton;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.ListBox GroupStatsBox;
		private System.Windows.Forms.Button ShowHelpButton;

	}
}