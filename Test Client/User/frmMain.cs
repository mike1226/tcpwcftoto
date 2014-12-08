using System;
using System.Windows.Forms;

namespace Test_Client
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgvAdmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dc = new DetailConfirm();
            dc.ShowDialog();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            var frmReg = new frmRegister();
            frmReg.ShowDialog();
        }
    }
}