using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Xml;
using System.Xml.Linq;

namespace Toto.Common
{
    public static class SiteSetClass
    {
        // 文件路径
        private static readonly string ConStrPath = Thread.GetDomain().BaseDirectory;

        /// <summary>
        ///     取得配置文件的定义
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public static string GetConstVal(string strName)
        {
            string strRet = string.Empty;
            // XML文件名
            string strXmlFile = Path.Combine(ConStrPath, "SiteSet.xml");
            using (XmlReader reader = XmlReader.Create(strXmlFile))
            {
                XDocument doc = XDocument.Load(reader);
                // 如果不为空，则进行下一步操作。
                if (doc.Root == null) return null;
                IEnumerable<XElement> node = doc.Root.Elements().Where(d => d.Attribute("name").Value == strName);
                foreach (XElement n in node)
                {
                    // 返回取得的值名
                    strRet = n.Attribute("value").Value;
                }
            }
            return strRet;
        }
    }
}