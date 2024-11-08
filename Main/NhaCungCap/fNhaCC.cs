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

namespace Main.NhaCungCap
{
    public partial class fNhaCC : Form
    {
        ProcessDatabase _data;
        public fNhaCC()
        {
            _data = new ProcessDatabase();
            InitializeComponent();
        }
        private void fNhaCC_Load(object sender, EventArgs e)
        {
            Load_NCC();
            resetTextBox();
            enableControls(false);
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void Load_NCC()
        {
            string querry = "Select * from [NhaCungCap]";
            DataTable dataTable = _data.ExecuteQuery(querry);
            dgv_NhaCC.DataSource = dataTable;
            
            dgv_NhaCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void resetTextBox()
        {
            txt_MaNCC.Text = "";
            txt_TenNCC.Text = "";
            txt_SDT.Text = "";
            txt_DiaChi.Text = "";
        }

        private void enableControls(bool enable)
        {
            txt_MaNCC.Enabled = enable;
            txt_SDT.Enabled = enable;
            txt_TenNCC.Enabled = enable;
            txt_DiaChi.Enabled = enable;
            
            btn_Luu.Enabled = enable;
            btn_Huy.Enabled = enable;
        }
        private void dgv_NhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                enableControls(false);
                btn_Them.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
                DataGridViewRow row = dgv_NhaCC.Rows[e.RowIndex];
                txt_MaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                txt_TenNCC.Text = row.Cells["TenNCC"].Value.ToString();
                txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txt_SDT.Text = row.Cells["DienThoai"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            lb_TrangThai.Text = "*Bạn đang ở chế dộ Thêm!";
            enableControls(true);
            resetTextBox();
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            lb_TrangThai.Text = "*Bạn đang ở chế dộ Sửa!";
            enableControls(true);
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa Nhà cung cấp có mã la " + txt_MaNCC.Text +
               " không ? Nếu có ấn nút Lưu, không Thì ấn nút Hủy", "Thông báo!",
                MessageBoxButtons.OK) == DialogResult.OK)
            {
                enableControls(false);
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

            string ma = txt_MaNCC.Text;
            string ten = txt_TenNCC.Text;
            string diachi = txt_DiaChi.Text;
            string sdt = txt_SDT.Text;
            //Kiểm tra dữ liêu
            if (ma.Trim() == "")
            {
                errNCC.SetError(txt_MaNCC, "Mã không được để trống");
                return;
            }
            else
            {
                errNCC.Clear();
            }

            if (ten.Trim() == "")
            {
                errNCC.SetError(txt_TenNCC, "Tên không được để trống");
                return;
            }
            else
            {
                errNCC.Clear();
            }
            int sodienthoai;
            if (!int.TryParse(sdt, out sodienthoai) || sodienthoai < 0)
            {
                errNCC.SetError(txt_SDT, "Số điện thoại phải là một số dương");
                return;
            }
            else
            {
                errNCC.Clear();
            }

            if (btn_Them.Enabled == true)
            {

                sql = $"Select Count(*) From [NhaCungCap] Where MaNCC = @ma;";
                var parameters = new Dictionary<string, object>
                {
                    {"@ma", ma},
                };
                int count = Convert.ToInt32(_data.ExecuteScalar(sql, parameters));
                if (count > 0)
                {
                    MessageBox.Show($"Đã tồn tại Khách hàng với mã {ma}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [NhaCungCap] (MaNCC, TenNCC, DiaChi, DienThoai)";
                sql += $"VALUES(@ma, @ten, @diachi, @dienthoai);";
                parameters = new Dictionary<string, object>
                {
                    {"@ma", ma},
                    {"@ten", ten},
                    {"@diachi", diachi},
                    {"@dienthoai",sdt }
                };
                _data.ExecuteNonQuery(sql, parameters);
            }


            //Nếu nút Sửa enable TNSXì thực hiện cập nhật dữ liệu
            if (btn_Sua.Enabled == true)
            {
                sql = "Update [NhaCungCap] SET ";
                sql += $"TenNCC = @ten, DiaChi = @diachi, DienThoai = @dienthoai ";
                sql += $"WHERE MaNCC = @ma";
                var parameters = new Dictionary<string, object>
                {
                    {"@ma", ma},
                    {"@ten", ten},
                    {"@diachi", diachi},
                    {"@dienthoai",sdt }
                };
                _data.ExecuteNonQuery(sql, parameters);
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_Xoa.Enabled == true)
            {
                sql = $"Delete From [NhaCungCap] Where MaNCC = @ma";
                var parameters = new Dictionary<string, object>
                {
                    {"@ma", ma},
                };
                _data.ExecuteNonQuery(sql, parameters);
            }

            Load_NCC();

            resetTextBox();
            enableControls(false);
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
            enableControls(false);
        }
    }
}
