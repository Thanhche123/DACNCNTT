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
using System.Xml.Linq;

namespace QuanLyNhanSu
{
    public partial class FrChinhSuaNV : Form
    {
        private QLNhanVien _nhanVien;
        private string maNV;

        public void SetMaNV(string maNV)
        {
            this.maNV = maNV;
        }

        public FrChinhSuaNV()
        {
            InitializeComponent();
        }

        private void LoadComboBoxes()
        {
            // Load Phong Ban
            string queryPB = "SELECT MaPB, TenPB FROM tblPhongBan";
            DataTable dtPB = GetDataTable(queryPB);
            txtPB.DataSource = dtPB;
            txtPB.DisplayMember = "TenPB";
            txtPB.ValueMember = "MaPB";

            // Load Chuc Vu
            string queryCV = "SELECT MaCV, TenCV FROM tblChucVu";
            DataTable dtCV = GetDataTable(queryCV);
            txtCV.DataSource = dtCV;
            txtCV.DisplayMember = "TenCV";
            txtCV.ValueMember = "MaCV";
        }


        private DataTable GetDataTable(string query)
        {
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        public FrChinhSuaNV(QLNhanVien nhanVien) : this()
        {
            
            _nhanVien = nhanVien;
            HienThiThongTinNhanVien();
        }

        private void HienThiThongTinNhanVien()
        {
            LoadComboBoxes();
            txtTenNV.Text = _nhanVien.HoTenNV;

            if (_nhanVien.NgaySinh < dateTimePicker1.MinDate || _nhanVien.NgaySinh > dateTimePicker1.MaxDate)
            {
                dateTimePicker1.Value = DateTime.Now; // Hoặc một giá trị hợp lệ khác
            }
            else
            {
                dateTimePicker1.Value = _nhanVien.NgaySinh;
            }

            txtDiaChi.Text = _nhanVien.DiaChi;
            txtSDT.Text = _nhanVien.SoDT;
            txtEmail.Text = _nhanVien.Email;
            int indexPB = txtPB.FindStringExact(_nhanVien.MaPB);
            if (indexPB != -1)
            {
                txtPB.SelectedIndex = indexPB;
            }

            // Tìm vị trí của mã chức vụ trong ComboBox Chức vụ và chọn nó
            int indexCV = txtCV.FindStringExact(_nhanVien.MaCV);
            if (indexCV != -1)
            {
                txtCV.SelectedIndex = indexCV;
            }

            if (_nhanVien.GioiTinh == "Nam")
            {
                rdoNam.Checked = true;
            }
            else if (_nhanVien.GioiTinh == "Nữ")
            {
                rdoNu.Checked = true;
            }
            
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuythemNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy bỏ thay đổi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void grbThemNV_Enter(object sender, EventArgs e)
        {

        }


        private void FrChinhSuaNV_Load(object sender, EventArgs e)
        {

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn lưu thay đổi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = @"
                UPDATE tblNhanVien
                SET HoTenNV = @HoTenNV,
                    NgaySinh = @NgaySinh,
                    DiaChi = @DiaChi,
                    GioiTinh = @GioiTinh,
                    SoDT = @SoDT,
                    Email = @Email,
                    MaPB = @MaPB,
                    MaCV = @MaCV
                WHERE MaNV = @MaNV";

                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@HoTenNV", txtTenNV.Text);
                        command.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                        command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        command.Parameters.AddWithValue("@SoDT", txtSDT.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@MaPB", txtPB.SelectedValue);
                        command.Parameters.AddWithValue("@MaCV", txtCV.SelectedValue);
                        command.Parameters.AddWithValue("@MaNV", maNV);

                        command.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
                MessageBox.Show("Hoàn tất: " + "Đã chỉnh sửa nhân viên", "Xong", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
