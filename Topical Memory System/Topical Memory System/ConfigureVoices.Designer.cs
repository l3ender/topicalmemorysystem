namespace Topical_Memory_System
{
	partial class ConfigureVoices
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
			this.SaveButton = new System.Windows.Forms.Button();
			this.VoicesDropDown = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TrySettingsButton = new System.Windows.Forms.Button();
			this.SoundBar = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.SoundBar)).BeginInit();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(132, 250);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(105, 33);
			this.SaveButton.TabIndex = 0;
			this.SaveButton.Text = "Save settings";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// VoicesDropDown
			// 
			this.VoicesDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VoicesDropDown.FormattingEnabled = true;
			this.VoicesDropDown.Location = new System.Drawing.Point(85, 58);
			this.VoicesDropDown.Name = "VoicesDropDown";
			this.VoicesDropDown.Size = new System.Drawing.Size(198, 21);
			this.VoicesDropDown.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(166, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Voice:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(164, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Speed:";
			// 
			// TrySettingsButton
			// 
			this.TrySettingsButton.Location = new System.Drawing.Point(147, 197);
			this.TrySettingsButton.Name = "TrySettingsButton";
			this.TrySettingsButton.Size = new System.Drawing.Size(75, 23);
			this.TrySettingsButton.TabIndex = 4;
			this.TrySettingsButton.Text = "Try settings";
			this.TrySettingsButton.UseVisualStyleBackColor = true;
			this.TrySettingsButton.Click += new System.EventHandler(this.TrySettingsButton_Click);
			// 
			// SoundBar
			// 
			this.SoundBar.Location = new System.Drawing.Point(45, 130);
			this.SoundBar.Minimum = -10;
			this.SoundBar.Name = "SoundBar";
			this.SoundBar.Size = new System.Drawing.Size(279, 45);
			this.SoundBar.TabIndex = 5;
			this.SoundBar.Value = -2;
			// 
			// ConfigureVoices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 295);
			this.Controls.Add(this.SoundBar);
			this.Controls.Add(this.TrySettingsButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.VoicesDropDown);
			this.Controls.Add(this.SaveButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConfigureVoices";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Configure Reading Voices";
			((System.ComponentModel.ISupportInitialize)(this.SoundBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.ComboBox VoicesDropDown;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button TrySettingsButton;
		private System.Windows.Forms.TrackBar SoundBar;
	}
}