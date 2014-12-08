using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Toto.DbModel
{

    /// <summary>
    /// 用于返回的DTO
    /// </summary>
    [DataContract]
    public class ResponseDTO
    {

        /// <summary>
        /// 返回代码 0 正常 < 0 异常
        /// </summary>
        [DataMember]
        public int RetCode { get; set; }

        /// <summary>
        /// 返回的格式，Json封装的DTO
        /// </summary>
        [DataMember]
        public string RetJson { get; set; }

        /// <summary>
        /// 返回的消息 
        /// </summary>
        [DataMember]
        public string RetMsg { get; set; }
    }
}
