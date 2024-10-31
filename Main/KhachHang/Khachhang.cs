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

namespace Main.KhachHang
{
    public partial class fCustomer : Form
    {
        ProcessDatabase _database;
        public fCustomer()
        {
            _database = new ProcessDatabase();
            InitializeComponent();
        }

        private void fCustomer_Load(object sender, EventArgs e)
        {
            Load_KhachHang();
            enableControl(false);
            resetTextBox();
        }
        private void Load_KhachHang()
        {   
            DataTable dt = _database.DocBang("SELECT * FROM [KHACHHANG];");
            dgv_KhachHang.DataSource = dt;
            dgv_KhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void resetTextBox()
        {
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
            txt_DC.Text = "";
            txt_SDT.Text = "";
        }
        private void enableControl(bool en)
        {
            txt_MaKH.Enabled = en;
            txt_TenKH.Enabled = en;
            txt_DC.Enabled = en;
            txt_SDT.Enabled = en;

            btn_Luu.Enabled = en;
            btn_Huy.Enabled = en;
        }
        private void dgv_KhachHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                enableControl(false);
                btn_Them.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
                DataGridViewRow row = dgv_KhachHang.Rows[e.RowIndex];
                txt_MaKH.Text = row.Cells["colMaKH"].Value.ToString();
                txt_TenKH.Text = row.Cells["colTenKH"].Value.ToString();
                txt_DC.Text = row.Cells["colDiaChi"].Value.ToString();
                txt_SDT.Text = row.Cells["colSDT"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            lb_TrangThai.Text = "*Bạn đang ở chế dộ Thêm!";
            enableControl(true);
            resetTextBox();
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            lb_TrangThai.Text = "*Bạn đang ở chế dộ Sửa!";
            enableControl(true);
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa Khách hàng có mã la " + txt_MaKH.Text +
               " không ? Nếu có ấn nút Lưu, không Thì ấn nút Hủy", "Thông báo!",
                MessageBoxButtons.OK) == DialogResult.OK)
            {
                enableControl(false);
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

            string ma = txt_MaKH.Text;
            string ten = txt_TenKH.Text;
            string diachi = txt_DC.Text;
            string sdt = txt_SDT.Text;
            //Kiểm tra dữ liêu
            if (ma.Trim() == "")
            {
                errKhachHang.SetError(txt_MaKH, "Mã không được để trống");
                return;
            }
            else
            {
                errKhachHang.Clear();
            }

            if (ten.Trim() == "")
            {
                errKhachHang.SetError(txt_TenKH, "Tên không được để trống");
                return;
            }
            else
            {
                errKhachHang.Clear();
            }
            int sodienthoai;
            if (!int.TryParse(sdt, out sodienthoai))
            {
                errKhachHang.SetError(txt_SDT, "Số điện thoại phải là một số");
                return;
            }
            else
            {
                errKhachHang.Clear();
            }

            if (btn_Them.Enabled == true)
            {

                sql = $"Select Count(*) From [KhachHang] Where MaKhach ='{ma}';";
                DataTable dt = _database.DocBang(sql);
                if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show($"Đã tồn tại Khách hàng với mã {ma}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [KhachHang] (MaKhach, TenKhach, DiaChi, DienThoai)";
                sql += $"VALUES('{ma}', N'{ten}', N'{diachi}', '{sdt}');";
            }


            //Nếu nút Sửa enable TNSXì thực hiện cập nhật dữ liệu
            if (btn_Sua.Enabled == true)
            {
                sql = "Update [KhachHang] SET ";
                sql += $"TenKhach = N'{ten}', DiaChi = N'{diachi}', DienThoai = '{sdt}'";
                sql += $"WHERE MaKhach = '{ma}'";
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_Xoa.Enabled == true)
            {
                sql = $"Delete From [KhachHang] Where MaKhach = '{ma}'";
            }

            _database.CapNhatDuLieu(sql);

            Load_KhachHang();

            resetTextBox();
            enableControl(false);
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
            enableControl(false);
        }

    }
}
