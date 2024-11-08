namespace Main.HoaDonNhap
{
    partial class fHDN
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
            this.txt_TT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SoHDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_HDN = new System.Windows.Forms.DataGridView();
            this.panel_btn = new System.Windows.Forms.Panel();
            this.btn_XuatFile = new System.Windows.Forms.Button();
            this.btn_ChiTiet = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_TrangThai = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.errHDB = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_MaNCC = new System.Windows.Forms.ComboBox();
            this.cb_MaNV = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDN)).BeginInit();
            this.panel_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errHDB)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_TT
            // 
            this.txt_TT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TT.Location = new System.Drawing.Point(743, 92);
            this.txt_TT.Name = "txt_TT";
            this.txt_TT.ReadOnly = true;
            this.txt_TT.Size = new System.Drawing.Size(196, 27);
            this.txt_TT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhân viên";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nhà CC";
            // 
            // txt_SoHDN
            // 
            this.txt_SoHDN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_SoHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoHDN.Location = new System.Drawing.Point(361, 39);
            this.txt_SoHDN.Name = "txt_SoHDN";
            this.txt_SoHDN.Size = new System.Drawing.Size(196, 27);
            this.txt_SoHDN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số HDN";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày nhập";
            // 
            // dgv_HDN
            // 
            this.dgv_HDN.AllowUserToAddRows = false;
            this.dgv_HDN.AllowUserToDeleteRows = false;
            this.dgv_HDN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_HDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HDN.Location = new System.Drawing.Point(61, 50);
            this.dgv_HDN.Name = "dgv_HDN";
            this.dgv_HDN.ReadOnly = true;
            this.dgv_HDN.RowHeadersWidth = 51;
            this.dgv_HDN.RowTemplate.Height = 24;
            this.dgv_HDN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HDN.Size = new System.Drawing.Size(1161, 232);
            this.dgv_HDN.TabIndex = 12;
            this.dgv_HDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HDB_CellClick);
            // 
            // panel_btn
            // 
            this.panel_btn.Controls.Add(this.btn_XuatFile);
            this.panel_btn.Controls.Add(this.btn_ChiTiet);
            this.panel_btn.Controls.Add(this.btn_Xoa);
            this.panel_btn.Controls.Add(this.btn_Sua);
            this.panel_btn.Controls.Add(this.btn_Them);
            this.panel_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_btn.Location = new System.Drawing.Point(0, 631);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(1282, 72);
            this.panel_btn.TabIndex = 13;
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_XuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btn_XuatFile.Location = new System.Drawing.Point(874, 12);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(110, 48);
            this.btn_XuatFile.TabIndex = 11;
            this.btn_XuatFile.Text = "Xuất File Excel";
            this.btn_XuatFile.UseVisualStyleBackColor = false;
            this.btn_XuatFile.Click += new System.EventHandler(this.btn_XuatFile_Click);
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btn_ChiTiet.Location = new System.Drawing.Point(218, 12);
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Size = new System.Drawing.Size(110, 48);
            this.btn_ChiTiet.TabIndex = 10;
            this.btn_ChiTiet.Text = "Chi tiết hoá đơn";
            this.btn_ChiTiet.UseVisualStyleBackColor = false;
            this.btn_ChiTiet.Click += new System.EventHandler(this.btn_ChiTiet_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btn_Xoa.Location = new System.Drawing.Point(710, 12);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(110, 48);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btn_Sua.Location = new System.Drawing.Point(546, 12);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(110, 48);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btn_Them.Location = new System.Drawing.Point(382, 12);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(110, 48);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(367, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(464, 34);
            this.label7.TabIndex = 14;
            this.label7.Text = "DANH SÁCH HOÁ ĐƠN NHẬP";
            // 
            // lb_TrangThai
            // 
            this.lb_TrangThai.AutoSize = true;
            this.lb_TrangThai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrangThai.ForeColor = System.Drawing.Color.Red;
            this.lb_TrangThai.Location = new System.Drawing.Point(200, 200);
            this.lb_TrangThai.Name = "lb_TrangThai";
            this.lb_TrangThai.Size = new System.Drawing.Size(0, 19);
            this.lb_TrangThai.TabIndex = 62;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btn_Huy.Location = new System.Drawing.Point(637, 200);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 29);
            this.btn_Huy.TabIndex = 61;
            this.btn_Huy.Text = "Huỷ";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btn_Luu.Location = new System.Drawing.Point(500, 200);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 29);
            this.btn_Luu.TabIndex = 60;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(617, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng tiền";
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_NgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayNhap.Location = new System.Drawing.Point(743, 39);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(192, 27);
            this.dtp_NgayNhap.TabIndex = 63;
            // 
            // errHDB
            // 
            this.errHDB.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 63);
            this.panel1.TabIndex = 64;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_MaNCC);
            this.groupBox1.Controls.Add(this.cb_MaNV);
            this.groupBox1.Controls.Add(this.dtp_NgayNhap);
            this.groupBox1.Controls.Add(this.lb_TrangThai);
            this.groupBox1.Controls.Add(this.btn_Huy);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_TT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_SoHDN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1282, 242);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cb_MaNCC
            // 
            this.cb_MaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaNCC.FormattingEnabled = true;
            this.cb_MaNCC.Location = new System.Drawing.Point(361, 148);
            this.cb_MaNCC.Name = "cb_MaNCC";
            this.cb_MaNCC.Size = new System.Drawing.Size(196, 28);
            this.cb_MaNCC.TabIndex = 65;
            // 
            // cb_MaNV
            // 
            this.cb_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaNV.FormattingEnabled = true;
            this.cb_MaNV.Location = new System.Drawing.Point(361, 91);
            this.cb_MaNV.Name = "cb_MaNV";
            this.cb_MaNV.Size = new System.Drawing.Size(195, 28);
            this.cb_MaNV.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_HDN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 326);
            this.panel2.TabIndex = 66;
            // 
            // fHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.panel1);
            this.Name = "fHDN";
            this.Text = "fHDN";
            this.Load += new System.EventHandler(this.fHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDN)).EndInit();
            this.panel_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errHDB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_TT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SoHDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_HDN;
        private System.Windows.Forms.Panel panel_btn;
        private System.Windows.Forms.Button btn_ChiTiet;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_TrangThai;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
        private System.Windows.Forms.ErrorProvider errHDB;
        private System.Windows.Forms.Button btn_XuatFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_MaNV;
        private System.Windows.Forms.ComboBox cb_MaNCC;
    }
}