namespace QuanLyNhanSu
{
    partial class FrTinhLuong
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
            this.txtChonNam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTimPB = new System.Windows.Forms.ComboBox();
            this.txtHienTenPB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtChonThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChonNam
            // 
            this.txtChonNam.FormattingEnabled = true;
            this.txtChonNam.Location = new System.Drawing.Point(151, 121);
            this.txtChonNam.Name = "txtChonNam";
            this.txtChonNam.Size = new System.Drawing.Size(145, 24);
            this.txtChonNam.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Chọn năm:";
            // 
            // cbxTimPB
            // 
            this.cbxTimPB.FormattingEnabled = true;
            this.cbxTimPB.Location = new System.Drawing.Point(189, 46);
            this.cbxTimPB.Name = "cbxTimPB";
            this.cbxTimPB.Size = new System.Drawing.Size(244, 24);
            this.cbxTimPB.TabIndex = 32;
            this.cbxTimPB.TextChanged += new System.EventHandler(this.cbxTimPB_TextChanged);
            this.cbxTimPB.Click += new System.EventHandler(this.cbxTimPB_Click);
            this.cbxTimPB.Enter += new System.EventHandler(this.cbxTimPB_Enter);
            // 
            // txtHienTenPB
            // 
            this.txtHienTenPB.Enabled = false;
            this.txtHienTenPB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHienTenPB.Location = new System.Drawing.Point(555, 56);
            this.txtHienTenPB.Name = "txtHienTenPB";
            this.txtHienTenPB.ReadOnly = true;
            this.txtHienTenPB.Size = new System.Drawing.Size(176, 34);
            this.txtHienTenPB.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tính lương";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(671, 385);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 33);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(729, 220);
            this.dataGridView1.TabIndex = 28;
            // 
            // txtChonThang
            // 
            this.txtChonThang.FormattingEnabled = true;
            this.txtChonThang.Location = new System.Drawing.Point(151, 83);
            this.txtChonThang.Name = "txtChonThang";
            this.txtChonThang.Size = new System.Drawing.Size(145, 24);
            this.txtChonThang.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Chọn tháng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Chọn phòng ban:";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(598, 116);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(94, 33);
            this.btnXem.TabIndex = 35;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // FrTinhLuong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(804, 430);
            this.Controls.Add(this.btnXem);
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
            this.Name = "FrTinhLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrTinhLuong";
            this.Load += new System.EventHandler(this.FrTinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtChonNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTimPB;
        private System.Windows.Forms.TextBox txtHienTenPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txtChonThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXem;
    }
}