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
        }

        private void Load_HDN()
        {
            DataTable dataTable = _data.DocBang("Select * From [HoaDonNhap]");
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

                sql = $"Select Count(*) From [HoaDonNhap] Where SoHDN ='{sohdn}';";
                DataTable dt = _data.DocBang(sql);
                if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show($"Đã tồn tại Hoá đơn bán với mã {sohdn}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [HoaDonNhap] (SoHDN, MaNV, MaNCC, NgayNhap, TongTien)";
                sql += $"VALUES('{sohdn}', '{manv}', '{mancc}', '{ngaynhap}', '{tongtien}');";
            }


            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            if (btn_Sua.Enabled == true)
            {
                sql = "Update [HoaDonNhap] SET ";
                sql += $"MaNV = '{manv}', MaNCC = '{mancc}', NgayNhap = '{ngaynhap}', TongTien = '{tongtien}'";
                sql += $"WHERE SoHDN = '{sohdn}'";
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_Xoa.Enabled == true)
            {
                sql = $"Delete From [HoaDonNhap] Where SoHDN = '{sohdn}'";
            }

            _data.CapNhatDuLieu(sql);

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
            resetTextBox();
            enableControls(false);
        }

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {

        }
    }
}
