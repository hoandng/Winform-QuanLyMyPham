using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.NhanVien
{
    partial class NhanVien : Form
    {
        ProcessDatabase _database = new ProcessDatabase();
        
        private void Load_NhanVien()
        {
            DataTable dtNhanVien = _database.DocBang("Select * from [NhanVien]");
            dtg_NhanVien.DataSource = dtNhanVien;
            dtNhanVien.Dispose();
        }

        private void resetTextBox()
        {
            txt_MaNV.Text = "";
            txt_TenNV.Text = "";
            txt_MaCV.Text = "";
            txt_SDT.Text = "";
            cb_GioiTinh.Text = "";
            dtp_NgaySinh.Value = DateTime.Now;
            txt_DiaChi.Text = "";
        }
        private void enableControl(bool enable)
        {
            txt_MaNV.Enabled = enable;
            txt_TenNV.Enabled = enable;
            txt_MaCV.Enabled = enable;
            txt_SDT.Enabled = enable;
            dtp_NgaySinh.Enabled = enable;
            txt_DiaChi.Enabled = enable;
            cb_GioiTinh.Enabled = enable;

            btn_NV_Luu.Enabled = enable;
            btn_NV_Huy.Enabled = enable;
        }
        private void tp_NhanVien_Enter(object sender, EventArgs e)
        {
            Load_NhanVien();
            resetTextBox();
            enableControl(false);
        }

        private void dtg_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                enableControl(false);
                btn_NV_Them.Enabled = true;
                btn_NV_Sua.Enabled = true;
                btn_NV_Xoa.Enabled = true;
                DataGridViewRow row = dtg_NhanVien.Rows[e.RowIndex];
                txt_MaNV.Text = row.Cells["MaNV"].Value.ToString();
                txt_TenNV.Text = row.Cells["TenNV"].Value.ToString();
                cb_GioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                dtp_NgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txt_SDT.Text = row.Cells["DienThoai"].Value.ToString();
                txt_MaCV.Text = row.Cells["MaCV"].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_NV_Them_Click(object sender, EventArgs e)
        {
            resetTextBox();
            enableControl(true);

            btn_NV_Sua.Enabled = false;
            btn_NV_Xoa.Enabled = false;
            lb_NV_TrangThai.Text = "*Bạn đang ở chế độ Thêm!";
        }

        private void btn_NV_Sua_Click(object sender, EventArgs e)
        {
            resetTextBox();
            enableControl(true);

            btn_NV_Them.Enabled = false;
            btn_NV_Xoa.Enabled=false;
            lb_NV_TrangThai.Text = "*Bạn đang ở chế độ Sửa!";
        }

        private void btn_NV_Xoa_Click(object sender, EventArgs e)
        {
            resetTextBox();
            enableControl(true);

            btn_NV_Them.Enabled = false;
            btn_NV_Sua.Enabled = false;
            lb_NV_TrangThai.Text = "*Bạn đang ở chế độ Xoá!";
        }

        private void btn_NV_Luu_Click(object sender, EventArgs e)
        {
            string sql = "";

            string ma = txt_MaNV.Text;
            string ten = txt_TenNV.Text;
            string diachi = txt_DiaChi.Text;
            string sdt = txt_SDT.Text;
            string macv = txt_MaCV.Text;
            string ngaysinh = dtp_NgaySinh.Value.ToString("MM/dd/yyyy");
            string gioitinh = cb_GioiTinh.Text;

            //Kiểm tra mã và tên nhân viên có trống không
            if (ma.Trim() == "")
            {
                errNhanVien.SetError(txt_MaNV, "Mã không được để trống");
                return;
            }
            else
            {
                errNhanVien.Clear();
            }

            if (ten.Trim() == "")
            {
                errNhanVien.SetError(txt_MaNV, "Tên không được để trống");
                return;
            }
            else
            {
                errNhanVien.Clear();
            }

            // Kiểm tra giới tính có đúng không
            if (!string.Equals(gioitinh, "Nam", StringComparison.OrdinalIgnoreCase) 
                && !string.Equals(gioitinh, "Nữ", StringComparison.OrdinalIgnoreCase))
            {
                errNhanVien.SetError(cb_GioiTinh, "Chọn đúng giới tính Nam hoặc Nữ");
                return;
            }
            else
            {
                errNhanVien.Clear();
            }

            // Kiểm tra định dạng ngày sinh
            DateTime dob;
            if (!DateTime.TryParse(ngaysinh, out dob))
            {
                errNhanVien.SetError(dtp_NgaySinh, "Nhập đúng định dạng ngày tháng");
                return;
            }
            else
            {
                errNhanVien.Clear();
            }

            // Kiểm tra định dạng số điện thoại
            int sodienthoai;
            if (!int.TryParse(sdt, out sodienthoai))
            {
                errNhanVien.SetError(txt_SDT, "Số điện thoại phải là một số");
                return;
            }
            else
            {
                errNhanVien.Clear();
            }
            if (sdt.Length != 10)
            {
                errNhanVien.SetError(txt_SDT, "Số điện thoại phải là 10 số");
                return;
            }
            else
            {
                errNhanVien.Clear();
            }

            if (btn_NV_Them.Enabled == true)
            {

                sql = $"Select Count(*) From [NhanVien] Where MaNV ='{ma}';";
                DataTable dt = _database.DocBang(sql);
                if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show($"Đã tồn tại Nhân viên với mã {ma}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [NhanVien] (MaNV, TenNV, GioiTinh, NgaySinh, DienThoai, DiaChi, MaCV)";
                sql += $"VALUES('{ma}', N'{ten}', N'{gioitinh}', '{dob}', '{sdt}', N'{diachi}', '{macv}');";
            }


            //Nếu nút Sửa enable TNSXì thực hiện cập nhật dữ liệu
            if (btn_NV_Sua.Enabled == true)
            {
                sql = "Update [NhanVien] SET ";
                sql += $"TenNV = N'{ten}', GioiTinh = N'{gioitinh}', NgaySinh = '{dob}', DienThoai = '{sdt}', DiaChi = N'{diachi}', MaCV = '{macv}'";
                sql += $"WHERE MaNV = '{ma}'";
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_NV_Xoa.Enabled == true)
            {
                sql = $"Delete From [NhanVien] Where MaNV = '{ma}'";
            }

            _database.CapNhatDuLieu(sql);

            Load_NhanVien();

            resetTextBox();
            enableControl(false);
            lb_NV_TrangThai.Text = "";
            btn_NV_Them.Enabled = true;
            btn_NV_Xoa.Enabled = false;
            btn_NV_Sua.Enabled = false;
        }

        private void btn_NV_Huy_Click(object sender, EventArgs e)
        {
            lb_NV_TrangThai.Text = "";
            btn_NV_Xoa.Enabled = false;
            btn_NV_Sua.Enabled = false;
            btn_NV_Them.Enabled = true;
            resetTextBox();
            enableControl(false);
        }

    }
}
