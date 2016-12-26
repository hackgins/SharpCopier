using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpCopier
{
    public class scAPI
    {
        #region system dll import
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr CreateSemaphore(ref SharpCopier.CopyStatic.SECURITY_ATTRIBUTES securityAttributes, int initialCount, int maximumCount, string name);

        
        [DllImport("kernel32.dll")]
        static extern IntPtr CreateMutex(IntPtr lpMutexAttributes, bool bInitialOwner, string lpName);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateFileMapping(IntPtr hFile, IntPtr lpFileMappingAttributes,SharpCopier.CopyStatic.FileMapProtection flProtect,uint dwMaximumSizeHigh,uint dwMaximumSizeLow,string lpName);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateEvent(IntPtr lpEventAttributes, bool bManualReset, bool bInitialState, string lpName);
        #endregion

        string sMainDLL ="";
        string sSecondDLL ="";
        public void getDLL()
        {
            if (System.Environment.Is64BitOperatingSystem)
            {
                sMainDLL = "SCShellExt64.dll";
                sSecondDLL = "SCShellExt.dll";
            }
            else {
                sSecondDLL = "SCShellExt64.dll";
                sMainDLL = "SCShellExt.dll";
            }

        }

        /// <summary>
        /// Register Dll in system with regsvr32
        /// </summary>
        /// <param name="sDllPath">URI to the DLL to register (32 or 64 bits)</param>
        /// <param name="bRegister">true: register / false : unregister</param>
        /// <param name="bQuiet">use silent mode for regsvr32 or not</param>
        /// <returns></returns>
        public bool registerShellExtDll(string sDllPath, bool bRegister, bool bQuiet)
        {
            string sArg = "";
            if(bQuiet) sArg += "/s";
            sArg += bRegister ? "" : " /u";
            sArg += '"' + sDllPath + '"';
            Console.WriteLine("Argument for regsvr32: " + sArg);

            //res := SysUtils.ExecuteProcess('regsvr32', argumentsString, []);
            //Execute and get response

            //manage error (runas needed for example)

            return true;
        }

        public void connect()
        {
            string sName = sessionUniqueAPIIdentifier(CopyStatic.SC2_API_SEMAPHORE_ID);

            SharpCopier.CopyStatic.SECURITY_ATTRIBUTES sec = new SharpCopier.CopyStatic.SECURITY_ATTRIBUTES();
            try
            {
                IntPtr FSemaphore = CreateSemaphore(ref sec, 0, int.MaxValue, CopyStatic.SC2_API_SEMAPHORE_ID);
            }
            catch (Exception)
            {
                //check errors
                throw;
            }
            
            

            sName = sessionUniqueAPIIdentifier(CopyStatic.SC2_API_MUTEX_ID);
            IntPtr fMutex = CreateMutex(IntPtr.Zero, false, sName);
            if (fMutex == IntPtr.Zero)
            {
                throw new Exception("Cannot create fMutex " + sName + " : check if dll are registered");
            }

            sName = sessionUniqueAPIIdentifier(CopyStatic.SC2_API_FILEMAPPING_ID);
            IntPtr fFileMapping = CreateFileMapping(IntPtr.Zero,IntPtr.Zero, CopyStatic.FileMapProtection.PageReadWrite,0,CopyStatic.SC2_API_FILEMAPPING_SIZE, sName);
            if (fFileMapping == IntPtr.Zero)
            {
                throw new Exception("Cannot create fFileMapping " + sName + " : check if dll are registered");
            }

            sName = sessionUniqueAPIIdentifier(CopyStatic.SC2_API_CLIENTEVENT_ID);

            IntPtr fClientEvent = CreateEvent(IntPtr.Zero,false,false,sName);
            if (fClientEvent == IntPtr.Zero)
            {
                throw new Exception("Cannot create fClientEvent " + sName + " : check if dll are registered");
            }

            sName = sessionUniqueAPIIdentifier(CopyStatic.SC2_API_APIEVENT_ID);
            IntPtr fAPIEvent = CreateEvent(IntPtr.Zero, false, false, sName);
            if (fAPIEvent == IntPtr.Zero)
            {
                throw new Exception("Cannot create fAPIEvent " + sName + " : check if dll are registered");
            }

        }

        public string sessionUniqueAPIIdentifier(string sID)
        {
            string sSessionUniqueAPII = "";
            string sUserName = System.Environment.UserName;
            sSessionUniqueAPII += CopyStatic.SC2_API_ID;
            sSessionUniqueAPII += " ";
            sSessionUniqueAPII += sID;
            sSessionUniqueAPII += " ";
            sSessionUniqueAPII += sUserName;

            return sSessionUniqueAPII;
        }

    }
}
