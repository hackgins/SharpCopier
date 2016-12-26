using SharpCopier.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpCopier
{
    public partial class copyForm : Form
    {

        private static scFilesSystemEntries files;
        private BackgroundWorker bw = new BackgroundWorker();

        public copyForm()
        {
            InitializeComponent();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                this.tbProgress.Text = "Canceled!";
            }

            else if (!(e.Error == null))
            {
                this.tbProgress.Text = ("Error: " + e.Error.Message);
            }

            else
            {
                this.tbProgress.Text = "Done!";
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.tbProgress.Text = (e.ProgressPercentage.ToString() + "%");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string sOrigin = @"C:\Temp\SC\origin\";
            string sDest = @"C:\Temp\SC\dest\";

            files = copyMoveMechanism.generateEntryByDir(sOrigin, sDest);
            foreach (scFile file in files.FileList)
            {
                lbToCopy.Items.Add(file.FromName);
            }
            lbFileCopiedProgress.Text = files.getTotalSize() / 1024 + " Kb";
            DoCopy();
        }


        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;


            string sOrigin = @"C:\Temp\SC\origin\";
            string sDest = @"C:\Temp\SC\dest\";

            files = copyMoveMechanism.generateEntryByDir(sOrigin, sDest);
            /*foreach (scFile file in files.FileList)
            {
                lbToCopy.Items.Add(file.FromName);
            }*/
            //lbFileCopiedProgress.Text = files.getTotalSize() / 1024 + " Kb";
            //DoCopy();

            copyMoveMechanism.CopyFiles(files, (file, status, filesize, prog, total) => worker.ReportProgress((int)(100*prog/total)));

            //for (int i = 1; (i <= 10); i++)
            //{
            //    if ((worker.CancellationPending == true))
            //    {
            //        e.Cancel = true;
            //        break;
            //    }
            //    else
            //    {
            //        // Perform a time consuming operation and report progress.
            //        System.Threading.Thread.Sleep(500);
            //        worker.ReportProgress((i * 10));
            //    }
            //}
        }

        public async void DoCopy()
        {
            await copyMoveMechanism.CopyFiles(files, (file, status, filesize, prog, total) => UpdateScreen(file, status, filesize, prog, total));
        }

        public async void DoMove()
        {
            await copyMoveMechanism.MoveFiles(files, (file, status, filesize, prog, total) => UpdateScreen(file, status, filesize, prog, total));
        }

        private void UpdateScreen(string sFile, Constants.Status status, long filesizeCopy, long CompleteCopy, long TotalSize)
        {
            int progress = (int)(100 * (filesizeCopy + CompleteCopy) / TotalSize);
            pbGlobalCopy.Value = progress;
            if (status == Constants.Status.Finished)
            {
                lbCopied.Items.Add(sFile);
                lbToCopy.Items.Remove(sFile);
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            List<string> ls = new List<string>();
            ls.Add(@"C:\Temp\SC\origin\logs pweb");
            ls.Add(@"C:\Temp\SC\origin\a239.jpg");
            ls.Add(@"C:\Temp\SC\origin\blank_europe_map.gif");
            ls.Add(@"C:\Temp\SC\origin\file2.bin");
            ls.Add(@"C:\Temp\SC\origin\fp");


            string sDest = @"C:\Temp\SC\dest\";

            files = copyMoveMechanism.generateEntryByList(ls, sDest);
            //scListBox1.add(files);
            lbFileCopiedProgress.Text = files.getTotalSize() / 1024 + " Kb";
            DoCopy();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sOrigin = @"C:\Temp\SC\origin\";
            string sDest = @"C:\Temp\SC\dest\";

            files = copyMoveMechanism.generateEntryByDir(sOrigin, sDest);
            //scListBox1.add(files);
            lbFileCopiedProgress.Text = files.getTotalSize() / 1024 + " Kb";
            DoMove();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> ls = new List<string>();
            ls.Add(@"C:\Temp\SC\origin\logs pweb");
            ls.Add(@"C:\Temp\SC\origin\a239.jpg");
            ls.Add(@"C:\Temp\SC\origin\blank_europe_map.gif");
            ls.Add(@"C:\Temp\SC\origin\file2.bin");
            ls.Add(@"C:\Temp\SC\origin\fp");


            string sDest = @"C:\Temp\SC\dest\";

            files = copyMoveMechanism.generateEntryByList(ls, sDest);

            lbFileCopiedProgress.Text = files.getTotalSize() / 1024 + " Kb";
            DoMove();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bw.IsBusy != true)
            {
                bw.RunWorkerAsync();
            }
        }


    }
}
