using System;
using System.Collections.Generic;
using System.Text;

namespace Development.Util
{
    public class Connection_Util
    {
        private static System.String _connString;
        public static System.String ConnString
        {
            get { return _connString; }
            set { _connString = value; }
        }

        private static System.String _database = "DevelopmentDB";
        public static System.String DataBase
        {
            get { return _database; }
            set { _database = value; }
        }
    }
}
