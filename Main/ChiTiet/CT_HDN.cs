using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.ChiTiet
{
    public partial class CT_HDN : Form
    {
        ProcessDatabase _data;
        string CTHD_SoHDN;
        public CT_HDN(string SoHDN)
        {
            _data = new ProcessDatabase();
            CTHD_SoHDN = SoHDN;
            InitializeComponent();
        }
        private void CT_HDN_Load(object sender, EventArgs e)
        {
            //Load data thông tin chi tiết hoá đơn về nhân viên, khách hàng
            txt_SoHDN.Text = CTHD_SoHDN;
            string query = @"
                           SELECT nv.MaNV, nv.TenNV, ncc.MaNCC, ncc.TenNCC, ncc.DienThoai 
                           FROM [HoaDonNhap] hd
                           JOIN NhanVien nv ON hd.MaNV = nv.MaNV
                           JOIN NhaCungCap ncc ON hd.MaNCC = ncc.MaNCC
                           WHERE hd.SoHDN = @SoHDN";

            var parameters = new Dictionary<string, object>
            {
                { "@SoHDN", CTHD_SoHDN }
            };

            DataTable dataTable = _data.ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                // Đổ dữ liệu vào TextBox
                txt_MaNV.Text = dataTable.Rows[0]["MaNV"].ToString();
                txt_TenNV.Text = dataTable.Rows[0]["TenNV"].ToString();
                txt_MaNCC.Text = dataTable.Rows[0]["MaNCC"].ToString();
                txt_TenNCC.Text = dataTable.Rows[0]["TenNCC"].ToString();
                txt_SĐT.Text = dataTable.Rows[0]["DienThoai"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn.");
            }


            fill_HangHoa();
            resetValue();
            enableControls(false);
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void resetValue()
        {
            cb_MaHang.Text = string.Empty;
            txt_TenHang.Text = string.Empty;
            txt_SL.Text = string.Empty;
            txt_DonGia.Text = string.Empty;
            txt_GiamGia.Text = string.Empty;
            txt_ThanhTien.Text = string.Empty;
            lb_TrangThai.Text = string.Empty;
        }

        private void enableControls(bool enable)
        {
            cb_MaHang.Enabled = enable;
            txt_SL.Enabled = enable;
            txt_GiamGia.Enabled = enable;

            btn_Luu.Enabled = enable;
            btn_Huy.Enabled = enable;
        }

        private void Load_CTHDB()
        {
            string querry = "Select * From [ChiTietHDN] Where SoHDN = @sohdn";
            var parameters = new Dictionary<string, object>{
                {"@sohdn", CTHD_SoHDN},
            };
            DataTable dataTable = _data.ExecuteQuery(querry, parameters);
            dgv_ChiTiet.DataSource = dataTable;

            dgv_ChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTable.Dispose();
        }

        private void fill_HangHoa()
        {
            string query = "SELECT MaHang, TenHang, DonGiaBan FROM [HangHoa]";
            DataTable dataTable = _data.ExecuteQuery(query);

            cb_MaHang.DataSource = dataTable;
            cb_MaHang.DisplayMember = "MaHang"; // Tên cột hiển thị
            cb_MaHang.ValueMember = "MaHang";     // Tên cột giá trị
        }

        private void cb_MaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem mục đã chọn có hợp lệ không
            if (cb_MaHang.SelectedValue != null)
            {
                // Lấy hàng tương ứng với mã hàng được chọn từ DataSource của ComboBox
                DataRowView selectedRow = cb_MaHang.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    txt_TenHang.Text = selectedRow["TenHang"].ToString(); // Hiển thị tên hàng tương ứng
                    txt_DonGia.Text = selectedRow["DonGiaBan"].ToString(); // Hiển thị giá bán tương ứng
                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            enableControls(true);
            lb_TrangThai.Text = "Bạn đang ở chế độ Thêm";
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            enableControls(true);
            lb_TrangThai.Text = "Bạn đang ở chế độ Sửa";
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            enableControls(false);
            lb_TrangThai.Text = "Bạn đang ở chế độ Xoá";
            btn_Sua.Enabled = false;
            btn_Them.Enabled = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string sql = "";

            string mahang = cb_MaHang.SelectedValue.ToString();
            string sl = txt_SL.Text;
            string giamgia = txt_GiamGia.Text;
            string thanhtien = txt_ThanhTien.Text;

            //Kiểm tra dữ liệu số lượng
            int quantity;
            if (!int.TryParse(sl, out quantity))
            {
                errChiTiet.SetError(txt_SL, "Số Lượng phải là một số");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            //Kiểm tra giảm giá
            int discount;
            if (!int.TryParse(giamgia, out discount))
            {
                errChiTiet.SetError(txt_GiamGia, "Giảm giá phải là một số");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (btn_Them.Enabled == true)
            {

                sql = $"Select Count(*) From [CHiTietHDN] Where SoHDN = @sohdN;";
                var parameters = new Dictionary<string, object>
                {
                    {"@sohdn", CTHD_SoHDN},
                };
                int count = Convert.ToInt32(_data.ExecuteScalar(sql, parameters));
                if (count > 0)
                {
                    MessageBox.Show($"Đã tồn tại Hàng hoá với mã {mahang} tại hoá đơn {CTHD_SoHDN}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [ChiTietHDN] (MaHang, SoLuong, GiamGia, ThanhTien)";
                sql += $"VALUES(@mahang, @soluong, @giamgia, @thanhtien);";
                parameters = new Dictionary<string, object>
                {
                    {"@mahang", mahang},
                    {"@soluong", sl},
                    {"@giamgia", giamgia},
                    {"@thanhtien", thanhtien},
                };
                _data.ExecuteNonQuery(sql, parameters);
            }


            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            if (btn_Sua.Enabled == true)
            {
                sql = "Update [ChiTietHDN] SET ";
                sql += $"SoLuong = @soluong, GiamGia = @giamgia, ThanhTien = @thanhtien ";
                sql += $"WHERE SoHDN = @sohdn And MaHang = @mahang";
                var parameters = new Dictionary<string, object>
                {
                    {"@sohdn", CTHD_SoHDN },
                    {"@mahang", mahang},
                    {"@soluong", sl},
                    {"@giamgia", giamgia},
                    {"@thanhtien", thanhtien},

                };
                _data.ExecuteNonQuery(sql, parameters);
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_Xoa.Enabled == true)
            {
                sql = $"Delete From [ChiTietHDB] Where SoHDN = @sohdn And MaHang = @mahang";
                var parameters = new Dictionary<string, object>
                {
                    {"@sohdn", CTHD_SoHDN},
                    {"@mahang", mahang},
                };

                _data.ExecuteNonQuery(sql, parameters);
            }

            Load_CTHDB();

            resetValue();
            enableControls(false);
            lb_TrangThai.Text = "";
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            resetValue();
            enableControls(false);
            lb_TrangThai.Text = "";
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            string sl = txt_SL.Text;
            string giamgia = txt_GiamGia.Text;
            string thanhtien = txt_ThanhTien.Text;
            string dongia = txt_DonGia.Text;
            //Kiểm tra dữ liệu số lượng
            int quantity;
            if (!int.TryParse(sl, out quantity))
            {
                errChiTiet.SetError(txt_SL, "Số Lượng phải là một số");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            //Kiểm tra giảm giá
            int discount;
            if (giamgia.Trim().Length > 0)
            {
                if (!int.TryParse(giamgia, out discount))
                {
                    errChiTiet.SetError(txt_GiamGia, "Giảm giá phải là một số");
                    return;
                }
                else
                {
                    errChiTiet.Clear();
                }
            }
            else
            {
                discount = 0;
            }
            int price = Convert.ToInt32(dongia);
            int total = price * quantity * (100 - discount) / 100;
            txt_ThanhTien.Text = total.ToString();
        }
    }
}
