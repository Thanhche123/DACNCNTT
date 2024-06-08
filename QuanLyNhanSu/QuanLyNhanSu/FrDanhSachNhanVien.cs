using System;
using System.Collections;
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
    public partial class FrDanhSachNhanVien : Form
    {
        public FrDanhSachNhanVien()
        {
            InitializeComponent();
        }

        Modify modify;
        //QLNhanVien nhanVien;
        private void FrDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getDanhSachNV();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {

            FrThemNV f= new FrThemNV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grbDSNV_Enter(object sender, EventArgs e)
        {

        }

        private void btnResert_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = modify.getDanhSachNV();
        }

        private void cbxTimTen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTimTen.Checked)
            {
                cbxTimQueQuan.Checked = false;
                cbxTimNamSinh.Checked = false;
                cbxTimChucVu.Checked = false;
                cbxTimPhongBan.Checked = false;
            }
        }

        private void cbxTimChucVu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTimChucVu.Checked)
            {
                cbxTimQueQuan.Checked = false;
                cbxTimNamSinh.Checked = false;
                cbxTimTen.Checked = false;
                cbxTimPhongBan.Checked = false;
            }
        }

        private void cbxTimQueQuan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTimQueQuan.Checked)
            {
                cbxTimTen.Checked = false;
                cbxTimNamSinh.Checked = false;
                cbxTimChucVu.Checked = false;
                cbxTimPhongBan.Checked = false;
            }
        }

        private void cbxTimNamSinh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTimNamSinh.Checked)
            {
                cbxTimQueQuan.Checked = false;
                cbxTimTen.Checked = false;
                cbxTimChucVu.Checked = false;
                cbxTimPhongBan.Checked=false;
            }
        }

        private void cbxTimPhongBan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTimPhongBan.Checked)
            {
                cbxTimQueQuan.Checked = false;
                cbxTimTen.Checked = false;
                cbxTimChucVu.Checked = false;
                cbxTimNamSinh.Checked=false;
            }
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
    if (cbxTimChucVu.Checked)
    {
        searchFields.Add("TenCV");
    }
    if (cbxTimPhongBan.Checked)
    {
        searchFields.Add("TenPB");
    }

    // Xây dựng câu truy vấn dựa trên các checkbox được chọn
    string query = "select NV.MaNV, NV.HoTenNV, NV.NgaySinh, NV.GioiTinh, NV.DiaChi, NV.SoDT, NV.Email, PB.TenPB, CV.TenCV from tblNhanVien NV join tblChucVu CV on NV.MaCV = CV.MaCV join tblPhongBan PB on NV.MaPB = PB.MaPB  WHERE 1=1";
    string parameter = "%" + tbxSearch.Text.Trim() + "%";
    
    if (searchFields.Any() && !string.IsNullOrWhiteSpace(tbxSearch.Text.Trim()))
    {
        query += " AND (";
        foreach (string field in searchFields)
        {
            query += $" {field} LIKE @search OR";
        }
        query = query.Remove(query.Length - 2); // Loại bỏ " OR" cuối cùng
        query += ")";
    }

    // Thực hiện truy vấn và hiển thị kết quả
    DataTable searchResult = modify.search(query, parameter);
    dataGridView1.DataSource = searchResult;
}

