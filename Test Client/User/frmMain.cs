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
            DetailConfirm dc = new DetailConfirm();
            dc.ShowDialog();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            frmRegister frmReg = new frmRegister();
            frmReg.ShowDialog();
        }
    }
}
