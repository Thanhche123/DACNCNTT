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
    public partial class FrChinhSuaPB : Form
    {
        Modify modify;
        private QLPhongBan _phongBan;
        private string maPB;
        //private QLNhanVien nhanVien;
        public FrChinhSuaPB()
        {
            InitializeComponent();
            Program.DoubleBuffered(dataGridView1, true);
        }

        public void SetMaPB(string maPB)
        {
            this.maPB = maPB;
        }

        public FrChinhSuaPB(QLPhongBan phongBan) : this()
        {
            _phongBan = phongBan;
            HienThiThongTinPB();
            LoadComboBoxes();
        }

        private void HienThiThongTinPB()
        {
            txtTenPB.Text = _phongBan.TenPB;
            txtMoTa.Text = _phongBan.MoTa;

        }
        private void FrChinhSuaPB_Load(object sender, EventArgs e)
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
            
            string nvQuery = "UPDATE tblNhanVien SET MaPB = @MaPB, MaCV = 'CV002' WHERE MaNV = @MaNV";

            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(nvQuery, sqlConnection))
                {
                    command.Parameters.AddWithValue("@MaPB", maPB);
                    command.Parameters.AddWithValue("@MaNV", MaNV);


                    command.ExecuteNonQuery();

                }
                sqlConnection.Close();
            }
            LoadComboBoxes();
            dataGridView1.DataSource = modify.getDanhSachCTPB();
            
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
            string nvQuery = "UPDATE tblNhanVien SET MaPB = @MaPB, MaCV = 'CV003' WHERE MaNV = @MaNV";

            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(nvQuery, sqlConnection))
                {
                    command.Parameters.AddWithValue("@MaPB", maPB);
                    command.Parameters.AddWithValue("@MaNV", MaNV);


                    command.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
            LoadComboBoxes();
            dataGridView1.DataSource = modify.getDanhSachCTPB();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (txtTenPB != null)
            {
                string TenPB = this.txtTenPB.Text;
                string MoTa = this.txtMoTa.Text;
                QLPhongBan phongBan = new QLPhongBan(TenPB, MoTa ?? "");
                modify.updatePB(phongBan, maPB);
                //MessageBox.Show(maPB, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Thông tin chỉnh sửa đã được lưu lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên phòng ban!!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var cellValue = dataGridView1.SelectedRows[0].Cells[0].Value;
                if (cellValue != null)
                {
                    string MaNV = cellValue.ToString();
                    //MessageBox.Show(MaNV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string nvQuery = "UPDATE tblNhanVien SET MaPB = 'PB001', MaCV = 'CV001' WHERE MaNV = @MaNV";
                    using (SqlConnection sqlConnection = connection.GetConnection())
                    {
                        sqlConnection.Open();
                        using (SqlCommand command = new SqlCommand(nvQuery, sqlConnection))
                        {
                            command.Parameters.AddWithValue("@MaNV", MaNV);

                            command.ExecuteNonQuery();
                        }
                        sqlConnection.Close();
                    }
                    LoadComboBoxes();
                    dataGridView1.DataSource = modify.getDanhSachCTPB();
                }
                else
                {
                    MessageBox.Show("Giá trị Mã NV không hợp lệ.", "Lỗi");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var cellValue = dataGridView1.SelectedRows[0].Cells[0].Value;
                if (cellValue != null)
                {
                    string MaNV = cellValue.ToString();
                    //MessageBox.Show(MaNV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //string maNV = dataGridView1.SelectedRows[0].Cells["MaNV"].Value.ToString();
                    string HoTenNV = dataGridView1.SelectedRows[0].Cells["HoTenNV"].Value.ToString();
                    DateTime NgaySinh = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["NgaySinh"].Value.ToString());
                    string DiaChi = dataGridView1.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                    string GioiTinh = dataGridView1.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                    string SoDT = dataGridView1.SelectedRows[0].Cells["SoDT"].Value.ToString();
                    string Email = dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString();
                    string TenPB = maPB;
                    string TenCV = dataGridView1.SelectedRows[0].Cells["TenCV"].Value.ToString();

                    var nhanVien = new QLNhanVien(HoTenNV, NgaySinh, GioiTinh, DiaChi, SoDT, Email, TenPB, TenCV);
                    FrChuyenNV f = new FrChuyenNV(nhanVien);
                    f.SetMaNV(MaNV);
                    f.ShowDialog();
                    dataGridView1.DataSource = modify.getDanhSachCTPB();
                }
                else
                {
                    MessageBox.Show("Giá trị Mã NV không hợp lệ.", "Lỗi");
                }
            }
        }
    }
}
