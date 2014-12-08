using System;
using System.Windows.Forms;

namespace Test_Client
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblRegUser_Click(object sender, EventArgs e)
        {
            // 弹出用户注册画面
            var register = new frmRegister();
            register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblLoginMsg.Hide();

            // 用户名和密码都是空的校验
            if (String.IsNullOrEmpty(txtUserName.Text.Trim()) && String.IsNullOrEmpty(txtPwd.Text.Trim()))
            {
                lblLoginMsg.Show();
                lblLoginMsg.Text = "请输入用户名和密码。";
                txtUserName.Focus();
            }
                // 用户名不为空、密码为空的校验
            else if (!String.IsNullOrEmpty(txtUserName.Text.Trim()) && String.IsNullOrEmpty(txtPwd.Text.Trim()))
            {
                lblLoginMsg.Show();
                lblLoginMsg.Text = "请输入密码。";
                txtPwd.Focus();
            }
                // 用户名为空、密码不为空的校验
            else if (String.IsNullOrEmpty(txtUserName.Text.Trim()) && !String.IsNullOrEmpty(txtPwd.Text.Trim()))
            {
                lblLoginMsg.Show();
                lblLoginMsg.Text = "请输入用户名。";
                txtUserName.Focus();
            }
                // 用户名、密码都不为空的校验
            else
            {
                // TODO 怎么处理尚不明确
                var mainForm = new frmMain();
                mainForm.Show();
                Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // 隐藏【用来显示登陆提示信息的Label】
            lblLoginMsg.Hide();

            // TODO 暂时取消注册功能。（管理系统应该不需要注册功能。）
            //this.lblRegUser.Hide();
        }
    }
}