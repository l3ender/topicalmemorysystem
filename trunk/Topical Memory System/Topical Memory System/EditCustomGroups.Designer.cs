namespace Topical_Memory_System
{
	partial class EditCustomGroups
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
			this.label1 = new System.Windows.Forms.Label();
			this.GroupNames = new System.Windows.Forms.ListBox();
			this.NewGroupName = new System.Windows.Forms.TextBox();
			this.SaveGroupName = new System.Windows.Forms.Button();
			this.DeleteGroup = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(80, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Select custom group pack:";
			// 
			// GroupNames
			// 
			this.GroupNames.FormattingEnabled = true;
			this.GroupNames.Location = new System.Drawing.Point(70, 55);
			this.GroupNames.Name = "GroupNames";
			this.GroupNames.Size = new System.Drawing.Size(186, 82);
			this.GroupNames.TabIndex = 3;
			this.GroupNames.SelectedIndexChanged += new System.EventHandler(this.GroupNames_SelectedIndexChanged);
			// 
			// NewGroupName
			// 
			this.NewGroupName.Location = new System.Drawing.Point(42, 181);
			this.NewGroupName.Name = "NewGroupName";
			this.NewGroupName.Size = new System.Drawing.Size(147, 20);
			this.NewGroupName.TabIndex = 4;
			this.NewGroupName.TextChanged += new System.EventHandler(this.NewGroupName_TextChanged);
			// 
			// SaveGroupName
			// 
			this.SaveGroupName.Enabled = false;
			this.SaveGroupName.Location = new System.Drawing.Point(209, 179);
			this.SaveGroupName.Name = "SaveGroupName";
			this.SaveGroupName.Size = new System.Drawing.Size(75, 23);
			this.SaveGroupName.TabIndex = 5;
			this.SaveGroupName.Text = "Save name";
			this.SaveGroupName.UseVisualStyleBackColor = true;
			this.SaveGroupName.Click += new System.EventHandler(this.SaveGroupName_Click);
			// 
			// DeleteGroup
			// 
			this.DeleteGroup.Enabled = false;
			this.DeleteGroup.Location = new System.Drawing.Point(126, 238);
			this.DeleteGroup.Name = "DeleteGroup";
			this.DeleteGroup.Size = new System.Drawing.Size(75, 23);
			this.DeleteGroup.TabIndex = 6;
			this.DeleteGroup.Text = "Delete group";
			this.DeleteGroup.UseVisualStyleBackColor = true;
			this.DeleteGroup.Click += new System.EventHandler(this.DeleteGroup_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(111, 159);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Update group name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(123, 219);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Remove group:";
			// 
			// EditCustomGroups
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(327, 276);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DeleteGroup);
			this.Controls.Add(this.SaveGroupName);
			this.Controls.Add(this.NewGroupName);
			this.Controls.Add(this.GroupNames);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditCustomGroups";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Custom Groups";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox GroupNames;
		private System.Windows.Forms.TextBox NewGroupName;
		private System.Windows.Forms.Button SaveGroupName;
		private System.Windows.Forms.Button DeleteGroup;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;

	}
}