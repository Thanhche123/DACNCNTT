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
    public partial class FrChiTietPB : Form
    {
        Modify modify;
        private QLPhongBan _phongBan;
        private string maPB;
        public FrChiTietPB()
        {
            InitializeComponent();
        }

        public void SetMaPB(string maPB)
        {
            this.maPB = maPB;
        }

        public FrChiTietPB(QLPhongBan phongBan) : this()
        {
            _phongBan = phongBan;
            HienThiThongTinPB();
        }

        private void HienThiThongTinPB()
        {

            txtTenPB.Text = _phongBan.TenPB;
            txtMoTa.Text = _phongBan.MoTa;
        }
        

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrChiTietPB_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            modify.SetMaPB(maPB);
            try
            {
                dataGridView1.DataSource = modify.getDanhSachCTPB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
