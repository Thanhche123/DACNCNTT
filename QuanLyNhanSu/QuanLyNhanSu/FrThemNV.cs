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
    public partial class FrThemNV : Form
    {
       
        public FrThemNV()
        {
            InitializeComponent();
            LoadComboBoxes();
        }
        Modify modify;
        QLNhanVien nhanVien;

        private void LoadComboBoxes()
        {
            // Load Phong Ban
            string queryPB = "SELECT MaPB, TenPB FROM tblPhongBan";
            DataTable dtPB = GetDataTable(queryPB);
            txtPB.DataSource = dtPB;
            txtPB.DisplayMember = "TenPB";
            txtPB.ValueMember = "MaPB";

            // Load Chuc Vu
            string queryCV = "SELECT MaCV, TenCV FROM tblChucVu";
            DataTable dtCV = GetDataTable(queryCV);
            txtCV.DataSource = dtCV;
            txtCV.DisplayMember = "TenCV";
            txtCV.ValueMember = "MaCV";
        }


        private DataTable GetDataTable(string query)
        {
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string name = this.txtTenNV.Text;
            string GioiTinh = (rdoNam.Checked ? rdoNam.Text : rdoNu.Text);
            DateTime NgaySinh = this.dateTimePicker1.Value;
            string DiaChi = this.txtDiaChi.Text;
            string SoDT = this.txtSDT.Text;
            string Email = this.txtEmail.Text;
            string MaPB = this.txtPB.SelectedValue.ToString();
            string MaCV = this.txtCV.SelectedValue.ToString();
           
            nhanVien = new QLNhanVien( name, NgaySinh, GioiTinh, DiaChi, SoDT, Email, MaPB, MaCV);

            if (modify.insert(nhanVien))
            {
                dataGridView1.DataSource = modify.getDanhSachNV();
                MessageBox.Show("Hoàn tất: " + "Đã thêm nhân viên", "Xong", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnHuythemNV_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrThemNV_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getDanhSachNV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrThemNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
