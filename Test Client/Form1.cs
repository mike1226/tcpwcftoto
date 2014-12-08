using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using Test_Client.TotoService;
using Toto.DbModel;
using Toto.Services;

namespace Test_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private async void btnReg_Click(object sender, EventArgs e)
        {
            string strUsrNm = txtUsr.Text;
            string strPwd = txtPwd.Text;
            var user = new T_USER_BASE();
            user.USER_NAME = strUsrNm;
            user.USER_PWD = strPwd;

            var dto = new RequestDTO();
            dto.Port = "100002";
            dto.Content = JsonConvert.SerializeObject(user);
            dto.UserName = "";
            dto.ChkCode = ""; // Need common entrycode method...

            // Need Package Dto Common Method....

            string strService = JsonConvert.SerializeObject(dto);

            using (var sc = new TotoServiceClient())
            {
                // 返回的应该是一个DTO
                // 根据DTO的JSON解析
                string strServiceName = await sc.ProcessAsync(strService);
                // 取回服务器处理结果
                var rsp = JsonConvert.DeserializeObject<ResponseDTO>(strServiceName);
                // 显示处理结果
                lblMsg.Text = rsp.RetMsg + Environment.NewLine;
                user = JsonConvert.DeserializeObject<T_USER_BASE>(rsp.RetJson);
                lblMsg.Text += "新用户的ID:" + user.USER_ID;
            }
        }

        private void btnLeague_Click(object sender, EventArgs e)
        {
            var frmLea = new frmLeague();
            frmLea.ShowDialog(this);
        }
    }
}