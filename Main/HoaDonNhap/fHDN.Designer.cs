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
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SoHDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_HDN = new System.Windows.Forms.DataGridView();
            this.panel_btn = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDN)).BeginInit();
            this.panel_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TT
            // 
            this.txt_TT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TT.Location = new System.Drawing.Point(729, 140);
            this.txt_TT.Name = "txt_TT";
            this.txt_TT.Size = new System.Drawing.Size(196, 34);
            this.txt_TT.TabIndex = 6;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(347, 140);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(196, 34);
            this.txt_MaNV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã NV";
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNCC.Location = new System.Drawing.Point(347, 197);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.Size = new System.Drawing.Size(196, 34);
            this.txt_MaNCC.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã NCC";
            // 
            // txt_SoHDN
            // 
            this.txt_SoHDN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoHDN.Location = new System.Drawing.Point(347, 91);
            this.txt_SoHDN.Name = "txt_SoHDN";
            this.txt_SoHDN.Size = new System.Drawing.Size(196, 34);
            this.txt_SoHDN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số HDN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày nhập";
            // 
            // dgv_HDN
            // 
            this.dgv_HDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HDN.Location = new System.Drawing.Point(158, 287);
            this.dgv_HDN.Name = "dgv_HDN";
            this.dgv_HDN.RowHeadersWidth = 51;
            this.dgv_HDN.RowTemplate.Height = 24;
            this.dgv_HDN.Size = new System.Drawing.Size(954, 294);
            this.dgv_HDN.TabIndex = 12;
            this.dgv_HDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HDB_CellClick);
            // 
            // panel_btn
            // 
            this.panel_btn.Controls.Add(this.btn_ChiTiet);
            this.panel_btn.Controls.Add(this.btn_Xoa);
            this.panel_btn.Controls.Add(this.btn_Sua);
            this.panel_btn.Controls.Add(this.btn_Them);
            this.panel_btn.Location = new System.Drawing.Point(198, 608);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(869, 72);
            this.panel_btn.TabIndex = 13;
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.Location = new System.Drawing.Point(77, 14);
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Size = new System.Drawing.Size(110, 48);
            this.btn_ChiTiet.TabIndex = 10;
            this.btn_ChiTiet.Text = "Chi tiết hoá đơn";
            this.btn_ChiTiet.UseVisualStyleBackColor = true;
            this.btn_ChiTiet.Click += new System.EventHandler(this.btn_ChiTiet_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(638, 14);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(110, 48);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(428, 14);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(110, 48);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(235, 14);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(110, 48);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 35);
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
            this.lb_TrangThai.Location = new System.Drawing.Point(217, 256);
            this.lb_TrangThai.Name = "lb_TrangThai";
            this.lb_TrangThai.Size = new System.Drawing.Size(0, 19);
            this.lb_TrangThai.TabIndex = 62;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(623, 252);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 29);
            this.btn_Huy.TabIndex = 61;
            this.btn_Huy.Text = "Huỷ";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(486, 252);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 29);
            this.btn_Luu.TabIndex = 60;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(603, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng tiền";
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayNhap.Location = new System.Drawing.Point(729, 91);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(192, 34);
            this.dtp_NgayNhap.TabIndex = 63;
            // 
            // errHDB
            // 
            this.errHDB.ContainerControl = this;
            // 
            // fHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.dtp_NgayNhap);
            this.Controls.Add(this.lb_TrangThai);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.dgv_HDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TT);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MaNCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_SoHDN);
            this.Controls.Add(this.label1);
            this.Name = "fHDN";
            this.Text = "fHDN";
            this.Load += new System.EventHandler(this.fHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDN)).EndInit();
            this.panel_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_TT;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaNCC;
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
    }
}