namespace QuanLyNhanSu
{
    partial class FrQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrQuanLy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbBanner = new System.Windows.Forms.Label();
            this.pbxSidebar = new System.Windows.Forms.PictureBox();
            this.lbfSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.lbfQLNV = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDanhSachNhanVien = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDanhsachnvNghi = new System.Windows.Forms.Button();
            this.lbfQLPB = new System.Windows.Forms.FlowLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnQLPB = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnDanhSachPhongBan = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnThemMoiPhongBan = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.QLNV = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.Timer(this.components);
            this.panhome = new System.Windows.Forms.Panel();
            this.QLPB = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidebar)).BeginInit();
            this.lbfSidebar.SuspendLayout();
            this.lbfQLNV.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.lbfQLPB.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 0;
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
            // lbfSidebar
            // 
            this.lbfSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lbfSidebar.Controls.Add(this.lbfQLNV);
            this.lbfSidebar.Controls.Add(this.lbfQLPB);
            this.lbfSidebar.Controls.Add(this.panel8);
            this.lbfSidebar.Controls.Add(this.panel9);
            this.lbfSidebar.Controls.Add(this.panel7);
            this.lbfSidebar.Controls.Add(this.panel6);
            this.lbfSidebar.Controls.Add(this.panel10);
            this.lbfSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbfSidebar.Location = new System.Drawing.Point(0, 47);
            this.lbfSidebar.Name = "lbfSidebar";
            this.lbfSidebar.Size = new System.Drawing.Size(211, 430);
            this.lbfSidebar.TabIndex = 1;
            // 
            // lbfQLNV
            // 
            this.lbfQLNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.lbfQLNV.Controls.Add(this.panel2);
            this.lbfQLNV.Controls.Add(this.panel4);
            this.lbfQLNV.Controls.Add(this.panel5);
            this.lbfQLNV.Location = new System.Drawing.Point(3, 3);
            this.lbfQLNV.Name = "lbfQLNV";
            this.lbfQLNV.Size = new System.Drawing.Size(211, 49);
            this.lbfQLNV.TabIndex = 5;
            this.lbfQLNV.Paint += new System.Windows.Forms.PaintEventHandler(this.lbfQLNV_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQLNV);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 49);
            this.panel2.TabIndex = 3;
            // 
            // btnQLNV
            // 
            this.btnQLNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnQLNV.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.ForeColor = System.Drawing.Color.White;
            this.btnQLNV.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNV.Image")));
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(-15, -14);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnQLNV.Size = new System.Drawing.Size(236, 78);
            this.btnQLNV.TabIndex = 2;
            this.btnQLNV.Text = "            Quản lý nhân viên";
            this.btnQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.UseVisualStyleBackColor = false;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel4.Controls.Add(this.btnDanhSachNhanVien);
            this.panel4.Location = new System.Drawing.Point(0, 49);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 49);
            this.panel4.TabIndex = 4;
            // 
            // btnDanhSachNhanVien
            // 
            this.btnDanhSachNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnDanhSachNhanVien.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachNhanVien.Image")));
            this.btnDanhSachNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachNhanVien.Location = new System.Drawing.Point(0, -14);
            this.btnDanhSachNhanVien.Name = "btnDanhSachNhanVien";
            this.btnDanhSachNhanVien.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDanhSachNhanVien.Size = new System.Drawing.Size(221, 78);
            this.btnDanhSachNhanVien.TabIndex = 2;
            this.btnDanhSachNhanVien.Text = "     Danh sách nhân viên";
            this.btnDanhSachNhanVien.UseVisualStyleBackColor = false;
            this.btnDanhSachNhanVien.Click += new System.EventHandler(this.btnDanhSachNhanVien_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel5.Controls.Add(this.btnDanhsachnvNghi);
            this.panel5.Location = new System.Drawing.Point(0, 98);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 49);
            this.panel5.TabIndex = 5;
            // 
            // btnDanhsachnvNghi
            // 
            this.btnDanhsachnvNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnDanhsachnvNghi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhsachnvNghi.ForeColor = System.Drawing.Color.White;
            this.btnDanhsachnvNghi.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhsachnvNghi.Image")));
            this.btnDanhsachnvNghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhsachnvNghi.Location = new System.Drawing.Point(0, -14);
            this.btnDanhsachnvNghi.Name = "btnDanhsachnvNghi";
            this.btnDanhsachnvNghi.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDanhsachnvNghi.Size = new System.Drawing.Size(221, 78);
            this.btnDanhsachnvNghi.TabIndex = 2;
            this.btnDanhsachnvNghi.Text = "Nhân viên đã nghỉ";
            this.btnDanhsachnvNghi.UseVisualStyleBackColor = false;
            this.btnDanhsachnvNghi.Click += new System.EventHandler(this.btnThemMoiNhanVien_Click);
            // 
            // lbfQLPB
            // 
            this.lbfQLPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.lbfQLPB.Controls.Add(this.panel11);
            this.lbfQLPB.Controls.Add(this.panel12);
            this.lbfQLPB.Controls.Add(this.panel13);
            this.lbfQLPB.Location = new System.Drawing.Point(3, 58);
            this.lbfQLPB.Name = "lbfQLPB";
            this.lbfQLPB.Size = new System.Drawing.Size(211, 49);
            this.lbfQLPB.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnQLPB);
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(211, 49);
            this.panel11.TabIndex = 3;
            // 
            // btnQLPB
            // 
            this.btnQLPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnQLPB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPB.ForeColor = System.Drawing.Color.White;
            this.btnQLPB.Image = ((System.Drawing.Image)(resources.GetObject("btnQLPB.Image")));
            this.btnQLPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPB.Location = new System.Drawing.Point(-15, -14);
            this.btnQLPB.Name = "btnQLPB";
            this.btnQLPB.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnQLPB.Size = new System.Drawing.Size(236, 78);
            this.btnQLPB.TabIndex = 2;
            this.btnQLPB.Text = "            Quản lý phòng ban";
            this.btnQLPB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPB.UseVisualStyleBackColor = false;
            this.btnQLPB.Click += new System.EventHandler(this.btnQLPB_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel12.Controls.Add(this.btnDanhSachPhongBan);
            this.panel12.Location = new System.Drawing.Point(0, 49);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(211, 49);
            this.panel12.TabIndex = 4;
            // 
            // btnDanhSachPhongBan
            // 
            this.btnDanhSachPhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnDanhSachPhongBan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachPhongBan.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachPhongBan.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachPhongBan.Image")));
            this.btnDanhSachPhongBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachPhongBan.Location = new System.Drawing.Point(0, -14);
            this.btnDanhSachPhongBan.Name = "btnDanhSachPhongBan";
            this.btnDanhSachPhongBan.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDanhSachPhongBan.Size = new System.Drawing.Size(221, 78);
            this.btnDanhSachPhongBan.TabIndex = 2;
            this.btnDanhSachPhongBan.Text = "     Danh sách phòng ban";
            this.btnDanhSachPhongBan.UseVisualStyleBackColor = false;
            this.btnDanhSachPhongBan.Click += new System.EventHandler(this.btnDanhSachPhongBan_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel13.Controls.Add(this.btnThemMoiPhongBan);
            this.panel13.Location = new System.Drawing.Point(0, 98);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(211, 49);
            this.panel13.TabIndex = 5;
            // 
            // btnThemMoiPhongBan
            // 
            this.btnThemMoiPhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnThemMoiPhongBan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoiPhongBan.ForeColor = System.Drawing.Color.White;
            this.btnThemMoiPhongBan.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoiPhongBan.Image")));
            this.btnThemMoiPhongBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoiPhongBan.Location = new System.Drawing.Point(0, -14);
            this.btnThemMoiPhongBan.Name = "btnThemMoiPhongBan";
            this.btnThemMoiPhongBan.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnThemMoiPhongBan.Size = new System.Drawing.Size(221, 78);
            this.btnThemMoiPhongBan.TabIndex = 2;
            this.btnThemMoiPhongBan.Text = "     Thêm mới phòng ban";
            this.btnThemMoiPhongBan.UseVisualStyleBackColor = false;
            this.btnThemMoiPhongBan.Click += new System.EventHandler(this.btnThemMoiPhongBan_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnThongKe);
            this.panel8.Location = new System.Drawing.Point(0, 110);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(211, 49);
            this.panel8.TabIndex = 5;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnThongKe.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(-12, -14);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(233, 78);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "             Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnTinhLuong);
            this.panel7.Location = new System.Drawing.Point(0, 208);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(211, 49);
            this.panel7.TabIndex = 5;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnTinhLuong.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.ForeColor = System.Drawing.Color.White;
            this.btnTinhLuong.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhLuong.Image")));
            this.btnTinhLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhLuong.Location = new System.Drawing.Point(-12, -14);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnTinhLuong.Size = new System.Drawing.Size(233, 78);
            this.btnTinhLuong.TabIndex = 2;
            this.btnTinhLuong.Text = "             Tính lương";
            this.btnTinhLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhLuong.UseVisualStyleBackColor = false;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnBaoCao);
            this.panel9.Location = new System.Drawing.Point(0, 159);
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
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnChamCong);
            this.panel6.Location = new System.Drawing.Point(0, 257);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(211, 49);
            this.panel6.TabIndex = 5;
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnChamCong.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.ForeColor = System.Drawing.Color.White;
            this.btnChamCong.Image = ((System.Drawing.Image)(resources.GetObject("btnChamCong.Image")));
            this.btnChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCong.Location = new System.Drawing.Point(-12, -14);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnChamCong.Size = new System.Drawing.Size(233, 78);
            this.btnChamCong.TabIndex = 2;
            this.btnChamCong.Text = "             Chấm công";
            this.btnChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnDangXuat);
            this.panel10.Location = new System.Drawing.Point(0, 306);
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
            // QLNV
            // 
            this.QLNV.Interval = 10;
            this.QLNV.Tick += new System.EventHandler(this.QLNV_Tick);
            // 
            // sidebar
            // 
            this.sidebar.Interval = 10;
            this.sidebar.Tick += new System.EventHandler(this.sidebar_Tick);
            // 
            // panhome
            // 
            this.panhome.Location = new System.Drawing.Point(211, 47);
            this.panhome.Name = "panhome";
            this.panhome.Size = new System.Drawing.Size(804, 430);
            this.panhome.TabIndex = 2;
            this.panhome.Paint += new System.Windows.Forms.PaintEventHandler(this.panhome_Paint);
            // 
            // QLPB
            // 
            this.QLPB.Interval = 10;
            this.QLPB.Tick += new System.EventHandler(this.QLPB_Tick);
            // 
            // FrQuanLy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1015, 477);
            this.Controls.Add(this.panhome);
            this.Controls.Add(this.lbfSidebar);
            this.Controls.Add(this.panel1);
            this.Name = "FrQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý nhân sự";
            this.Load += new System.EventHandler(this.FrQuanLy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidebar)).EndInit();
            this.lbfSidebar.ResumeLayout(false);
            this.lbfQLNV.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.lbfQLPB.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbBanner;
        private System.Windows.Forms.PictureBox pbxSidebar;
        private System.Windows.Forms.FlowLayoutPanel lbfSidebar;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel lbfQLNV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDanhSachNhanVien;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDanhsachnvNghi;
        private System.Windows.Forms.Timer QLNV;
        private System.Windows.Forms.Timer sidebar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.FlowLayoutPanel lbfQLPB;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnQLPB;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnDanhSachPhongBan;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnThemMoiPhongBan;
        private System.Windows.Forms.Panel panhome;
        private System.Windows.Forms.Timer QLPB;
    }
}