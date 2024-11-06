using System;
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
        private void tp_NuocSX_Enter(object sender, EventArgs e)
        {
            Load_NuocSX();
            Enable_NuocSX(false);
            ResetValueTextBox_NuocSX();
            btn_NSX_Them.Enabled = true;
            btn_NSX_Sua.Enabled = false;
            btn_NSX_Xoa.Enabled = false;

            lb_NSX_TrangThai.Text = "";
        }

        private void tp_NuocSX_Leave(object sender, EventArgs e)
        {

        }

        private void Load_NuocSX()
        {
            string querry = "Select * from [NuocSX]";
            DataTable dt = _data.ExecuteQuery(querry);
            dtg_NuocSX.DataSource = dt;
            dtg_NuocSX.Columns[0].HeaderText = "Mã Nước";
            dtg_NuocSX.Columns[1].HeaderText = "Tên Nước";

            dtg_NuocSX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt.Dispose();
        }
        private void Enable_NuocSX(Boolean hien)
        {
            txt_MNSX.Enabled = hien;
            txt_TNSX.Enabled = hien;
            btn_NSX_Luu.Enabled = hien;
            btn_NSX_Huy.Enabled = hien;
        }
        private void ResetValueTextBox_NuocSX()
        {
            txt_MNSX.Text = "";
            txt_TNSX.Text = "";
            lb_NSX_TrangThai.Text = "";
        }
        private void dtg_NuocSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Hien thi nut sua va xoa
                btn_NSX_Them.Enabled = true;
                btn_NSX_Sua.Enabled = true;
                btn_NSX_Xoa.Enabled = true;
                Enable_NuocSX(false);
                DataGridViewRow row = dtg_NuocSX.Rows[e.RowIndex];
                txt_MNSX.Text = row.Cells["MaNuocSX"].Value.ToString();
                txt_TNSX.Text = row.Cells["TenNuocSX"].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_NSX_Them_Click(object sender, EventArgs e)
        {
            Enable_NuocSX(true);
            ResetValueTextBox_NuocSX();
            lb_NSX_TrangThai.Text = "*Bạn đang ở chế dộ THÊM";
            btn_NSX_Sua.Enabled = false;
            btn_NSX_Xoa.Enabled = false;
        }

        private void btn_NSX_Sua_Click(object sender, EventArgs e)
        {
            Enable_NuocSX(true);
            lb_NSX_TrangThai.Text = "*Bạn đang ở chế dộ SỬA";
            txt_MNSX.Enabled = false;
            btn_NSX_Them.Enabled = false;
            btn_NSX_Xoa.Enabled = false;
        }

        private void btn_NSX_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa nước sản xuất có mã la " + txt_MNSX.Text +
               " không ? Nếu có ấn nút Lưu, không TNSXì ấn nút Hủy", "Xóa sản phẩm",
          MessageBoxButtons.OK) == DialogResult.OK)
            {
                Enable_NuocSX(false);
                lb_NSX_TrangThai.Text = "*Bạn đang ở chế dộ XOÁ";
                btn_NSX_Them.Enabled = false;
                btn_NSX_Sua.Enabled = false;
                btn_NSX_Luu.Enabled = true;
                btn_NSX_Huy.Enabled = true;
            }
        }

        private void btn_NSX_Luu_Click(object sender, EventArgs e)
        {
            string sql = "";

            string mansx = txt_MNSX.Text;
            string tennsx = txt_TNSX.Text;

            //Kiểm tra dữ liêu
            if (mansx.Trim() == "")
            {
                errHangHoa.SetError(txt_MNSX, "Mã không được để trống");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (tennsx.Trim() == "")
            {
                errHangHoa.SetError(txt_TNSX, "Tên không được để trống");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (btn_NSX_Them.Enabled == true)
            {
                sql = "Select Count(*) From [NuocSX] Where MaNuocSX = @mansx;";
                var parameters = new Dictionary<string, object>
                {
                    {"@mansx", mansx},
                };
                int count = Convert.ToInt32(_data.ExecuteScalar(sql, parameters));
                if (count > 0)
                {
                    MessageBox.Show($"Đã tồn tại nước sản xuất với mã {mansx}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [NuocSX] (MaNuocSX, TenNuocSX)";
                sql += $"VALUES(@mansx, @tennsx);";
                parameters = new Dictionary<string, object>
                {
                    {"@mansx", mansx},
                    {"@tennxs", tennsx},
                };
                _data.ExecuteNonQuery(sql, parameters);
            }


            //Nếu nút Sửa enable TNSXì thực hiện cập nhật dữ liệu
            if (btn_NSX_Sua.Enabled == true)
            {
                sql = "Update [NuocSX] SET ";
                sql += "TenNuocSX = @tennsx ";
                sql += "WHERE MaNuocSX = @mansx";
                var parameters = new Dictionary<string, object>
                {
                    {"@mansx", mansx},
                    {"@tennsx", tennsx},
                };
                _data.ExecuteNonQuery(sql, parameters);
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_NSX_Xoa.Enabled == true)
            {
                sql = $"Delete From [NuocSX] Where MaNuocSX = @mansx";
                var parameters = new Dictionary<string, object>
                {
                    {"@mansx", mansx},
                };
                _data.ExecuteNonQuery(sql, parameters);
            }

            Load_NuocSX();

            ResetValueTextBox_NuocSX();
            Enable_NuocSX(false);
            lb_NSX_TrangThai.Text = "";
            btn_NSX_Them.Enabled = true;
            btn_NSX_Xoa.Enabled = false;
            btn_NSX_Sua.Enabled = false;
        }

        private void btn_NSX_Huy_Click(object sender, EventArgs e)
        {
            lb_NSX_TrangThai.Text = "";
            btn_NSX_Xoa.Enabled = false;
            btn_NSX_Sua.Enabled = false;
            btn_NSX_Them.Enabled = true;
            ResetValueTextBox_NuocSX();
            Enable_NuocSX(false);
        }

    }
}
