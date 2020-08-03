using System;
using System.Collections.Generic;
using System.Text;

namespace Development.Util
{
    public static class Message_Util
    {
        private static System.String _messagetxt = "";
        public static System.String MessageTxt
        {
            get { return _messagetxt; }
            set { _messagetxt = value; }
        }
        private static System.String _messagetitle = "";
        public static System.String MessageTitle
        {
            get { return _messagetitle; }
            set { _messagetitle = value; }
        }
    }
}
