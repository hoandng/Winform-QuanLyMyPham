using Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            if (username == "hoan" && password == "1234")
            {
                this.Hide();
                fmain main = new fmain();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chăn muốn thoát không?", "Thông báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
