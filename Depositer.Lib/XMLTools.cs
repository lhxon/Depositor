using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Depositer.Lib
{
    public class XMLTools
    {
        private XmlDocument xmlDoc = new XmlDocument();
        private string fullpath;
        private Dictionary<object, object> xmlAttributeDict = new Dictionary<object, object>();
        
        /// <summary>
        /// xml属性内存字典
        /// </summary>
        public Dictionary<object,object> XmlAttributeDict
        {
            get { return xmlAttributeDict; }
        }

        /// <summary>
        /// 从xml读取数据
        /// 异常：XMLFormatException
        /// </summary>
        /// <param name="filename">仅包括文件名称</param>
        /// <param name="t">模型对象</param>
        public void ReadFromXML(string filename, Type t)
        {
            LoadXml(filename);
            InitAttributeDict(t);
            var xmlroot = xmlDoc.SelectSingleNode("Setting");
            if (xmlroot == null)
                throw new ArgumentNullException("XML的根节点");
            var nodelist = xmlroot.ChildNodes;
            foreach (XmlNode node in nodelist)
            {
                if (node.ChildNodes.Count > 1)
                    throw new XMLFormatException("读入XML文件子节点中含有节点！");
                xmlAttributeDict[node.Name] = node.InnerText;
            }
        }

        /// <summary>
        /// 向xml文件更新数据
        /// </summary>
        /// <param name="filename">仅包括文件名称</param>
        /// <param name="obj">根对象</param>
        public void UpdateXML(string filename, Object obj)
        {
            //if(string.IsNullOrEmpty(fullpath))
            LoadXml(filename);
            //if(xmlAttributeDict.Count==0)
            InitAttributeDict(obj.GetType());
            var xmlroot = xmlDoc.SelectSingleNode("Setting");
            var nodelist = xmlroot.ChildNodes;
            UpdateAttributeDict(obj);
            foreach (XmlNode node in nodelist)
            {
                if (xmlAttributeDict.ContainsKey(node.Name))
                    (node as XmlElement).InnerText = xmlAttributeDict[node.Name].ToString();
            }
            xmlDoc.Save(fullpath);
        }

        /// <summary>
        /// 从XML文件读取数据
        /// </summary>
        /// <param name="filename"></param>
        private void LoadXml(string filename)
        {
            var root = Environment.CurrentDirectory;
            var splits = root.Split('\\');
            root = root.Substring(0, root.IndexOf(splits[splits.Length - 2]));
            fullpath = Path.Combine(root, "Settings\\" + filename);
            xmlDoc.Load(fullpath);
        }

        /// <summary>
        /// 获取模型中配置的与XML交互用的属性字典
        /// 异常：Exception()
        /// </summary>
        /// <param name="debt"></param>
        private void InitAttributeDict(Type t)
        {
            xmlAttributeDict.Clear();
            var attributeList = XMLAttribute.GetCustomAttributes(t);
            if (attributeList.Length == 0)
                throw new Exception("未在模型中配置可与XML交互的属性！");
            foreach (var attr in attributeList)
            {
                if (!xmlAttributeDict.ContainsKey((attr as XMLAttribute).XMLProperty))
                    xmlAttributeDict.Add((attr as XMLAttribute).XMLProperty, new Object());
            }
        }

        /// <summary>
        /// 为xml字典赋值
        /// </summary>
        /// <param name="obj"></param>
        private void UpdateAttributeDict(object obj)
        {
            foreach (var property in obj.GetType().GetProperties())
            {
                if (xmlAttributeDict.ContainsKey(property.Name))
                {
                    xmlAttributeDict[property.Name] = property.GetValue(obj);
                }
            }
        }

    }
}
