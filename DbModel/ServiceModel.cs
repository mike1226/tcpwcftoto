using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Toto.Services
{
    /// <summary>
    /// 用于解析服务的DTO
    /// </summary>
    public class ServiceModel
    {
        /// <summary>
        /// 程序集名字
        /// </summary>
        public string ClassAssembly { get; set; }

        /// <summary>
        /// 服务类名
        /// </summary>
        public string ClassName { get; set; }
        /// <summary>
        /// 服务方法【Method】
        /// </summary>
        public string ClassMethod { get; set; }
        /// <summary>
        /// 传入参数【DTO】
        /// </summary>
        public string InputPara { get; set; }
        /// <summary>
        /// 传出参数【DTO】
        /// </summary>
        public string OutParqa { get; set; }
    }
}
