using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCopier.Common
{
    public class scFile
    {
        private string _sFromName;
        private Constants.Action _aAction;

        public Constants.Action Action
        {
            get { return _aAction; }
            set { _aAction = value; }
        } 

        public string FromName
        {
            get { return _sFromName; }
            set { _sFromName = value; }
        }
        private string _sToName;

        public string ToName
        {
            get { return _sToName; }
            set { _sToName = value; }
        }
        private Int64 _iFileSize;

        public Int64 FileSize
        {
            get { return _iFileSize; }
            set { _iFileSize = value; }
        }

    }
}
