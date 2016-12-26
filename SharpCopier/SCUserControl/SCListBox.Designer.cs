namespace SharpCopier
{
    partial class SCListBox
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
            this.pFiles = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pFiles
            // 
            this.pFiles.AutoScroll = true;
            this.pFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFiles.Location = new System.Drawing.Point(0, 0);
            this.pFiles.Name = "pFiles";
            this.pFiles.Size = new System.Drawing.Size(558, 137);
            this.pFiles.TabIndex = 0;
            // 
            // SCListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pFiles);
            this.Name = "SCListBox";
            this.Size = new System.Drawing.Size(558, 137);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pFiles;
    }
}
