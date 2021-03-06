﻿using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Test_Client.TotoService;
using Toto.DbModel;
using Toto.Services;

namespace Test_Client
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }
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
                string strService = JsonConvert.SerializeObject(dto);
                using (var sc = new TotoServiceClient())
                {
                    string strServiceName = await sc.ProcessAsync(strService);
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
