namespace SharpCopier
{
    partial class copyForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFileCopiedProgress = new System.Windows.Forms.Label();
            this.pbGlobalCopy = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbToCopy = new System.Windows.Forms.ListBox();
            this.lbCopied = new System.Windows.Forms.ListBox();
            this.scListBox1 = new SharpCopier.SCListBox();
            this.tbProgress = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbProgress);
            this.panel1.Controls.Add(this.lbFileCopiedProgress);
            this.panel1.Controls.Add(this.pbGlobalCopy);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 87);
            this.panel1.TabIndex = 0;
            // 
            // lbFileCopiedProgress
            // 
            this.lbFileCopiedProgress.AutoSize = true;
            this.lbFileCopiedProgress.Location = new System.Drawing.Point(19, 7);
            this.lbFileCopiedProgress.Name = "lbFileCopiedProgress";
            this.lbFileCopiedProgress.Size = new System.Drawing.Size(105, 13);
            this.lbFileCopiedProgress.TabIndex = 3;
            this.lbFileCopiedProgress.Text = "lbFileCopiedProgress";
            // 
            // pbGlobalCopy
            // 
            this.pbGlobalCopy.Location = new System.Drawing.Point(19, 26);
            this.pbGlobalCopy.Name = "pbGlobalCopy";
            this.pbGlobalCopy.Size = new System.Drawing.Size(619, 23);
            this.pbGlobalCopy.Step = 1;
            this.pbGlobalCopy.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(499, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 21);
            this.button3.TabIndex = 7;
            this.button3.Text = "test MoveList";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 21);
            this.button2.TabIndex = 5;
            this.button2.Text = "test CopyList";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(348, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 21);
            this.button4.TabIndex = 6;
            this.button4.Text = "test MoveDir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "test CopyDir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbToCopy
            // 
            this.lbToCopy.FormattingEnabled = true;
            this.lbToCopy.Location = new System.Drawing.Point(46, 184);
            this.lbToCopy.Name = "lbToCopy";
            this.lbToCopy.Size = new System.Drawing.Size(271, 108);
            this.lbToCopy.TabIndex = 8;
            // 
            // lbCopied
            // 
            this.lbCopied.FormattingEnabled = true;
            this.lbCopied.Location = new System.Drawing.Point(338, 184);
            this.lbCopied.Name = "lbCopied";
            this.lbCopied.Size = new System.Drawing.Size(271, 108);
            this.lbCopied.TabIndex = 9;
            // 
            // scListBox1
            // 
            this.scListBox1.AllowDrop = true;
            this.scListBox1.Location = new System.Drawing.Point(13, 94);
            this.scListBox1.Name = "scListBox1";
            this.scListBox1.Size = new System.Drawing.Size(659, 212);
            this.scListBox1.TabIndex = 1;
            // 
            // tbProgress
            // 
            this.tbProgress.Location = new System.Drawing.Point(329, 0);
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.Size = new System.Drawing.Size(258, 20);
            this.tbProgress.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(242, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // copyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 309);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lbCopied);
            this.Controls.Add(this.lbToCopy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scListBox1);
            this.Controls.Add(this.panel1);
            this.Name = "copyForm";
            this.Text = "SharpCopier";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFileCopiedProgress;
        private System.Windows.Forms.ProgressBar pbGlobalCopy;
        private System.Windows.Forms.Button button1;
        private SCListBox scListBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lbToCopy;
        private System.Windows.Forms.ListBox lbCopied;
        private System.Windows.Forms.TextBox tbProgress;
        private System.Windows.Forms.Button button5;
    }
}