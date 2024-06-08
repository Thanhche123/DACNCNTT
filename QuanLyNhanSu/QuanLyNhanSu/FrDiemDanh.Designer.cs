namespace QuanLyNhanSu
{
    partial class FrDiemDanh
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
            this.txtHienTenPB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtChonThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTimPB = new System.Windows.Forms.ComboBox();
            this.txtChonNam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHienTenPB
            // 
            this.txtHienTenPB.Enabled = false;
            this.txtHienTenPB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHienTenPB.Location = new System.Drawing.Point(260, 87);
            this.txtHienTenPB.Name = "txtHienTenPB";
            this.txtHienTenPB.ReadOnly = true;
            this.txtHienTenPB.Size = new System.Drawing.Size(176, 34);
            this.txtHienTenPB.TabIndex = 21;
            this.txtHienTenPB.TextChanged += new System.EventHandler(this.txtHienTenPB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Chấm công nhân viên";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(668, 356);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 33);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(609, 253);
            this.dataGridView1.TabIndex = 17;
            // 
            // txtChonThang
            // 
            this.txtChonThang.FormattingEnabled = true;
            this.txtChonThang.Location = new System.Drawing.Point(627, 49);
            this.txtChonThang.Name = "txtChonThang";
            this.txtChonThang.Size = new System.Drawing.Size(145, 24);
            this.txtChonThang.TabIndex = 16;
            this.txtChonThang.SelectedIndexChanged += new System.EventHandler(this.txtChonThang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chọn tháng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chọn phòng ban:";
            // 
            // cbxTimPB
            // 
            this.cbxTimPB.FormattingEnabled = true;
            this.cbxTimPB.Location = new System.Drawing.Point(192, 49);
            this.cbxTimPB.Name = "cbxTimPB";
            this.cbxTimPB.Size = new System.Drawing.Size(244, 24);
            this.cbxTimPB.TabIndex = 22;
            this.cbxTimPB.SelectedIndexChanged += new System.EventHandler(this.cbxTimPB_SelectedIndexChanged);
            this.cbxTimPB.TextChanged += new System.EventHandler(this.cbxTimPB_TextChanged);
            this.cbxTimPB.Click += new System.EventHandler(this.cbxTimPB_Click);
            this.cbxTimPB.Enter += new System.EventHandler(this.cbxTimPB_Enter);
            // 
            // txtChonNam
            // 
            this.txtChonNam.FormattingEnabled = true;
            this.txtChonNam.Location = new System.Drawing.Point(627, 87);
            this.txtChonNam.Name = "txtChonNam";
            this.txtChonNam.Size = new System.Drawing.Size(145, 24);
            this.txtChonNam.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Chọn năm:";
            // 
            // FrDiemDanh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(804, 430);
            this.Controls.Add(this.txtChonNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxTimPB);
            this.Controls.Add(this.txtHienTenPB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtChonThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrDiemDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrDiemDanh";
            this.Load += new System.EventHandler(this.FrDiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHienTenPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txtChonThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTimPB;
        private System.Windows.Forms.ComboBox txtChonNam;
        private System.Windows.Forms.Label label4;
    }
}