using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.HangHoa
{
    partial class HangHoa : Form
    {
        private void Load_CongDung()
        {
            string querry = "Select * from [CongDung]";
            DataTable dt = _data.ExecuteQuery(querry);
            dtg_CongDung.DataSource = dt;
            dtg_CongDung.Columns[0].HeaderText = "Mã Công dụng";
            dtg_CongDung.Columns[1].HeaderText = "Tên Công dụng";

            dtg_CongDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt.Dispose();
        }
        private void Enable_CongDung(Boolean hien)
        {
            txt_MCD.Enabled = hien;
            txt_TCD.Enabled = hien;
            btn_CD_Luu.Enabled = hien;
            btn_CD_Huy.Enabled = hien;
        }
        private void ResetValueTextBox_CongDung()
        {
            txt_MCD.Text = "";
            txt_TCD.Text = "";
            lb_CD_TrangThai.Text = "";
        }
        private void tp_CongDung_Enter(object sender, EventArgs e)
        {
            Load_CongDung();
            Enable_CongDung(false);
            ResetValueTextBox_CongDung();
            lb_CD_TrangThai.Text = "";
            btn_CD_Them.Enabled = true;
            btn_CD_Sua.Enabled = false;
            btn_CD_Xoa.Enabled = false;
        }

        private void dtg_CongDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_CD_Them.Enabled = true;
                btn_CD_Sua.Enabled = true;
                btn_CD_Xoa.Enabled = true;
                Enable_CongDung(false);
                DataGridViewRow row = dtg_CongDung.Rows[e.RowIndex];
                txt_MCD.Text = row.Cells["MaCongDung"].Value.ToString();
                txt_TCD.Text = row.Cells["TenCongDung"].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_CD_Them_Click(object sender, EventArgs e)
        {
            Enable_CongDung(true);
            ResetValueTextBox_CongDung();
            lb_CD_TrangThai.Text = "*Bạn đang ở chế dộ THÊM";
            btn_CD_Sua.Enabled = false;
            btn_CD_Xoa.Enabled = false;
        }

        private void btn_CD_Sua_Click(object sender, EventArgs e)
        {
            Enable_CongDung(true);
            lb_CD_TrangThai.Text = "*Bạn đang ở chế dộ SỬA";
            txt_MCD.Enabled = false;
            btn_CD_Them.Enabled = false;
            btn_CD_Xoa.Enabled = false;
        }

        private void btn_CD_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa công dụng có mã la " + txt_MCD.Text +
               " không ? Nếu có ấn nút Lưu, không Thì ấn nút Hủy", "Xóa sản phẩm",
                MessageBoxButtons.OK) == DialogResult.OK)
            {
                Enable_CongDung(false);
                lb_CD_TrangThai.Text = "*Bạn đang ở chế dộ XOÁ";
                btn_CD_Them.Enabled = false;
                btn_CD_Sua.Enabled = false;
                btn_CD_Luu.Enabled = true;
                btn_CD_Huy.Enabled = true;
            }
        }

        private void Them_CD()
        {
            string sql = $"Select Count(*) From [CongDung] Where MaCongDung = @ma;";
            var parameters = new Dictionary<string, object>
            {
                {"@ma", txt_MCD},
            };
            int count = Convert.ToInt32(_data.ExecuteScalar(sql, parameters));
            if (count > 0)
            {
                MessageBox.Show($"Đã tồn tại công dụng với mã {txt_MCD}", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            sql = "INSERT INTO [CongDung] (MaCongDung, TenCongDUng)";
            sql += $"VALUES(@ma, @ten);";
            parameters = new Dictionary<string, object>
            {
            {"@ma", txt_MCD},
                {"@ten", txt_TCD},
            };
            _data.ExecuteNonQuery(sql, parameters);
        }

        private void Sua_CD()
        {
            string sql = "Update [CongDung] SET ";
            sql += $"TenCongDung = @ten ";
            sql += $"WHERE MaCongDung = @ma";
            var parameters = new Dictionary<string, object>
                {
                    {"@ma", txt_MCD},
                    {"@ten", txt_TCD},
                };
            _data.ExecuteNonQuery(sql, parameters);
        }

        private void Xoa_CD()
        {
            string sql = $"Delete From [CongDung] Where MaCongDung = @ma";
            var parameters = new Dictionary<string, object>
                {
                    {"@ma", txt_MCD},
                };
            _data.ExecuteNonQuery(sql, parameters);
        }

        private void btn_CD_Luu_Click(object sender, EventArgs e)
        {
            string ma = txt_MCD.Text;
            string ten = txt_TCD.Text;

            //Kiểm tra dữ liêu
            if (ma.Trim() == "")
            {
                errHangHoa.SetError(txt_MCD, "Mã không được để trống");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (ten.Trim() == "")
            {
                errHangHoa.SetError(txt_TCD, "Tên không được để trống");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (btn_CD_Them.Enabled == true)
            {
                Them_CD();
            }


            //Nếu nút Sửa enable TNSXì thực hiện cập nhật dữ liệu
            if (btn_CD_Sua.Enabled == true)
            {
                Sua_CD();
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_CD_Xoa.Enabled == true)
            {
                Xoa_CD();
            }

            Load_CongDung();

            ResetValueTextBox_CongDung();
            Enable_CongDung(false);
            lb_CD_TrangThai.Text = "";
            btn_CD_Them.Enabled = true;
            btn_CD_Xoa.Enabled = false;
            btn_CD_Sua.Enabled = false;
        }

        private void btn_CD_Huy_Click(object sender, EventArgs e)
        {
            lb_CD_TrangThai.Text = "";
            btn_CD_Xoa.Enabled = false;
            btn_CD_Sua.Enabled = false;
            btn_CD_Them.Enabled = true;
            ResetValueTextBox_CongDung();
            Enable_CongDung(false);
        }
    }
}
