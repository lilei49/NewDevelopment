using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Development.Util
{
    public static class Connection_Util
    {
        private static System.String _connstring = "";
        public static System.String ConnString
        {
            get { return _connstring; }
            set { _connstring = value; }
        }
        private static System.String _databasename = "DevelopmentDB";
        public static System.String DataBaseName
        {
            get { return _databasename; }
            set { _databasename = value; }
        }
    }
}
