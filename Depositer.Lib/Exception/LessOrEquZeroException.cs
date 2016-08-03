using System;
using System.Collections.Generic;
using System.Linq;

namespace Depositer.Lib
{
   public  class LessOrEquZeroException:Exception
    {
       private string msg;
       public LessOrEquZeroException(object val)
       {
           msg = string.Format("{0}为非正数，取值不合法！",val);
       }
       public override string Message
       {
           get { return msg; }
       }
    }
}
