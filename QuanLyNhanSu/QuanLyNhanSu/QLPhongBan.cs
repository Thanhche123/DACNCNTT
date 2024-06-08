using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    public class QLPhongBan
    {
        public string TenPB { get; set; }

        public string MoTa { get; set;}

        public QLPhongBan(string tenPB, string moTa) 
        { 
            TenPB = tenPB;
            MoTa = moTa;
        }

        public QLPhongBan()
        {
        }
    }
}
