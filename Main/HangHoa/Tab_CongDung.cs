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
        private void Load_CongDung()
        {
            DataTable dt = _data.DocBang("Select * from [CongDung]");
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

        private void btn_CD_Luu_Click(object sender, EventArgs e)
        {
            string sql = "";

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

                sql = $"Select Count(*) From [CongDung] Where MaCongDung ='{ma}';";
                DataTable dt = _data.DocBang(sql);
                if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show($"Đã tồn tại công dụng với mã {ma}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [CongDUng] (MaCongDung, TenCongDUng)";
                sql += $"VALUES('{ma}', N'{ten}');";
            }


            //Nếu nút Sửa enable TNSXì thực hiện cập nhật dữ liệu
            if (btn_CD_Sua.Enabled == true)
            {
                sql = "Update [CongDung] SET ";
                sql += $"TenCongDung = N'{ten}'";
                sql += $"WHERE MaCongDung = '{ma}'";
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_CD_Xoa.Enabled == true)
            {
                sql = $"Delete From [CongDung] Where MaCongDung = '{ma}'";
            }

            _data.CapNhatDuLieu(sql);

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
