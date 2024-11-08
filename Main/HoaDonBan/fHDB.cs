using ClosedXML.Excel;
using Main.ChiTiet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Main.HoaDonBan
{
    public partial class fHDB : Form
    {
        ProcessDatabase _data;
        public fHDB()
        {
            _data = new ProcessDatabase();
            InitializeComponent();
        }

        private void fHDB_Load(object sender, EventArgs e)
        {
            fill_NhanVien();
            fill_KhachHang();

            Load_HDB();
            resetTextBox();
            enableControls(false);
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void Load_HDB()
        {
            string querry = "Select * from [HoaDonBan] ORDER BY NGAYBAN DESC";
            DataTable dataTable = _data.ExecuteQuery(querry);
            dgv_HDB.DataSource = dataTable;

            dgv_HDB.Columns["TongTien"].DefaultCellStyle.Format = "C0";
            dgv_HDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTable.Dispose();
        }

        private void fill_NhanVien()
        {
            string query = "SELECT MaNV, TenNV FROM [NhanVien]";
            DataTable dataTable = _data.ExecuteQuery(query);

            cb_MaNV.DataSource = dataTable;
            cb_MaNV.DisplayMember = "TenNV"; // Tên cột hiển thị
            cb_MaNV.ValueMember = "MaNV";     // Tên cột giá trị
        }
        
        private void fill_KhachHang()
        {
            string query = "SELECT MaKhach, TenKhach FROM [KhachHang]";
            DataTable dataTable = _data.ExecuteQuery(query);

            cb_MaKH.DataSource = dataTable;
            cb_MaKH.DisplayMember = "TenKhach"; // Tên cột hiển thị
            cb_MaKH.ValueMember = "MaKhach";     // Tên cột giá trị
        }

        private void resetTextBox()
        {
            txt_SoHDB.Text = "";
            cb_MaNV.Text = "";
            dtp_NgayBan.Value = DateTime.Now;
            cb_MaKH.Text = "";
            txt_TT.Text = "0";
        }

        private void enableControls(bool enable)
        {
            txt_SoHDB.Enabled = enable;
            cb_MaNV.Enabled = enable;
            dtp_NgayBan.Enabled = enable;
            cb_MaKH.Enabled = enable;
            txt_TT.Enabled = enable;

            btn_Luu.Enabled = enable;
            btn_Huy.Enabled = enable;
            btn_ChiTiet.Enabled = enable;
        }

        private void dgv_HDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                enableControls(false);
                btn_Them.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_ChiTiet.Enabled = true;
                DataGridViewRow row = dgv_HDB.Rows[e.RowIndex];
                txt_SoHDB.Text = row.Cells["SoHDB"].Value.ToString();
                cb_MaNV.SelectedValue = row.Cells["MaNV"].Value.ToString();
                dtp_NgayBan.Text = row.Cells["NgayBan"].Value.ToString();
                cb_MaKH.SelectedValue = row.Cells["MaKhach"].Value.ToString();
                txt_TT.Text = row.Cells["TongTien"].Value.ToString();
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
            btn_ChiTiet.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            lb_TrangThai.Text = "*Bạn đang ở chế dộ Sửa!";
            enableControls(true);
            txt_SoHDB.Enabled = false;
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa Hoá đơn bán có mã la " + txt_SoHDB.Text +
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

            string sohdb = txt_SoHDB.Text;
            string manv = cb_MaNV.SelectedValue.ToString();
            string makh = cb_MaKH.SelectedValue.ToString();
            string ngayban = dtp_NgayBan.Value.ToString("MM/dd/yyyy");
            string tongtien = txt_TT.Text;
            //Kiểm tra dữ liêu
            if (sohdb.Trim() == "")
            {
                errHDB.SetError(txt_SoHDB, "Mã không được để trống");
                return;
            }
            else
            {
                errHDB.Clear();
            }
            int total;
            if (!int.TryParse(tongtien, out total))
            {
                errHDB.SetError(txt_TT, "Tổng tiền phải là một số");
                return;
            }
            else
            {
                errHDB.Clear();
            }

            if (btn_Them.Enabled == true)
            {

                sql = $"Select Count(*) From [HoaDonBan] Where SoHDB = @sohdb;";
                var parameters = new Dictionary<string, object>
                {
                    {"@sohdb", sohdb},
                };
                int count = Convert.ToInt32(_data.ExecuteScalar(sql, parameters));
                if (count > 0)
                {
                    MessageBox.Show($"Đã tồn tại Hoá đơn bán với mã {sohdb}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [HoaDonBan] (SoHDB, MaNV, MaKhach, NgayBan, TongTien)";
                sql += $"VALUES(@sohdb, @manv, @makh, @ngayban, @tongtien);";
                parameters = new Dictionary<string, object>
                {
                    {"@sohdb", sohdb},
                    {"@manv", manv},
                    {"@ngayban", ngayban},
                    {"@makh", makh},
                    {"@tongtien", tongtien},
                };
                _data.ExecuteNonQuery(sql, parameters);
            }


            //Nếu nút Sửa enable TNSXì thực hiện cập nhật dữ liệu
            if (btn_Sua.Enabled == true)
            {
                sql = "Update [HoaDonBan] SET ";
                sql += $"MaNV = @manv, MaKhach = @makh, NgayBan = @ngayban, TongTien = @tongtien ";
                sql += $"WHERE SoHDB = @sohdb";
                var parameters = new Dictionary<string, object>
                {
                    {"@sohdb", sohdb},
                    {"@manv", manv},
                    {"@ngayban", ngayban},
                    {"@makh", makh},
                    {"@tongtien", tongtien},

                };
                _data.ExecuteNonQuery(sql, parameters);
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_Xoa.Enabled == true)
            {
                sql = $"Delete From [HoaDonBan] Where SoHDB = @sohdb";
                var parameters = new Dictionary<string, object>
                {
                    {"@sohdb", sohdb},

                };

                _data.ExecuteNonQuery(sql, parameters);
            }

            Load_HDB();

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

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            if(txt_SoHDB.Text.Trim() != null)
            {
                CT_HDB ctHDB = new CT_HDB(txt_SoHDB.Text);
                ctHDB.ShowDialog();
            }
        }

        private void btn_XuatFile_Click(object sender, EventArgs e)
        {
            // Sử dụng SaveFileDialog để cho phép người dùng chọn vị trí và tên tệp
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Chọn vị trí lưu file Excel";
                saveFileDialog.FileName = "DanhSachHoaDonBan.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Truy vấn tất cả hóa đơn, lấy thêm tháng và năm để nhóm
                    string invoiceQuery = @"
                    SELECT SoHDB, NgayBan, MaNV, MaKhach, TongTien, MONTH(NgayBan) AS Thang, YEAR(NgayBan) AS Nam 
                    FROM HoaDonBan
                    ORDER BY Nam, Thang";

                    DataTable dtAllInvoices = _data.ExecuteQuery(invoiceQuery);

                    // Nhóm dữ liệu theo tháng và năm
                    var groupedInvoices = dtAllInvoices.AsEnumerable()
                        .GroupBy(row => new { Thang = row.Field<int>("Thang"), Nam = row.Field<int>("Nam") });

                    // Tạo tệp Excel với ClosedXML
                    using (var workbook = new XLWorkbook())
                    {
                        foreach (var group in groupedInvoices)
                        {
                            int thang = group.Key.Thang;
                            int nam = group.Key.Nam;

                            // Tạo worksheet cho mỗi tháng
                            var worksheet = workbook.Worksheets.Add($"Thang_{thang}_{nam}");

                            // Tạo tiêu đề cột cho bảng hóa đơn
                            worksheet.Cell(1, 1).Value = "Danh sách hóa đơn";
                            for (int i = 0; i < dtAllInvoices.Columns.Count - 2; i++) // Bỏ cột Thang và Nam
                            {
                                worksheet.Cell(2, i + 1).Value = dtAllInvoices.Columns[i].ColumnName;
                            }

                            // Ghi dữ liệu hóa đơn vào worksheet
                            int rowIndex = 3;
                            foreach (var row in group)
                            {
                                for (int colIndex = 0; colIndex < dtAllInvoices.Columns.Count - 2; colIndex++)
                                {
                                    worksheet.Cell(rowIndex, colIndex + 1).Value = row[colIndex].ToString();
                                }

                                // Lấy mã hóa đơn để truy vấn chi tiết hóa đơn
                                string soHDB = row["SoHDB"].ToString();

                                // Truy vấn chi tiết hóa đơn cho mã hóa đơn hiện tại
                                string detailQuery = @"
                                SELECT MaHang, SoLuong, GiamGia, ThanhTien 
                                FROM ChiTietHDB
                                WHERE SoHDB = @SoHDB";
                                var detailParams = new Dictionary<string, object> { { "@SoHDB", soHDB } };
                                DataTable dtInvoiceDetails = _data.ExecuteQuery(detailQuery, detailParams);

                                // Ghi tiêu đề cột cho chi tiết hóa đơn bên dưới hóa đơn tương ứng
                                int detailStartRow = rowIndex + 1;
                                worksheet.Cell(detailStartRow, 1).Value = "Chi tiết hóa đơn: " + soHDB;
                                for (int j = 0; j < dtInvoiceDetails.Columns.Count; j++)
                                {
                                    worksheet.Cell(detailStartRow + 1, j + 1).Value = dtInvoiceDetails.Columns[j].ColumnName;
                                }

                                // Ghi dữ liệu chi tiết hóa đơn
                                int detailRowIndex = detailStartRow + 2;
                                foreach (DataRow detailRow in dtInvoiceDetails.Rows)
                                {
                                    for (int j = 0; j < dtInvoiceDetails.Columns.Count; j++)
                                    {
                                        worksheet.Cell(detailRowIndex, j + 1).Value = detailRow[j].ToString();
                                    }
                                    detailRowIndex++;
                                }

                                // Tăng hàng tiếp theo cho hóa đơn
                                rowIndex = detailRowIndex + 1;
                            }

                            // Tự động điều chỉnh kích thước cột
                            worksheet.Columns().AdjustToContents();
                        }

                        // Lưu workbook vào vị trí đã chọn
                        workbook.SaveAs(filePath);
                        MessageBox.Show("Xuất dữ liệu thành công! Tệp đã được lưu tại: " + filePath);
                    }
                }
            }
        }
    }
}
