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


namespace QuanLyNhanSu
{
    public partial class FrThemPB : Form
    {
        Modify modify;
        /*QLPhongBan phongBan;
        QLCTPhongBan ctPhongBan;*/
        public FrThemPB()
        {
            InitializeComponent();
            LoadComboBoxes();
        }
        

        private void FrThemPB_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadComboBoxes()
        {
            string queryPB = "SELECT MaNV, HoTenNV FROM tblNhanVien Where MaPB = 'PB001'";
            DataTable dtPB = GetDataTable(queryPB);
            if (dtPB.Rows.Count > 0)
            {
                cbxQL.DataSource = dtPB;
                cbxQL.DisplayMember = "HoTenNV";
                cbxQL.ValueMember = "MaNV";
            }
            else
            {
                cbxQL.DataSource = null;
                cbxQL.Text = "không có nhân viên";
            }

            string queryCV = "SELECT MaNV, HoTenNV FROM tblNhanVien Where MaPB = 'PB001'";
            DataTable dtCV = GetDataTable(queryCV);
            if (dtPB.Rows.Count > 0)
            {
                cbxNV.DataSource = dtCV;
                cbxNV.DisplayMember = "HoTenNV";
                cbxNV.ValueMember = "MaNV";
            }
            else
            {
                cbxNV.DataSource = null;
                cbxNV.Text = "Không có nhân viên";
            }
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

        private bool Taophongban = false;
        private void button1_Click(object sender, EventArgs e)
        {
            modify = new Modify();
            string TenPB = this.txtTenPB.Text;
            string MoTa = this.txtMoTa.Text;

            QLPhongBan phongBan = new QLPhongBan(TenPB, MoTa ?? "");

            if (modify.insertPB(phongBan))
            {
                dataGridView1.DataSource = modify.getDanhSachPB();
                MessageBox.Show("Hoàn tất: Tạo hoàn tất", "Xong", MessageBoxButtons.OK);
                Taophongban = true;
            }
            else
            {
                MessageBox.Show("Lỗi: Không tạo được vui lòng xem lại thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnThemQL_Click(object sender, EventArgs e)
        {
            string MaNV;
            if (cbxQL.SelectedItem != null)
            {
                MaNV = cbxQL.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string MaPB;
            string searchQuery = "SELECT MaPB FROM tblPhongBan WHERE TenPB = @TenPB";
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(searchQuery, sqlConnection))
                {
                    command.Parameters.AddWithValue("@TenPB", txtTenPB.Text);

                    MaPB = (string)command.ExecuteScalar();
                }
                sqlConnection.Close();
            }
            string nvQuery = "UPDATE tblNhanVien SET MaPB = @MaPB, MaCV = 'CV002' WHERE MaNV = @MaNV";

            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(nvQuery, sqlConnection))
                {
                    command.Parameters.AddWithValue("@MaPB", MaPB);
                    command.Parameters.AddWithValue("@MaNV", MaNV);


                    command.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
            LoadComboBoxes();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string MaNV;
            if (cbxNV.SelectedItem != null)
            {
                MaNV = cbxNV.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string MaPB;
            string searchQuery = "SELECT MaPB FROM tblPhongBan WHERE TenPB = @TenPB";
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(searchQuery, sqlConnection))
                {
                    command.Parameters.AddWithValue("@TenPB", txtTenPB.Text);

                    MaPB = (string)command.ExecuteScalar();
                }
                sqlConnection.Close();
            }
            string nvQuery = "UPDATE tblNhanVien SET MaPB = @MaPB, MaCV = 'CV003' WHERE MaNV = @MaNV";

            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(nvQuery, sqlConnection))
                {
                    command.Parameters.AddWithValue("@MaPB", MaPB);
                    command.Parameters.AddWithValue("@MaNV", MaNV);


                    command.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
            LoadComboBoxes();
        }


        private void btnHuyTaoPB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuCTPB_Click(object sender, EventArgs e)
        {
            if (Taophongban)
            {
                MessageBox.Show("Thông tin đã được lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                var result = MessageBox.Show("Phòng ban chưa được tạo, bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes) 
                {
                    this.Close();
                }
            }
        }
    }
}
