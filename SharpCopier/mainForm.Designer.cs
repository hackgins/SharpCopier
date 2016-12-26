namespace SharpCopier
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pbComplete = new System.Windows.Forms.ProgressBar();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.lblFileToCopy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbComplete
            // 
            this.pbComplete.Location = new System.Drawing.Point(12, 12);
            this.pbComplete.Name = "pbComplete";
            this.pbComplete.Size = new System.Drawing.Size(491, 23);
            this.pbComplete.TabIndex = 0;
            // 
            // btnExpand
            // 
            this.btnExpand.Image = ((System.Drawing.Image)(resources.GetObject("btnExpand.Image")));
            this.btnExpand.Location = new System.Drawing.Point(438, 68);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(51, 41);
            this.btnExpand.TabIndex = 1;
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Image = ((System.Drawing.Image)(resources.GetObject("btnCollapse.Image")));
            this.btnCollapse.Location = new System.Drawing.Point(381, 68);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(51, 41);
            this.btnCollapse.TabIndex = 2;
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Visible = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // lblFileToCopy
            // 
            this.lblFileToCopy.AutoSize = true;
            this.lblFileToCopy.Location = new System.Drawing.Point(12, 42);
            this.lblFileToCopy.Name = "lblFileToCopy";
            this.lblFileToCopy.Size = new System.Drawing.Size(35, 13);
            this.lblFileToCopy.TabIndex = 3;
            this.lblFileToCopy.Text = "label1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 121);
            this.Controls.Add(this.lblFileToCopy);
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.pbComplete);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.SizeChanged += new System.EventHandler(this.mainForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbComplete;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Label lblFileToCopy;
    }
}