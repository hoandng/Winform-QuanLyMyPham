using Main.HoaDonBan;
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

namespace Main.ChiTiet
{
    public partial class CT_HDB : Form
    {
        string CTHD_SoHDB = "";
        ProcessDatabase _data;
        public CT_HDB(string SoHDB)
        {
            CTHD_SoHDB =  SoHDB;
            _data = new ProcessDatabase();
            InitializeComponent();
        }

        private void CT_HDB_Load(object sender, EventArgs e)
        {

            //Load data thông tin chi tiết hoá đơn về nhân viên, khách hàng
            txt_SoHDB.Text = CTHD_SoHDB;
            string query = @"
                           SELECT nv.MaNV, nv.TenNV, kh.MaKhach, kh.TenKhach, kh.DienThoai 
                           FROM [HoaDonBan] hd
                           JOIN NhanVien nv ON hd.MaNV = nv.MaNV
                           JOIN KhachHang kh ON hd.MaKhach = kh.MaKhach
                           WHERE hd.SoHDB = @SoHDB";

            var parameters = new Dictionary<string, object>
            {
                { "@SoHDB", CTHD_SoHDB }
            };

            DataTable dataTable = _data.ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                // Đổ dữ liệu vào TextBox
                txt_MaNV.Text = dataTable.Rows[0]["MaNV"].ToString();
                txt_TenNV.Text = dataTable.Rows[0]["TenNV"].ToString();
                txt_MaKH.Text = dataTable.Rows[0]["MaKhach"].ToString();
                txt_TenKH.Text = dataTable.Rows[0]["TenKhach"].ToString();
                txt_SĐT.Text = dataTable.Rows[0]["DienThoai"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn.");
            }

            Load_CTHDB();
            fill_HangHoa();
            resetValue();
            enableControls(false);
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }
        private void resetValue()
        {
            cb_MaHang.Text = "";
            txt_TenHang.Text = "";
            txt_SL.Text = "1";
            txt_DonGia.Text = "";
            txt_GiamGia.Text = "0";
            txt_ThanhTien.Text = "";
            lb_TrangThai.Text = "";
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
            string querry = "Select * From [ChiTietHDB] Where SoHDB = @sohdb";
            var parameters = new Dictionary<string, object>{
                {"@sohdb", CTHD_SoHDB},
            };
            DataTable dataTable = _data.ExecuteQuery(querry, parameters);
            dgv_ChiTiet.DataSource = dataTable;
            dgv_ChiTiet.Columns["ThanhTien"].DefaultCellStyle.Format = "C0";

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

        private void UpdateTongTien_HDB()
        {
            string query = @"
            UPDATE [HoaDonBan]
            SET TongTien = (
                SELECT SUM(ThanhTien) 
                FROM [ChiTietHDB] cthd
                WHERE cthd.SoHDB = @sohdb
            )
            WHERE SoHDB = @sohdb";

            var parameters = new Dictionary<string, object>
            {
                { "@sohdb", CTHD_SoHDB },
            };
            _data.ExecuteQuery(query, parameters);
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
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
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

            // Kiểm tra dữ liệu số lượng
            int quantity;
            if (!int.TryParse(sl, out quantity) || quantity <= 0)
            {
                errChiTiet.SetError(txt_SL, "Số lượng phải là một số nguyên dương");
                return;
            }
            else
            {
                errChiTiet.SetError(txt_SL, "");
            }

            // Kiểm tra giảm giá
            int discount;
            if (giamgia.Trim().Length > 0)
            {
                if (!int.TryParse(giamgia, out discount) || discount < 0 || discount > 100)
                {
                    errChiTiet.SetError(txt_GiamGia, "Giảm giá phải là một số từ 0 đến 100");
                    return;
                }
                else
                {
                    errChiTiet.SetError(txt_GiamGia, "");
                }
            }
            else
            {
                discount = 0;
            }

            if (btn_Them.Enabled == true)
            {

                sql = $"Select Count(*) From [CHiTietHDB] Where SoHDB = @sohdb and MaHang = @mahang;";
                var parameters = new Dictionary<string, object>
                {
                    {"@sohdb", CTHD_SoHDB},
                    {"@mahang", mahang},
                };
                int count = Convert.ToInt32(_data.ExecuteScalar(sql, parameters));
                if (count > 0)
                {
                    MessageBox.Show($"Đã tồn tại Hàng hoá với mã {mahang} tại hoá đơn {CTHD_SoHDB}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [ChiTietHDB] (SoHDB, MaHang, SoLuong, GiamGia, ThanhTien)";
                sql += $"VALUES(@sohdb, @mahang, @soluong, @giamgia, @thanhtien);";
                parameters = new Dictionary<string, object>
                {
                    {"@sohdb", CTHD_SoHDB},
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
                sql = "Update [ChiTietHDB] SET ";
                sql += $"SoLuong = @soluong, GiamGia = @giamgia, ThanhTien = @thanhtien ";
                sql += $"WHERE SoHDB = @sohdb And MaHang = @mahang";
                var parameters = new Dictionary<string, object>
                {
                    {"@sohdb", CTHD_SoHDB },
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
                sql = $"Delete From [ChiTietHDB] Where SoHDB = @sohdb And MaHang = @mahang";
                var parameters = new Dictionary<string, object>
                {
                    {"@sohdb", CTHD_SoHDB},
                    {"@mahang", mahang},
                };

                _data.ExecuteNonQuery(sql, parameters);
            }

            Load_CTHDB();
            UpdateTongTien_HDB();

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
            btn_Xoa .Enabled = false;
        }

        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            string sl = txt_SL.Text;
            string giamgia = txt_GiamGia.Text;
            string dongia = txt_DonGia.Text;

            // Kiểm tra dữ liệu số lượng
            int quantity;
            if (!int.TryParse(sl, out quantity) || quantity <= 0)
            {
                errChiTiet.SetError(txt_SL, "Số lượng phải là một số nguyên dương");
                return;
            }
            else
            {
                errChiTiet.SetError(txt_SL, "");
            }

            // Kiểm tra đơn giá
            decimal price;
            if (!decimal.TryParse(dongia, out price) || price <= 0)
            {
                errChiTiet.SetError(txt_DonGia, "Đơn giá phải là một số dương");
                return;
            }
            else
            {
                errChiTiet.SetError(txt_DonGia, "");
            }

            // Kiểm tra giảm giá
            int discount;
            if (giamgia.Trim().Length > 0)
            {
                if (!int.TryParse(giamgia, out discount) || discount < 0 || discount > 100)
                {
                    errChiTiet.SetError(txt_GiamGia, "Giảm giá phải là một số từ 0 đến 100");
                    return;
                }
                else
                {
                    errChiTiet.SetError(txt_GiamGia, "");
                }
            }
            else
            {
                discount = 0;
            }

            // Tính tổng tiền
            try
            {
                // Sử dụng decimal cho các phép tính lớn
                decimal total = price * quantity * (100 - discount) / 100;
                txt_ThanhTien.Text = total.ToString(); // Hiển thị số tiền với dấu phân cách hàng nghìn
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgv_ChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                enableControls(false);
                btn_Them.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
                DataGridViewRow row = dgv_ChiTiet.Rows[e.RowIndex];
                cb_MaHang.Text = row.Cells["MaHang"].Value.ToString();
                txt_SL.Text = row.Cells["SoLuong"].Value.ToString();
                txt_GiamGia.Text = row.Cells["GiamGia"].Value.ToString();
                txt_ThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
