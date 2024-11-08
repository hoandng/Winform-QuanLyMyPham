using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Main.KhachHang
{
    public partial class fCustomer : Form
    {
        ProcessDatabase _database;
        public fCustomer()
        {
            _database = new ProcessDatabase();
            InitializeComponent();
        }

        private void fCustomer_Load(object sender, EventArgs e)
        {
            Load_KhachHang();
            enableControl(false);
            resetTextBox();
        }
        private void Load_KhachHang()
        {
            string querry = "Select * from [KhachHang]";
            DataTable dt = _database.ExecuteQuery(querry);
            dgv_KhachHang.DataSource = dt;
            dgv_KhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void resetTextBox()
        {
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
            txt_DC.Text = "";
            txt_SDT.Text = "";
        }
        private void enableControl(bool en)
        {
            txt_MaKH.Enabled = en;
            txt_TenKH.Enabled = en;
            txt_DC.Enabled = en;
            txt_SDT.Enabled = en;

            btn_Luu.Enabled = en;
            btn_Huy.Enabled = en;
        }
        private void dgv_KhachHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                enableControl(false);
                btn_Them.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
                DataGridViewRow row = dgv_KhachHang.Rows[e.RowIndex];
                txt_MaKH.Text = row.Cells["colMaKH"].Value.ToString();
                txt_TenKH.Text = row.Cells["colTenKH"].Value.ToString();
                txt_DC.Text = row.Cells["colDiaChi"].Value.ToString();
                txt_SDT.Text = row.Cells["colSDT"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            lb_TrangThai.Text = "*Bạn đang ở chế dộ Thêm!";
            enableControl(true);
            resetTextBox();
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            lb_TrangThai.Text = "*Bạn đang ở chế dộ Sửa!";
            enableControl(true);
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa Khách hàng có mã la " + txt_MaKH.Text +
               " không ? Nếu có ấn nút Lưu, không Thì ấn nút Hủy", "Thông báo!",
                MessageBoxButtons.OK) == DialogResult.OK)
            {
                enableControl(false);
                lb_TrangThai.Text = "*Bạn đang ở chế dộ XOÁ";
                btn_Them.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Luu.Enabled = true;
                btn_Huy.Enabled = true;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string sql = "";

            string ma = txt_MaKH.Text;
            string ten = txt_TenKH.Text;
            string diachi = txt_DC.Text;
            string sdt = txt_SDT.Text;
            //Kiểm tra dữ liêu
            if (ma.Trim() == "")
            {
                errKhachHang.SetError(txt_MaKH, "Mã không được để trống");
                return;
            }
            else
            {
                errKhachHang.Clear();
            }

            if (ten.Trim() == "")
            {
                errKhachHang.SetError(txt_TenKH, "Tên không được để trống");
                return;
            }
            else
            {
                errKhachHang.Clear();
            }

            // Kiểm tra định dạng số điện thoại
            int sodienthoai;
            if (!int.TryParse(sdt, out sodienthoai) || sodienthoai < 0)
            {
                errKhachHang.SetError(txt_SDT, "Số điện thoại phải là một số dương");
                return;
            }
            else
            {
                errKhachHang.Clear();
            }
            if (sdt.Length != 10)
            {
                errKhachHang.SetError(txt_SDT, "Số điện thoại phải là 10 số");
                return;
            }
            else
            {
                errKhachHang.Clear();
            }

            if (btn_Them.Enabled == true)
            {

                sql = $"Select Count(*) From [KhachHang] Where MaKhach = @makh;";
                var parameters = new Dictionary<string, object>
                {
                    {"@makh", ma},

                };
                int count = Convert.ToInt32(_database.ExecuteScalar(sql, parameters));
                if (count > 0)
                {
                    MessageBox.Show($"Đã tồn tại Khách hàng với mã {ma}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [KhachHang] (MaKhach, TenKhach, DiaChi, DienThoai)";
                sql += "VALUES(@makh, @tenkh, @diachi, @dienthoai);";
                parameters = new Dictionary<string, object>
                {
                    {"@makh", ma},
                    {"@tenkh", ten},
                    {"@diachi", diachi},
                    {"@dienthoai",sdt }
                };
                _database.ExecuteNonQuery(sql, parameters);
            }


            //Nếu nút Sửa enable TNSXì thực hiện cập nhật dữ liệu
            if (btn_Sua.Enabled == true)
            {
                sql = "Update [KhachHang] SET ";
                sql += "TenKhach = @tenkh, DiaChi = @diachi, DienThoai = @sdt ";
                sql += "WHERE MaKhach = @makh";
                var parameters = new Dictionary<string, object>
                {
                    {"@makh", ma},
                    {"@tenkh", ten},
                    {"@diachi", diachi},
                    {"@sdt",sdt }
                };
                _database.ExecuteNonQuery(sql, parameters);
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_Xoa.Enabled == true)
            {
                sql = "Delete From [KhachHang] Where MaKhach = @makh";
                var parameters = new Dictionary<string, object>
                {
                    {"@makh", ma},
                };
                _database.ExecuteNonQuery(sql, parameters);
            }

            Load_KhachHang();

            resetTextBox();
            enableControl(false);
            lb_TrangThai.Text = "";
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            lb_TrangThai.Text = "";
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Them.Enabled = true;
            resetTextBox();
            enableControl(false);
        }

    }
}
