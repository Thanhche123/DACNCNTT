using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{

    public partial class FrDangNhap : Form
    {
        private const string SavedUsername = "savedUsername";
        private const string SavedPassword = "savedPassword";
        public FrDangNhap()
        {
            InitializeComponent();
            LoadSavedCredentials();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadSavedCredentials()
        {
            string savedUsername = Properties.Settings.Default[SavedUsername]?.ToString();
            string savedPassword = Properties.Settings.Default[SavedPassword]?.ToString();

            if (!string.IsNullOrEmpty(savedUsername) && !string.IsNullOrEmpty(savedPassword))
            {
                tbxTaiKhoan.Text = savedUsername;
                tbxMatKhau.Text = savedPassword;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string maNV = tbxTaiKhoan.Text;
            string ngaySinh = tbxMatKhau.Text;

            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                string query = "SELECT MaNV, NgaySinh, MaCV FROM tblNhanVien WHERE MaNV = @MaNV AND NgaySinh = @NgaySinh";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@MaNV", maNV);
                    command.Parameters.AddWithValue("@NgaySinh", ngaySinh);

                    SqlDataReader reader = command.ExecuteReader();
                    if (chkLuuTaiKhoan.Checked)
                    {
                        Properties.Settings.Default[SavedUsername] = maNV;
                        Properties.Settings.Default[SavedPassword] = ngaySinh;
                        Properties.Settings.Default.Save();
                    }
                    if (reader.Read())
                    {
                        string maCV = reader["MaCV"].ToString();
                        
                        if (maCV == "CV002")
                        {
                            FrQuanLy f = new FrQuanLy();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            FrNhanVien f = new FrNhanVien();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên hoặc ngày sinh không đúng. Vui lòng thử lại.", "Đăng nhập không thành công");
                    }
                    sqlConnection.Close();
                }
            }
        }

        private void FrDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void FrDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
