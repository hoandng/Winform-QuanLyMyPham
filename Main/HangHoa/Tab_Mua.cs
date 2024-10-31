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
        private void Load_Mua()
        {
            DataTable dt = _data.DocBang("Select * from [Mua]");
            dtg_Mua.DataSource = dt;
            dtg_Mua.Columns[0].HeaderText = "Mã Mùa";
            dtg_Mua.Columns[1].HeaderText = "Tên Mùa";

            dtg_Mua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt.Dispose();
        }
        private void Enable_Mua(Boolean hien)
        {
            txt_MMua.Enabled = hien;
            txt_TMua.Enabled = hien;
            btn_Mua_Luu.Enabled = hien;
            btn_Mua_Huy.Enabled = hien;
        }
        private void ResetValueTextBox_Mua()
        {
            txt_MMua.Text = "";
            txt_TMua.Text = "";
            lb_Mua_TrangThai.Text = "";
        }
        private void tp_Mua_Enter(object sender, EventArgs e)
        {
            Load_Mua();
            Enable_Mua(false);
            ResetValueTextBox_Mua();
            lb_Mua_TrangThai.Text = "";
            btn_Mua_Them.Enabled = true;
            btn_Mua_Sua.Enabled = false;
            btn_Mua_Xoa.Enabled = false;
        }

        private void dtg_Mua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_Mua_Them.Enabled = true;
                btn_Mua_Sua.Enabled = true;
                btn_Mua_Xoa.Enabled = true;
                Enable_Mua(false);
                DataGridViewRow row = dtg_Mua.Rows[e.RowIndex];
                txt_MMua.Text = row.Cells["MaMua"].Value.ToString();
                txt_TMua.Text = row.Cells["TenMua"].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_Mua_Them_Click(object sender, EventArgs e)
        {
            Enable_Mua(true);
            ResetValueTextBox_Mua();
            lb_Mua_TrangThai.Text = "*Bạn đang ở chế dộ THÊM";
            btn_Mua_Sua.Enabled = false;
            btn_Mua_Xoa.Enabled = false;
        }

        private void btn_Mua_Sua_Click(object sender, EventArgs e)
        {
            Enable_Mua(true);
            lb_Mua_TrangThai.Text = "*Bạn đang ở chế dộ SỬA";
            txt_MMua.Enabled = false;
            btn_Mua_Them.Enabled = false;
            btn_Mua_Xoa.Enabled = false;
        }

        private void btn_Mua_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa mùa có mã la " + txt_MMua.Text +
               " không ? Nếu có ấn nút Lưu, không Thì ấn nút Hủy", "Xóa sản phẩm",
                MessageBoxButtons.OK) == DialogResult.OK)
            {
                Enable_Mua(false);
                lb_Mua_TrangThai.Text = "*Bạn đang ở chế dộ XOÁ";
                btn_Mua_Them.Enabled = false;
                btn_Mua_Sua.Enabled = false;
                btn_Mua_Luu.Enabled = true;
                btn_Mua_Huy.Enabled = true;
            }
        }

        private void btn_Mua_Luu_Click(object sender, EventArgs e)
        {
            string sql = "";

            string ma = txt_MMua.Text;
            string ten = txt_TMua.Text;

            //Kiểm tra dữ liêu
            if (ma.Trim() == "")
            {
                errHangHoa.SetError(txt_MMua, "Mã không được để trống");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (ten.Trim() == "")
            {
                errHangHoa.SetError(txt_TMua, "Tên không được để trống");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (btn_Mua_Them.Enabled == true)
            {
                sql = $"Select Count(*) From [Mua] Where MaMua ='{ma}';";
                DataTable dt = _data.DocBang(sql);
                if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show($"Đã tồn tại mùa với mã {ma}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [Mua] (MaMua, TenMua)";
                sql += $"VALUES('{ma}', N'{ten}');";
            }


            //Nếu nút Sửa enable TNSXì thực hiện cập nhật dữ liệu
            if (btn_Mua_Sua.Enabled == true)
            {
                sql = "Update [Mua] SET ";
                sql += $"TenMua = N'{ten}'";
                sql += $"WHERE MaMua = '{ma}'";
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_Mua_Xoa.Enabled == true)
            {
                sql = $"Delete From [Mua] Where MaMua = '{ma}'";
            }

            _data.CapNhatDuLieu(sql);

            Load_Mua();

            ResetValueTextBox_Mua();
            Enable_Mua(false);
            lb_Mua_TrangThai.Text = "";
            btn_Mua_Them.Enabled = true;
            btn_Mua_Xoa.Enabled = false;
            btn_Mua_Sua.Enabled = false;
        }

        private void btn_Mua_Huy_Click(object sender, EventArgs e)
        {
            lb_Mua_TrangThai.Text = "";
            btn_Mua_Xoa.Enabled = false;
            btn_Mua_Sua.Enabled = false;
            btn_Mua_Them.Enabled = true;
            ResetValueTextBox_Mua();
            Enable_Mua(false);
        }
    }
}
