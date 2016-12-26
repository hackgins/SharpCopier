using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpCopier
{
    public class CopyStatic
    {
        public enum type
        {
            move, copy   
        }

        public static string SC2_API_ID="SuperCopier API";
        public static string SC2_API_SEMAPHORE_ID="Semaphore"; // le sйmaphore est utilisй pour s'assurer qu'une seule instance de l'API tourne pour une session
        public static string SC2_API_MUTEX_ID = "Mutex"; // le mutex est utilisй pour empйcher 2 clients utilisant l'API de se corrompre mutuellement
        public static string SC2_API_FILEMAPPING_ID = "FileMapping"; // le filemapping est utilisй pour transfйrer des donnйes depuis et vers les clients utilisant l'API
        public static string SC2_API_CLIENTEVENT_ID = "ClientEvent"; // l'event est utilisй pour notifier que des donnйes d'un client sont prкtes dans le filemapping
        public static string SC2_API_APIEVENT_ID = "APIEvent"; // l'event est utilisй pour notifier que des donnйes de l'API sont prкtes dans le filemapping
        public static UInt32 SC2_API_FILEMAPPING_SIZE=128*1024;
        /// <summary>
        /// Security enumeration from:
        /// http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dllproc/base/synchronization_object_security_and_access_rights.asp
        /// </summary>

        public static UInt32 DELETE = 0x00010000;
        public static UInt32 READ_CONTROL = 0x00020000;
        public static UInt32 WRITE_DAC = 0x00040000;
        public static UInt32 WRITE_OWNER = 0x00080000;
        public static UInt32 SYNCHRONIZE = 0x00100000;
        public static UInt32 EVENT_ALL_ACCESS = 0x001F0003;
        public static UInt32 EVENT_MODIFY_STATE = 0x00000002;
        public static UInt32 MUTEX_ALL_ACCESS = 0x001F0001;
        public static UInt32 MUTEX_MODIFY_STATE = 0x00000001;
        public static UInt32 SEMAPHORE_ALL_ACCESS = 0x001F0003;
        public static UInt32 SEMAPHORE_MODIFY_STATE = 0x00000002;
        public static UInt32 TIMER_ALL_ACCESS = 0x001F0003;
        public static UInt32 TIMER_MODIFY_STATE = 0x00000002;
        public static UInt32 TIMER_QUERY_STATE = 0x0000000;
        public static UInt32 STANDARD_RIGHTS_REQUIRED = 0x000F0000;
        public static UInt32 SECTION_QUERY = 0x0001;
        public static UInt32 SECTION_MAP_WRITE = 0x0002;
        public static UInt32 SECTION_MAP_READ = 0x0004;
        public static UInt32 SECTION_MAP_EXECUTE = 0x0008;
        public static UInt32 SECTION_EXTEND_SIZE = 0x0010;
        public static UInt32 SECTION_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED | SECTION_QUERY |
            SECTION_MAP_WRITE |
            SECTION_MAP_READ |
            SECTION_MAP_EXECUTE |
            SECTION_EXTEND_SIZE);
        public static UInt32 FILE_MAP_ALL_ACCESS = SECTION_ALL_ACCESS;


        [StructLayout(LayoutKind.Sequential)]
        public struct SECURITY_ATTRIBUTES
        {
            public int nLength;
            public unsafe byte* lpSecurityDescriptor;
            public int bInheritHandle;
        }

        [Flags]
        public enum FileMapProtection : uint
        {
            PageReadonly = 0x02,
            PageReadWrite = 0x04,
            PageWriteCopy = 0x08,
            PageExecuteRead = 0x20,
            PageExecuteReadWrite = 0x40,
            SectionCommit = 0x8000000,
            SectionImage = 0x1000000,
            SectionNoCache = 0x10000000,
            SectionReserve = 0x4000000,
        }
    }
}
