namespace QuanLyNhanSu
{
    partial class FrNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrNhanVien));
            this.pbxSidebar = new System.Windows.Forms.PictureBox();
            this.lbBanner = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panhome = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnXemLuong = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnHoSoCaNhan = new System.Windows.Forms.Button();
            this.lbfSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.sidebar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidebar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.lbfSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxSidebar
            // 
            this.pbxSidebar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbxSidebar.Image = ((System.Drawing.Image)(resources.GetObject("pbxSidebar.Image")));
            this.pbxSidebar.Location = new System.Drawing.Point(0, 0);
            this.pbxSidebar.Margin = new System.Windows.Forms.Padding(5);
            this.pbxSidebar.Name = "pbxSidebar";
            this.pbxSidebar.Padding = new System.Windows.Forms.Padding(13, 10, 12, 12);
            this.pbxSidebar.Size = new System.Drawing.Size(57, 47);
            this.pbxSidebar.TabIndex = 1;
            this.pbxSidebar.TabStop = false;
            this.pbxSidebar.Click += new System.EventHandler(this.pbxSidebar_Click);
            // 
            // lbBanner
            // 
            this.lbBanner.AutoSize = true;
            this.lbBanner.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBanner.Location = new System.Drawing.Point(314, 11);
            this.lbBanner.Name = "lbBanner";
            this.lbBanner.Size = new System.Drawing.Size(614, 27);
            this.lbBanner.TabIndex = 2;
            this.lbBanner.Text = "CHÀO MỪNG ĐẾN VỚI HỆ THỐNG QUẢN LÝ NHÂN SỰ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbBanner);
            this.panel1.Controls.Add(this.pbxSidebar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 47);
            this.panel1.TabIndex = 3;
            // 
            // panhome
            // 
            this.panhome.Location = new System.Drawing.Point(211, 47);
            this.panhome.Name = "panhome";
            this.panhome.Size = new System.Drawing.Size(804, 430);
            this.panhome.TabIndex = 2;
            this.panhome.Paint += new System.Windows.Forms.PaintEventHandler(this.panhome_Paint);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnDangXuat);
            this.panel10.Location = new System.Drawing.Point(0, 147);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(211, 49);
            this.panel10.TabIndex = 6;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(-12, -14);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(233, 78);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "             Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnBaoCao);
            this.panel9.Location = new System.Drawing.Point(0, 98);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(211, 49);
            this.panel9.TabIndex = 6;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnBaoCao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Image")));
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(-12, -14);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(233, 78);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.Text = "             Báo cáo";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnXemLuong);
            this.panel8.Location = new System.Drawing.Point(0, 49);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(211, 49);
            this.panel8.TabIndex = 5;
            // 
            // btnXemLuong
            // 
            this.btnXemLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnXemLuong.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLuong.ForeColor = System.Drawing.Color.White;
            this.btnXemLuong.Image = ((System.Drawing.Image)(resources.GetObject("btnXemLuong.Image")));
            this.btnXemLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemLuong.Location = new System.Drawing.Point(-12, -14);
            this.btnXemLuong.Name = "btnXemLuong";
            this.btnXemLuong.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnXemLuong.Size = new System.Drawing.Size(233, 78);
            this.btnXemLuong.TabIndex = 2;
            this.btnXemLuong.Text = "             Xem lương";
            this.btnXemLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemLuong.UseVisualStyleBackColor = false;
            this.btnXemLuong.Click += new System.EventHandler(this.btnXemLuong_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnHoSoCaNhan);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(211, 49);
            this.panel7.TabIndex = 5;
            // 
            // btnHoSoCaNhan
            // 
            this.btnHoSoCaNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnHoSoCaNhan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoSoCaNhan.ForeColor = System.Drawing.Color.White;
            this.btnHoSoCaNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnHoSoCaNhan.Image")));
            this.btnHoSoCaNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoSoCaNhan.Location = new System.Drawing.Point(-12, -14);
            this.btnHoSoCaNhan.Name = "btnHoSoCaNhan";
            this.btnHoSoCaNhan.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnHoSoCaNhan.Size = new System.Drawing.Size(233, 78);
            this.btnHoSoCaNhan.TabIndex = 2;
            this.btnHoSoCaNhan.Text = "             Hồ sơ cá nhân";
            this.btnHoSoCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoSoCaNhan.UseVisualStyleBackColor = false;
            this.btnHoSoCaNhan.Click += new System.EventHandler(this.btnHoSoCaNhan_Click);
            // 
            // lbfSidebar
            // 
            this.lbfSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lbfSidebar.Controls.Add(this.panel7);
            this.lbfSidebar.Controls.Add(this.panel8);
            this.lbfSidebar.Controls.Add(this.panel9);
            this.lbfSidebar.Controls.Add(this.panel10);
            this.lbfSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbfSidebar.Location = new System.Drawing.Point(0, 47);
            this.lbfSidebar.Name = "lbfSidebar";
            this.lbfSidebar.Size = new System.Drawing.Size(211, 430);
            this.lbfSidebar.TabIndex = 4;
            // 
            // sidebar
            // 
            this.sidebar.Interval = 10;
            this.sidebar.Tick += new System.EventHandler(this.sidebar_Tick);
            // 
            // FrNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1015, 477);
            this.Controls.Add(this.lbfSidebar);
            this.Controls.Add(this.panhome);
            this.Controls.Add(this.panel1);
            this.Name = "FrNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrNhanVien";
            this.Load += new System.EventHandler(this.FrNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidebar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.lbfSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSidebar;
        private System.Windows.Forms.Label lbBanner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panhome;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnXemLuong;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnHoSoCaNhan;
        private System.Windows.Forms.FlowLayoutPanel lbfSidebar;
        private System.Windows.Forms.Timer sidebar;
    }
}