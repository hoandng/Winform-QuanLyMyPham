using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.TaiKhoan
{
    public partial class TaiKhoan : Form
    {
        ProcessDatabase _data;
        private string curr_user = "";
        private string curr_password = "";
        
        public TaiKhoan(string user = "", string password = "")
        {
            curr_user = user;
            curr_password = password;
            _data = new ProcessDatabase();
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            Load_ThongTin();
            enableControl(false);
        }

        private void Load_ThongTin()
        {
            txt_TenTK.Text = curr_user;
            txt_MK.Text = curr_password;

            string query = "Select Anh From [TaiKhoan] Where Email = @tk";
            var parameters = new Dictionary<string, object>
            {
                {"@tk", curr_user},
            };
            var dest = _data.ExecuteScalar(query, parameters);
            if(dest != "")
            {
                pb_Anh.ImageLocation = dest.ToString();
            }
        }

        private void enableControl(bool en)
        {
            txt_MK.Enabled = en;
            btn_Luu.Enabled = en;
            btn_Huy.Enabled = en;
            btn_TaiAnh.Enabled = en;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            enableControl(true);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string tk = txt_TenTK.Text;
            string mk = txt_MK.Text;
            string anh = pb_Anh.ImageLocation.ToString();
            string querry = "Update [TaiKhoan] SET " +
                             "Password = @mk, Anh = @anh " +
                             "Where Email = @tk";
            var parameters = new Dictionary<string, object>
            {
                {"@tk", tk},
                {"@mk", mk},
                {"@anh", anh},
            };
            _data.ExecuteNonQuery(querry, parameters);
            curr_user = tk;
            curr_password = mk;
            Load_ThongTin();
            enableControl(false);
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            enableControl(false);
            Load_ThongTin();
        }

        private void btn_TaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";  // Chỉ cho phép chọn các file ảnh
            openFileDialog.Title = "Chọn ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị ảnh trong PictureBox
                pb_Anh.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
