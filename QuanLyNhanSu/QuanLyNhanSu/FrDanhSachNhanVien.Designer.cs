namespace QuanLyNhanSu
{
    partial class FrDanhSachNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrDanhSachNhanVien));
            this.lbDSNV = new System.Windows.Forms.Label();
            this.cbxTimTen = new System.Windows.Forms.CheckBox();
            this.cbxTimChucVu = new System.Windows.Forms.CheckBox();
            this.cbxTimQueQuan = new System.Windows.Forms.CheckBox();
            this.cbxTimNamSinh = new System.Windows.Forms.CheckBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.cbxTimPhongBan = new System.Windows.Forms.CheckBox();
            this.grbDSNV = new System.Windows.Forms.GroupBox();
            this.btnResert = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSNSGiam = new System.Windows.Forms.Button();
            this.btnSNSTang = new System.Windows.Forms.Button();
            this.btnSQQGiam = new System.Windows.Forms.Button();
            this.btnSQQTang = new System.Windows.Forms.Button();
            this.btnSCVGiam = new System.Windows.Forms.Button();
            this.btnSCVTang = new System.Windows.Forms.Button();
            this.btnSNameGiam = new System.Windows.Forms.Button();
            this.btnSNameTang = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbSearch.SuspendLayout();
            this.grbDSNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDSNV
            // 
            this.lbDSNV.AutoSize = true;
            this.lbDSNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSNV.Location = new System.Drawing.Point(19, 9);
            this.lbDSNV.Name = "lbDSNV";
            this.lbDSNV.Size = new System.Drawing.Size(180, 23);
            this.lbDSNV.TabIndex = 0;
            this.lbDSNV.Text = "Danh sách nhân viên";
            // 
            // cbxTimTen
            // 
            this.cbxTimTen.AutoSize = true;
            this.cbxTimTen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimTen.Location = new System.Drawing.Point(17, 19);
            this.cbxTimTen.Name = "cbxTimTen";
            this.cbxTimTen.Size = new System.Drawing.Size(107, 21);
            this.cbxTimTen.TabIndex = 1;
            this.cbxTimTen.Text = "Tìm kiếm tên";
            this.cbxTimTen.UseVisualStyleBackColor = true;
            this.cbxTimTen.CheckedChanged += new System.EventHandler(this.cbxTimTen_CheckedChanged);
            // 
            // cbxTimChucVu
            // 
            this.cbxTimChucVu.AutoSize = true;
            this.cbxTimChucVu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimChucVu.Location = new System.Drawing.Point(130, 19);
            this.cbxTimChucVu.Name = "cbxTimChucVu";
            this.cbxTimChucVu.Size = new System.Drawing.Size(136, 21);
            this.cbxTimChucVu.TabIndex = 2;
            this.cbxTimChucVu.Text = "Tìm kiếm chức vụ";
            this.cbxTimChucVu.UseVisualStyleBackColor = true;
            this.cbxTimChucVu.CheckedChanged += new System.EventHandler(this.cbxTimChucVu_CheckedChanged);
            // 
            // cbxTimQueQuan
            // 
            this.cbxTimQueQuan.AutoSize = true;
            this.cbxTimQueQuan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimQueQuan.Location = new System.Drawing.Point(442, 19);
            this.cbxTimQueQuan.Name = "cbxTimQueQuan";
            this.cbxTimQueQuan.Size = new System.Drawing.Size(142, 21);
            this.cbxTimQueQuan.TabIndex = 3;
            this.cbxTimQueQuan.Text = "Tìm kiếm quê quán";
            this.cbxTimQueQuan.UseVisualStyleBackColor = true;
            this.cbxTimQueQuan.CheckedChanged += new System.EventHandler(this.cbxTimQueQuan_CheckedChanged);
            // 
            // cbxTimNamSinh
            // 
            this.cbxTimNamSinh.AutoSize = true;
            this.cbxTimNamSinh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimNamSinh.Location = new System.Drawing.Point(591, 19);
            this.cbxTimNamSinh.Name = "cbxTimNamSinh";
            this.cbxTimNamSinh.Size = new System.Drawing.Size(141, 21);
            this.cbxTimNamSinh.TabIndex = 4;
            this.cbxTimNamSinh.Text = "Tìm kiếm năm sinh";
            this.cbxTimNamSinh.UseVisualStyleBackColor = true;
            this.cbxTimNamSinh.CheckedChanged += new System.EventHandler(this.cbxTimNamSinh_CheckedChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(36, 71);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(148, 17);
            this.lbSearch.TabIndex = 5;
            this.lbSearch.Text = "Nhập thông tin tìm kiếm";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(190, 68);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(394, 22);
            this.tbxSearch.TabIndex = 6;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            this.tbxSearch.Enter += new System.EventHandler(this.tbxSearch_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(590, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 29);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.cbxTimPhongBan);
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.tbxSearch);
            this.grbSearch.Controls.Add(this.lbSearch);
            this.grbSearch.Controls.Add(this.cbxTimNamSinh);
            this.grbSearch.Controls.Add(this.cbxTimQueQuan);
            this.grbSearch.Controls.Add(this.cbxTimChucVu);
            this.grbSearch.Controls.Add(this.cbxTimTen);
            this.grbSearch.Location = new System.Drawing.Point(20, 51);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(767, 107);
            this.grbSearch.TabIndex = 8;
            this.grbSearch.TabStop = false;
            // 
            // cbxTimPhongBan
            // 
            this.cbxTimPhongBan.AutoSize = true;
            this.cbxTimPhongBan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimPhongBan.Location = new System.Drawing.Point(278, 19);
            this.cbxTimPhongBan.Name = "cbxTimPhongBan";
            this.cbxTimPhongBan.Size = new System.Drawing.Size(149, 21);
            this.cbxTimPhongBan.TabIndex = 8;
            this.cbxTimPhongBan.Text = "Tìm kiếm phòng ban";
            this.cbxTimPhongBan.UseVisualStyleBackColor = true;
            this.cbxTimPhongBan.CheckedChanged += new System.EventHandler(this.cbxTimPhongBan_CheckedChanged_1);
            // 
            // grbDSNV
            // 
            this.grbDSNV.Controls.Add(this.btnResert);
            this.grbDSNV.Controls.Add(this.btnThemNV);
            this.grbDSNV.Controls.Add(this.btnXoa);
            this.grbDSNV.Controls.Add(this.btnChinhSua);
            this.grbDSNV.Controls.Add(this.label5);
            this.grbDSNV.Controls.Add(this.btnSNSGiam);
            this.grbDSNV.Controls.Add(this.btnSNSTang);
            this.grbDSNV.Controls.Add(this.btnSQQGiam);
            this.grbDSNV.Controls.Add(this.btnSQQTang);
            this.grbDSNV.Controls.Add(this.btnSCVGiam);
            this.grbDSNV.Controls.Add(this.btnSCVTang);
            this.grbDSNV.Controls.Add(this.btnSNameGiam);
            this.grbDSNV.Controls.Add(this.btnSNameTang);
            this.grbDSNV.Controls.Add(this.label4);
            this.grbDSNV.Controls.Add(this.label3);
            this.grbDSNV.Controls.Add(this.label2);
            this.grbDSNV.Controls.Add(this.label1);
            this.grbDSNV.Controls.Add(this.dataGridView1);
            this.grbDSNV.Location = new System.Drawing.Point(20, 164);
            this.grbDSNV.Name = "grbDSNV";
            this.grbDSNV.Size = new System.Drawing.Size(766, 253);
            this.grbDSNV.TabIndex = 9;
            this.grbDSNV.TabStop = false;
            this.grbDSNV.Enter += new System.EventHandler(this.grbDSNV_Enter);
            // 
            // btnResert
            // 
            this.btnResert.Image = ((System.Drawing.Image)(resources.GetObject("btnResert.Image")));
            this.btnResert.Location = new System.Drawing.Point(613, 15);
            this.btnResert.Name = "btnResert";
            this.btnResert.Size = new System.Drawing.Size(22, 27);
            this.btnResert.TabIndex = 17;
            this.btnResert.UseVisualStyleBackColor = true;
            this.btnResert.Click += new System.EventHandler(this.btnResert_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.Blue;
            this.btnThemNV.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThemNV.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemNV.Location = new System.Drawing.Point(656, 125);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(1);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(97, 28);
            this.btnThemNV.TabIndex = 16;
            this.btnThemNV.Text = "Thêm mới";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(656, 198);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 28);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.LimeGreen;
            this.btnChinhSua.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChinhSua.Location = new System.Drawing.Point(656, 164);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(1);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(97, 28);
            this.btnChinhSua.TabIndex = 14;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sắp xếp:";
            // 
            // btnSNSGiam
            // 
            this.btnSNSGiam.Image = ((System.Drawing.Image)(resources.GetObject("btnSNSGiam.Image")));
            this.btnSNSGiam.Location = new System.Drawing.Point(569, 15);
            this.btnSNSGiam.Name = "btnSNSGiam";
            this.btnSNSGiam.Size = new System.Drawing.Size(22, 27);
            this.btnSNSGiam.TabIndex = 12;
            this.btnSNSGiam.UseVisualStyleBackColor = true;
            this.btnSNSGiam.Click += new System.EventHandler(this.btnSNSGiam_Click);
            // 
            // btnSNSTang
            // 
            this.btnSNSTang.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSNSTang.Image = ((System.Drawing.Image)(resources.GetObject("btnSNSTang.Image")));
            this.btnSNSTang.Location = new System.Drawing.Point(541, 15);
            this.btnSNSTang.Name = "btnSNSTang";
            this.btnSNSTang.Size = new System.Drawing.Size(22, 27);
            this.btnSNSTang.TabIndex = 11;
            this.btnSNSTang.UseVisualStyleBackColor = true;
            this.btnSNSTang.Click += new System.EventHandler(this.btnSNSTang_Click);
            // 
            // btnSQQGiam
            // 
            this.btnSQQGiam.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSQQGiam.Image = ((System.Drawing.Image)(resources.GetObject("btnSQQGiam.Image")));
            this.btnSQQGiam.Location = new System.Drawing.Point(433, 15);
            this.btnSQQGiam.Name = "btnSQQGiam";
            this.btnSQQGiam.Size = new System.Drawing.Size(22, 27);
            this.btnSQQGiam.TabIndex = 10;
            this.btnSQQGiam.UseVisualStyleBackColor = true;
            this.btnSQQGiam.Click += new System.EventHandler(this.btnSQQGiam_Click);
            // 
            // btnSQQTang
            // 
            this.btnSQQTang.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSQQTang.Image = ((System.Drawing.Image)(resources.GetObject("btnSQQTang.Image")));
            this.btnSQQTang.Location = new System.Drawing.Point(405, 15);
            this.btnSQQTang.Name = "btnSQQTang";
            this.btnSQQTang.Size = new System.Drawing.Size(22, 27);
            this.btnSQQTang.TabIndex = 9;
            this.btnSQQTang.UseVisualStyleBackColor = true;
            this.btnSQQTang.Click += new System.EventHandler(this.btnSQQTang_Click);
            // 
            // btnSCVGiam
            // 
            this.btnSCVGiam.Image = ((System.Drawing.Image)(resources.GetObject("btnSCVGiam.Image")));
            this.btnSCVGiam.Location = new System.Drawing.Point(299, 13);
            this.btnSCVGiam.Name = "btnSCVGiam";
            this.btnSCVGiam.Size = new System.Drawing.Size(22, 27);
            this.btnSCVGiam.TabIndex = 8;
            this.btnSCVGiam.UseVisualStyleBackColor = true;
            this.btnSCVGiam.Click += new System.EventHandler(this.btnSCVGiam_Click);
            // 
            // btnSCVTang
            // 
            this.btnSCVTang.Image = ((System.Drawing.Image)(resources.GetObject("btnSCVTang.Image")));
            this.btnSCVTang.Location = new System.Drawing.Point(271, 13);
            this.btnSCVTang.Name = "btnSCVTang";
            this.btnSCVTang.Size = new System.Drawing.Size(22, 27);
            this.btnSCVTang.TabIndex = 7;
            this.btnSCVTang.UseVisualStyleBackColor = true;
            this.btnSCVTang.Click += new System.EventHandler(this.btnSCVTang_Click);
            // 
            // btnSNameGiam
            // 
            this.btnSNameGiam.Image = ((System.Drawing.Image)(resources.GetObject("btnSNameGiam.Image")));
            this.btnSNameGiam.Location = new System.Drawing.Point(172, 13);
            this.btnSNameGiam.Name = "btnSNameGiam";
            this.btnSNameGiam.Size = new System.Drawing.Size(22, 27);
            this.btnSNameGiam.TabIndex = 6;
            this.btnSNameGiam.UseVisualStyleBackColor = true;
            this.btnSNameGiam.Click += new System.EventHandler(this.btnSNameGiam_Click);
            // 
            // btnSNameTang
            // 
            this.btnSNameTang.Image = ((System.Drawing.Image)(resources.GetObject("btnSNameTang.Image")));
            this.btnSNameTang.Location = new System.Drawing.Point(144, 13);
            this.btnSNameTang.Name = "btnSNameTang";
            this.btnSNameTang.Size = new System.Drawing.Size(22, 27);
            this.btnSNameTang.TabIndex = 5;
            this.btnSNameTang.UseVisualStyleBackColor = true;
            this.btnSNameTang.Click += new System.EventHandler(this.btnSNameTang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Năm sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quê quán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Theo tên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(629, 193);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrDanhSachNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(804, 430);
            this.Controls.Add(this.grbDSNV);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.lbDSNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrDanhSachNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách nhân viên";
            this.Load += new System.EventHandler(this.FrDanhSachNhanVien_Load);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.grbDSNV.ResumeLayout(false);
            this.grbDSNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDSNV;
        private System.Windows.Forms.CheckBox cbxTimTen;
        private System.Windows.Forms.CheckBox cbxTimChucVu;
        private System.Windows.Forms.CheckBox cbxTimQueQuan;
        private System.Windows.Forms.CheckBox cbxTimNamSinh;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.GroupBox grbDSNV;
        private System.Windows.Forms.Button btnSNSGiam;
        private System.Windows.Forms.Button btnSNSTang;
        private System.Windows.Forms.Button btnSQQGiam;
        private System.Windows.Forms.Button btnSQQTang;
        private System.Windows.Forms.Button btnSCVGiam;
        private System.Windows.Forms.Button btnSCVTang;
        private System.Windows.Forms.Button btnSNameGiam;
        private System.Windows.Forms.Button btnSNameTang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnResert;
        private System.Windows.Forms.CheckBox cbxTimPhongBan;
    }
}