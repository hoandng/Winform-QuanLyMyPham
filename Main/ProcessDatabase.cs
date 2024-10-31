using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    internal class ProcessDatabase
    {
        string strConnect = @"Server=HOANDANG\THANHDANGHOAN;Database=MYPHAM;Trusted_Connection=True;";

        SqlConnection sqlConnect = null;
        //Hàm mở kết nối CSDL
        private void KetNoiCSDL()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }
        //Hàm đóng kết nối CSDL
        private void DongKetNoiCSDL()
        {
            if (sqlConnect.State != ConnectionState.Closed)
                sqlConnect.Close();
            sqlConnect.Dispose();
        }
        //Hàm thực thi câu lệnh dạng Select trả về một DataTable
        public DataTable DocBang(string sql)
        {
            DataTable dtBang = new DataTable();
            try
            {
                KetNoiCSDL();
                SqlDataAdapter sqldataAdapte = new SqlDataAdapter(sql, sqlConnect);
                sqldataAdapte.Fill(dtBang);
                DongKetNoiCSDL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối cơ sở dữ liệu: " + ex.Message);
            }
            return dtBang;
        }
        //Hàm thực lệnh insert hoặc update hoặc delete
        public void CapNhatDuLieu(string sql)
        {
            try
            {
                KetNoiCSDL();
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlConnect;
                sqlcommand.CommandText = sql;
                sqlcommand.ExecuteNonQuery();
                DongKetNoiCSDL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
