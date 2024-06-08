using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    internal class connection
    {
        private static string connectionString = @"Data Source=DESKTOP-SOEE5S8\SQLEXPRESS;Initial Catalog=QuanLyNhanSuDP;Integrated Security=True;Connection Timeout=30;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
