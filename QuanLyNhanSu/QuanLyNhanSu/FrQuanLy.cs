using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public partial class FrQuanLy : Form
    {
        private Form currentForm;
        
        
        public FrQuanLy()
        {
            InitializeComponent();
            SwitchForm(new FrMenuload());
            
        }

        bool Sidebar = false;
        private void sidebar_Tick(object sender, EventArgs e)
        {
            SwitchForm(new FrMenuload());
            if (Sidebar == false)
            {
                lbfSidebar.Width += 5;
                if (lbfSidebar.Width >= 211)
                {
                    sidebar.Stop();
                    Sidebar = true;
                }
            }
            else
            {
                lbfSidebar.Width -= 5;
                if (lbfSidebar.Width <= 57)
                {
                    sidebar.Stop();
                    Sidebar = false;
                }
            }
        }

        private void pbxSidebar_Click(object sender, EventArgs e)
        {
            if (QuanlyNV)
            {
                lbfQLNV.Height = 49;
                QuanlyNV = false;
            }
            if (QuanlyPB)
            {
                lbfQLPB.Height = 49;
                QuanlyPB = false;
            }

            sidebar.Start();
        }

        bool QuanlyNV = false;

        private void QLNV_Tick(object sender, EventArgs e)
        {
            if (QuanlyNV == false) {
                lbfQLNV.Height += 5;
                if(lbfQLNV.Height >= 147)
                {
                    QLNV.Stop();
                    QuanlyNV = true;
                }
            }
            else
            {
                lbfQLNV.Height -= 5;
                if(lbfQLNV.Height <= 49) {
                    QLNV.Stop();
                    QuanlyNV= false;
                }
            }
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            if (QuanlyPB)
            {
                lbfQLPB.Height = 49;
                QuanlyPB = false;
            }
            QLNV.Start();
        }

        bool QuanlyPB = false;
        private void QLPB_Tick(object sender, EventArgs e)
        {
            if (QuanlyPB == false)
            {
                lbfQLPB.Height += 5;
                if (lbfQLPB.Height >= 147)
                {
                    QLPB.Stop();
                    QuanlyPB = true;
                }
            }
            else
            {
                lbfQLPB.Height -= 5;
                if (lbfQLPB.Height <= 49)
                {
                    QLPB.Stop();
                    QuanlyPB = false;
                }
            }
        }
        private void btnQLPB_Click(object sender, EventArgs e)
        {
            if (QuanlyNV)
            {
                lbfQLNV.Height = 49;
                QuanlyNV = false;
            }
            QLPB.Start();
            
        }
        private void lbfQLNV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SwitchForm(Form newForm)
        {
            
            if (currentForm != null)
            {
                currentForm.Close();
            }
            
            currentForm = newForm;
            currentForm.TopLevel = false;
            panhome.Controls.Add(currentForm);
            currentForm.Size = panhome.Size;
            currentForm.Location = new Point(0, 0);
            currentForm.Show();
        }

        private void btnDanhSachPhongBan_Click(object sender, EventArgs e)
        {
            SwitchForm(new FrDanhSachPhongBan());
        }

        private void btnThemMoiPhongBan_Click(object sender, EventArgs e)
        {
            SwitchForm(new FrThemPB());
        }

        private void btnDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            SwitchForm(new FrDanhSachNhanVien());  
        }

        private void btnThemMoiNhanVien_Click(object sender, EventArgs e)
        {
            SwitchForm(new FrNhanVienDaNghi());
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            SwitchForm(new FrDiemDanh());
            if (QuanlyNV)
            {
                lbfQLNV.Height = 49;
                QuanlyNV = false;
            }
            if (QuanlyPB)
            {
                lbfQLPB.Height = 49;
                QuanlyPB = false;
            }
            
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            SwitchForm(new FrTinhLuong());
            if (QuanlyNV)
            {
                lbfQLNV.Height = 49;
                QuanlyNV = false;
            }
            if (QuanlyPB)
            {
                lbfQLPB.Height = 49;
                QuanlyPB = false;
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SwitchForm(new FrThongKe());
            if (QuanlyNV)
            {
                lbfQLNV.Height = 49;
                QuanlyNV = false;
            }
            if (QuanlyPB)
            {
                lbfQLPB.Height = 49;
                QuanlyPB = false;
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            SwitchForm(new FrBaoCao());
            if (QuanlyNV)
            {
                lbfQLNV.Height = 49;
                QuanlyNV = false;
            }
            if (QuanlyPB)
            {
                lbfQLPB.Height = 49;
                QuanlyPB = false;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void FrQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void panhome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
