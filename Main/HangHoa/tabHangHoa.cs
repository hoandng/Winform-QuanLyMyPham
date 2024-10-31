using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.HangHoa
{
    partial class HangHoa : Form
    {
        ProcessDatabase _data = new ProcessDatabase();
        private void Load_HangHoa()
        {
            DataTable dtHangHoa = _data.DocBang("Select * from [HangHoa]");
            dtg_HangHoa.DataSource = dtHangHoa;

            dtg_HangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_HangHoa.Columns[0].HeaderText = "Mã Hàng";
            dtg_HangHoa.Columns[1].HeaderText = "Tên Hàng";
            dtg_HangHoa.Columns[2].HeaderText = "Mã Loại";
            dtg_HangHoa.Columns[3].HeaderText = "Mã Khối Lượng";
            dtg_HangHoa.Columns[4].HeaderText = "Mã Hãng SX";
            dtg_HangHoa.Columns[5].HeaderText = "Mã Chất Liệu";
            dtg_HangHoa.Columns[6].HeaderText = "Mã Công dụng";
            dtg_HangHoa.Columns[7].HeaderText = "Mã Màu";
            dtg_HangHoa.Columns[8].HeaderText = "Mã Nước SX";
            dtg_HangHoa.Columns[9].HeaderText = "Mã Mùa";
            dtg_HangHoa.Columns[10].HeaderText = "Số lượng";
            dtg_HangHoa.Columns[11].HeaderText = "Đơn giá nhập";
            dtg_HangHoa.Columns[12].HeaderText = "Đơn giá bán";
            dtg_HangHoa.Columns[13].HeaderText = "Ảnh";
            dtg_HangHoa.Columns[14].HeaderText = "Ghi chú";

            dtg_HangHoa.VirtualMode = true;
            dtg_HangHoa.BackgroundColor = Color.LightBlue;
            dtHangHoa.Dispose();
        }
        private void tp_HangHoa_Enter(object sender, EventArgs e)
        {
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

        private void tp_HangHoa_Leave(object sender, EventArgs e)
        {


        }
        private void Enable_HangHoa(Boolean hien)
        {
            txt_MaHang.Enabled = hien;
            txt_TenHang.Enabled = hien;
            txt_MaHangSX.Enabled = hien;
            txt_MaLoai.Enabled = hien;
            txt_MaMau.Enabled = hien;
            txt_MaKL.Enabled = hien;
            txt_MaCL.Enabled = hien;
            txt_MaCD.Enabled = hien;
            txt_MaNSX.Enabled = hien;
            txt_SL.Enabled = hien;
            txt_MaMua.Enabled = hien;
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
            txt_MaHangSX.Text = "";
            txt_MaLoai.Text = "";
            txt_MaMau.Text = "";
            txt_MaKL.Text = "";
            txt_MaCL.Text = "";
            txt_MaCD.Text = "";
            txt_MaNSX.Text = "";
            txt_SL.Text = "0";
            txt_MaMua.Text = "";
            txt_BH.Text = "";
            txt_GiaBan.Text = "0";
            txt_GiaNhap.Text = "0";
            txt_GhiChu.Text = "";
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
                txt_MaHang.Text = row.Cells["MaHang"].Value.ToString();
                txt_TenHang.Text = row.Cells["TenHang"].Value.ToString();
                txt_MaLoai.Text = row.Cells["MaLoai"].Value.ToString();
                txt_MaKL.Text = row.Cells["MaKhoiLuong"].Value.ToString();
                txt_MaHangSX.Text = row.Cells["MaHangSX"].Value.ToString();
                txt_MaCL.Text = row.Cells["MaChatLieu"].Value.ToString();
                txt_MaCD.Text = row.Cells["MaCongDung"].Value.ToString();
                txt_MaMau.Text = row.Cells["MaMau"].Value.ToString();
                txt_MaNSX.Text = row.Cells["MaNuocSX"].Value.ToString();
                txt_MaMua.Text = row.Cells["MaMua"].Value.ToString();
                txt_SL.Text = row.Cells["SoLuong"].Value.ToString();
                txt_BH.Text = row.Cells["ThoiGianBaoHanh"].Value.ToString();
                txt_GiaBan.Text = row.Cells["DonGiaBan"].Value.ToString();
                txt_GiaNhap.Text = row.Cells["DonGiaNhap"].Value.ToString();
                txt_GhiChu.Text = row.Cells["GhiChu"].Value.ToString();
                pictureBox_AnhSP.ImageLocation = row.Cells["Anh"].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_HH_Luu_Click(object sender, EventArgs e)
        {
            string sql = "";

            string mahang = txt_MaHang.Text;
            string tenhang = txt_TenHang.Text;
            string mahangsx = txt_MaHangSX.Text;
            string maloai = txt_MaLoai.Text;
            string mamau = txt_MaMau.Text;
            string makl = txt_MaKL.Text;
            string macl = txt_MaCL.Text;
            string macd = txt_MaCD.Text;
            string mansx = txt_MaNSX.Text;
            string sl = txt_SL.Text;
            string mamua = txt_MaMua.Text;
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
                sql = $"Select Count(*) From [HangHoa] Where MaHang ='{mahang}';";
                DataTable dt = _data.DocBang(sql);
                if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show($"Đã tồn tại mặt hàng với mã {mahang}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [HangHoa] (MaHang, TenHang, MaLoai, MaKhoiLuong, MaHangSX, MaChatLieu," +
                      " MaCongDung, MaMau, MaNuocSX, MaMua, SoLuong, DonGiaNhap, DonGiaBan, ThoiGianBaoHanh, GhiChu, Anh)";
                sql += $"VALUES('{mahang}' ,N'{tenhang}', '{maloai}', '{makl}', '{mahangsx}', '{macl}', '{macd}'," +
                       $"'{mamau}', '{mansx}', '{mamua}', '{sl}', '{gianhap}', '{giaban}', '{bh}', N'{ghichu}', '{anh}');";
            }


            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            if (btn_HH_Sua.Enabled == true)
            {
                sql = "Update [HangHoa] SET ";
                sql += $"TenHang = N'{tenhang}', MaLoai = '{maloai}', MaKhoiLuong = '{makl}', MaHangSX = '{mahangsx}', " +
                       $"MaChatLieu = '{macl}', MaCongDung = '{macd}', MaMau = '{mamau}', MaNuocSX = '{mansx}', MaMua = '{mamua}'," +
                       $" SoLuong = '{sl}', DonGiaBan = '{giaban}', DonGiaNhap = '{gianhap}', ThoiGianBaoHanh = '{bh}', GhiChu = N'{ghichu}', Anh = '{anh}'";
                sql += $"WHERE MaHang = '{mahang}'";
            }
            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_HH_Xoa.Enabled == true)
            {
                sql = $"Delete From [HangHoa] Where MaHang = '{mahang}'";
            }

            _data.CapNhatDuLieu(sql);

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
        private void ClearDataGrid(DataGridView gridView)
        {
            gridView.DataSource = null;
            gridView.Rows.Clear();
        }
    }
}
