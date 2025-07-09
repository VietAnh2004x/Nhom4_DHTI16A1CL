using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Data_Access_Layer
{
    public class DataProvider
    {
        const string connString = "Data Source=DESKTOP-14M8VC0\\SQLEXPRESS;Initial Catalog=qlbx;Integrated Security=True;TrustServerCertificate=True";
        private static SqlConnection connection;
        public static void OpenConnection()
        {
            connection = new SqlConnection(connString); 
            connection.Open();
        }
        public static void CloseConnection()
        {
            connection.Close();
        }
        public static DataTable loadcsdl(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, connection);//tao những lệnh
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }
        //SỬA XÓA UPDATE
        public static int thaotacCSDL(string query)
        {
            int kq = 0;
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                kq = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return kq;
        }
    }
}
