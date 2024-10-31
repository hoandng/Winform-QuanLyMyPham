using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.HangHoa
{
    partial class HangHoa : Form
    {
        private void Load_Mau()
        {
            DataTable dt = _data.DocBang("Select * from [MauSac]");
            dtg_Mau.DataSource = dt;
            dtg_Mau.Columns[0].HeaderText = "Mã Màu";
            dtg_Mau.Columns[1].HeaderText = "Tên Màu";

            dtg_Mau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt.Dispose();
        }
        private void Enable_Mau(Boolean hien)
        {
            txt_MMau.Enabled = hien;
            txt_TMau.Enabled = hien;
            btn_Mau_Luu.Enabled = hien;
            btn_Mau_Huy.Enabled = hien;
        }
        private void ResetValueTextBox_Mau()
        {
            txt_MMau.Text = "";
            txt_TMau.Text = "";
            lb_Mau_TrangThai.Text = "";
        }
        private void tp_Mau_Enter(object sender, EventArgs e)
        {
            Load_Mau();
            Enable_Mau(false);
            ResetValueTextBox_Mau();
            lb_Mau_TrangThai.Text = "";
            btn_Mau_Them.Enabled = true;
            btn_Mau_Sua.Enabled = false;
            btn_Mau_Xoa.Enabled = false;
        }

        private void tp_Mau_Leave(object sender, EventArgs e)
        {
        }
        private void dtg_Mau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_Mau_Them.Enabled = true;
                btn_Mau_Sua.Enabled = true;
                btn_Mau_Xoa.Enabled = true;
                Enable_Mau(false);
                DataGridViewRow row = dtg_Mau.Rows[e.RowIndex];
                txt_MMau.Text = row.Cells["MaMau"].Value.ToString();
                txt_TMau.Text = row.Cells["TenMau"].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_Mau_Them_Click(object sender, EventArgs e)
        {
            Enable_Mau(true);
            ResetValueTextBox_Mau();
            lb_Mau_TrangThai.Text = "*Bạn đang ở chế dộ THÊM";
            btn_Mau_Sua.Enabled = false;
            btn_Mau_Xoa.Enabled = false;
        }

        private void btn_Mau_Sua_Click(object sender, EventArgs e)
        {
            Enable_Mau(true);
            lb_Mau_TrangThai.Text = "*Bạn đang ở chế dộ SỬA";
            txt_MMau.Enabled = false;
            btn_Mau_Them.Enabled = false;
            btn_Mau_Xoa.Enabled = false;
        }

        private void btn_Mau_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa màu có mã la " + txt_MMau.Text +
               " không ? Nếu có ấn nút Lưu, không Thì ấn nút Hủy", "Xóa sản phẩm",
                MessageBoxButtons.OK) == DialogResult.OK)
            {
                Enable_Mau(false);
                lb_Mau_TrangThai.Text = "*Bạn đang ở chế dộ XOÁ";
                btn_Mau_Them.Enabled = false;
                btn_Mau_Sua.Enabled = false;
                btn_Mau_Luu.Enabled = true;
                btn_Mau_Huy.Enabled = true;
            }
        }

        private void btn_Mau_Thoat_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mau_Luu_Click(object sender, EventArgs e)
        {
            string sql = "";

            string ma = txt_MMau.Text;
            string ten = txt_TMau.Text;

            //Kiểm tra dữ liêu
            if (ma.Trim() == "")
            {
                errHangHoa.SetError(txt_MMau, "Mã không được để trống");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (ten.Trim() == "")
            {
                errHangHoa.SetError(txt_TMau, "Tên không được để trống");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (btn_Mau_Them.Enabled == true)
            {
                sql = $"Select Count(*) From [MauSac] Where MaMau ='{ma}';";
                DataTable dt = _data.DocBang(sql);
                if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show($"Đã tồn tại màu với mã {ma}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [MauSac] (MaMau, TenMau)";
                sql += $"VALUES('{ma}', N'{ten}');";
            }


            //Nếu nút Sửa enable TNSXì thực hiện cập nhật dữ liệu
            if (btn_Mau_Sua.Enabled == true)
            {
                sql = "Update [MauSac] SET ";
                sql += $"TenMau = N'{ten}'";
                sql += $"WHERE MaMau = '{ma}'";
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_Mau_Xoa.Enabled == true)
            {
                sql = $"Delete From [MauSac] Where MaMau = '{ma}'";
            }

            _data.CapNhatDuLieu(sql);

            Load_Mau();

            ResetValueTextBox_Mau();
            Enable_Mau(false);
            lb_Mau_TrangThai.Text = "";
            btn_Mau_Them.Enabled = true;
            btn_Mau_Xoa.Enabled = false;
            btn_Mau_Sua.Enabled = false;
        }

        private void btn_Mau_Huy_Click(object sender, EventArgs e)
        {
            lb_Mau_TrangThai.Text = "";
            btn_Mau_Xoa.Enabled = false;
            btn_Mau_Sua.Enabled = false;
            btn_Mau_Them.Enabled = true;
            ResetValueTextBox_Mau();
            Enable_Mau(false);
        }

    }
}
