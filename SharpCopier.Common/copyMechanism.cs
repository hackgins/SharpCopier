using SharpCopier.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCopier.Common
{
    public static class copyMoveMechanism
    {
        /// <summary>
        /// generate a list of fileSystemEntry (dirs and/or filse) to a destination Dir
        /// </summary>
        /// <param name="sListFSI">list of FileSystemEntry</param>
        /// <param name="sDestDir">Destination Directory</param>
        /// <returns>Entries in given list</returns>
        public static scFilesSystemEntries generateEntryByList(List<string> sListFSI, string sDestDir)
        {
            scFilesSystemEntries files = new scFilesSystemEntries();
            foreach (string fsi in sListFSI)
            {
                FileAttributes attr = File.GetAttributes(fsi);

                //detect whether its a directory or file
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    
                    List<string> myFileSystemEntry = Directory.GetFileSystemEntries(fsi, "*", SearchOption.AllDirectories).ToList<string>();
                    myFileSystemEntry.Add(new DirectoryInfo(fsi).FullName);
                    files.add(new scFilesSystemEntries(myFileSystemEntry, getParentDir(fsi), sDestDir, Constants.Action.Copy));
                }
                else
                {
                    files.add(fsi, getParentDir(fsi), sDestDir, Constants.Action.Copy);
                }
            }

            return files;
        }

        /// <summary>
        /// Get Parent Dir
        /// </summary>
        /// <param name="sEntry">File or Directory fullname</param>
        /// <returns>parent directory</returns>
        private static string getParentDir(string sEntry)
        {
            FileAttributes attr = File.GetAttributes(sEntry);

            //detect whether its a directory or file
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                DirectoryInfo di = new DirectoryInfo(sEntry);
                return di.Parent.FullName;
            }
            else
            {
                FileInfo fi = new FileInfo(sEntry);
                return fi.Directory.FullName;
            }

        }

        /// <summary>
        /// generate a list of fileSystemEntry (dirs and/or filse) contained in a dir to a destination Dir
        /// </summary>
        /// <param name="sOriginDir">Origin Directory to parse</param>
        /// <param name="sDestDir">Destination Directory</param>
        /// <returns>Entries in given origin directory</returns>
        public static scFilesSystemEntries generateEntryByDir(string sOriginDir, string sDestDir)
        {
            scFilesSystemEntries files;
            List<string> myFileSystemEntry = Directory.GetFileSystemEntries(sOriginDir, "*", SearchOption.AllDirectories).ToList<string>();
            files = new scFilesSystemEntries(myFileSystemEntry, sOriginDir, sDestDir, Constants.Action.Copy);
            
            return files;
        }

        public static async Task CopyFiles(scFilesSystemEntries files, Action<string, Constants.Status, long, long, long> progressCallback)
        {
            Int64 iNbTotal = files.getTotalSize();
            Int64 iNbCurrent = 0;
            foreach (scDir dir in files.DirList)
            {
                if (!Directory.Exists(dir.ToName))
                {
                    Directory.CreateDirectory(dir.ToName);
                }
            }
            //All dir created to destination
            foreach (scFile file in files.FileList)
            {

                try
                {
                    await CopyData(file, (fi, status, filesize) => progressCallback(fi, status, filesize, iNbCurrent, iNbTotal));

                    iNbCurrent += file.FileSize;
                }
                catch (Exception)
                {
                    //TODO: Add Log or some error management
                    throw;
                }
            }
        }
        /// <summary>
        /// Technical File Copy, using stream and buffer to improve perf on large files and allow progressCallback 
        /// Can be optimised for smaller file
        /// TODO: Set the buffer size as parameter
        /// </summary>
        /// <param name="file">Files to copy</param>
        /// <param name="progressCallback">give the information on file copy progress</param>
        /// <returns>Task to manage asynch</returns>
        public static async Task CopyData(scFile file, Action<string, Constants.Status, long> progressCallback)
        {
            var from = file.FromName;
                var to = file.ToName;
                
                using (var outStream = new FileStream(to, FileMode.Create, FileAccess.Write, FileShare.Read))
                {
                    using (var inStream = new FileStream(from, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                    //await inStream.CopyToAsync(outStream);

                    try
                    {
                        int bufferLength = 1280;
                        byte[] buffer = new byte[bufferLength];
                        int bytesRead = 0;
                        int iIteration = 1;
                        do
                        {
                            bytesRead = inStream.Read(buffer, 0, bufferLength);
                            outStream.Write(buffer, 0, bytesRead);
                            progressCallback(file.FromName, Constants.Status.InProgress, iIteration * bufferLength);
                        }
                        while (bytesRead != 0);
                    }
                    catch (Exception)
                    {
                        progressCallback(file.FromName, Constants.Status.CopyError, 0);
                        throw;
                    }

                    }
                }
                
                progressCallback(file.FromName, Constants.Status.Finished, file.FileSize);
                
            }
                
        public static async Task MoveFiles(scFilesSystemEntries files, Action<string, Constants.Status, long, long, long> progressCallback)
        {
            Int64 iNbTotal = files.getTotalSize();
            Int64 iNbCurrent = 0;
            foreach (scDir dir in files.DirList)
            {
                if (!Directory.Exists(dir.ToName))
                {
                    Directory.CreateDirectory(dir.ToName);
                }
            }
            //All dir created to destination
            foreach (scFile file in files.FileList)
            {
                try
                {
                    await CopyData(file, (fi, status, filesize) => progressCallback(fi, status, filesize, iNbCurrent, iNbTotal));

                    iNbCurrent += file.FileSize;
                    File.Delete(file.FromName);
                }
                catch (Exception)
                {
                    //TODO: Add Log or some error management
                    throw;
                }
            }
            //Remove all dir (all data inside are moved)
            foreach (scDir dir in files.DirList)
            {
                if (Directory.Exists(dir.FromName))
                {
                    Directory.Delete(dir.FromName, true);
                }
            }
        }

    }
}
