using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Client
{
    public partial class DetailConfirm : Form
    {
        public DetailConfirm()
        {
            InitializeComponent();
        }

        private void btnDetailConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("确定要修改该用户信息吗","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // 更新DB

                // 更新成功的时候，弹出提示信息,关闭该画面
                MessageBox.Show("用户修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TODO 需要刷新前画面数据（怎么做还不确定）
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnDetaiCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
