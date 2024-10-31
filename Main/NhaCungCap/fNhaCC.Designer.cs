namespace Main.NhaCungCap
{
    partial class fNhaCC
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel_btn = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgv_NhaCC = new System.Windows.Forms.DataGridView();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.table4 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_TrangThai = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.errNCC = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(385, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(454, 34);
            this.label7.TabIndex = 29;
            this.label7.Text = "DANH SÁCH NHÀ CUNG CẤP";
            // 
            // panel_btn
            // 
            this.panel_btn.Controls.Add(this.btn_Xoa);
            this.panel_btn.Controls.Add(this.btn_Sua);
            this.panel_btn.Controls.Add(this.btn_Them);
            this.panel_btn.Location = new System.Drawing.Point(301, 606);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(645, 72);
            this.panel_btn.TabIndex = 28;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(480, 14);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(110, 48);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(270, 14);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(110, 48);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(77, 14);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(110, 48);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_NhaCC
            // 
            this.dgv_NhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhaCC.Location = new System.Drawing.Point(164, 309);
            this.dgv_NhaCC.Name = "dgv_NhaCC";
            this.dgv_NhaCC.RowHeadersWidth = 51;
            this.dgv_NhaCC.RowTemplate.Height = 24;
            this.dgv_NhaCC.Size = new System.Drawing.Size(954, 277);
            this.dgv_NhaCC.TabIndex = 27;
            this.dgv_NhaCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhaCC_CellClick);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(738, 92);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(196, 94);
            this.txt_DiaChi.TabIndex = 4;
            // 
            // table4
            // 
            this.table4.AutoSize = true;
            this.table4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table4.Location = new System.Drawing.Point(653, 97);
            this.table4.Name = "table4";
            this.table4.Size = new System.Drawing.Size(71, 25);
            this.table4.TabIndex = 16;
            this.table4.Text = "Địa chỉ";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(356, 198);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(196, 34);
            this.txt_SDT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "SDT";
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNCC.Location = new System.Drawing.Point(356, 142);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.Size = new System.Drawing.Size(196, 34);
            this.txt_TenNCC.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên NCC";
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNCC.Location = new System.Drawing.Point(356, 92);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.Size = new System.Drawing.Size(196, 34);
            this.txt_MaNCC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã NCC";
            // 
            // lb_TrangThai
            // 
            this.lb_TrangThai.AutoSize = true;
            this.lb_TrangThai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrangThai.ForeColor = System.Drawing.Color.Red;
            this.lb_TrangThai.Location = new System.Drawing.Point(259, 267);
            this.lb_TrangThai.Name = "lb_TrangThai";
            this.lb_TrangThai.Size = new System.Drawing.Size(0, 19);
            this.lb_TrangThai.TabIndex = 62;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(665, 263);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 29);
            this.btn_Huy.TabIndex = 61;
            this.btn_Huy.Text = "Huỷ";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(528, 263);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 29);
            this.btn_Luu.TabIndex = 60;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // errNCC
            // 
            this.errNCC.ContainerControl = this;
            // 
            // fNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.lb_TrangThai);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.dgv_NhaCC);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.table4);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenNCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MaNCC);
            this.Controls.Add(this.label1);
            this.Name = "fNhaCC";
            this.Text = "fNhaCC";
            this.Load += new System.EventHandler(this.fNhaCC_Load);
            this.panel_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_btn;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_NhaCC;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label table4;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_TrangThai;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.ErrorProvider errNCC;
    }
}