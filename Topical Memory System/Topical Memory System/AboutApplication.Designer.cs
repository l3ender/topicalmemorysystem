namespace Topical_Memory_System
{
    partial class AboutApplication
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.richTextBox3);
			this.panel1.Controls.Add(this.richTextBox2);
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(268, 300);
			this.panel1.TabIndex = 0;
			// 
			// richTextBox3
			// 
			this.richTextBox3.BackColor = System.Drawing.SystemColors.Control;
			this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox3.ContextMenuStrip = this.contextMenuStrip1;
			this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox3.Location = new System.Drawing.Point(0, 283);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.ReadOnly = true;
			this.richTextBox3.Size = new System.Drawing.Size(227, 22);
			this.richTextBox3.TabIndex = 3;
			this.richTextBox3.Text = "bender.r.o.s.s+TMS@gmail.com";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// richTextBox2
			// 
			this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
			this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
			this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox2.Location = new System.Drawing.Point(0, 242);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.ReadOnly = true;
			this.richTextBox2.Size = new System.Drawing.Size(268, 52);
			this.richTextBox2.TabIndex = 2;
			this.richTextBox2.Text = "If you have comments, suggestions, ideas, or complaints, please let me know at: ";
			this.richTextBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
			this.richTextBox2.MouseEnter += new System.EventHandler(this.MainUnfocus);
			this.richTextBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(0, 184);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(268, 52);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "TMS Assistant is an application that was developed to help people memorize God\'s " +
				"Word...hopefully it is able to do just that!";
			this.richTextBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
			this.richTextBox1.MouseEnter += new System.EventHandler(this.MainUnfocus);
			this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Unfocus);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = global::Topical_Memory_System.Properties.Resources.bible;
			this.pictureBox1.InitialImage = global::Topical_Memory_System.Properties.Resources.bible;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(268, 178);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// AboutApplication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 324);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutApplication";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About TMS Assistant";
			this.panel1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}