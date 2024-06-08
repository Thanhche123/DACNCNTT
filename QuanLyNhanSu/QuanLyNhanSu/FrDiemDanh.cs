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
    public partial class FrDiemDanh : Form
    {
        Modify modify = new Modify();
        QLPhongBan phongBan = new QLPhongBan();
        public FrDiemDanh()
        {
            InitializeComponent();
            LoadComboBoxes();

        }

        private void AddAdditionalColumn()
        {
            DataGridViewTextBoxColumn additionalColumn = new DataGridViewTextBoxColumn();
            additionalColumn.HeaderText = "SoNgay";
            additionalColumn.Name = "SoNgay";
            dataGridView1.Columns.Add(additionalColumn);
        }
        private void txtTimPB_TextChanged(object sender, EventArgs e)
        {
            

        }
        private bool clickne = false;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
       

        private void txtChonThang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHienTenPB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string insertquery = "INSERT INTO tblChamCong (MaNV, Thang, Nam, SoNgay) VALUES (@MaNV, @Thang, @Nam, @SoNgay)";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string maNV = row.Cells["MaNV"].Value.ToString();
                    string soNgay = row.Cells["SoNgay"].Value.ToString();

                    var insertParameters = new SqlParameter[]
                    {
                        new SqlParameter("@MaNV", maNV),
                        new SqlParameter("@Thang", txtChonThang.Text),
                        new SqlParameter("@Nam",txtChonNam.Text),
                        new SqlParameter("@SoNgay", soNgay)
                    };

                    modify.Update(insertquery, insertParameters);
                }
            }
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
            string inLquery = @"
                        INSERT into tblLuong (MaNV, LuongCoBan, PhuCap, KhauTru, LuongNet, Thang, Nam) 
                        values 
                        (@MaNV, @LuongCoBan, @PhuCap, @KhauTru, @LuongNet, @Thang, @Nam)";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string maNV = row.Cells["MaNV"].Value.ToString();
                    string soNgayStr = row.Cells["SoNgay"].Value.ToString();
                    int soNgay = int.Parse(soNgayStr);
                    decimal luongCoBan = 0;
                    if (MaPB == "PB002")
                    {
                        luongCoBan = 8000000;
                    }
                    else if (MaPB == "PB003")
                    {
                        luongCoBan = 5000000;
                    }

                    decimal phuCap = 500000;
                    decimal khauTru = (30 - soNgay) * 200000;
                    decimal luongNet = luongCoBan + phuCap - khauTru;

                    var inLParameters = new SqlParameter[]
                    {
                        new SqlParameter("@MaNV", maNV),
                        new SqlParameter("@LuongCoBan", luongCoBan),
                        new SqlParameter("@PhuCap", phuCap),
                        new SqlParameter("@KhauTru", khauTru),
                        new SqlParameter("@LuongNet", luongNet),
                        new SqlParameter("@Thang", txtChonThang.Text),
                        new SqlParameter("@Nam", txtChonNam.Text)
                    };

                    modify.Update(inLquery, inLParameters);
                }
            }
            MessageBox.Show("Đã chấm công tháng "+txtChonThang.Text+"/"+txtChonNam.Text+" cho phòng ban "+txtHienTenPB.Text, "Hoàn tất",MessageBoxButtons.OK,MessageBoxIcon.None);
        }

        private void FrDiemDanh_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadComboBoxes()
        {
            string queryPB = "SELECT MaPB, TenPB FROM tblPhongBan where MaPB <> 'PB001'";
            DataTable dtPB = GetDataTable(queryPB);
            cbxTimPB.DataSource = dtPB;
            cbxTimPB.DisplayMember = "TenPB";
            cbxTimPB.ValueMember = "MaPB";

            txtChonThang.Items.Clear();

            // Thêm các số từ 1 đến 10 vào ComboBox
            for (int i = 1; i <= 12; i++)
            {
                txtChonThang.Items.Add(i.ToString());
            }

            txtChonNam.Items.Clear();

            // Thêm các số từ 1 đến 10 vào ComboBox
            for (int i = 2024; i <= 2124; i++)
            {
                txtChonNam.Items.Add(i.ToString());
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
        private void cbxTimPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbxTimPB_Click(object sender, EventArgs e)
        {
            clickne = true;
        }

        private void cbxTimPB_TextChanged(object sender, EventArgs e)
        {
            if (clickne)
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
                txtHienTenPB.Text = cbxTimPB.Text;
                //MessageBox.Show(MaPB, "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                modify = new Modify();
                modify.SetMaPB(MaPB);
                try
                {
                    dataGridView1.DataSource = modify.getDanhSachDiemDanh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbxTimPB_Enter(object sender, EventArgs e)
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
            txtHienTenPB.Text = cbxTimPB.Text;
            modify = new Modify();
            modify.SetMaPB(MaPB);
            try
            {
                dataGridView1.DataSource = modify.getDanhSachDiemDanh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AddAdditionalColumn();
            //MessageBox.Show(MaPB, "", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
