using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FrHoSoCaNhan : Form
    {
        private string maNV;

        public void SetMaNV(string maNV)
        {
            this.maNV = maNV;
        }
        public FrHoSoCaNhan()
        {
            InitializeComponent();
            HienThiThongTinNhanVien();
        }


        private void HienThiThongTinNhanVien()
        {
            /*LoadComboBoxes();
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
            }*/

        }

       
    }
}
