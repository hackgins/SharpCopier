namespace SharpCopier
{
    partial class scListItem
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbFileCopy = new System.Windows.Forms.ProgressBar();
            this.lbFileSize = new System.Windows.Forms.Label();
            this.lbFileName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbFileName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 28);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbFileCopy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(397, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 28);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbFileSize);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 28);
            this.panel3.TabIndex = 2;
            // 
            // pbFileCopy
            // 
            this.pbFileCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFileCopy.Location = new System.Drawing.Point(0, 0);
            this.pbFileCopy.Name = "pbFileCopy";
            this.pbFileCopy.Size = new System.Drawing.Size(130, 28);
            this.pbFileCopy.TabIndex = 0;
            // 
            // lbFileSize
            // 
            this.lbFileSize.AutoSize = true;
            this.lbFileSize.Location = new System.Drawing.Point(18, 8);
            this.lbFileSize.Name = "lbFileSize";
            this.lbFileSize.Size = new System.Drawing.Size(51, 13);
            this.lbFileSize.TabIndex = 0;
            this.lbFileSize.Text = "lbFileSize";
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(18, 7);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(59, 13);
            this.lbFileName.TabIndex = 0;
            this.lbFileName.Text = "lbFileName";
            // 
            // scListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "scListItem";
            this.Size = new System.Drawing.Size(527, 28);
            this.Resize += new System.EventHandler(this.scListItem_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar pbFileCopy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbFileSize;
    }
}
