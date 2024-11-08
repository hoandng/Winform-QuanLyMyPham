using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.HangHoa
{
    partial class HangHoa : Form
    {
        private void Load_HangHoa()
        {
            string querry = "Select * from [HangHoa]";
            DataTable dtHangHoa = _data.ExecuteQuery(querry);
            dtg_HangHoa.DataSource = dtHangHoa;

            dtg_HangHoa.Columns["colGiaBan"].DefaultCellStyle.Format = "C0";
            dtg_HangHoa.Columns["colGiaNhap"].DefaultCellStyle.Format = "C0";
            dtg_HangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

            dtg_HangHoa.VirtualMode = true;
            dtHangHoa.Dispose();
        }
        
        private void tp_HangHoa_Enter(object sender, EventArgs e)
        {
            // Đổ dữ liệu vào Combobox
            fill_ChatLieu();
            fill_CongDung();
            fill_KhoiLuong();
            fill_Loai();
            fill_Mau();
            fill_Mua();
            fill_NuocSX();
            fill_HangSX();

            Load_HangHoa();
            Enable_HangHoa(false);
            ResetValueTextBox_HangHoa();
            Enable_HangHoa(false);
            btn_HH_Them.Enabled = true;
            btn_HH_Sua.Enabled = false;
            btn_HH_Xoa.Enabled = false;

            lb_HH_TrangThai.Text = "";



            //ClearDataGrid(dtg_HangHoa);
        }
        
        private void fill_ChatLieu()
        {
            string query = "SELECT MaChatLieu, TenChatLieu FROM [ChatLieu]";
            DataTable dataTable = _data.ExecuteQuery(query);

            cb_CL.DataSource = dataTable;
            cb_CL.DisplayMember = "TenChatLieu"; // Tên cột hiển thị
            cb_CL.ValueMember = "MaChatLieu";     // Tên cột giá trị
        }
        
        private void fill_CongDung()
        {
            string query = "SELECT MaCongDung, TenCongDung FROM [CongDung]";
            DataTable dataTable = _data.ExecuteQuery(query);

            cb_CD.DataSource = dataTable;
            cb_CD.DisplayMember = "TenCongDung"; // Tên cột hiển thị
            cb_CD.ValueMember = "MaCongDung";     // Tên cột giá trị
        }
        
        private void fill_KhoiLuong()
        {
            string query = "SELECT MaKhoiLuong, TenKhoiLuong FROM [KhoiLuong]";
            DataTable dataTable = _data.ExecuteQuery(query);

            cb_KL.DataSource = dataTable;
            cb_KL.DisplayMember = "TenKhoiLuong"; // Tên cột hiển thị
            cb_KL.ValueMember = "MaKhoiLuong";     // Tên cột giá trị
        }
        
        private void fill_Loai ()
        {
            string query = "SELECT MaLoai, TenLoai FROM [Loai]";
            DataTable dataTable = _data.ExecuteQuery(query);

            cb_Loai.DataSource = dataTable;
            cb_Loai.DisplayMember = "TenLoai"; // Tên cột hiển thị
            cb_Loai.ValueMember = "MaLoai";     // Tên cột giá trị
        }
        
        private void fill_Mau()
        {
            string query = "SELECT MaMau, TenMau FROM [MauSac]";
            DataTable dataTable = _data.ExecuteQuery(query);

            cb_Mau.DataSource = dataTable;
            cb_Mau.DisplayMember = "TenMau"; // Tên cột hiển thị
            cb_Mau.ValueMember = "MaMau";     // Tên cột giá trị
        }
        
        private void fill_Mua()
        {
            string query = "SELECT MaMua, TenMua FROM [Mua]";
            DataTable dataTable = _data.ExecuteQuery(query);

            cb_Mua.DataSource = dataTable;
            cb_Mua.DisplayMember = "TenMua"; // Tên cột hiển thị
            cb_Mua.ValueMember = "MaMua";     // Tên cột giá trị
        }
        
        private void fill_NuocSX()
        {
            string query = "SELECT MaNuocSX, TenNuocSX FROM [NuocSX]";
            DataTable dataTable = _data.ExecuteQuery(query);

            cb_NuocSX.DataSource = dataTable;
            cb_NuocSX.DisplayMember = "TenNuocSX"; // Tên cột hiển thị
            cb_NuocSX.ValueMember = "MaNuocSX";     // Tên cột giá trị
        }
        
        private void fill_HangSX()
        {
            string query = "SELECT MaHangSX, TenHangSX FROM [HangSX]";
            DataTable dataTable = _data.ExecuteQuery(query);

            cb_Hang.DataSource = dataTable;
            cb_Hang.DisplayMember = "TenHangSX"; // Tên cột hiển thị
            cb_Hang.ValueMember = "MaHangSX";     // Tên cột giá trị
        }
        
        private void tp_HangHoa_Leave(object sender, EventArgs e)
        {


        }
        
        private void Enable_HangHoa(Boolean hien)
        {
            txt_MaHang.Enabled = hien;
            txt_TenHang.Enabled = hien;
            cb_Hang.Enabled = hien;
            cb_Loai.Enabled = hien;
            cb_Mau.Enabled = hien;
            cb_KL.Enabled = hien;
            cb_CL.Enabled = hien;
            cb_CD.Enabled = hien;
            cb_NuocSX.Enabled = hien;
            cb_Mua.Enabled = hien;
            txt_SL.Enabled = hien;
            txt_BH.Enabled = hien;
            txt_GiaBan.Enabled = hien;
            txt_GiaNhap.Enabled = hien;
            txt_GhiChu.Enabled = hien;
            //Ẩn hiện 2 nút Lưu và Hủy
            btn_HH_Luu.Enabled = hien;
            btn_HH_Huy.Enabled = hien;
            btn_TaiAnh.Enabled = hien;

        }
        
        private void ResetValueTextBox_HangHoa()
        {
            txt_MaHang.Text = "";
            txt_TenHang.Text = "";
            cb_Hang.Text = "";
            cb_Loai.Text = "";
            cb_Mau.Text = "";
            cb_KL.Text = "";
            cb_CL.Text = "";
            cb_CD.Text = "";
            cb_NuocSX.Text = "";
            txt_SL.Text = "";
            cb_Mua.Text = "";
            txt_BH.Text = "";
            txt_GiaBan.Text = "";
            txt_GiaNhap.Text = "";
            txt_GhiChu.Text = "";
            pictureBox_AnhSP.ImageLocation = "";
        }
        
        private void dtg_HangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Bắt lỗi khi người sử dụng kích linh tinh lên datagrid
            try
            {
                btn_HH_Them.Enabled = true;
                btn_HH_Sua.Enabled = true;
                btn_HH_Xoa.Enabled = true;
                Enable_HangHoa(false);
                DataGridViewRow row = dtg_HangHoa.Rows[e.RowIndex];

                txt_MaHang.Text = row.Cells["colMaHang"].Value.ToString();
                txt_TenHang.Text = row.Cells["colTenHang"].Value.ToString();
                txt_SL.Text = row.Cells["colSoLuong"].Value.ToString();
                txt_BH.Text = row.Cells["colBaoHanh"].Value.ToString();
                txt_GiaBan.Text = row.Cells["colGiaBan"].Value.ToString();
                txt_GiaNhap.Text = row.Cells["colGiaNhap"].Value.ToString();
                txt_GhiChu.Text = row.Cells["colGhiChu"].Value.ToString();

                cb_Loai.SelectedValue = row.Cells["colLoai"].Value.ToString();
                cb_KL.SelectedValue = row.Cells["colKhoiLuong"].Value.ToString();
                cb_Hang.SelectedValue = row.Cells["colHangSX"].Value.ToString();
                cb_CL.SelectedValue = row.Cells["colChatLieu"].Value.ToString();
                cb_CD.SelectedValue = row.Cells["colCongDung"].Value.ToString();
                cb_Mau.SelectedValue = row.Cells["colMau"].Value.ToString();
                cb_NuocSX.SelectedValue = row.Cells["colNuocSX"].Value.ToString();
                cb_Mua.SelectedValue = row.Cells["colMua"].Value.ToString();
                
                pictureBox_AnhSP.ImageLocation = row.Cells["colAnh"].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_HH_Luu_Click(object sender, EventArgs e)
        {
            string sql = "";

            string mahang = txt_MaHang.Text;
            string tenhang = txt_TenHang.Text;
            string mahangsx = cb_Hang.SelectedValue.ToString();
            string maloai = cb_Loai.SelectedValue.ToString();
            string mamau = cb_Mau.SelectedValue.ToString();
            string makl = cb_KL.SelectedValue.ToString();
            string macl = cb_CL.SelectedValue.ToString();
            string macd = cb_CD.SelectedValue.ToString();
            string mansx = cb_NuocSX.SelectedValue.ToString();
            string mamua = cb_Mua.SelectedValue.ToString();
            string sl = txt_SL.Text;
            string bh = txt_BH.Text;
            string giaban = txt_GiaBan.Text;
            string gianhap = txt_GiaNhap.Text;
            string ghichu = txt_GhiChu.Text;
            string anh = pictureBox_AnhSP.ImageLocation;
            //Kiểm tra dữ liêu
            if (mahang.Trim() == "")
            {
                errHangHoa.SetError(txt_MaHang, "Bạn không để trống mã sản phẩm!");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (txt_TenHang.Text.Trim() == "")
            {
                errHangHoa.SetError(txt_TenHang, "Bạn không để trống tên sản phẩm!");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }
            decimal soluong, hdb, hdn;
            if (!decimal.TryParse(sl, out soluong))
            {
                errHangHoa.SetError(txt_SL, "Số lượng phải là một số!");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }
            if (!decimal.TryParse(giaban, out hdb))
            {
                errHangHoa.SetError(txt_GiaBan, "Giá bán phải là một số!");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }
            if (!decimal.TryParse(gianhap, out hdn))
            {
                errHangHoa.SetError(txt_GiaNhap, "Giá nhập phải là một số!");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (btn_HH_Them.Enabled == true)
            {
                sql = $"Select Count(*) From [HangHoa] Where MaHang = @mahang;";
                var parameters = new Dictionary<string, object>
                {
                    {"@mahang", mahang},
                };
                int count = Convert.ToInt32(_data.ExecuteScalar(sql, parameters));
                if (count > 0)
                {
                    MessageBox.Show($"Đã tồn tại mặt hàng với mã {mahang}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [HangHoa] (MaHang, TenHang, MaLoai, MaKhoiLuong, MaHangSX, MaChatLieu, MaCongDung," +
                      "MaMau, MaNuocSX, MaMua, SoLuong, DonGiaNhap, DonGiaBan, ThoiGianBaoHanh, GhiChu, Anh)";
                sql += "VALUES(@mahang,@tenhang, @maloai, @makl, @mahsx, @macl, @macd," +
                       "@mamau, @mansx, @mamua, @sl, @gianhap, @giaban, @bh, @ghichu, @anh);";
                parameters = new Dictionary<string, object>
                {
                    {"@mahang", mahang},
                    {"@tenhang", tenhang},
                    {"@maloai", maloai},
                    {"@makl", makl},
                    {"@mahsx", mahangsx},
                    {"@macl", macl},
                    {"@macd", macd},
                    {"@mamau", mamau},
                    {"@mansx", mansx},
                    {"@mamua", mamua},
                    {"@sl", sl},
                    {"@gianhap", gianhap},
                    {"@giaban", giaban},
                    {"@bh", bh},
                    {"@ghichu", ghichu},
                    {"@anh", anh},
                };
                _data.ExecuteNonQuery(sql, parameters);
            }


            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            if (btn_HH_Sua.Enabled == true)
            {
                sql = "Update [HangHoa] SET ";
                sql += "TenHang = @tenhang, " +
                       "MaLoai = @maloai," +
                       "MaKhoiLuong = @makl," +
                       "MaHangSX = @mahsx, " +
                       "MaChatLieu = @macl," +
                       "MaCongDung = @macd," +
                       "MaMau = @mamau," +
                       "MaNuocSX = @mansx," +
                       "MaMua = @mamua," +
                       "SoLuong = @sl," +
                       "DonGiaBan = @giaban," +
                       "DonGiaNhap = @gianhap," +
                       "ThoiGianBaoHanh = @bh," +
                       "GhiChu = @ghichu," +
                       "Anh = @anh";
                sql += " WHERE MaHang = @mahang";
                var parameters = new Dictionary<string, object>
                {
                    {"@mahang", mahang},
                    {"@tenhang", tenhang},
                    {"@maloai", maloai},
                    {"@makl", makl},
                    {"@mahsx", mahangsx},
                    {"@macl", macl},
                    {"@macd", macd},
                    {"@mamau", mamau},
                    {"@mansx", mansx},
                    {"@mamua", mamua},
                    {"@sl", sl},
                    {"@gianhap", gianhap},
                    {"@giaban", giaban},
                    {"@bh", bh},
                    {"@ghichu", ghichu},
                    {"@anh", anh},
                };
                _data.ExecuteNonQuery(sql, parameters);
            }
            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_HH_Xoa.Enabled == true)
            {
                sql = "Delete From [HangHoa] Where MaHang = @mahang";
                var parameters = new Dictionary<string, object>
                {
                    {"@mahang", mahang},
                };
                _data.ExecuteNonQuery(sql, parameters);
            }


            Load_HangHoa();

            ResetValueTextBox_HangHoa();
            Enable_HangHoa(false);
            lb_HH_TrangThai.Text = "";
            btn_HH_Them.Enabled = true;
            btn_HH_Xoa.Enabled = false;
            btn_HH_Sua.Enabled = false;
        }

        private void btn_HH_Huy_Click(object sender, EventArgs e)
        {
            lb_HH_TrangThai.Text = "";
            //Thiết lập lại các nút như ban đầu
            btn_HH_Xoa.Enabled = false;
            btn_HH_Sua.Enabled = false;
            btn_HH_Them.Enabled = true;
            //xoa trang
            ResetValueTextBox_HangHoa();
            //Cam nhap
            Enable_HangHoa(false);
        }
        
        private void btn_HH_Them_Click(object sender, EventArgs e)
        {
            lb_HH_TrangThai.Text = "*Bạn đang ở chế độ thêm!";
            ResetValueTextBox_HangHoa();
            Enable_HangHoa(true);
            btn_HH_Sua.Enabled = false;
            btn_HH_Xoa.Enabled = false;
        }

        private void btn_HH_Sua_Click(object sender, EventArgs e)
        {
            lb_HH_TrangThai.Text = "*Bạn đang ở chế độ sửa!";
            //Ẩn hai nút Thêm và Xoá
            btn_HH_Them.Enabled = false;
            btn_HH_Xoa.Enabled = false;
            //Hiện gropbox chi tiết
            Enable_HangHoa(true);
            txt_MaHang.Enabled = false;
        }

        private void btn_HH_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa mã mặt hàng " + txt_MaHang.Text +
                " không ? Nếu có ấn nút Lưu, không thì ấn nút Hủy", "Xóa sản phẩm",
                MessageBoxButtons.OK) == DialogResult.OK)
            {
                lb_HH_TrangThai.Text = "*Bạn đang ở chế độ xoá!";
                Enable_HangHoa(false);
                btn_HH_Them.Enabled = false;
                btn_HH_Sua.Enabled = false;
                btn_HH_Luu.Enabled = true;
                btn_HH_Huy.Enabled = true;
            }
        }
        
        private void btn_TaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";  // Chỉ cho phép chọn các file ảnh
            openFileDialog.Title = "Chọn ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị ảnh trong PictureBox
                pictureBox_AnhSP.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btn_HH_ChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            //Viet cau lenh SQL cho tim kiem
            String sql = "SELECT * FROM [HangHoa]";
            String dk = "";
            //Tim theo MaSP khac rong
            if (txt_TimKiem.Text.Trim() != "")
            {
                dk += " MaHang Like @mahang Or TenHang Like @tenhang";
            }
            //Ket hoi dk
            if (dk != "")
            {
                sql += " WHERE" + dk;
            }
            //Goi phương thức Load dữ liệu kết hợp điều kiện tìm kiếm
            var parameters = new Dictionary<string, object>
            {
                {"@mahang", "%" + txt_TimKiem.Text + "%"},
                {"@tenhang", "%" + txt_TimKiem.Text + "%"}
            };
            DataTable dtHangHoa = _data.ExecuteQuery(sql, parameters);
            if(dtHangHoa.Rows.Count > 0)
            {
                dtg_HangHoa.DataSource = dtHangHoa;
                dtg_HangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Không tìm thấy hàng hoá", "Thông báo", MessageBoxButtons.OK);
                Load_HangHoa();
            }
            dtHangHoa.Dispose();
        }

        private void ClearDataGrid(DataGridView gridView)
        {
            gridView.DataSource = null;
            gridView.Rows.Clear();
        }
    }
}
