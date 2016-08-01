using Depositer.Controller.Model;
using Depositer.Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Depositer.Forms
{
    public partial class BaseDlg : Form
    {
        private XmlDocument xmlDoc = new XmlDocument();
        private string fullpath;
        protected Dictionary<object, object> xmlAttributeDict = new Dictionary<object, object>();

        /// <summary>
        /// 保存成功与否标志
        /// </summary>
        protected bool IsSavedOK = false;

        public BaseDlg()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveButtonCall();
        }

        /// <summary>
        /// 保存按钮下的事件响应
        /// </summary>
        protected virtual void SaveButtonCall()
        {
            if (IsSavedOK == true)
            {
                IMessageBox.ShowInformationOK("保存成功!");
                Close();
            }
            else
                IMessageBox.ShowWarning("保存失败");
        }

        /// <summary>
        /// 取消按钮响应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 获取贷款的时间类型
        /// 异常：ArgumentNullException
        /// </summary>       
        /// <param name="debt"></param>
        /// <returns></returns>
        protected TimeType GetTimeType()
        {
            if (yearRadioBtn.Checked == true) return TimeType.Year;
            else if (monthRadioBtn.Checked == true) return TimeType.Month;
            else if (dayRadioBtn.Checked == true) return TimeType.Day;
            else throw new ArgumentNullException("未选择时长的类型为年或月或日！");
        }

        /// <summary>
        /// 选择RadioButton更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yearRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (yearRadioBtn.Checked == true)
                monthRadioBtn.Checked = dayRadioBtn.Checked = false;
        }
        private void monthRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (monthRadioBtn.Checked == true)
                yearRadioBtn.Checked = dayRadioBtn.Checked = false;
        }
        private void dayRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dayRadioBtn.Checked == true)
                yearRadioBtn.Checked = monthRadioBtn.Checked = false;
        }

        protected void FillControlsBase(string filename, object obj)
        {
            ReadFromXML(filename, obj.GetType());
            string debtTimeType = xmlAttributeDict["TimeType"].ToString();
            if (debtTimeType == "Year")
                yearRadioBtn.Checked = true;
            else if (debtTimeType == "Month")
                monthRadioBtn.Checked = true;
            else if (debtTimeType == "Day")
                dayRadioBtn.Checked = true;
        }

        /// <summary>
        /// 从XML文件读取数据
        /// </summary>
        /// <param name="filename"></param>
        private void LoadXml(string filename)
        {
            var root = Environment.CurrentDirectory;
            var splits =root.Split('\\');
            root = root.Substring(0,root.IndexOf(splits[splits.Length - 2]));
            fullpath = Path.Combine(root, "Settings\\"+filename);        
            xmlDoc.Load(fullpath);
        }
        
        /// <summary>
        /// 获取模型中配置的与XML交互用的属性字典
        /// 异常：Exception()
        /// </summary>
        /// <param name="debt"></param>
        private void GetXMLAttribute(Type t)
        {
            xmlAttributeDict.Clear();
           var attributeList = XMLAttribute.GetCustomAttributes(t);
           if (attributeList.Length == 0)
               throw new Exception("未在模型中配置可与XML交互的属性！");
           foreach (var attr in attributeList)
           {
               if(!xmlAttributeDict.ContainsKey((attr as XMLAttribute).XMLProperty))
                   xmlAttributeDict.Add((attr as XMLAttribute).XMLProperty, new Object());
           }
        }

        /// <summary>
        /// 从xml读取数据
        /// 异常：XMLFormatException
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="t"></param>
        protected void ReadFromXML(string filename, Type t)
        {
            LoadXml(filename);
            GetXMLAttribute(t);
            var xmlroot = xmlDoc.SelectSingleNode("Setting");
            if (xmlroot == null)
                throw new ArgumentNullException("XML的根节点");
            var nodelist = xmlroot.ChildNodes;
            foreach (XmlNode node in nodelist)
            {
                if (node.ChildNodes.Count >1)
                    throw new XMLFormatException("读入的XML文件子节点中含有节点！");
                xmlAttributeDict[node.Name] = node.InnerText;                
                //if (node.Name == "TimeLength")
                //{
                //    if (string.IsNullOrEmpty(xmlAttributeDict["TimeType"].ToString()))
                //        throw new XMLFormatException("TimeType节点应该位于TimeLength节点之前！");
                //    if (xmlAttributeDict["TimeType"].ToString() == "Year")
                //        xmlAttributeDict[node.Name] = Double.Parse(node.InnerText) / 12;
                //    else if (xmlAttributeDict["TimeType"].ToString() == "Day")
                //        xmlAttributeDict[node.Name] = Double.Parse(node.InnerText) * 30;
                //}
                //if (node.Name == "YearRate")
                //    xmlAttributeDict[node.Name] = Double.Parse(node.InnerText) * 100;
            }
        }

        protected void UpdateXML(string filename, Object obj)
        {
            //if(string.IsNullOrEmpty(fullpath))
            LoadXml(filename);
            //if(xmlAttributeDict.Count==0)
            GetXMLAttribute(obj.GetType());
            var xmlroot = xmlDoc.SelectSingleNode("Setting");
            var nodelist = xmlroot.ChildNodes;
            UpdateDict(obj);
            foreach (XmlNode node in nodelist)
            {
                if (xmlAttributeDict.ContainsKey(node.Name))
                    (node as XmlElement).InnerText = xmlAttributeDict[node.Name].ToString();
            }
            xmlDoc.Save(fullpath);
        }

        private void UpdateDict(object obj)
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
