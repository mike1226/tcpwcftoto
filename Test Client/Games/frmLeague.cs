using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using Toto.DbModel;
using Toto.Services;

namespace Test_Client
{
    public partial class frmLeague : frmBase
    {
        public frmLeague()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     画面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLeague_Load(object sender, EventArgs e)
        {
            // 绑定下拉列表
            try
            {
                BindGameKind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///     绑定比赛信息
        /// </summary>
        private async void BindGameKind()
        {
            var dto = new RequestDTO {Port = "900001", Content = "", UserName = "", ChkCode = ""};

            // 取回服务器处理结果
            ResponseDTO rsp = await CallService(dto);

            if (rsp.RetCode == -1)
            {
                MessageBox.Show(rsp.RetMsg);
                return;
            }
            var datas = JsonConvert.DeserializeObject<List<T_GAME_KIND>>(rsp.RetJson);

            if (datas == null) return;

            cbxLeague.DataSource = datas;
            cbxLeague.DisplayMember = "KIND_NAME";
            cbxLeague.ValueMember = "KIND_ID";
        }

        /// <summary>
        ///     添加比赛信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ChkSubmit())
            {
                return;
            }

            var obj = new T_LEAGUE();
            obj.LEAGUE_KIND = (int) cbxLeague.SelectedValue;
            obj.LEAGUE_NAME = txtName.Text;
            obj.LEAGUE_ENNAME = txtEnName.Text;

            var dto = new RequestDTO
            {
                Port = "200001",
                Content = JsonConvert.SerializeObject(obj),
                UserName = "",
                ChkCode = ""
            };

            // 取回服务器处理结果
            ResponseDTO rsp = await CallService(dto);
            // 显示处理结果
            MessageBox.Show(rsp.RetMsg);
        }

        private bool ChkSubmit()
        {
            bool ret = true;
            if (string.IsNullOrEmpty(cbxLeague.Text))
            {
                ret = false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                ret = false;
            }
            return ret;
        }
    }
}