using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Toto.DbModel;

namespace Toto.Common
{
    public static class SiteSetClass
    {

        // 文件路径
        static readonly string ConStrPath = System.Threading.Thread.GetDomain().BaseDirectory;
        /// <summary>
        /// 取得配置文件的定义
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public static string GetConstVal(string strName)
        {
            string strRet = string.Empty;
            // XML文件名
            var strXmlFile = Path.Combine(ConStrPath, "SiteSet.xml");
            using (var reader = XmlReader.Create(strXmlFile))
            {
                var doc = XDocument.Load(reader);
                // 如果不为空，则进行下一步操作。
                if (doc.Root == null) return null;
                var node = doc.Root.Elements().Where(d => d.Attribute("name").Value == strName);
                foreach (var n in node)
                {
                    // 返回取得的值名
                    strRet = n.Attribute("value").Value;
                }
            }
            return strRet;
        }

    }
}
