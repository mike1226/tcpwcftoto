using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Xml;
using System.Xml.Linq;

namespace Toto.Services
{
    /// <summary>
    ///     取得服务引用的方法
    /// </summary>
    public static class XmlHelper
    {
        // 文件路径
        private static readonly string StrPath = Thread.GetDomain().BaseDirectory;

        /// <summary>
        ///     获取Services服务名称
        /// </summary>
        /// <param name="strProt">服务号</param>
        /// <returns></returns>
        public static ServiceModel GetService(string strProt)
        {
            var modService = new ServiceModel();
            // XML文件名
            string strXmlFile = Path.Combine(StrPath, "ServiceMap.xml");
            using (XmlReader reader = XmlReader.Create(strXmlFile))
            {
                XDocument doc = XDocument.Load(reader);
                // 如果不为空，则进行下一步操作。
                if (doc.Root == null) return null;
                IEnumerable<XElement> node = doc.Root.Elements().Where(d => d.Attribute("port").Value == strProt);
                foreach (XElement n in node)
                {
                    // 返回方法名
                    modService.ClassAssembly = n.Attribute("assembly").Value;
                    modService.ClassName = n.Attribute("class").Value;
                    modService.ClassMethod = n.Attribute("methed").Value;
                    modService.InputPara = n.Attribute("para").Value;
                }
            }

            return modService;
        }
    }
}