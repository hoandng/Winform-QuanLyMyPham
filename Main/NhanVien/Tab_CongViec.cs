﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Main.NhanVien
{
    partial class NhanVien : Form
    {
        private void Load_CongViec()
        {
            string querry = "Select * from [CongViec]";
            DataTable dt = _database.ExecuteQuery(querry);
            dtg_CongViec.DataSource = dt;

            dtg_CongViec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_CongViec.Columns["MucLuong"].DefaultCellStyle.Format = "C0";
            dtg_CongViec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void resetTextBox_CongViec()
        {
            txt_MCV.Text = "";
            txt_TCV.Text = "";
            txt_MucLuong.Text = "";
        }
        private void enableControl_CongViec(bool en)
        {
            txt_MCV.Enabled = en;
            txt_TCV.Enabled = en;
            txt_MucLuong.Enabled = en;
            btn_CV_Luu.Enabled = en;
            btn_CV_Huy.Enabled = en;
        }
        private void dtg_CongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                enableControl(false);
                btn_CV_Them.Enabled = true;
                btn_CV_Sua.Enabled = true;
                btn_CV_Xoa.Enabled = true;
                DataGridViewRow row = dtg_CongViec.Rows[e.RowIndex];
                txt_MCV.Text = row.Cells["MaCV"].Value.ToString();
                txt_TCV.Text = row.Cells["TenCV"].Value.ToString();
                txt_MucLuong.Text = row.Cells["MucLuong"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            Load_CongViec();
            resetTextBox_CongViec();
            enableControl_CongViec(false);
            lb_CV_TrangThai.Text = "";
            btn_CV_Them.Enabled = true;
            btn_CV_Sua.Enabled = false;
            btn_CV_Xoa.Enabled= false;
        }

        private void btn_CV_Them_Click(object sender, EventArgs e)
        {
            lb_CV_TrangThai.Text = "*Bạn đang ở chế dộ Thêm!";
            enableControl_CongViec(true);
            resetTextBox_CongViec();
            btn_CV_Sua.Enabled = false;
            btn_CV_Xoa.Enabled = false;
        }

        private void btn_CV_Sua_Click(object sender, EventArgs e)
        {
            lb_CV_TrangThai.Text = "*Bạn đang ở chế dộ Sửa!";
            enableControl_CongViec(true);
            txt_MCV.Enabled = false;
            btn_CV_Them.Enabled = false;
            btn_CV_Xoa.Enabled = false;
        }

        private void btn_CV_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa Công việc có mã la " + txt_MCV.Text +
               " không ? Nếu có ấn nút Lưu, không Thì ấn nút Hủy", "Thông báo!",
                MessageBoxButtons.OK) == DialogResult.OK)
            {
                enableControl(false);
                lb_CV_TrangThai.Text = "*Bạn đang ở chế dộ XOÁ";
                btn_CV_Them.Enabled = false;
                btn_CV_Sua.Enabled = false;
                btn_CV_Luu.Enabled = true;
                btn_CV_Huy.Enabled = true;
            }
        }

        private void btn_CV_Luu_Click(object sender, EventArgs e)
        {
            string sql = "";

            string ma = txt_MCV.Text;
            string ten = txt_TCV.Text;
            string luong = txt_MucLuong.Text;
            //Kiểm tra dữ liêu
            if (ma.Trim() == "")
            {
                errNhanVien.SetError(txt_MCV, "Mã không được để trống");
                return;
            }
            else
            {
                errNhanVien.Clear();
            }

            if (ten.Trim() == "")
            {
                errNhanVien.SetError(txt_TCV, "Tên không được để trống");
                return;
            }
            else
            {
                errNhanVien.Clear();
            }
            decimal salary;
            if (!decimal.TryParse(luong, out salary))
            {
                errNhanVien.SetError(txt_SDT, "Lương phải là một số");
                return;
            }
            else
            {
                errNhanVien.Clear();
            }

            if (btn_CV_Them.Enabled == true)
            {

                sql = $"Select Count(*) From [CongViec] Where MaCV = @ma;";
                var parameters = new Dictionary<string, object>
                {
                    {"@ma", ma},
                };
                int count = Convert.ToInt32(_database.ExecuteScalar(sql, parameters));
                if (count > 0)
                {
                    MessageBox.Show($"Đã tồn tại Công việc với mã {ma}", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                sql = "INSERT INTO [CongViec] (MaCV, TenCV, MucLuong)";
                sql += $"VALUES(@ma, @ten, @mucluong);";
                parameters = new Dictionary<string, object>
                {
                    {"@ma", ma},
                    {"@ten", ten},
                    {"@mucluong", luong},
                };
                _database.ExecuteNonQuery(sql, parameters);
            }


            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            if (btn_CV_Sua.Enabled == true)
            {
                sql = "Update [CongViec] SET ";
                sql += $"TenCV = @ten, MucLuong = @luong ";
                sql += $"WHERE MaCV = @ma";
                var parameters = new Dictionary<string, object>
                {
                    {"@ma", ma},
                    {"@ten", ten},
                    {"@luong", luong},
                };
                _database.ExecuteNonQuery(sql, parameters);
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btn_CV_Xoa.Enabled == true)
            {
                sql = $"Delete From [CongViec] Where MaCV = @ma";
                var parameters = new Dictionary<string, object>
                {
                    {"@ma", ma},
                };
                _database.ExecuteNonQuery(sql, parameters);
            }

            Load_CongViec();

            resetTextBox_CongViec();
            enableControl_CongViec(false);
            lb_CV_TrangThai.Text = "";
            btn_CV_Them.Enabled = true;
            btn_CV_Xoa.Enabled = false;
            btn_CV_Sua.Enabled = false;
        }

        private void btn_CV_Huy_Click(object sender, EventArgs e)
        {
            lb_CV_TrangThai.Text = "";
            btn_CV_Xoa.Enabled = false;
            btn_CV_Sua.Enabled = false;
            btn_CV_Them.Enabled = true;
            resetTextBox_CongViec();
            enableControl_CongViec(false);
        }
    }
}
