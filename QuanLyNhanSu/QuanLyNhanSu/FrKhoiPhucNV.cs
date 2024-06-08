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
    public partial class FrKhoiPhucNV : Form
    {
        private QLNhanVien _nhanVien;
        private string MaNVNV;

        public void SetMaNV(string maNV)
        {
            this.MaNVNV = maNV;
        }
        public FrKhoiPhucNV()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        Modify modify=new Modify();
        QLNhanVien nhanVien;

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
        private void FrKhoiPhucNV_Load(object sender, EventArgs e)
        {

        }

        public FrKhoiPhucNV(QLNhanVien nhanVien) : this()
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

            if (_nhanVien.GioiTinh == "Nam")
            {
                rdoNam.Checked = true;
            }
            else if (_nhanVien.GioiTinh == "Nữ")
            {
                rdoNu.Checked = true;
            }

        }

        private void btnKhoiPhucNV_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(MaNVNV, "Xong", MessageBoxButtons.OK);
            string name = this.txtTenNV.Text;
            string GioiTinh = (rdoNam.Checked ? rdoNam.Text : rdoNu.Text);
            DateTime NgaySinh = this.dateTimePicker1.Value;
            string DiaChi = this.txtDiaChi.Text;
            string SoDT = this.txtSDT.Text;
            string Email = this.txtEmail.Text;
            string MaPB = this.txtPB.SelectedValue.ToString();
            string MaCV = this.txtCV.SelectedValue.ToString();

            nhanVien = new QLNhanVien(name, NgaySinh, GioiTinh, DiaChi, SoDT, Email, MaPB, MaCV);

            if (modify.insert(nhanVien))
            {
                dataGridView1.DataSource = modify.getDanhSachNV();
                MessageBox.Show("Hoàn tất: " + "Đã khôi phục nhân viên", "Xong", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không khôi phục được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string query = "DELETE FROM tblNhanVienNghiViec WHERE MaNVNV = @MaNV";
            var parameters = new SqlParameter[]
            {
                            new SqlParameter("@MaNV", MaNVNV)
            };
            modify.Delete(query, parameters);

            this.Close();
        }

        private void btnHuythemNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
