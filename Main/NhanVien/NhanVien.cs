using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Main.NhanVien
{
    public partial class NhanVien : Form
    {

        public NhanVien()
        {
            InitializeComponent();
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            Load_NhanVien();
            enableControl(false);
        }

        private void dtg_CongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                enableControl(false);
                btn_CV_Them.Enabled = true;
                btn_CV_Sua.Enabled = true;
                btn_CV_Xoa.Enabled = true;
                DataGridViewRow row = dtg_CongViec.Rows[e.RowIndex];
                txt_MCV.Text = row.Cells["MaCV"].Value.ToString();
                txt_TCV.Text = row.Cells["TenCV"].Value.ToString();
                txt_MucLuong.Text = row.Cells["MucLuong"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            Load_CongViec();
            resetTextBox_CongViec();
            enableControl_CongViec(false);
        }

        private void btn_CV_Them_Click(object sender, EventArgs e)
        {
            lb_CV_TrangThai.Text = "*Bạn đang ở chế dộ Thêm!";
            enableControl_CongViec(true);
            resetTextBox_CongViec();
            btn_CV_Sua.Enabled = false;
            btn_CV_Xoa.Enabled = false;
        }

        private void btn_CV_Sua_Click(object sender, EventArgs e)
        {
            lb_CV_TrangThai.Text = "*Bạn đang ở chế dộ Sửa!";
            enableControl_CongViec(true);
            txt_MaCV.Enabled = false;
            btn_CV_Them.Enabled = false;
            btn_CV_Xoa.Enabled = false;
        }

        private void btn_CV_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa Công việc có mã la " + txt_MCV.Text +
               " không ? Nếu có ấn nút Lưu, không Thì ấn nút Hủy", "Thông báo!",
                MessageBoxButtons.OK) == DialogResult.OK)
            {
                enableControl(false);
                lb_CV_TrangThai.Text = "*Bạn đang ở chế dộ XOÁ";
                btn_CV_Them.Enabled = false;
                btn_CV_Sua.Enabled = false;
                btn_CV_Luu.Enabled = true;
                btn_CV_Huy.Enabled = true;
            }
        }

        private void btn_CV_Luu_Click(object sender, EventArgs e)
        {
            string sql = "";

            string ma = txt_MCV.Text;
            string ten = txt_TCV.Text;
            string luong = txt_MucLuong.Text;
            //Kiểm tra dữ liêu
            if (ma.Trim() == "")
            {
                errNhanVien.SetError(txt_MCV, "Mã không được để trống");
                return;
            }
            else
            {
                errNhanVien.Clear();
            }

            if (ten.Trim() == "")
            {
                errNhanVien.SetError(txt_TCV, "Tên không được để trống");
                return;
            }
            else
            {
                errNhanVien.Clear();
            }
            decimal salary;
            if (!decimal.TryParse(luong, out salary))
            {
                errNhanVien.SetError(txt_SDT, "Lương phải là một số");
                return;
            }
            else
            {
                errNhanVien.Clear();
            }

            if (btn_CV_Them.Enabled == true)
            {

                sql = $"Select Count(*) From [CongViec] Where MaCV ='{ma}';";
                DataTable dt = _database.DocBang(sql);
                if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show($"Đã tồn tại Công việc với mã {ma}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [CongViec] (MaCV, TenCV, MucLuong)";
                sql += $"VALUES('{ma}', N'{ten}', '{salary}');";
            }


            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            if (btn_CV_Sua.Enabled == true)
            {
                sql = "Update [CongViec] SET ";
                sql += $"TenCV = N'{ten}', MucLuong = '{salary}'";
                sql += $"WHERE MaCV = '{ma}'";
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_CV_Xoa.Enabled == true)
            {
                sql = $"Delete From [CongViec] Where MaCV = '{ma}'";
            }

            _database.CapNhatDuLieu(sql);

            Load_CongViec();

            resetTextBox_CongViec();
            enableControl_CongViec(false);
            lb_CV_TrangThai.Text = "";
            btn_CV_Them.Enabled = true;
            btn_CV_Xoa.Enabled = false;
            btn_CV_Sua.Enabled = false;
        }

        private void btn_CV_Huy_Click(object sender, EventArgs e)
        {
            lb_CV_TrangThai.Text = "";
            btn_CV_Xoa.Enabled = false;
            btn_CV_Sua.Enabled = false;
            btn_CV_Them.Enabled = true;
            resetTextBox_CongViec();
            enableControl_CongViec(false);
        }
    }
}
