namespace Topical_Memory_System
{
    partial class MatchVersesOptionPanel
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
            this.matchVerseToReferences = new System.Windows.Forms.Button();
            this.matchReferenceToVerseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matchVerseToReferences
            // 
            this.matchVerseToReferences.Location = new System.Drawing.Point(247, 217);
            this.matchVerseToReferences.Name = "matchVerseToReferences";
            this.matchVerseToReferences.Size = new System.Drawing.Size(143, 46);
            this.matchVerseToReferences.TabIndex = 4;
            this.matchVerseToReferences.Text = "Match Verses to References";
            this.matchVerseToReferences.UseVisualStyleBackColor = true;
            this.matchVerseToReferences.Click += new System.EventHandler(this.MatchVersesToReferencesButton_Click);
            // 
            // matchReferenceToVerseButton
            // 
            this.matchReferenceToVerseButton.Location = new System.Drawing.Point(247, 148);
            this.matchReferenceToVerseButton.Name = "matchReferenceToVerseButton";
            this.matchReferenceToVerseButton.Size = new System.Drawing.Size(143, 46);
            this.matchReferenceToVerseButton.TabIndex = 3;
            this.matchReferenceToVerseButton.Text = "Match References to Verses";
            this.matchReferenceToVerseButton.UseVisualStyleBackColor = true;
            this.matchReferenceToVerseButton.Click += new System.EventHandler(this.MatchReferencesToVersesButton_Click);
            // 
            // MatchVersesOptionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.matchVerseToReferences);
            this.Controls.Add(this.matchReferenceToVerseButton);
            this.Name = "MatchVersesOptionPanel";
            this.Size = new System.Drawing.Size(637, 411);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button matchVerseToReferences;
        private System.Windows.Forms.Button matchReferenceToVerseButton;
    }
}
