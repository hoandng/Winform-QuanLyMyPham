using Main.HangHoa;
using Main.KhachHang;
using Main.NhanVien;
using Main.HoaDonBan;
using Main.HoaDonNhap;
using Main.ThongKe;
using Main.TaiKhoan;
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
using Login;
using System.Runtime.CompilerServices;
namespace Main
{
    public partial class fmain : Form
    {
        ProcessDatabase _data;
        private Form activeform = null;
        private Button currentButton;
        private string curr_user = "";
        private string curr_password = "";
        public fmain(string user = "", string password = "")
        {
            _data = new ProcessDatabase();
            curr_user = user;
            curr_password = password;
            InitializeComponent();
        }
        private void fmain_Load(object sender, EventArgs e)
        {
            btn_ThongKe.PerformClick();
            lb_TenTK.Text = curr_user;
            string query = "Select Anh From [TaiKhoan] Where Email = @tk";
            var parameters = new Dictionary<string, object>
            {
                {"@tk", curr_user},
            };
            var dest = _data.ExecuteScalar(query, parameters);
            if(dest.ToString().Trim() != "")
            {
                pb_TaiKhoan.ImageLocation = dest.ToString();
            }
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
                    Color color = Color.FromArgb(147, 129, 255);
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
                    previousBtn.BackColor = Color.FromArgb(184, 184, 255);
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

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new ThongKe.ThongKe());
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất không", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Dispose();
                fLogin dangnhap = new fLogin();
                dangnhap.ShowDialog();
            }

        }

        private void fmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pb_TaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new TaiKhoan.TaiKhoan(curr_user, curr_password));
        }


    }
}
