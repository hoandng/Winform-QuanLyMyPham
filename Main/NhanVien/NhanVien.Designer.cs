namespace Main.NhanVien
{
    partial class NhanVien
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
            this.tp_CongViec = new System.Windows.Forms.TabControl();
            this.tp_NhanVien = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtg_NhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_CongViec = new System.Windows.Forms.ComboBox();
            this.lb_NV_TrangThai = new System.Windows.Forms.Label();
            this.btn_NV_Huy = new System.Windows.Forms.Button();
            this.btn_NV_Luu = new System.Windows.Forms.Button();
            this.cb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_NV_Xoa = new System.Windows.Forms.Button();
            this.btn_NV_Sua = new System.Windows.Forms.Button();
            this.btn_NV_Them = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtg_CongViec = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_CV_TrangThai = new System.Windows.Forms.Label();
            this.btn_CV_Huy = new System.Windows.Forms.Button();
            this.btn_CV_Luu = new System.Windows.Forms.Button();
            this.txt_MucLuong = new System.Windows.Forms.TextBox();
            this.txt_TCV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MCV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_btn = new System.Windows.Forms.Panel();
            this.btn_CV_Xoa = new System.Windows.Forms.Button();
            this.btn_CV_Sua = new System.Windows.Forms.Button();
            this.btn_CV_Them = new System.Windows.Forms.Button();
            this.errNhanVien = new System.Windows.Forms.ErrorProvider(this.components);
            this.tp_CongViec.SuspendLayout();
            this.tp_NhanVien.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_NhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CongViec)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tp_CongViec
            // 
            this.tp_CongViec.Controls.Add(this.tp_NhanVien);
            this.tp_CongViec.Controls.Add(this.tabPage2);
            this.tp_CongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tp_CongViec.Location = new System.Drawing.Point(0, 0);
            this.tp_CongViec.Name = "tp_CongViec";
            this.tp_CongViec.SelectedIndex = 0;
            this.tp_CongViec.Size = new System.Drawing.Size(1282, 703);
            this.tp_CongViec.TabIndex = 9;
            // 
            // tp_NhanVien
            // 
            this.tp_NhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.tp_NhanVien.Controls.Add(this.panel2);
            this.tp_NhanVien.Controls.Add(this.groupBox1);
            this.tp_NhanVien.Controls.Add(this.panel1);
            this.tp_NhanVien.Controls.Add(this.panel3);
            this.tp_NhanVien.Location = new System.Drawing.Point(4, 25);
            this.tp_NhanVien.Name = "tp_NhanVien";
            this.tp_NhanVien.Size = new System.Drawing.Size(1274, 674);
            this.tp_NhanVien.TabIndex = 0;
            this.tp_NhanVien.Text = "Nhân viên";
            this.tp_NhanVien.Enter += new System.EventHandler(this.tp_NhanVien_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtg_NhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1274, 271);
            this.panel2.TabIndex = 63;
            // 
            // dtg_NhanVien
            // 
            this.dtg_NhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_NhanVien.Location = new System.Drawing.Point(53, 35);
            this.dtg_NhanVien.Name = "dtg_NhanVien";
            this.dtg_NhanVien.RowHeadersWidth = 51;
            this.dtg_NhanVien.RowTemplate.Height = 24;
            this.dtg_NhanVien.Size = new System.Drawing.Size(1171, 206);
            this.dtg_NhanVien.TabIndex = 24;
            this.dtg_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_NhanVien_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_CongViec);
            this.groupBox1.Controls.Add(this.lb_NV_TrangThai);
            this.groupBox1.Controls.Add(this.btn_NV_Huy);
            this.groupBox1.Controls.Add(this.btn_NV_Luu);
            this.groupBox1.Controls.Add(this.cb_GioiTinh);
            this.groupBox1.Controls.Add(this.dtp_NgaySinh);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_TenNV);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1274, 276);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cb_CongViec
            // 
            this.cb_CongViec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_CongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CongViec.FormattingEnabled = true;
            this.cb_CongViec.Location = new System.Drawing.Point(376, 190);
            this.cb_CongViec.Name = "cb_CongViec";
            this.cb_CongViec.Size = new System.Drawing.Size(227, 28);
            this.cb_CongViec.TabIndex = 60;
            // 
            // lb_NV_TrangThai
            // 
            this.lb_NV_TrangThai.AutoSize = true;
            this.lb_NV_TrangThai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NV_TrangThai.ForeColor = System.Drawing.Color.Red;
            this.lb_NV_TrangThai.Location = new System.Drawing.Point(281, 244);
            this.lb_NV_TrangThai.Name = "lb_NV_TrangThai";
            this.lb_NV_TrangThai.Size = new System.Drawing.Size(0, 19);
            this.lb_NV_TrangThai.TabIndex = 59;
            // 
            // btn_NV_Huy
            // 
            this.btn_NV_Huy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_NV_Huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btn_NV_Huy.Location = new System.Drawing.Point(687, 240);
            this.btn_NV_Huy.Name = "btn_NV_Huy";
            this.btn_NV_Huy.Size = new System.Drawing.Size(75, 29);
            this.btn_NV_Huy.TabIndex = 58;
            this.btn_NV_Huy.Text = "Huỷ";
            this.btn_NV_Huy.UseVisualStyleBackColor = false;
            this.btn_NV_Huy.Click += new System.EventHandler(this.btn_NV_Huy_Click);
            // 
            // btn_NV_Luu
            // 
            this.btn_NV_Luu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_NV_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btn_NV_Luu.Location = new System.Drawing.Point(550, 240);
            this.btn_NV_Luu.Name = "btn_NV_Luu";
            this.btn_NV_Luu.Size = new System.Drawing.Size(75, 29);
            this.btn_NV_Luu.TabIndex = 57;
            this.btn_NV_Luu.Text = "Lưu";
            this.btn_NV_Luu.UseVisualStyleBackColor = false;
            this.btn_NV_Luu.Click += new System.EventHandler(this.btn_NV_Luu_Click);
            // 
            // cb_GioiTinh
            // 
            this.cb_GioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_GioiTinh.FormattingEnabled = true;
            this.cb_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_GioiTinh.Location = new System.Drawing.Point(376, 134);
            this.cb_GioiTinh.Name = "cb_GioiTinh";
            this.cb_GioiTinh.Size = new System.Drawing.Size(228, 28);
            this.cb_GioiTinh.TabIndex = 18;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(761, 27);
            this.dtp_NgaySinh.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtp_NgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(228, 27);
            this.dtp_NgaySinh.TabIndex = 20;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(761, 136);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(229, 82);
            this.txt_DiaChi.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(655, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Địa chỉ";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(761, 87);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(229, 27);
            this.txt_SDT.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(655, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "SĐT";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(655, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "Ngày sinh";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(280, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Mã CV";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(280, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 25);
            this.label14.TabIndex = 11;
            this.label14.Text = "Giới tính";
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNV.Location = new System.Drawing.Point(376, 87);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(229, 27);
            this.txt_TenNV.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(280, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 25);
            this.label15.TabIndex = 10;
            this.label15.Text = "Tên NV";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(376, 27);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(229, 27);
            this.txt_MaNV.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(280, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 25);
            this.label16.TabIndex = 15;
            this.label16.Text = "Mã NV";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 56);
            this.panel1.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(419, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(394, 34);
            this.label9.TabIndex = 21;
            this.label9.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_NV_Xoa);
            this.panel3.Controls.Add(this.btn_NV_Sua);
            this.panel3.Controls.Add(this.btn_NV_Them);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 603);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1274, 71);
            this.panel3.TabIndex = 25;
            // 
            // btn_NV_Xoa
            // 
            this.btn_NV_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_NV_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btn_NV_Xoa.Location = new System.Drawing.Point(783, 6);
            this.btn_NV_Xoa.Name = "btn_NV_Xoa";
            this.btn_NV_Xoa.Size = new System.Drawing.Size(122, 48);
            this.btn_NV_Xoa.TabIndex = 11;
            this.btn_NV_Xoa.Text = "Xoá";
            this.btn_NV_Xoa.UseVisualStyleBackColor = false;
            this.btn_NV_Xoa.Click += new System.EventHandler(this.btn_NV_Xoa_Click);
            // 
            // btn_NV_Sua
            // 
            this.btn_NV_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_NV_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btn_NV_Sua.Location = new System.Drawing.Point(575, 6);
            this.btn_NV_Sua.Name = "btn_NV_Sua";
            this.btn_NV_Sua.Size = new System.Drawing.Size(122, 48);
            this.btn_NV_Sua.TabIndex = 10;
            this.btn_NV_Sua.Text = "Sửa";
            this.btn_NV_Sua.UseVisualStyleBackColor = false;
            this.btn_NV_Sua.Click += new System.EventHandler(this.btn_NV_Sua_Click);
            // 
            // btn_NV_Them
            // 
            this.btn_NV_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_NV_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btn_NV_Them.Location = new System.Drawing.Point(357, 6);
            this.btn_NV_Them.Name = "btn_NV_Them";
            this.btn_NV_Them.Size = new System.Drawing.Size(122, 48);
            this.btn_NV_Them.TabIndex = 9;
            this.btn_NV_Them.Text = "Thêm";
            this.btn_NV_Them.UseVisualStyleBackColor = false;
            this.btn_NV_Them.Click += new System.EventHandler(this.btn_NV_Them_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel_btn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1274, 674);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Công việc";
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtg_CongViec);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 271);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1274, 314);
            this.panel5.TabIndex = 65;
            // 
            // dtg_CongViec
            // 
            this.dtg_CongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_CongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_CongViec.Location = new System.Drawing.Point(49, 43);
            this.dtg_CongViec.Name = "dtg_CongViec";
            this.dtg_CongViec.RowHeadersWidth = 51;
            this.dtg_CongViec.RowTemplate.Height = 24;
            this.dtg_CongViec.Size = new System.Drawing.Size(1189, 231);
            this.dtg_CongViec.TabIndex = 17;
            this.dtg_CongViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CongViec_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_CV_TrangThai);
            this.groupBox2.Controls.Add(this.btn_CV_Huy);
            this.groupBox2.Controls.Add(this.btn_CV_Luu);
            this.groupBox2.Controls.Add(this.txt_MucLuong);
            this.groupBox2.Controls.Add(this.txt_TCV);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_MCV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1274, 209);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // lb_CV_TrangThai
            // 
            this.lb_CV_TrangThai.AutoSize = true;
            this.lb_CV_TrangThai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CV_TrangThai.ForeColor = System.Drawing.Color.Red;
            this.lb_CV_TrangThai.Location = new System.Drawing.Point(216, 171);
            this.lb_CV_TrangThai.Name = "lb_CV_TrangThai";
            this.lb_CV_TrangThai.Size = new System.Drawing.Size(0, 19);
            this.lb_CV_TrangThai.TabIndex = 62;
            // 
            // btn_CV_Huy
            // 
            this.btn_CV_Huy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CV_Huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btn_CV_Huy.Location = new System.Drawing.Point(648, 171);
            this.btn_CV_Huy.Name = "btn_CV_Huy";
            this.btn_CV_Huy.Size = new System.Drawing.Size(75, 29);
            this.btn_CV_Huy.TabIndex = 61;
            this.btn_CV_Huy.Text = "Huỷ";
            this.btn_CV_Huy.UseVisualStyleBackColor = false;
            this.btn_CV_Huy.Click += new System.EventHandler(this.btn_CV_Huy_Click);
            // 
            // btn_CV_Luu
            // 
            this.btn_CV_Luu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CV_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btn_CV_Luu.Location = new System.Drawing.Point(511, 171);
            this.btn_CV_Luu.Name = "btn_CV_Luu";
            this.btn_CV_Luu.Size = new System.Drawing.Size(75, 29);
            this.btn_CV_Luu.TabIndex = 60;
            this.btn_CV_Luu.Text = "Lưu";
            this.btn_CV_Luu.UseVisualStyleBackColor = false;
            this.btn_CV_Luu.Click += new System.EventHandler(this.btn_CV_Luu_Click);
            // 
            // txt_MucLuong
            // 
            this.txt_MucLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MucLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MucLuong.Location = new System.Drawing.Point(511, 131);
            this.txt_MucLuong.Name = "txt_MucLuong";
            this.txt_MucLuong.Size = new System.Drawing.Size(229, 27);
            this.txt_MucLuong.TabIndex = 14;
            // 
            // txt_TCV
            // 
            this.txt_TCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TCV.Location = new System.Drawing.Point(511, 82);
            this.txt_TCV.Name = "txt_TCV";
            this.txt_TCV.Size = new System.Drawing.Size(229, 27);
            this.txt_TCV.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mức Lương";
            // 
            // txt_MCV
            // 
            this.txt_MCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MCV.Location = new System.Drawing.Point(511, 29);
            this.txt_MCV.Name = "txt_MCV";
            this.txt_MCV.Size = new System.Drawing.Size(229, 27);
            this.txt_MCV.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên CV";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã CV";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1274, 62);
            this.panel4.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "DANH SÁCH CÔNG VIỆC";
            // 
            // panel_btn
            // 
            this.panel_btn.Controls.Add(this.btn_CV_Xoa);
            this.panel_btn.Controls.Add(this.btn_CV_Sua);
            this.panel_btn.Controls.Add(this.btn_CV_Them);
            this.panel_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_btn.Location = new System.Drawing.Point(0, 585);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(1274, 89);
            this.panel_btn.TabIndex = 18;
            // 
            // btn_CV_Xoa
            // 
            this.btn_CV_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CV_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btn_CV_Xoa.Location = new System.Drawing.Point(765, 22);
            this.btn_CV_Xoa.Name = "btn_CV_Xoa";
            this.btn_CV_Xoa.Size = new System.Drawing.Size(123, 48);
            this.btn_CV_Xoa.TabIndex = 0;
            this.btn_CV_Xoa.Text = "Xoá";
            this.btn_CV_Xoa.UseVisualStyleBackColor = false;
            this.btn_CV_Xoa.Click += new System.EventHandler(this.btn_CV_Xoa_Click);
            // 
            // btn_CV_Sua
            // 
            this.btn_CV_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CV_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btn_CV_Sua.Location = new System.Drawing.Point(548, 22);
            this.btn_CV_Sua.Name = "btn_CV_Sua";
            this.btn_CV_Sua.Size = new System.Drawing.Size(123, 48);
            this.btn_CV_Sua.TabIndex = 0;
            this.btn_CV_Sua.Text = "Sửa";
            this.btn_CV_Sua.UseVisualStyleBackColor = false;
            this.btn_CV_Sua.Click += new System.EventHandler(this.btn_CV_Sua_Click);
            // 
            // btn_CV_Them
            // 
            this.btn_CV_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CV_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btn_CV_Them.Location = new System.Drawing.Point(331, 22);
            this.btn_CV_Them.Name = "btn_CV_Them";
            this.btn_CV_Them.Size = new System.Drawing.Size(123, 48);
            this.btn_CV_Them.TabIndex = 0;
            this.btn_CV_Them.Text = "Thêm";
            this.btn_CV_Them.UseVisualStyleBackColor = false;
            this.btn_CV_Them.Click += new System.EventHandler(this.btn_CV_Them_Click);
            // 
            // errNhanVien
            // 
            this.errNhanVien.ContainerControl = this;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.tp_CongViec);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.tp_CongViec.ResumeLayout(false);
            this.tp_NhanVien.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_NhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CongViec)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tp_CongViec;
        private System.Windows.Forms.TabPage tp_NhanVien;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_NV_Xoa;
        private System.Windows.Forms.Button btn_NV_Sua;
        private System.Windows.Forms.Button btn_NV_Them;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtg_NhanVien;
        private System.Windows.Forms.ComboBox cb_GioiTinh;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel_btn;
        private System.Windows.Forms.Button btn_CV_Xoa;
        private System.Windows.Forms.Button btn_CV_Sua;
        private System.Windows.Forms.Button btn_CV_Them;
        private System.Windows.Forms.DataGridView dtg_CongViec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TCV;
        private System.Windows.Forms.TextBox txt_MCV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_NV_TrangThai;
        private System.Windows.Forms.Button btn_NV_Huy;
        private System.Windows.Forms.Button btn_NV_Luu;
        private System.Windows.Forms.Label lb_CV_TrangThai;
        private System.Windows.Forms.Button btn_CV_Huy;
        private System.Windows.Forms.Button btn_CV_Luu;
        private System.Windows.Forms.ErrorProvider errNhanVien;
        private System.Windows.Forms.TextBox txt_MucLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_CongViec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
    }
}