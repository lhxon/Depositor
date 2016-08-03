using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depositer.Lib
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method|AttributeTargets.Property,
        AllowMultiple=true, Inherited=true)]
    public class XMLAttribute:Attribute
    {
        private object xmlProperty;
        public XMLAttribute(object xmlProperty)
        {
            this.xmlProperty = xmlProperty;
        }
        
        /// <summary>
        /// 对象中读入xml的属性
        /// </summary>
        public object XMLProperty
        {
            get { return xmlProperty; }
        }
    }
}
