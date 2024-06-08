using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    internal class Modify
    {
        SqlDataAdapter _adapter;
        SqlCommand _command;
        public Modify()
        {

        }


        public DataTable getDanhSachNV()
        {
            DataTable dataTable = new DataTable();
            string query = "select NV.MaNV, NV.HoTenNV, NV.NgaySinh, NV.GioiTinh, NV.DiaChi, NV.SoDT, NV.Email, PB.TenPB, CV.TenCV from tblNhanVien NV join tblChucVu CV on NV.MaCV = CV.MaCV join tblPhongBan PB on NV.MaPB = PB.MaPB";
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                _adapter = new SqlDataAdapter(query, sqlConnection);
                _adapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public DataTable getDanhSachNVNV()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from tblNhanVienNghiViec";
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                _adapter = new SqlDataAdapter(query, sqlConnection);
                _adapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool insert(QLNhanVien nhanVien)
        {
            SqlConnection sqlConnection = connection.GetConnection();
            string query = "INSERT INTO tblNhanVien (HoTenNV, NgaySinh, GioiTinh, DiaChi, SoDT, Email, MaPB, MaCV) " +
                           "VALUES (@HoTenNV, @NgaySinh, @GioiTinh, @DiaChi, @SoDT, @Email, @MaPB, @MaCV)";
            try
            {
                sqlConnection.Open();
                _command = new SqlCommand(query, sqlConnection);
                _command.Parameters.Add("@HoTenNV", SqlDbType.NVarChar).Value = nhanVien.HoTenNV;
                _command.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nhanVien.NgaySinh;
                _command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nhanVien.GioiTinh;
                _command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanVien.DiaChi;
                _command.Parameters.Add("@SoDT", SqlDbType.VarChar).Value = nhanVien.SoDT;
                _command.Parameters.Add("@Email", SqlDbType.VarChar).Value = nhanVien.Email;
                _command.Parameters.Add("@MaPB", SqlDbType.Char).Value = nhanVien.MaPB;
                _command.Parameters.Add("@MaCV", SqlDbType.Char).Value = nhanVien.MaCV;
                _command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public DataTable search(string query, string parameter)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@search", parameter);
                _adapter = new SqlDataAdapter(command);
                _adapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public DataTable searchPB(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool Delete(string query, SqlParameter[] parameters)
        {
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    if (parameters != null)
                    {
                        sqlCommand.Parameters.AddRange(parameters);
                    }
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    return rowsAffected > 0;
                }
            }
        }
        public bool Update(string query, SqlParameter[] parameters)
        {
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    if (parameters != null)
                    {
                        sqlCommand.Parameters.AddRange(parameters);
                    }
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    return rowsAffected > 0;
                }
            }
        }

        public DataTable Arrange(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                _adapter = new SqlDataAdapter(query, sqlConnection);
                _adapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public DataTable getDanhSachPB()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM tblPhongBan WHERE TenPB != 'Không'";

            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                _adapter = new SqlDataAdapter(query, sqlConnection);
                _adapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool insertPB(QLPhongBan phongBan)
        {
            SqlConnection sqlConnection = connection.GetConnection();
            string query = "INSERT INTO tblPhongBan (TenPB, MoTa) VALUES (@TenPB, @MoTa)";

            try
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.Add("@TenPB", SqlDbType.NVarChar).Value = phongBan.TenPB;
                    command.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = phongBan.MoTa ?? (object)DBNull.Value;

                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool insertCTPB(QLCTPhongBan ctPhongBan)
        {
            SqlConnection sqlConnection = connection.GetConnection();
            string query = "INSERT INTO tblChiTietPhongBan (MaPB, MaNV, MaCV) " +
                           "VALUES (@MaPB, @MaNV, @MaCV)";
            try
            {
                sqlConnection.Open();
                _command = new SqlCommand(query, sqlConnection);
                _command.Parameters.Add("@MaPB", SqlDbType.NVarChar).Value = ctPhongBan.MaPB;
                _command.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = ctPhongBan.MaNV;
                _command.Parameters.Add("@MaCV", SqlDbType.Char).Value = ctPhongBan.MaCV;
               

                _command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        private string maPB;
        public void SetMaPB(string maPB)
        {
            this.maPB = maPB;
        }
        public DataTable getDanhSachCTPB()
        {
            DataTable dataTable = new DataTable();
            string query = "select NV.MaNV, NV.HoTenNV, NV.NgaySinh, NV.GioiTinh, NV.DiaChi, NV.SoDT, NV.Email, CV.TenCV from tblNhanVien NV join tblChucVu CV on NV.MaCV = CV.MaCV join tblPhongBan PB on NV.MaPB = PB.MaPB where PB.MaPB = @MaPB";
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@MaPB", maPB);
                _adapter = new SqlDataAdapter(command);
                _adapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public DataTable getDanhSachDiemDanh()
        {
            DataTable dataTable = new DataTable();
            string query = "select NV.MaNV, NV.HoTenNV, CV.TenCV from tblNhanVien NV join tblChucVu CV on NV.MaCV = CV.MaCV join tblPhongBan PB on NV.MaPB = PB.MaPB where PB.MaPB = @MaPB";
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@MaPB", maPB);
                _adapter = new SqlDataAdapter(command);
                _adapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        /*public DataTable getBangLuong()
        {
            DataTable dataTable = new DataTable();
            string query = "select NV.MaNV, NV.HoTenNV, CV.TenCV, L.LuongNet from tblNhanVien NV join tblChucVu CV on NV.MaCV = CV.MaCV join tblPhongBan PB on NV.MaPB = PB.MaPB join tblLuong L on L.MaNV = NV.MaNV where PB.MaPB = @MaPB";
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@MaPB", maPB);
                _adapter = new SqlDataAdapter(command);
                _adapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }*/

        public bool updatePB(QLPhongBan phongBan, string MaPB)
        {
            //MessageBox.Show(MaPB, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            SqlConnection sqlConnection = connection.GetConnection();
            string query = "UPDATE tblPhongBan SET TenPB = @TenPB, MoTa = @MoTa WHERE MaPB = @MaPB";

            try
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.Add("@MaPB", SqlDbType.NVarChar).Value = MaPB;
                    command.Parameters.Add("@TenPB", SqlDbType.NVarChar).Value = phongBan.TenPB;
                    command.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = phongBan.MoTa ?? (object)DBNull.Value;

                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        
    }
}
