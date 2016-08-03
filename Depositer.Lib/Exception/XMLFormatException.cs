using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Lib
{
    public class XMLFormatException:Exception
    {
        private string msg;
        public XMLFormatException(string text)
        {
            msg = text;
        }
        public override string Message
        {
            get
            {
                return msg;
            }
        }
    }
}
