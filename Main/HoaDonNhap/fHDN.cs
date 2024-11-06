using ClosedXML.Excel;
using Main.ChiTiet;
using Main.HoaDonBan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Main.HoaDonNhap
{
    public partial class fHDN : Form
    {
        ProcessDatabase _data;
        public fHDN()
        {
            _data = new ProcessDatabase();
            InitializeComponent();
        }
        private void fHDN_Load(object sender, EventArgs e)
        {
            Load_HDN();
            resetTextBox();
            enableControls(false);
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_ChiTiet.Enabled = false;
        }

        private void Load_HDN()
        {
            string querry = "Select * from [HoaDonNhap]";
            DataTable dataTable = _data.ExecuteQuery(querry);
            dgv_HDN.DataSource = dataTable;

            dgv_HDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTable.Dispose();
        }

        private void resetTextBox()
        {
            txt_SoHDN.Text = "";
            txt_MaNV.Text = "";
            dtp_NgayNhap.Value = DateTime.Now;
            txt_MaNCC.Text = "";
            txt_TT.Text = "";
        }

        private void enableControls(bool enable)
        {
            txt_SoHDN.Enabled = enable;
            txt_MaNV.Enabled = enable;
            dtp_NgayNhap.Enabled = enable;
            txt_MaNCC.Enabled = enable;
            txt_TT.Enabled = enable;

            btn_Luu.Enabled = enable;
            btn_Huy.Enabled = enable;
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
                DataGridViewRow row = dgv_HDN.Rows[e.RowIndex];
                txt_SoHDN.Text = row.Cells["SoHDN"].Value.ToString();
                txt_MaNV.Text = row.Cells["MaNV"].Value.ToString();
                dtp_NgayNhap.Text = row.Cells["NgayNhap"].Value.ToString();
                txt_MaNCC.Text = row.Cells["MaNCC"].Value.ToString();
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
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            lb_TrangThai.Text = "*Bạn đang ở chế dộ Sửa!";
            enableControls(true);
            txt_SoHDN.Enabled = false;
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa Hoá đơn nhập có mã la " + txt_SoHDN.Text +
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

            string sohdn = txt_SoHDN.Text;
            string manv = txt_MaNV.Text;
            string mancc = txt_MaNCC.Text;
            string ngaynhap = dtp_NgayNhap.Value.ToString("MM/dd/yyyy");
            string tongtien = txt_TT.Text;
            //Kiểm tra dữ liêu
            if (sohdn.Trim() == "")
            {
                errHDB.SetError(txt_SoHDN, "Mã không được để trống");
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

                sql = $"Select Count(*) From [HoaDonNhap] Where SoHDN = @sohdn;";
                var parameters = new Dictionary<string, object>
                {
                    {"@sohdn", sohdn},

                };
                int count = Convert.ToInt32(_data.ExecuteScalar(sql, parameters));
                if (count > 0)
                {
                    MessageBox.Show($"Đã tồn tại Hoá đơn nhập với mã {sohdn}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [HoaDonNhap] (SoHDN, MaNV, MaNCC, NgayNhap, TongTien)";
                sql += "VALUES(@sohdn, @manv, @mancc, @ngaynhap, @tongtien);";
                parameters = new Dictionary<string, object>
                {
                    {"@sohdn", sohdn},
                    {"@manv", manv},
                    {"@ngaynhap", ngaynhap},
                    {"@mancc", mancc},
                    {"@tongtien", tongtien},

                };
                _data.ExecuteNonQuery(sql,parameters);
            }


            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            if (btn_Sua.Enabled == true)
            {
                sql = "Update [HoaDonNhap] SET ";
                sql += $"MaNV = @manv, MaNCC = @mancc, NgayNhap = @ngaynhap, TongTien = @tongtien ";
                sql += $"WHERE SoHDN = @sohdn";
                var parameters = new Dictionary<string, object>
                {
                    {"@sohdn", sohdn},
                    {"@manv", manv},
                    {"@ngaynhap", ngaynhap},
                    {"@mancc", mancc},
                    {"@tongtien", tongtien},

                };
                _data.ExecuteNonQuery(sql, parameters);
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_Xoa.Enabled == true)
            {
                sql = $"Delete From [HoaDonNhap] Where SoHDN = @sohdn";
                var parameters = new Dictionary<string, object>
                {
                    {"@sohdn", sohdn},
                };
                _data.ExecuteNonQuery(sql, parameters);
            }

            Load_HDN();

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
            btn_ChiTiet.Enabled = false;
            resetTextBox();
            enableControls(false);
        }

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            if(txt_SoHDN.Text.Trim() != null)
            {
                CT_HDN ct = new CT_HDN(txt_SoHDN.Text);
                ct.ShowDialog();
            }
        }

        private void btn_XuatFile_Click(object sender, EventArgs e)
        {
            // Sử dụng SaveFileDialog để cho phép người dùng chọn vị trí và tên tệp
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Chọn vị trí lưu file Excel";
                saveFileDialog.FileName = "DanhSachHoaDonNhap.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Truy vấn tất cả hóa đơn, lấy thêm tháng và năm để nhóm
                    string invoiceQuery = @"
                    SELECT SoHDN, NgayNhap, MaNV, MaNCC, TongTien, MONTH(NgayNhap) AS Thang, YEAR(NgayNhap) AS Nam 
                    FROM HoaDonNhap
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
                                string soHDN = row["SoHDN"].ToString();

                                // Truy vấn chi tiết hóa đơn cho mã hóa đơn hiện tại
                                string detailQuery = @"
                                SELECT MaHang, SoLuong, GiamGia, ThanhTien 
                                FROM ChiTietHDN
                                WHERE SoHDN = @SoHDN";
                                var detailParams = new Dictionary<string, object> { { "@SoHDN", soHDN } };
                                DataTable dtInvoiceDetails = _data.ExecuteQuery(detailQuery, detailParams);

                                // Ghi tiêu đề cột cho chi tiết hóa đơn bên dưới hóa đơn tương ứng
                                int detailStartRow = rowIndex + 1;
                                worksheet.Cell(detailStartRow, 1).Value = "Chi tiết hóa đơn: " + soHDN;
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
