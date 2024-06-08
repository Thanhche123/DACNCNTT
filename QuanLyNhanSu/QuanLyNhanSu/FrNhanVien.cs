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
    public partial class FrNhanVien : Form
    {
        private Form currentForm;
        public FrNhanVien()
        {
            InitializeComponent();
            SwitchForm(new FrMenuload());
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

        bool Sidebar = false;

        private void pbxSidebar_Click(object sender, EventArgs e)
        {
            sidebar.Start();
        }

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

        private void btnHoSoCaNhan_Click(object sender, EventArgs e)
        {
            SwitchForm(new FrHoSoCaNhan());
        }

        private void btnXemLuong_Click(object sender, EventArgs e)
        {

        }

        private void panhome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
