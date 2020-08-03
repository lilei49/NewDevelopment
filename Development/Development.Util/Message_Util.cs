using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private static System.Boolean _messagestate = false;
        /// <summary>
        /// 判断是否发生错误，（true：发生错误，false：为发生错误）
        /// </summary>
        public static System.Boolean MessageState
        {
            get { return _messagestate; }
            set { _messagestate = value; }
        }
    }
}
