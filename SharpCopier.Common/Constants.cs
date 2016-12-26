using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCopier.Common
{
    public static class Constants
    {
        public enum Action{ Copy, Move};
        public enum Status { InProgress, CopyError, Finished };
    }
}
