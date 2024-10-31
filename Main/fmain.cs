using Main.HangHoa;
using Main.KhachHang;
using Main.NhanVien;
using Main.HoaDonBan;
using Main.HoaDonNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.NhaCungCap;

namespace Main
{
    public partial class fmain : Form
    {
        private Form activeform = null;
        private Button currentButton;
        public fmain()
        {
            InitializeComponent();
        }
        private void fmain_Load(object sender, EventArgs e)
        {
             btn_HangHoa.PerformClick();
        }

        //Mở form khi click vào 1 button
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pannel_content.Controls.Add(childForm);
            pannel_content.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(37, 113, 128);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pannel_menu_btn.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(160, 71, 71);
                    previousBtn.ForeColor = Color.Black;
                }
            }
        }
        private void btn_HangHoa_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new HangHoa.HangHoa());
        }
        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new fCustomer());
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new NhanVien.NhanVien());
        }
        private void btn_DonBan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new fHDB());
        }

        private void btn_DonNhap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new fHDN());
        }

        private void brn_NhaCC_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new fNhaCC());
        }
    }
}
