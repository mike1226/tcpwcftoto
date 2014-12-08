using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Client.TotoService;
using Toto.DbModel;
using Toto.Services;
using Newtonsoft.Json;

namespace Test_Client
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegCancel_Click(object sender, EventArgs e)
        {
            DialogResult reslult = MessageBox.Show("确定要退出注册画面吗", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (reslult == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private async void btnRegConfirm_Click(object sender, EventArgs e)
        {
            // 用户表映射类
            T_USER_BASE user = new T_USER_BASE();
            user.USER_NAME = this.txtRegUserName.Text;                                     // 画面上的用户名
            user.USER_PWD = this.txtRegUserPwd.Text;                                       // 画面上的用户密码
            user.USER_STS = 1;                                                             // 初始化用户状态
            user.USER_MOBIL = this.txtRegTelNo.Text;                                       // 画面上的用户电话
            user.USER_BANK_ACCOUNT = this.txtRegBankAccount.Text;                          // 画面上的用户的银行账号

            // 参数DTO做成
            RequestDTO dto = new RequestDTO();
            dto.Port = "100001";
            dto.Content = JsonConvert.SerializeObject(user);
            dto.UserName = "";
            dto.ChkCode = "";

            string strService = JsonConvert.SerializeObject(dto);

            using (var sc = new TotoServiceClient())
            {
                // 返回的应该是一个DTO
                // 根据DTO的JSON解析
                var strServiceName = await sc.ProcessAsync(strService);
                // 取回服务器处理结果
                ResponseDTO rsp = JsonConvert.DeserializeObject<ResponseDTO>(strServiceName);
                // 显示处理结果
                user = JsonConvert.DeserializeObject<T_USER_BASE>(rsp.RetJson);
                if (user.USER_ID != null)
                {
                    DialogResult dr = MessageBox.Show(rsp.RetMsg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
