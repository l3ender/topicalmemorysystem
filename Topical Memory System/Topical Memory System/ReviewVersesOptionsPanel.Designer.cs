namespace Topical_Memory_System
{
	partial class ReviewVersesOptionsPanel
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.VersePackListBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.startButton = new System.Windows.Forms.Button();
			this.chooseVersesLabel = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.VersePackListBox);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.startButton);
			this.panel1.Controls.Add(this.chooseVersesLabel);
			this.panel1.Location = new System.Drawing.Point(132, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(372, 338);
			this.panel1.TabIndex = 0;
			// 
			// VersePackListBox
			// 
			this.VersePackListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VersePackListBox.FormattingEnabled = true;
			this.VersePackListBox.ItemHeight = 15;
			this.VersePackListBox.Location = new System.Drawing.Point(77, 92);
			this.VersePackListBox.Name = "VersePackListBox";
			this.VersePackListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.VersePackListBox.Size = new System.Drawing.Size(217, 169);
			this.VersePackListBox.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(102, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "(Hold Ctrl to select multiple packs)";
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(136, 281);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(98, 30);
			this.startButton.TabIndex = 20;
			this.startButton.Text = "Start!";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// chooseVersesLabel
			// 
			this.chooseVersesLabel.AutoSize = true;
			this.chooseVersesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chooseVersesLabel.Location = new System.Drawing.Point(79, 25);
			this.chooseVersesLabel.Name = "chooseVersesLabel";
			this.chooseVersesLabel.Size = new System.Drawing.Size(212, 20);
			this.chooseVersesLabel.TabIndex = 13;
			this.chooseVersesLabel.Text = "Select verse packs to review:";
			// 
			// ReviewVersesOptionsPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "ReviewVersesOptionsPanel";
			this.Size = new System.Drawing.Size(637, 411);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label chooseVersesLabel;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox VersePackListBox;




	}
}
