using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO;
using SharpCopier.Common;

namespace SharpCopier
{
    public partial class SCListBox : UserControl
    {
        public SCListBox()
        {
            InitializeComponent();
        }

        public void add(scFilesSystemEntries lfiFiles)
        {
            int yVal = 0;
            List<scFile> files = lfiFiles.FileList;
            foreach (scFile item in files)
            {
                scListItem myItem = new scListItem(item.FromName, item.FileSize / 1024 + " Kb");
                myItem.Location = new Point(0, yVal);
                myItem.Width = this.Width -22; //22 is for scrollbar width
                yVal += myItem.Height;

                this.pFiles.Controls.Add(myItem);
            }
        }

    }
}
