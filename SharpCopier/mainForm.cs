using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpCopier
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_SizeChanged(object sender, EventArgs e)
        {
            pbComplete.Width = (int)(this.Width - 50);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.Height = 160;
            this.Width = 550;
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            this.Height += 150;
            btnCollapse.Left = btnExpand.Left;
            btnExpand.Visible = false;
            btnCollapse.Visible = true;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            this.Height -= 150;
            btnExpand.Visible = true;
            btnCollapse.Visible = false;
        }
    }
}
