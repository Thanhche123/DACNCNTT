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
    public partial class FrTinhLuong : Form
    {
        Modify modify = new Modify();
        private bool clickne = false;
        public FrTinhLuong()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        private void FrTinhLuong_Load(object sender, EventArgs e)
        {

        }

        private void LoadComboBoxes()
        {
            string queryPB = "SELECT MaPB, TenPB FROM tblPhongBan where MaPB <> 'PB001'";
            DataTable dtPB = GetDataTable(queryPB, "");
            cbxTimPB.DataSource = dtPB;
            cbxTimPB.DisplayMember = "TenPB";
            cbxTimPB.ValueMember = "MaPB";
        }
        private DataTable GetDataTable(string query, string maPB)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@MaPB", maPB);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }

        private void cbxTimPB_TextChanged(object sender, EventArgs e)
        {
            if (clickne)
            {
                txtHienTenPB.Text = cbxTimPB.Text;
                string maPB;
                string searchQuery = "SELECT MaPB FROM tblPhongBan WHERE TenPB = @TenPB";
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand command = new SqlCommand(searchQuery, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@TenPB", cbxTimPB.Text);

                        maPB = (string)command.ExecuteScalar();
                    }
                    sqlConnection.Close();
                }
                //MessageBox.Show(maPB, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!string.IsNullOrEmpty(maPB))
                {
                    string queryT = "SELECT DISTINCT L.Thang FROM tblNhanVien NV join tblLuong L on L.MaNV = NV.MaNV join tblPhongBan PB on PB.MaPB = NV.MaPB where PB.MaPB = @MaPB";
                    DataTable dtT = GetDataTable(queryT, maPB);
                    if (dtT.Rows.Count > 0)
                    {
                        txtChonThang.DataSource = dtT;
                        txtChonThang.DisplayMember = "Thang";
                        txtChonThang.ValueMember = "Thang";
                    }
                    else
                    {
                        txtChonThang.DataSource = null;
                        txtChonThang.Text = "";
                    }

                    string queryN = "SELECT DISTINCT L.Nam FROM tblNhanVien NV join tblLuong L on L.MaNV = NV.MaNV join tblPhongBan PB on PB.MaPB = NV.MaPB where PB.MaPB = @MaPB";
                    DataTable dtN = GetDataTable(queryN, maPB);
                    if (dtT.Rows.Count > 0)
                    {
                        txtChonNam.DataSource = dtN;
                        txtChonNam.DisplayMember = "Nam";
                        txtChonNam.ValueMember = "Nam";
                    }
                    else
                    {
                        txtChonNam.DataSource = null;
                        txtChonNam.Text = "";
                    }
                }
            }
        }

        private void cbxTimPB_Enter(object sender, EventArgs e)
        {
            txtHienTenPB.Text = cbxTimPB.Text;
        }

        private void cbxTimPB_Click(object sender, EventArgs e)
        {
            clickne = true;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
                string MaPB;
                string searchQuery = "SELECT MaPB FROM tblPhongBan WHERE TenPB = @TenPB";
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand command = new SqlCommand(searchQuery, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@TenPB", cbxTimPB.Text);

                        MaPB = (string)command.ExecuteScalar();
                    }
                    sqlConnection.Close();
                }
            //MessageBox.Show(MaPB + txtChonThang.Text + txtChonNam.Text, "",MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (!string.IsNullOrEmpty(MaPB))
            {
                string query = "select NV.MaNV, NV.HoTenNV, CV.TenCV, L.LuongNet from tblNhanVien NV " +
                               "join tblChucVu CV on NV.MaCV = CV.MaCV " +
                               "join tblPhongBan PB on NV.MaPB = PB.MaPB " +
                               "join tblLuong L on L.MaNV = NV.MaNV " +
                               "where PB.MaPB = @MaPB and L.Thang = @Thang and L.Nam = @Nam";

                DataTable dt = new DataTable();
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@MaPB", MaPB);
                        command.Parameters.AddWithValue("@Thang", txtChonThang.Text);
                        command.Parameters.AddWithValue("@Nam", txtChonNam.Text);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    sqlConnection.Close();
                }

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy Mã Phòng Ban.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }
}

