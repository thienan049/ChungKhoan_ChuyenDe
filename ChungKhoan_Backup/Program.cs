using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChungKhoan_Backup
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the Wapplication.
        /// </summary>
        /// 

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;

        public static String servername = "ANTHIEN049\\SQLSERVER1";
        public static String username = "sa";
        public static String password = "asd";
        public static String database = "CHUNGKHOAN";

        public static int DBConnect()
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.username + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Backup());
        }
    }
}
