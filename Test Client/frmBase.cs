using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Test_Client.TotoService;
using Toto.DbModel;
using Toto.Services;

namespace Test_Client
{
    public class frmBase : Form
    {
        /// <summary>
        /// 取得服务器方法 
        /// </summary>
        /// <param name="dto">发送的参数</param>
        /// <returns></returns>
        public async Task<ResponseDTO> CallService(RequestDTO dto)
        {
            var rsp = new ResponseDTO();
            try
            {
                var strService = JsonConvert.SerializeObject(dto);
                using (var sc = new TotoServiceClient())
                {
                    var strServiceName = await sc.ProcessAsync(strService);
                    // 取回服务器处理结果
                    rsp = JsonConvert.DeserializeObject<ResponseDTO>(strServiceName);
                }
            }
            catch 
            {
                rsp.RetMsg = "取得服务器方法失败";
                rsp.RetCode = -1;
            }
            
            return rsp;
        }
    }
}