private void btnXoa_Click(object sender, EventArgs e)
{
    
    if (dataGridView1.SelectedRows.Count > 0)
    {
        var cellValue = dataGridView1.SelectedRows[0].Cells[0].Value;
        if (cellValue != null)
        {
                
            string MaNV = cellValue.ToString();
                    //MessageBox.Show(MaNV,"",MessageBoxButtons.OK, MessageBoxIcon.Question);
            string maNV = MaNV;
            string HoTenNV = dataGridView1.SelectedRows[0].Cells["HoTenNV"].Value.ToString();
            DateTime NgaySinh = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["NgaySinh"].Value.ToString());
            string DiaChi = dataGridView1.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            string GioiTinh = dataGridView1.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
            string SoDT = dataGridView1.SelectedRows[0].Cells["SoDT"].Value.ToString();
            string Email = dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString();
            string TenPB = null;
            string TenCV = null;

            var nhanVien = new QLNhanVien(HoTenNV, NgaySinh, GioiTinh, DiaChi, SoDT, Email, TenPB, TenCV);

            FrSaThaiNV f = new FrSaThaiNV(nhanVien);
            f.SetMaNV(maNV);
            f.ShowDialog();

                    string query = "DELETE FROM tblNhanVien WHERE MaNV = @MaNV";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", MaNV)
            };
            bool isDeleted = modify.Delete(query, parameters);
            if (isDeleted)
            {
                dataGridView1.DataSource = modify.getDanhSachNV();
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

        private void cbxTimPhongBan_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxTimPhongBan.Checked)
            {
                cbxTimQueQuan.Checked = false;
                cbxTimTen.Checked = false;
                cbxTimChucVu.Checked = false;
                cbxTimNamSinh.Checked = false;
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maNV = dataGridView1.SelectedRows[0].Cells["MaNV"].Value.ToString();
                string HoTenNV = dataGridView1.SelectedRows[0].Cells["HoTenNV"].Value.ToString();
                DateTime NgaySinh = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["NgaySinh"].Value.ToString());
                string DiaChi = dataGridView1.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                string GioiTinh = dataGridView1.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                string SoDT = dataGridView1.SelectedRows[0].Cells["SoDT"].Value.ToString();
                string Email = dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString();
                string TenPB = dataGridView1.SelectedRows[0].Cells["TenPB"].Value.ToString();
                string TenCV = dataGridView1.SelectedRows[0].Cells["TenCV"].Value.ToString();

                var nhanVien = new QLNhanVien(HoTenNV, NgaySinh, GioiTinh, DiaChi, SoDT, Email, TenPB, TenCV);

                FrChinhSuaNV f = new FrChinhSuaNV(nhanVien);
                f.SetMaNV(maNV); // Thiết lập mã nhân viên cho form chỉnh sửa
                f.ShowDialog();
            }
        }

        private void btnSNameTang_Click(object sender, EventArgs e)
        {
            string orderByColumn = "HoTenNV"; // Thay "HoTenNV" bằng tên cột mà bạn muốn sắp xếp
            dataGridView1.Sort(dataGridView1.Columns[orderByColumn], ListSortDirection.Ascending);
        }

        private void btnSNameGiam_Click(object sender, EventArgs e)
        {
            string orderByColumn = "HoTenNV"; // Thay "HoTenNV" bằng tên cột mà bạn muốn sắp xếp
            dataGridView1.Sort(dataGridView1.Columns[orderByColumn], ListSortDirection.Descending);
        }

        private void btnSCVTang_Click(object sender, EventArgs e)
        {
            string orderByColumn = "TenCV";
            dataGridView1.Sort(dataGridView1.Columns[orderByColumn], ListSortDirection.Ascending);
        }

        private void btnSCVGiam_Click(object sender, EventArgs e)
        {
            string orderByColumn = "TenCV";
            dataGridView1.Sort(dataGridView1.Columns[orderByColumn], ListSortDirection.Descending);
        }

        private void btnSQQTang_Click(object sender, EventArgs e)
        {
            string orderByColumn = "DiaChi";
            dataGridView1.Sort(dataGridView1.Columns[orderByColumn], ListSortDirection.Ascending);
        }

        private void btnSQQGiam_Click(object sender, EventArgs e)
        {
            string orderByColumn = "DiaChi";
            dataGridView1.Sort(dataGridView1.Columns[orderByColumn], ListSortDirection.Descending);
        }

        private void btnSNSTang_Click(object sender, EventArgs e)
        {
            string orderByColumn = "NgaySinh";
            dataGridView1.Sort(dataGridView1.Columns[orderByColumn], ListSortDirection.Ascending);
        }

        private void btnSNSGiam_Click(object sender, EventArgs e)
        {
            string orderByColumn = "NgaySinh";
            dataGridView1.Sort(dataGridView1.Columns[orderByColumn], ListSortDirection.Descending);
        }

        private void tbxSearch_Enter(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        

    }
}
