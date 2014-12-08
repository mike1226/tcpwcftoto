using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace Toto.Services
{
    /// <summary>
    /// 取得服务引用的方法
    /// </summary>
    public static class XmlHelper
    {
        // 文件路径
        static readonly string StrPath = System.Threading.Thread.GetDomain().BaseDirectory;
         /// <summary>
         /// 获取Services服务名称 
         /// </summary>
         /// <param name="strProt">服务号</param>
         /// <returns></returns>

        public static Toto.Services.ServiceModel  GetService(string strProt)
         {
             var modService = new Services.ServiceModel();
             // XML文件名
            var strXmlFile = Path.Combine(StrPath, "ServiceMap.xml");
            using (var reader = XmlReader.Create(strXmlFile))
            {
                var doc = XDocument.Load(reader);
                // 如果不为空，则进行下一步操作。
                if (doc.Root == null) return null;
                var node = doc.Root.Elements().Where(d => d.Attribute("port").Value == strProt);
                foreach (var n in node)
                {
                    // 返回方法名
                    modService.ClassAssembly = n.Attribute("assembly").Value;
                    modService.ClassName  = n.Attribute("class").Value;
                    modService.ClassMethod = n.Attribute("methed").Value;
                    modService.InputPara = n.Attribute("para").Value;
                }
            }

            return modService;
        }

    }
}
