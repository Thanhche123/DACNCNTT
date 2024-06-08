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
    public partial class FrThongKe : Form
    {
        public FrThongKe()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        private void chxAllCV_CheckedChanged(object sender, EventArgs e)
        {
            if (chxAllCV.Checked)
            {
                chxQL.Checked = false;
                chxNV.Checked = false;
            }
        }

        private void chxQL_CheckedChanged(object sender, EventArgs e)
        {
            if (chxQL.Checked)
            {
                chxAllCV.Checked = false;
                chxNV.Checked = false;
            }
        }

        private void chxNV_CheckedChanged(object sender, EventArgs e)
        {
            if (chxNV.Checked)
            {
                chxQL.Checked = false;
                chxAllCV.Checked = false;
            }
        }

        private void chxAllGT_CheckedChanged(object sender, EventArgs e)
        {
            if (chxAllGT.Checked)
            {
                chxNam.Checked = false;
                chxNu.Checked = false;
            }
        }

        private void chxNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chxNam.Checked)
            {
                chxNu.Checked = false;
                chxAllGT.Checked = false;
            }
        }

        private void chxNu_CheckedChanged(object sender, EventArgs e)
        {
            if (chxNu.Checked)
            {
                chxNam.Checked = false;
                chxAllGT.Checked = false;
            }
        }

        private void LoadComboBoxes()
        {
            string queryPB = "SELECT MaPB, TenPB FROM tblPhongBan where MaPB <> 'PB001'";
            DataTable dtPB = GetDataTable(queryPB, "");
            cbxPB.DataSource = dtPB;
            cbxPB.DisplayMember = "TenPB";
            cbxPB.ValueMember = "MaPB";
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

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            string MaCV = null;
            string GioiTinh = null;

            if (chxAllCV.Checked)
            {
                
            }
            else if (chxNV.Checked)
            {
                MaCV = "CV003";
            }
            else if (chxQL.Checked)
            {
                MaCV = "CV002";
            }
            if (chxAllGT.Checked)
            {
                
            }
            else if (chxNam.Checked)
            {
                GioiTinh = "Nam";
            }
            else if (chxNu.Checked)
            {
                GioiTinh = "Nữ";
            }
            int resultCount = 0;
            //MessageBox.Show(MaCV + GioiTinh,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            string query = "SELECT COUNT(MaNV) FROM tblNhanVien WHERE 1=1";
            if (string.IsNullOrEmpty(MaCV) && string.IsNullOrEmpty(GioiTinh))
            {
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        sqlConnection.Open();
                        resultCount = (int)command.ExecuteScalar();
                        sqlConnection.Close();
                    }
                }
            }
            if (!string.IsNullOrEmpty(MaCV))
            {
                query += " AND MaCV = @MaCV";
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@MaCV", MaCV);
                        sqlConnection.Open();
                        resultCount = (int)command.ExecuteScalar();
                        sqlConnection.Close();
                    }
                }
            }
            if (!string.IsNullOrEmpty(GioiTinh))
            {
                query += " AND GioiTinh = @GioiTinh";
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@MaCV", MaCV);
                        command.Parameters.AddWithValue("@GioiTinh", GioiTinh);

                        sqlConnection.Open();
                        resultCount = (int)command.ExecuteScalar();
                        sqlConnection.Close();
                    }
                }
            }
            txtNV.Text = resultCount.ToString();
        }

        private void btnSearchL_Click(object sender, EventArgs e)
        {
            int resultCount = 0;
            string MaPB;
            string searchQuery = "SELECT MaPB FROM tblPhongBan WHERE TenPB = @TenPB";
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(searchQuery, sqlConnection))
                {
                    command.Parameters.AddWithValue("@TenPB", cbxPB.Text);

                    MaPB = (string)command.ExecuteScalar();
                }
                sqlConnection.Close();
            }
            string Thang = cbxThang.Text;
            string Nam = cbxNam.Text;
            if (chxAllPB.Checked)
            {
                string query = "SELECT Sum(L.LuongNet) FROM tblLuong L join tblNhanVien NV on NV.MaNV = L.MaNV WHERE L.Thang = @Thang and L.Nam =@Nam";
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@Thang", Thang);
                        command.Parameters.AddWithValue("@Nam", Nam);

                        sqlConnection.Open();
                        resultCount = (int)command.ExecuteScalar();
                        sqlConnection.Close();
                    }
                }
                txtLuong.Text = resultCount.ToString();
            }
            // MessageBox.Show(MaPB + Thang + Nam,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string query = "SELECT Sum(L.LuongNet) FROM tblLuong L join tblNhanVien NV on NV.MaNV = L.MaNV WHERE NV.MaPB = @MaPB and L.Thang = @Thang and L.Nam =@Nam";
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@MaPB", MaPB);
                        command.Parameters.AddWithValue("@Thang", Thang);
                        command.Parameters.AddWithValue("@Nam", Nam);

                        sqlConnection.Open();
                        resultCount = (int)command.ExecuteScalar();
                        sqlConnection.Close();
                    }
                }
                txtLuong.Text = resultCount.ToString();
            }
        }

        private void FrThongKe_Load(object sender, EventArgs e)
        {

        }

        private bool clickne = false;
        private void cbxPB_TextChanged(object sender, EventArgs e)
        {
            if (clickne)
            {
                string maPB;
                string searchQuery = "SELECT MaPB FROM tblPhongBan WHERE TenPB = @TenPB";
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand command = new SqlCommand(searchQuery, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@TenPB", cbxPB.Text);

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
                        cbxThang.DataSource = dtT;
                        cbxThang.DisplayMember = "Thang";
                        cbxThang.ValueMember = "Thang";
                    }
                    else
                    {
                        cbxThang.DataSource = null;
                        cbxThang.Text = "";
                    }

                    string queryN = "SELECT DISTINCT L.Nam FROM tblNhanVien NV join tblLuong L on L.MaNV = NV.MaNV join tblPhongBan PB on PB.MaPB = NV.MaPB where PB.MaPB = @MaPB";
                    DataTable dtN = GetDataTable(queryN, maPB);
                    if (dtT.Rows.Count > 0)
                    {
                        cbxNam.DataSource = dtN;
                        cbxNam.DisplayMember = "Nam";
                        cbxNam.ValueMember = "Nam";
                    }
                    else
                    {
                        cbxNam.DataSource = null;
                        cbxNam.Text = "";
                    }
                }
            }
        }

        private void cbxPB_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxPB_MouseCaptureChanged(object sender, EventArgs e)
        {
            clickne = true;
        }
        private void chxAllPB_Click(object sender, EventArgs e)
        {
            if (chxAllPB.Checked)
            {
                string queryAllT = "SELECT DISTINCT L.Thang FROM tblNhanVien NV join tblLuong L on L.MaNV = NV.MaNV join tblPhongBan PB on PB.MaPB = NV.MaPB";
                DataTable dtAllT = GetDataTable(queryAllT, "");
                cbxThang.DataSource = dtAllT;
                cbxThang.DisplayMember = "Thang";
                cbxThang.ValueMember = "Thang";

                string queryAllN = "SELECT DISTINCT L.Nam FROM tblNhanVien NV join tblLuong L on L.MaNV = NV.MaNV join tblPhongBan PB on PB.MaPB = NV.MaPB";
                DataTable dtAllN = GetDataTable(queryAllN, "");
                cbxNam.DataSource = dtAllN;
                cbxNam.DisplayMember = "Nam";
                cbxNam.ValueMember = "Nam";
            }
        }
    }
}
