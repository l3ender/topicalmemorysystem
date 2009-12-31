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
            this.chooseVersesLabel = new System.Windows.Forms.Label();
            this.allPacksCheck = new System.Windows.Forms.CheckBox();
            this.aPackCheck = new System.Windows.Forms.CheckBox();
            this.bPackCheck = new System.Windows.Forms.CheckBox();
            this.cPackCheck = new System.Windows.Forms.CheckBox();
            this.dPackCheck = new System.Windows.Forms.CheckBox();
            this.ePackCheck = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.custom1Check = new System.Windows.Forms.CheckBox();
            this.custom2Check = new System.Windows.Forms.CheckBox();
            this.custom5Check = new System.Windows.Forms.CheckBox();
            this.custom4Check = new System.Windows.Forms.CheckBox();
            this.custom3Check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chooseVersesLabel
            // 
            this.chooseVersesLabel.AutoSize = true;
            this.chooseVersesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseVersesLabel.Location = new System.Drawing.Point(229, 25);
            this.chooseVersesLabel.Name = "chooseVersesLabel";
            this.chooseVersesLabel.Size = new System.Drawing.Size(179, 16);
            this.chooseVersesLabel.TabIndex = 0;
            this.chooseVersesLabel.Text = "Select verse packs to review";
            // 
            // allPacksCheck
            // 
            this.allPacksCheck.AutoSize = true;
            this.allPacksCheck.Location = new System.Drawing.Point(300, 58);
            this.allPacksCheck.Name = "allPacksCheck";
            this.allPacksCheck.Size = new System.Drawing.Size(37, 17);
            this.allPacksCheck.TabIndex = 1;
            this.allPacksCheck.Text = "All";
            this.allPacksCheck.UseVisualStyleBackColor = true;
            this.allPacksCheck.Click += new System.EventHandler(this.CheckBoxClicked);
            // 
            // aPackCheck
            // 
            this.aPackCheck.AutoSize = true;
            this.aPackCheck.Location = new System.Drawing.Point(245, 90);
            this.aPackCheck.Name = "aPackCheck";
            this.aPackCheck.Size = new System.Drawing.Size(129, 17);
            this.aPackCheck.TabIndex = 2;
            this.aPackCheck.Text = "A - Live The New Life";
            this.aPackCheck.UseVisualStyleBackColor = true;
            this.aPackCheck.Click += new System.EventHandler(this.CheckBoxClicked);
            // 
            // bPackCheck
            // 
            this.bPackCheck.AutoSize = true;
            this.bPackCheck.Location = new System.Drawing.Point(245, 125);
            this.bPackCheck.Name = "bPackCheck";
            this.bPackCheck.Size = new System.Drawing.Size(111, 17);
            this.bPackCheck.TabIndex = 3;
            this.bPackCheck.Text = "B - Proclaim Christ";
            this.bPackCheck.UseVisualStyleBackColor = true;
            this.bPackCheck.Click += new System.EventHandler(this.CheckBoxClicked);
            // 
            // cPackCheck
            // 
            this.cPackCheck.AutoSize = true;
            this.cPackCheck.Location = new System.Drawing.Point(245, 159);
            this.cPackCheck.Name = "cPackCheck";
            this.cPackCheck.Size = new System.Drawing.Size(164, 17);
            this.cPackCheck.TabIndex = 4;
            this.cPackCheck.Text = "C - Rely On God\'s Resources";
            this.cPackCheck.UseVisualStyleBackColor = true;
            this.cPackCheck.Click += new System.EventHandler(this.CheckBoxClicked);
            // 
            // dPackCheck
            // 
            this.dPackCheck.AutoSize = true;
            this.dPackCheck.Location = new System.Drawing.Point(245, 192);
            this.dPackCheck.Name = "dPackCheck";
            this.dPackCheck.Size = new System.Drawing.Size(132, 17);
            this.dPackCheck.TabIndex = 5;
            this.dPackCheck.Text = "D - Be Christ\'s Disciple";
            this.dPackCheck.UseVisualStyleBackColor = true;
            this.dPackCheck.Click += new System.EventHandler(this.CheckBoxClicked);
            // 
            // ePackCheck
            // 
            this.ePackCheck.AutoSize = true;
            this.ePackCheck.Location = new System.Drawing.Point(245, 225);
            this.ePackCheck.Name = "ePackCheck";
            this.ePackCheck.Size = new System.Drawing.Size(146, 17);
            this.ePackCheck.TabIndex = 6;
            this.ePackCheck.Text = "E - Grow In Christlikeness";
            this.ePackCheck.UseVisualStyleBackColor = true;
            this.ePackCheck.Click += new System.EventHandler(this.CheckBoxClicked);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(269, 371);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(98, 30);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // custom1Check
            // 
            this.custom1Check.AutoSize = true;
            this.custom1Check.Location = new System.Drawing.Point(214, 266);
            this.custom1Check.Name = "custom1Check";
            this.custom1Check.Size = new System.Drawing.Size(70, 17);
            this.custom1Check.TabIndex = 8;
            this.custom1Check.Text = "Custom 1";
            this.custom1Check.UseVisualStyleBackColor = true;
            this.custom1Check.Visible = false;
            this.custom1Check.Click += new System.EventHandler(this.CheckBoxClicked);
            // 
            // custom2Check
            // 
            this.custom2Check.AutoSize = true;
            this.custom2Check.Location = new System.Drawing.Point(352, 266);
            this.custom2Check.Name = "custom2Check";
            this.custom2Check.Size = new System.Drawing.Size(70, 17);
            this.custom2Check.TabIndex = 9;
            this.custom2Check.Text = "Custom 2";
            this.custom2Check.UseVisualStyleBackColor = true;
            this.custom2Check.Visible = false;
            this.custom2Check.Click += new System.EventHandler(this.CheckBoxClicked);
            // 
            // custom5Check
            // 
            this.custom5Check.AutoSize = true;
            this.custom5Check.Location = new System.Drawing.Point(352, 319);
            this.custom5Check.Name = "custom5Check";
            this.custom5Check.Size = new System.Drawing.Size(70, 17);
            this.custom5Check.TabIndex = 11;
            this.custom5Check.Text = "Custom 5";
            this.custom5Check.UseVisualStyleBackColor = true;
            this.custom5Check.Visible = false;
            this.custom5Check.Click += new System.EventHandler(this.CheckBoxClicked);
            // 
            // custom4Check
            // 
            this.custom4Check.AutoSize = true;
            this.custom4Check.Location = new System.Drawing.Point(214, 319);
            this.custom4Check.Name = "custom4Check";
            this.custom4Check.Size = new System.Drawing.Size(70, 17);
            this.custom4Check.TabIndex = 10;
            this.custom4Check.Text = "Custom 4";
            this.custom4Check.UseVisualStyleBackColor = true;
            this.custom4Check.Visible = false;
            this.custom4Check.Click += new System.EventHandler(this.CheckBoxClicked);
            // 
            // custom3Check
            // 
            this.custom3Check.AutoSize = true;
            this.custom3Check.Location = new System.Drawing.Point(283, 293);
            this.custom3Check.Name = "custom3Check";
            this.custom3Check.Size = new System.Drawing.Size(70, 17);
            this.custom3Check.TabIndex = 12;
            this.custom3Check.Text = "Custom 3";
            this.custom3Check.UseVisualStyleBackColor = true;
            this.custom3Check.Visible = false;
            this.custom3Check.Click += new System.EventHandler(this.CheckBoxClicked);
            // 
            // ReviewVersesOptionsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.custom3Check);
            this.Controls.Add(this.custom5Check);
            this.Controls.Add(this.custom4Check);
            this.Controls.Add(this.custom2Check);
            this.Controls.Add(this.custom1Check);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.ePackCheck);
            this.Controls.Add(this.dPackCheck);
            this.Controls.Add(this.cPackCheck);
            this.Controls.Add(this.bPackCheck);
            this.Controls.Add(this.aPackCheck);
            this.Controls.Add(this.allPacksCheck);
            this.Controls.Add(this.chooseVersesLabel);
            this.Name = "ReviewVersesOptionsPanel";
            this.Size = new System.Drawing.Size(637, 411);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintMethod);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label chooseVersesLabel;
		private System.Windows.Forms.CheckBox allPacksCheck;
		private System.Windows.Forms.CheckBox aPackCheck;
		private System.Windows.Forms.CheckBox bPackCheck;
		private System.Windows.Forms.CheckBox cPackCheck;
		private System.Windows.Forms.CheckBox dPackCheck;
		private System.Windows.Forms.CheckBox ePackCheck;
		private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckBox custom1Check;
        private System.Windows.Forms.CheckBox custom2Check;
        private System.Windows.Forms.CheckBox custom5Check;
        private System.Windows.Forms.CheckBox custom4Check;
        private System.Windows.Forms.CheckBox custom3Check;



	}
}
