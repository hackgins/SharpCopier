using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCopier.Common
{
    public class scFilesSystemEntries 
    {
        private List<scFile> _lfFiles;
        
        public List<scFile> FileList
        {
            get { return _lfFiles; }
        }

        private List<scDir> _lfDirs;

        public List<scDir> DirList
        {
            get { return _lfDirs; }
        }

        public scFilesSystemEntries()
        {
            _lfFiles = new List<scFile>();
            _lfDirs = new List<scDir>();
        }

        public scFilesSystemEntries(List<string> lsFileSystemEntries, string sOriginDir, string sDestDir, Constants.Action action)
        {
            _lfFiles = new List<scFile>();
            _lfDirs = new List<scDir>();

            foreach(string currentEntry in lsFileSystemEntries )
            {
                add(currentEntry, sOriginDir, sDestDir, action);
            };
            
        }

        public int getNbFiles()
        {
            return _lfFiles.Count();
        }

        public Int64 getTotalSize()
        {
            Int64 iSize = 0;
            foreach (scFile file in _lfFiles)
            {
                iSize += file.FileSize;
            }

            return iSize;
        }

        public void add(scFilesSystemEntries scEntries)
        {
            this._lfDirs.AddRange(scEntries.DirList);
            this._lfFiles.AddRange(scEntries.FileList);
        }

        public void add(string sEntry, string sOriginDir, string sDestDir, Constants.Action aAction)
        {
            try
            {
                // get the file attributes for file or directory
                FileAttributes attr = File.GetAttributes(sEntry);

                //detect whether its a directory or file
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    scDir dir = new scDir();
                    DirectoryInfo di = new DirectoryInfo(sEntry);
                    dir.FromName = di.FullName;
                    dir.ToName = di.FullName.Replace(sOriginDir, sDestDir);
                    dir.Action = aAction;
                    this._lfDirs.Add(dir);
                }
                else
                {
                    scFile file = new scFile();
                    FileInfo fi = new FileInfo(sEntry);
                    file.FileSize = fi.Length;
                    file.FromName = fi.FullName;
                    file.ToName = fi.FullName.Replace(sOriginDir, sDestDir);
                    file.Action = aAction;
                    this._lfFiles.Add(file);
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            
        }
    }
}
