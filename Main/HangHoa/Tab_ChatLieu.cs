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
        private void Load_ChatLieu()
        {
            DataTable dt = _data.DocBang("Select * from [ChatLieu]");
            dtg_ChatLieu.DataSource = dt;
            dtg_ChatLieu.Columns[0].HeaderText = "Mã Chất liệu";
            dtg_ChatLieu.Columns[1].HeaderText = "Tên Chất liệu";

            dtg_ChatLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt.Dispose();
        }
        private void Enable_ChatLieu(Boolean hien)
        {
            txt_MCL.Enabled = hien;
            txt_TCL.Enabled = hien;
            btn_CL_Luu.Enabled = hien;
            btn_CL_Huy.Enabled = hien;
        }
        private void ResetValueTextBox_ChatLieu()
        {
            txt_MCL.Text = "";
            txt_TCL.Text = "";
            lb_Loai_TrangThai.Text = "";
        }
        private void tp_ChatLieu_Enter(object sender, EventArgs e)
        {
            Load_ChatLieu();
            Enable_ChatLieu(false);
            ResetValueTextBox_ChatLieu();
            lb_CL_TrangThai.Text = "";
            btn_CL_Them.Enabled = true;
            btn_CL_Sua.Enabled = false;
            btn_CL_Xoa.Enabled = false;
        }

        private void dtg_ChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_CL_Them.Enabled = true;
                btn_CL_Sua.Enabled = true;
                btn_CL_Xoa.Enabled = true;
                Enable_ChatLieu(false);
                DataGridViewRow row = dtg_ChatLieu.Rows[e.RowIndex];
                txt_MCL.Text = row.Cells["MaMau"].Value.ToString();
                txt_TCL.Text = row.Cells["TenMau"].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_CL_Them_Click(object sender, EventArgs e)
        {
            Enable_ChatLieu(true);
            ResetValueTextBox_ChatLieu();
            lb_CL_TrangThai.Text = "*Bạn đang ở chế dộ THÊM";
            btn_CL_Sua.Enabled = false;
            btn_CL_Xoa.Enabled = false;
        }

        private void btn_CL_Sua_Click(object sender, EventArgs e)
        {
            Enable_ChatLieu(true);
            lb_CL_TrangThai.Text = "*Bạn đang ở chế dộ SỬA";
            txt_MCL.Enabled = false;
            btn_CL_Them.Enabled = false;
            btn_CL_Xoa.Enabled = false;
        }

        private void btn_CL_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa chất liệu có mã la " + txt_MMau.Text +
               " không ? Nếu có ấn nút Lưu, không Thì ấn nút Hủy", "Xóa sản phẩm",
                MessageBoxButtons.OK) == DialogResult.OK)
            {
                Enable_ChatLieu(false);
                lb_CL_TrangThai.Text = "*Bạn đang ở chế dộ XOÁ";
                btn_CL_Them.Enabled = false;
                btn_CL_Sua.Enabled = false;
                btn_CL_Luu.Enabled = true;
                btn_CL_Huy.Enabled = true;
            }
        }

        private void btn_CL_Luu_Click(object sender, EventArgs e)
        {
            string sql = "";

            string ma = txt_MCL.Text;
            string ten = txt_TCL.Text;

            //Kiểm tra dữ liêu
            if (ma.Trim() == "")
            {
                errHangHoa.SetError(txt_MCL, "Mã không được để trống");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (ten.Trim() == "")
            {
                errHangHoa.SetError(txt_TCL, "Tên không được để trống");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (btn_CL_Them.Enabled == true)
            {

                sql = $"Select Count(*) From [ChatLieu] Where MaChatLieu ='{ma}';";
                DataTable dt = _data.DocBang(sql);
                if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show($"Đã tồn tại chất liệu với mã {ma}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [ChatLieu] (MaChatLieu, TenChatLieu)";
                sql += $"VALUES('{ma}', N'{ten}');";
            }


            //Nếu nút Sửa enable TNSXì thực hiện cập nhật dữ liệu
            if (btn_CL_Sua.Enabled == true)
            {
                sql = "Update [ChatLieu] SET ";
                sql += $"TenChatLieu = N'{ten}'";
                sql += $"WHERE MaChatLieu = '{ma}'";
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_CL_Xoa.Enabled == true)
            {
                sql = $"Delete From [MauSac] Where MaChatLieu = '{ma}'";
            }

            _data.CapNhatDuLieu(sql);

            Load_ChatLieu();

            ResetValueTextBox_ChatLieu();
            Enable_ChatLieu(false);
            lb_CL_TrangThai.Text = "";
            btn_CL_Them.Enabled = true;
            btn_CL_Xoa.Enabled = false;
            btn_CL_Sua.Enabled = false;
        }

        private void btn_CL_Huy_Click(object sender, EventArgs e)
        {
            lb_CL_TrangThai.Text = "";
            btn_CL_Xoa.Enabled = false;
            btn_CL_Sua.Enabled = false;
            btn_CL_Them.Enabled = true;
            ResetValueTextBox_ChatLieu();
            Enable_ChatLieu(false);
        }

    }
}
