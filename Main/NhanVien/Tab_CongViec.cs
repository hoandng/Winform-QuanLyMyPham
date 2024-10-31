using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.NhanVien
{
    partial class NhanVien : Form
    {
        private void Load_CongViec()
        {
            DataTable dt = _database.DocBang("SELECT * FROM [CongViec];");
            dtg_CongViec.DataSource = dt;
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

    }
}
