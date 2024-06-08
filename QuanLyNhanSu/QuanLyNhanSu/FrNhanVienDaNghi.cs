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
    public partial class FrNhanVienDaNghi : Form
    {
        public FrNhanVienDaNghi()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        //QLNhanVien nhanVien;

        private void cbxTimTen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTimTen.Checked)
            {
                cbxTimQueQuan.Checked = false;
                cbxTimNamSinh.Checked = false;
                cbxTimLyDo.Checked = false;
                cbxTimThoiGian.Checked = false;
            }
        }

        private void cbxTimQueQuan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTimQueQuan.Checked)
            {
                cbxTimTen.Checked = false;
                cbxTimNamSinh.Checked = false;
                cbxTimLyDo.Checked = false;
                cbxTimThoiGian.Checked = false;
            }
        }

        private void cbxTimNamSinh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTimNamSinh.Checked)
            {
                cbxTimQueQuan.Checked = false;
                cbxTimTen.Checked = false;
                cbxTimLyDo.Checked = false;
                cbxTimThoiGian.Checked = false;
            }
        }

        private void cbxTimThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTimThoiGian.Checked)
            {
                cbxTimQueQuan.Checked = false;
                cbxTimTen.Checked = false;
                cbxTimLyDo.Checked = false;
                cbxTimNamSinh.Checked = false;
            }
        }

        private void cbxTimLyDo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTimLyDo.Checked)
            {
                cbxTimQueQuan.Checked = false;
                cbxTimTen.Checked = false;
                cbxTimNamSinh.Checked = false;
                cbxTimThoiGian.Checked = false;
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> searchFields = new List<string>();
            if (cbxTimTen.Checked)
            {
                searchFields.Add("HoTenNV");
            }
            if (cbxTimQueQuan.Checked)
            {
                searchFields.Add("DiaChi");
            }
            if (cbxTimNamSinh.Checked)
            {
                searchFields.Add("NgaySinh");
            }
            if (cbxTimLyDo.Checked)
            {
                searchFields.Add("LoaiNghi");
            }
            if (cbxTimThoiGian.Checked)
            {
                searchFields.Add("NgayNghi");
            }

            // Xây dựng câu truy vấn dựa trên các checkbox được chọn
            string query = "SELECT * FROM tblNhanVienNghiViec";
            string parameter = "%" + tbxSearch.Text.Trim() + "%";

            if (searchFields.Any() && !string.IsNullOrWhiteSpace(tbxSearch.Text.Trim()))
            {
                query += " WHERE (";
                foreach (string field in searchFields)
                {
                    query += $" {field} LIKE @search OR";
                }
                query = query.Remove(query.Length - 2); // Remove the trailing 'OR'
                query += ")";
            }

            DataTable searchResult = modify.search(query, parameter);
            dataGridView1.DataSource = searchResult;
        }

        private void btnSNameTang_Click(object sender, EventArgs e)
        {

        }

        private void btnSNameGiam_Click(object sender, EventArgs e)
        {

        }

        private void btnSQQTang_Click(object sender, EventArgs e)
        {

        }

        private void btnSQQGiam_Click(object sender, EventArgs e)
        {

        }

        private void btnSNSTang_Click(object sender, EventArgs e)
        {

        }

        private void btnSNSGiam_Click(object sender, EventArgs e)
        {

        }

        private void btnResert_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = modify.getDanhSachNVNV();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maNV = dataGridView1.SelectedRows[0].Cells["MaNVNV"].Value.ToString();
                string HoTenNV = dataGridView1.SelectedRows[0].Cells["HoTenNV"].Value.ToString();
                DateTime NgaySinh = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["NgaySinh"].Value.ToString());
                string DiaChi = dataGridView1.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                string GioiTinh = dataGridView1.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                string SoDT = dataGridView1.SelectedRows[0].Cells["SoDT"].Value.ToString();
                string Email = dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString();
                string TenPB = null;
                string TenCV = null;

                var nhanVien = new QLNhanVien(HoTenNV, NgaySinh, GioiTinh, DiaChi, SoDT, Email, TenPB, TenCV);

                FrKhoiPhucNV f = new FrKhoiPhucNV(nhanVien);
                f.SetMaNV(maNV); // Thiết lập mã nhân viên cho form chỉnh sửa
                f.ShowDialog();
                dataGridView1.DataSource = modify.getDanhSachNVNV();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa người này ra khỏi hệ thống?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var cellValue = dataGridView1.SelectedRows[0].Cells[0].Value;
                    if (cellValue != null)
                    {
                        string MaNV = cellValue.ToString();
                        string query = "DELETE FROM tblNhanVienNghiViec WHERE MaNVNV = @MaNV";
                        var parameters = new SqlParameter[]
                        {
                            new SqlParameter("@MaNV", MaNV)
                        };
                        bool isDeleted = modify.Delete(query, parameters);
                        if (isDeleted)
                        {
                            dataGridView1.DataSource = modify.getDanhSachNVNV();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa phòng ban.", "Lỗi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giá trị Mã NV không hợp lệ.", "Lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Không có hàng nào được chọn.", "Lỗi");
                }
            }
        }

        private void FrNhanVienDaNghi_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getDanhSachNVNV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
