using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    public class QLCTPhongBan
    {
        public string MaPB { get; set; }

        public string MaNV { get; set; }

        public string MaCV { get; set; }


        public QLCTPhongBan(string maPB, string maNV, string maCV)
        {
            MaPB = maPB;
            MaNV = maNV;
            MaCV = maCV;
           
        }
    }
}
