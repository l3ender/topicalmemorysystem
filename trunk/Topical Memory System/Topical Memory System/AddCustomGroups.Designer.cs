namespace Topical_Memory_System
{
	partial class AddCustomGroups
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
			this.CreateGroupButton = new System.Windows.Forms.Button();
			this.NewGroupName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CreateGroupButton
			// 
			this.CreateGroupButton.Enabled = false;
			this.CreateGroupButton.Location = new System.Drawing.Point(91, 102);
			this.CreateGroupButton.Name = "CreateGroupButton";
			this.CreateGroupButton.Size = new System.Drawing.Size(92, 28);
			this.CreateGroupButton.TabIndex = 0;
			this.CreateGroupButton.Text = "Create group";
			this.CreateGroupButton.UseVisualStyleBackColor = true;
			this.CreateGroupButton.Click += new System.EventHandler(this.CreateGroupButton_Click);
			// 
			// NewGroupName
			// 
			this.NewGroupName.Location = new System.Drawing.Point(35, 64);
			this.NewGroupName.Name = "NewGroupName";
			this.NewGroupName.Size = new System.Drawing.Size(204, 20);
			this.NewGroupName.TabIndex = 1;
			this.NewGroupName.TextChanged += new System.EventHandler(this.NewGroupName_TextChanged);
			this.NewGroupName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewGroupName_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(56, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Specify the group\'s name:";
			// 
			// AddCustomGroups
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 150);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NewGroupName);
			this.Controls.Add(this.CreateGroupButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddCustomGroups";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Custom Groups";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CreateGroupButton;
		private System.Windows.Forms.TextBox NewGroupName;
		private System.Windows.Forms.Label label1;
	}
}