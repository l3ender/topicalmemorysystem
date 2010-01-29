namespace Topical_Memory_System
{
	partial class LearnVersesOptionPanel
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ReciteVersesButton = new System.Windows.Forms.Button();
			this.LearnReferencesButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ReciteVersesButton
			// 
			this.ReciteVersesButton.Location = new System.Drawing.Point(247, 245);
			this.ReciteVersesButton.Name = "ReciteVersesButton";
			this.ReciteVersesButton.Size = new System.Drawing.Size(143, 46);
			this.ReciteVersesButton.TabIndex = 6;
			this.ReciteVersesButton.Text = "Recite Verses";
			this.ReciteVersesButton.UseVisualStyleBackColor = true;
			this.ReciteVersesButton.Click += new System.EventHandler(this.ReciteVersesButton_Click);
			// 
			// LearnReferencesButton
			// 
			this.LearnReferencesButton.Location = new System.Drawing.Point(247, 119);
			this.LearnReferencesButton.Name = "LearnReferencesButton";
			this.LearnReferencesButton.Size = new System.Drawing.Size(143, 46);
			this.LearnReferencesButton.TabIndex = 5;
			this.LearnReferencesButton.Text = "Learn References";
			this.LearnReferencesButton.UseVisualStyleBackColor = true;
			this.LearnReferencesButton.Click += new System.EventHandler(this.LearnReferencesButton_Click);
			// 
			// LearnVersesOptionPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ReciteVersesButton);
			this.Controls.Add(this.LearnReferencesButton);
			this.Name = "LearnVersesOptionPanel";
			this.Size = new System.Drawing.Size(637, 411);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ReciteVersesButton;
		private System.Windows.Forms.Button LearnReferencesButton;
	}
}
