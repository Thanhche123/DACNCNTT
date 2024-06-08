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
    public partial class FrSaThaiNV : Form
    {
        Modify modify = new Modify();
        //QLNhanVien nhanVien;
        private QLNhanVien _nhanVien;
        private string maNV;

        public void SetMaNV(string maNV)
        {
            this.maNV = maNV;
        }

        public FrSaThaiNV()
        {
            InitializeComponent();
        }
        public FrSaThaiNV(QLNhanVien nhanVien) : this()
        {

            _nhanVien = nhanVien;
            HienThiThongTinNhanVien();
        }

        private void HienThiThongTinNhanVien()
        {
            txtTenNV.Text = _nhanVien.HoTenNV;

            if (_nhanVien.NgaySinh < dateTimePicker1.MinDate || _nhanVien.NgaySinh > dateTimePicker1.MaxDate)
            {
                dateTimePicker1.Value = DateTime.Now;
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


        private void FrSaThaiNV_Load(object sender, EventArgs e)
        {

        }

        private void btnSaThai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn sa thải nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DateTime ngaySinh = dateTimePicker1.Value;
                string gioiTinh = rdoNam.Checked ? "Nam" : (rdoNu.Checked ? "Nữ" : null);
                //MessageBox.Show(maNV+txtLoaiNghi.Text+ngaySinh+gioiTinh+txtSDT.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                string insertquery = "INSERT INTO tblNhanVienNghiViec (HoTenNV, NgaySinh, GioiTinh, DiaChi, SoDT, Email, NgayNghi, LoaiNghi) " +
                               "VALUES (@HoTenNV, @NgaySinh, @GioiTinh, @DiaChi, @SoDT, @Email, @NgayNghi, @LoaiNghi)";
                var insertParameters = new SqlParameter[]
                {
                            new SqlParameter("@HoTenNV", txtTenNV.Text),
                            new SqlParameter("@NgaySinh", ngaySinh),
                            new SqlParameter("@GioiTinh", gioiTinh),
                            new SqlParameter("@DiaChi", txtDiaChi.Text),
                            new SqlParameter("@SoDT", txtSDT.Text),
                            new SqlParameter("@Email", txtEmail.Text),
                            new SqlParameter("@NgayNghi", txtNgayNghi.Text),
                            new SqlParameter("@LoaiNghi", txtLoaiNghi.Text),
                };
                modify.Update(insertquery, insertParameters);
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}