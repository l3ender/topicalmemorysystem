namespace Topical_Memory_System
{
	partial class PrintOptions
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintOptions));
			this.BothRadio = new System.Windows.Forms.RadioButton();
			this.VerseRadio = new System.Windows.Forms.RadioButton();
			this.ReferenceRadio = new System.Windows.Forms.RadioButton();
			this.PrintButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BothRadio
			// 
			this.BothRadio.AutoSize = true;
			this.BothRadio.Checked = true;
			this.BothRadio.Location = new System.Drawing.Point(26, 30);
			this.BothRadio.Name = "BothRadio";
			this.BothRadio.Size = new System.Drawing.Size(178, 17);
			this.BothRadio.TabIndex = 0;
			this.BothRadio.TabStop = true;
			this.BothRadio.Text = "Print both references and verses";
			this.BothRadio.UseVisualStyleBackColor = true;
			// 
			// VerseRadio
			// 
			this.VerseRadio.AutoSize = true;
			this.VerseRadio.Location = new System.Drawing.Point(26, 65);
			this.VerseRadio.Name = "VerseRadio";
			this.VerseRadio.Size = new System.Drawing.Size(99, 17);
			this.VerseRadio.TabIndex = 1;
			this.VerseRadio.Text = "Print just verses";
			this.VerseRadio.UseVisualStyleBackColor = true;
			// 
			// ReferenceRadio
			// 
			this.ReferenceRadio.AutoSize = true;
			this.ReferenceRadio.Location = new System.Drawing.Point(26, 99);
			this.ReferenceRadio.Name = "ReferenceRadio";
			this.ReferenceRadio.Size = new System.Drawing.Size(118, 17);
			this.ReferenceRadio.TabIndex = 2;
			this.ReferenceRadio.Text = "Print just references";
			this.ReferenceRadio.UseVisualStyleBackColor = true;
			// 
			// PrintButton
			// 
			this.PrintButton.Location = new System.Drawing.Point(78, 145);
			this.PrintButton.Name = "PrintButton";
			this.PrintButton.Size = new System.Drawing.Size(75, 23);
			this.PrintButton.TabIndex = 3;
			this.PrintButton.Text = "Print!";
			this.PrintButton.UseVisualStyleBackColor = true;
			this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
			// 
			// PrintOptions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(218, 180);
			this.ControlBox = false;
			this.Controls.Add(this.PrintButton);
			this.Controls.Add(this.ReferenceRadio);
			this.Controls.Add(this.VerseRadio);
			this.Controls.Add(this.BothRadio);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PrintOptions";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Print Options";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton BothRadio;
		private System.Windows.Forms.RadioButton VerseRadio;
		private System.Windows.Forms.RadioButton ReferenceRadio;
		private System.Windows.Forms.Button PrintButton;
	}
}