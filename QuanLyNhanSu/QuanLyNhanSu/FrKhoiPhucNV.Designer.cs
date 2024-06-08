namespace QuanLyNhanSu
{
    partial class FrKhoiPhucNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnHuythemNV = new System.Windows.Forms.Button();
            this.btnKhoiPhucNV = new System.Windows.Forms.Button();
            this.txtPB = new System.Windows.Forms.ComboBox();
            this.txtCV = new System.Windows.Forms.ComboBox();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.grbThemNV = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbThemNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Khôi phục nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-6, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(20, 89);
            this.dataGridView1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Giới tính:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // btnHuythemNV
            // 
            this.btnHuythemNV.BackColor = System.Drawing.Color.Red;
            this.btnHuythemNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuythemNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuythemNV.Location = new System.Drawing.Point(401, 272);
            this.btnHuythemNV.Name = "btnHuythemNV";
            this.btnHuythemNV.Size = new System.Drawing.Size(106, 30);
            this.btnHuythemNV.TabIndex = 20;
            this.btnHuythemNV.Text = "Hủy";
            this.btnHuythemNV.UseVisualStyleBackColor = false;
            this.btnHuythemNV.Click += new System.EventHandler(this.btnHuythemNV_Click);
            // 
            // btnKhoiPhucNV
            // 
            this.btnKhoiPhucNV.BackColor = System.Drawing.Color.LimeGreen;
            this.btnKhoiPhucNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhucNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKhoiPhucNV.Location = new System.Drawing.Point(513, 272);
            this.btnKhoiPhucNV.Name = "btnKhoiPhucNV";
            this.btnKhoiPhucNV.Size = new System.Drawing.Size(106, 30);
            this.btnKhoiPhucNV.TabIndex = 2;
            this.btnKhoiPhucNV.Text = "Khôi phục";
            this.btnKhoiPhucNV.UseVisualStyleBackColor = false;
            this.btnKhoiPhucNV.Click += new System.EventHandler(this.btnKhoiPhucNV_Click);
            // 
            // txtPB
            // 
            this.txtPB.FormattingEnabled = true;
            this.txtPB.Location = new System.Drawing.Point(99, 193);
            this.txtPB.Name = "txtPB";
            this.txtPB.Size = new System.Drawing.Size(156, 24);
            this.txtPB.TabIndex = 19;
            // 
            // txtCV
            // 
            this.txtCV.FormattingEnabled = true;
            this.txtCV.Location = new System.Drawing.Point(366, 193);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(153, 24);
            this.txtCV.TabIndex = 18;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNu.Location = new System.Drawing.Point(576, 18);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(51, 23);
            this.rdoNu.TabIndex = 17;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNam.Location = new System.Drawing.Point(513, 18);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(62, 23);
            this.rdoNam.TabIndex = 16;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(291, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Chức vụ:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(354, 138);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(295, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(118, 140);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(172, 22);
            this.txtSDT.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(80, 96);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(570, 22);
            this.txtDiaChi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(80, 16);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(274, 22);
            this.txtTenNV.TabIndex = 1;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(9, 19);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(60, 19);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ tên:";
            // 
            // grbThemNV
            // 
            this.grbThemNV.BackColor = System.Drawing.SystemColors.Control;
            this.grbThemNV.Controls.Add(this.dataGridView1);
            this.grbThemNV.Controls.Add(this.label2);
            this.grbThemNV.Controls.Add(this.dateTimePicker1);
            this.grbThemNV.Controls.Add(this.btnHuythemNV);
            this.grbThemNV.Controls.Add(this.btnKhoiPhucNV);
            this.grbThemNV.Controls.Add(this.txtPB);
            this.grbThemNV.Controls.Add(this.txtCV);
            this.grbThemNV.Controls.Add(this.rdoNu);
            this.grbThemNV.Controls.Add(this.rdoNam);
            this.grbThemNV.Controls.Add(this.label9);
            this.grbThemNV.Controls.Add(this.label8);
            this.grbThemNV.Controls.Add(this.txtEmail);
            this.grbThemNV.Controls.Add(this.label7);
            this.grbThemNV.Controls.Add(this.txtSDT);
            this.grbThemNV.Controls.Add(this.label6);
            this.grbThemNV.Controls.Add(this.txtDiaChi);
            this.grbThemNV.Controls.Add(this.label5);
            this.grbThemNV.Controls.Add(this.label3);
            this.grbThemNV.Controls.Add(this.txtTenNV);
            this.grbThemNV.Controls.Add(this.lbHoTen);
            this.grbThemNV.Location = new System.Drawing.Point(67, 61);
            this.grbThemNV.Name = "grbThemNV";
            this.grbThemNV.Size = new System.Drawing.Size(667, 354);
            this.grbThemNV.TabIndex = 2;
            this.grbThemNV.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Phòng ban:";
            // 
            // FrKhoiPhucNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbThemNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrKhoiPhucNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrKhoiPhucNV";
            this.Load += new System.EventHandler(this.FrKhoiPhucNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbThemNV.ResumeLayout(false);
            this.grbThemNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnHuythemNV;
        private System.Windows.Forms.Button btnKhoiPhucNV;
        private System.Windows.Forms.ComboBox txtPB;
        private System.Windows.Forms.ComboBox txtCV;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.GroupBox grbThemNV;
        private System.Windows.Forms.Label label9;
    }
}