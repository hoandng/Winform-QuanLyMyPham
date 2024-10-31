using Main.ChiTiet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Load_HDB();
            resetTextBox();
            enableControls(false);
        }

        private void Load_HDB()
        {
            DataTable dataTable = _data.DocBang("Select * From [HoaDonBan]");
            dgv_HDB.DataSource = dataTable;

            dgv_HDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTable.Dispose();
        }

        private void resetTextBox()
        {
            txt_SoHDB.Text = "";
            txt_MaNV.Text = "";
            dtp_NgayBan.Value = DateTime.Now;
            txt_MaKH.Text = "";
            txt_TT.Text = "";
        }

        private void enableControls(bool enable)
        {
            txt_SoHDB.Enabled = enable;
            txt_MaNV.Enabled = enable;
            dtp_NgayBan.Enabled = enable;
            txt_MaKH.Enabled = enable;
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
                DataGridViewRow row = dgv_HDB.Rows[e.RowIndex];
                txt_SoHDB.Text = row.Cells["SoHDB"].Value.ToString();
                txt_MaNV.Text = row.Cells["MaNV"].Value.ToString();
                dtp_NgayBan.Text = row.Cells["NgayBan"].Value.ToString();
                txt_MaKH.Text = row.Cells["MaKhach"].Value.ToString();
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
            string manv = txt_MaNV.Text;
            string makh = txt_MaKH.Text;
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

                sql = $"Select Count(*) From [HoaDonBan] Where SoHDB ='{sohdb}';";
                DataTable dt = _data.DocBang(sql);
                if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show($"Đã tồn tại Hoá đơn bán với mã {sohdb}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [HoaDonBan] (SoHDB, MaNV, MaKhach, NgayBan, TongTien)";
                sql += $"VALUES('{sohdb}', '{manv}', '{makh}', '{ngayban}', '{tongtien}');";
            }


            //Nếu nút Sửa enable TNSXì thực hiện cập nhật dữ liệu
            if (btn_Sua.Enabled == true)
            {
                sql = "Update [HoaDonBan] SET ";
                sql += $"MaNV = '{manv}', MaKhach = '{makh}', NgayBan = '{ngayban}', TongTien = '{tongtien}'";
                sql += $"WHERE SoHDb = '{sohdb}'";
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_Xoa.Enabled == true)
            {
                sql = $"Delete From [HoaDonBan] Where SoHDB = '{sohdb}'";
            }

            _data.CapNhatDuLieu(sql);

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
            CT_HDB ctHDB = new CT_HDB();
            ctHDB.ShowDialog();
        }
    }
}
