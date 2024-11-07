﻿using System;
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
        private void Load_ChatLieu()
        {
            string querry = "Select * from [ChatLieu]";
            DataTable dt = _data.ExecuteQuery(querry);
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
                txt_MCL.Text = row.Cells["MaChatLieu"].Value.ToString();
                txt_TCL.Text = row.Cells["TenChatLieu"].Value.ToString();
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

        private void Them_CL()
        {
            string sql = $"Select Count(*) From [ChatLieu] Where MaChatLieu = @ma;";
            var parameters = new Dictionary<string, object>
            {
                {"@ma", txt_MCL},
            };
            int count = Convert.ToInt32(_data.ExecuteScalar(sql, parameters));
            if (count > 0)
            {
                MessageBox.Show($"Đã tồn tại chất liệu với mã {txt_TCL}", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            sql = "INSERT INTO [ChatLieu] (MaChatLieu, TenChatLieu)";
            sql += "VALUES(@ma, @ten);";
            parameters = new Dictionary<string, object>
            {
                {"@ma", txt_MCL},
                {"@ten", txt_TCL},
            };
            _data.ExecuteNonQuery(sql, parameters);
        }

        private void Sua_CL()
        {
            string sql = "Update [ChatLieu] SET ";
            sql += $"TenChatLieu = @ten ";
            sql += $"WHERE MaChatLieu = @ma";
            var parameters = new Dictionary<string, object>
            {
                {"@ma", txt_MCL},
                {"@ten", txt_TCL},
            };
            _data.ExecuteNonQuery(sql, parameters);
        }

        private void Xoa_CL()
        {
            string sql = $"Delete From [ChatLieu] Where MaChatLieu = @ma";
            var parameters = new Dictionary<string, object>
            {
                {"@ma", txt_MCL},
            };
            _data.ExecuteNonQuery(sql, parameters);
        }

        private void btn_CL_Luu_Click(object sender, EventArgs e)
        {
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
                Them_CL();
            }

                //Nếu nút Sửa enable TNSXì thực hiện cập nhật dữ liệu
            if (btn_CL_Sua.Enabled == true)
            {
                Sua_CL();
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_CL_Xoa.Enabled == true)
            {
                Xoa_CL();
            }


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
