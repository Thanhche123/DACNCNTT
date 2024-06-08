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
    public partial class FrDanhSachPhongBan : Form
    {
        public FrDanhSachPhongBan()
        {
            InitializeComponent();
            Program.DoubleBuffered(dataGridView1, true);
        }

        Modify modify;
        
        private void lbDSNV_Click(object sender, EventArgs e)
        {

        }

        private void FrDanhSachPhongBan_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getDanhSachPB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = " ";
            btnColumn.Name = "btnXemThem";
            btnColumn.Text = "Xem thêm";
            btnColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnColumn);
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa phòng ban này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var cellValue = dataGridView1.SelectedRows[0].Cells[1].Value;
                    if (cellValue != null)
                    {
                        string MaPB = cellValue.ToString();
                        //MessageBox.Show(MaPB, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        string updateQuery = "UPDATE tblNhanVien SET MaPB = 'PB001', MaCV = 'CV001' WHERE MaPB = @MaPB";
                        var updateParameters = new SqlParameter[]
                        {
                            new SqlParameter("@MaPB", MaPB)
                        };
                        modify.Update(updateQuery, updateParameters);
                        string deleteQuery = "DELETE FROM tblPhongBan WHERE MaPB = @MaPB";
                        var deleteParameters = new SqlParameter[]
                        {
                            new SqlParameter("@MaPB", MaPB)
                        };
                        bool isDeleted = modify.Delete(deleteQuery, deleteParameters);
                        if (isDeleted)
                        {
                            dataGridView1.DataSource = modify.getDanhSachPB();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa phòng ban.", "Lỗi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giá trị Mã PB không hợp lệ.", "Lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Không có hàng nào được chọn.", "Lỗi");
                }
            }
        }



        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maPB = dataGridView1.SelectedRows[0].Cells["MaPB"].Value.ToString();
                string tenPB = dataGridView1.SelectedRows[0].Cells["TenPB"].Value.ToString();
                string moTa = dataGridView1.SelectedRows[0].Cells["Mota"].Value.ToString() ;
                var phongBan = new QLPhongBan(tenPB, moTa ?? "");
                FrChinhSuaPB f = new FrChinhSuaPB(phongBan);
                f.SetMaPB(maPB);
                f.ShowDialog();
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            FrThemPB f = new FrThemPB();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> searchFields = new List<string>();
            
            searchFields.Add("TenPB");
            
            string query = "select * from tblPhongBan  WHERE 1=1 and MaPB <> 'PB001'";
            string parameter = "%" + tbxSearch.Text.Trim() + "%";

            if (searchFields.Any() && !string.IsNullOrWhiteSpace(tbxSearch.Text.Trim()))
            {
                query += " AND (";
                foreach (string field in searchFields)
                {
                    query += $" {field} LIKE @search OR";
                }
                query = query.Remove(query.Length - 2);
                query += ")";
            }

            DataTable searchResult = modify.search(query, parameter);
            dataGridView1.DataSource = searchResult;
        }

        private void tbxSearch_Enter(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnXemThem")
            {
                string maPB = dataGridView1.SelectedRows[0].Cells["MaPB"].Value.ToString();
                string tenPB = dataGridView1.SelectedRows[0].Cells["TenPB"].Value.ToString();
                string moTa = dataGridView1.SelectedRows[0].Cells["Mota"].Value.ToString();
                var phongBan = new QLPhongBan(tenPB, moTa);
                FrChiTietPB f = new FrChiTietPB(phongBan);
                f.SetMaPB(maPB);
                f.ShowDialog();
            }
        }
    }
}