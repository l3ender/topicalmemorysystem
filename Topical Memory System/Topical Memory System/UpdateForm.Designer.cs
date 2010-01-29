namespace Topical_Memory_System
{
	partial class UpdateForm
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
			this.DisplayBox = new System.Windows.Forms.TextBox();
			this.LinkLabel = new System.Windows.Forms.LinkLabel();
			this.CloseButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.DisplayBox);
			this.panel1.Controls.Add(this.LinkLabel);
			this.panel1.Controls.Add(this.CloseButton);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(182, 142);
			this.panel1.TabIndex = 0;
			// 
			// DisplayBox
			// 
			this.DisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DisplayBox.Location = new System.Drawing.Point(0, 13);
			this.DisplayBox.Multiline = true;
			this.DisplayBox.Name = "DisplayBox";
			this.DisplayBox.ReadOnly = true;
			this.DisplayBox.Size = new System.Drawing.Size(182, 42);
			this.DisplayBox.TabIndex = 3;
			this.DisplayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// LinkLabel
			// 
			this.LinkLabel.AutoSize = true;
			this.LinkLabel.Location = new System.Drawing.Point(36, 74);
			this.LinkLabel.Name = "LinkLabel";
			this.LinkLabel.Size = new System.Drawing.Size(110, 13);
			this.LinkLabel.TabIndex = 2;
			this.LinkLabel.TabStop = true;
			this.LinkLabel.Text = "Get the latest version!";
			this.LinkLabel.Visible = false;
			this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(54, 107);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(75, 23);
			this.CloseButton.TabIndex = 0;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// UpdateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(206, 166);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "UpdateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.LinkLabel LinkLabel;
		private System.Windows.Forms.TextBox DisplayBox;
	}
}