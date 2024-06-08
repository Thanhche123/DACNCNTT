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
    public partial class FrChuyenNV : Form
    {
        QLNhanVien _nhanVien;
        private string maNV;

        public void SetMaNV(string maNV)
        {
            this.maNV = maNV;
        }
        public FrChuyenNV()
        {
            InitializeComponent();
            LoadComboBoxes();
            //HienThiThongTinNhanVien();
        }

        public FrChuyenNV(QLNhanVien nhanVien) : this()
        {
            _nhanVien = nhanVien;
            HienThiThongTinNhanVien();
        }
        private void HienThiThongTinNhanVien()
        {
            txtTenNV.Text = _nhanVien.HoTenNV;
            string queryPB = "SELECT MaPB, TenPB FROM tblPhongBan WHERE MaPB = @MaPB";
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(queryPB, sqlConnection))
                {
                    command.Parameters.AddWithValue("@MaPB", _nhanVien.MaPB);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tenPhongBan = reader["TenPB"].ToString();
                            txtPBDi.Text = tenPhongBan;
                        }
                        else
                        {
                            txtPBDi.Text = "Không tìm thấy phòng ban";
                        }
                    }
                }
                sqlConnection.Close();
            }
        }
        private void FrChuyenNV_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //string hoten = _nhanVien.MaPB;
            //MessageBox.Show(hoten,"",MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (MessageBox.Show("Bạn có chắc chắn muốn chuyển nhân viên không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = @"
                UPDATE tblNhanVien
                SET MaPB = @MaPB,
                    MaCV = @MaCV
                WHERE MaNV = @MaNV";

                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@MaPB", txtPBDen.SelectedValue);
                        command.Parameters.AddWithValue("@MaCV", txtCVMoi.SelectedValue);
                        command.Parameters.AddWithValue("@MaNV", maNV);

                        command.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
                MessageBox.Show("Hoàn tất: " + "Đã chuyển nhân viên", "Xong", MessageBoxButtons.OK);
                this.Close();
            }
        }
        

        private void LoadComboBoxes()
        {
            string queryPB = "SELECT MaPB, TenPB FROM tblPhongBan where MaPB <> 'PB001'";
            DataTable dtPB = GetDataTable(queryPB);
            txtPBDen.DataSource = dtPB;
            txtPBDen.DisplayMember = "TenPB";
            txtPBDen.ValueMember = "MaPB";

            string queryCV = "SELECT MaCV, TenCV FROM tblChucVu where MaCV <> 'CV001'";
            DataTable dtCV = GetDataTable(queryCV);
            txtCVMoi.DataSource = dtCV;
            txtCVMoi.DisplayMember = "TenCV";
            txtCVMoi.ValueMember = "MaCV";
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

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn hủy không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
