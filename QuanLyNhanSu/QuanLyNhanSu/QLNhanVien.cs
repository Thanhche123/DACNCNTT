using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    public class QLNhanVien
    {
        //public string MaNV { get; set; }
        //public string MatKhau { get; set; }
        public string HoTenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public string Email { get; set; }
        public string MaPB { get; set; }
        public string MaCV { get; set; }

        public QLNhanVien( string hoTenNV, DateTime ngaySinh, string gioiTinh, string diaChi, string soDT, string email, string maPB, string maCV)
        {
           // MaNV = maNV;
            HoTenNV = hoTenNV;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SoDT = soDT;
            Email = email;
            MaPB = maPB;
            MaCV = maCV;
        }
    }
}
