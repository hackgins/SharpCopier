using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpCopier
{
    public partial class scListItem : UserControl
    {
        public scListItem()
        {
            InitializeComponent();
        }

        public scListItem(string sFileName, string sFileSize)
        {
            InitializeComponent();
            this.lbFileName.Text = sFileName;
            this.lbFileSize.Text = sFileSize;
            this.pbFileCopy.Minimum = 0;
            this.pbFileCopy.Maximum = 100;
            this.pbFileCopy.Step = 0;
        }

        public void updateProgress(int iProgress)
        {
            this.pbFileCopy.Step = iProgress;
        }

        private void scListItem_Resize(object sender, EventArgs e)
        {
            panel1.Width = Convert.ToInt32(this.Width * 0.6);
            panel2.Width = Convert.ToInt32(this.Width * 0.3);
            panel3.Width = Convert.ToInt32(this.Width * 0.1);
        }

    }
}
