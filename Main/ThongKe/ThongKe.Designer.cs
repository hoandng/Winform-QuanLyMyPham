namespace Main.ThongKe
{
    partial class ThongKe
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_DoanhThu = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_Nam = new System.Windows.Forms.ComboBox();
            this.dgv_DoanhThu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_MHBC = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_MHBC = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txt_MaHang = new System.Windows.Forms.TextBox();
            this.pb_AnhSP = new System.Windows.Forms.PictureBox();
            this.cb_MHBC_Nam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_MHBC_Thang = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.txt_TenHangSX = new System.Windows.Forms.TextBox();
            this.txt_MaHangSX = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tp_DoanhThu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoanhThu)).BeginInit();
            this.panel1.SuspendLayout();
            this.tp_MHBC.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MHBC)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhSP)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_DoanhThu);
            this.tabControl1.Controls.Add(this.tp_MHBC);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1282, 703);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_DoanhThu
            // 
            this.tp_DoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.tp_DoanhThu.Controls.Add(this.groupBox2);
            this.tp_DoanhThu.Controls.Add(this.panel1);
            this.tp_DoanhThu.Location = new System.Drawing.Point(4, 25);
            this.tp_DoanhThu.Name = "tp_DoanhThu";
            this.tp_DoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tp_DoanhThu.Size = new System.Drawing.Size(1274, 674);
            this.tp_DoanhThu.TabIndex = 0;
            this.tp_DoanhThu.Text = "Doanh Thu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_Nam);
            this.groupBox2.Controls.Add(this.dgv_DoanhThu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1268, 606);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // cb_Nam
            // 
            this.cb_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Nam.FormattingEnabled = true;
            this.cb_Nam.Location = new System.Drawing.Point(76, 35);
            this.cb_Nam.Name = "cb_Nam";
            this.cb_Nam.Size = new System.Drawing.Size(229, 28);
            this.cb_Nam.TabIndex = 1;
            this.cb_Nam.SelectedIndexChanged += new System.EventHandler(this.cb_Năm_SelectedIndexChanged);
            // 
            // dgv_DoanhThu
            // 
            this.dgv_DoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DoanhThu.Location = new System.Drawing.Point(36, 85);
            this.dgv_DoanhThu.Name = "dgv_DoanhThu";
            this.dgv_DoanhThu.RowHeadersWidth = 51;
            this.dgv_DoanhThu.RowTemplate.Height = 24;
            this.dgv_DoanhThu.Size = new System.Drawing.Size(1200, 498);
            this.dgv_DoanhThu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOANH THU";
            // 
            // tp_MHBC
            // 
            this.tp_MHBC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.tp_MHBC.Controls.Add(this.groupBox3);
            this.tp_MHBC.Controls.Add(this.groupBox1);
            this.tp_MHBC.Controls.Add(this.panel2);
            this.tp_MHBC.Location = new System.Drawing.Point(4, 25);
            this.tp_MHBC.Name = "tp_MHBC";
            this.tp_MHBC.Padding = new System.Windows.Forms.Padding(3);
            this.tp_MHBC.Size = new System.Drawing.Size(1274, 674);
            this.tp_MHBC.TabIndex = 1;
            this.tp_MHBC.Text = "Mặt hàng bán chạy";
            this.tp_MHBC.Enter += new System.EventHandler(this.tp_MHBC_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_MHBC);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1268, 321);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // dgv_MHBC
            // 
            this.dgv_MHBC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_MHBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MHBC.Location = new System.Drawing.Point(41, 36);
            this.dgv_MHBC.Name = "dgv_MHBC";
            this.dgv_MHBC.RowHeadersWidth = 51;
            this.dgv_MHBC.RowTemplate.Height = 24;
            this.dgv_MHBC.Size = new System.Drawing.Size(1182, 262);
            this.dgv_MHBC.TabIndex = 0;
            this.dgv_MHBC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MHBC_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TenHang);
            this.groupBox1.Controls.Add(this.label44);
            this.groupBox1.Controls.Add(this.txt_MaHang);
            this.groupBox1.Controls.Add(this.pb_AnhSP);
            this.groupBox1.Controls.Add(this.cb_MHBC_Nam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_MHBC_Thang);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.txt_SL);
            this.groupBox1.Controls.Add(this.txt_TenHangSX);
            this.groupBox1.Controls.Add(this.txt_MaHangSX);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1268, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHang.Location = new System.Drawing.Point(146, 151);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.ReadOnly = true;
            this.txt_TenHang.Size = new System.Drawing.Size(232, 27);
            this.txt_TenHang.TabIndex = 53;
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label44.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label44.Location = new System.Drawing.Point(39, 151);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(99, 25);
            this.label44.TabIndex = 52;
            this.label44.Text = "Tên Hàng";
            // 
            // txt_MaHang
            // 
            this.txt_MaHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHang.Location = new System.Drawing.Point(146, 89);
            this.txt_MaHang.Name = "txt_MaHang";
            this.txt_MaHang.ReadOnly = true;
            this.txt_MaHang.Size = new System.Drawing.Size(232, 27);
            this.txt_MaHang.TabIndex = 50;
            // 
            // pb_AnhSP
            // 
            this.pb_AnhSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_AnhSP.Location = new System.Drawing.Point(939, 21);
            this.pb_AnhSP.Name = "pb_AnhSP";
            this.pb_AnhSP.Size = new System.Drawing.Size(250, 250);
            this.pb_AnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_AnhSP.TabIndex = 49;
            this.pb_AnhSP.TabStop = false;
            // 
            // cb_MHBC_Nam
            // 
            this.cb_MHBC_Nam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_MHBC_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MHBC_Nam.FormattingEnabled = true;
            this.cb_MHBC_Nam.Location = new System.Drawing.Point(402, 28);
            this.cb_MHBC_Nam.Name = "cb_MHBC_Nam";
            this.cb_MHBC_Nam.Size = new System.Drawing.Size(153, 28);
            this.cb_MHBC_Nam.TabIndex = 48;
            this.cb_MHBC_Nam.SelectedIndexChanged += new System.EventHandler(this.cb_MHBC_Nam_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(337, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Năm";
            // 
            // cb_MHBC_Thang
            // 
            this.cb_MHBC_Thang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_MHBC_Thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MHBC_Thang.FormattingEnabled = true;
            this.cb_MHBC_Thang.Location = new System.Drawing.Point(128, 28);
            this.cb_MHBC_Thang.Name = "cb_MHBC_Thang";
            this.cb_MHBC_Thang.Size = new System.Drawing.Size(153, 28);
            this.cb_MHBC_Thang.TabIndex = 48;
            this.cb_MHBC_Thang.SelectedIndexChanged += new System.EventHandler(this.cb_MHBC_Thang_SelectedIndexChanged);
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label36.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label36.Location = new System.Drawing.Point(39, 30);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(69, 25);
            this.label36.TabIndex = 47;
            this.label36.Text = "Tháng";
            // 
            // txt_SL
            // 
            this.txt_SL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.Location = new System.Drawing.Point(211, 211);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.ReadOnly = true;
            this.txt_SL.Size = new System.Drawing.Size(167, 27);
            this.txt_SL.TabIndex = 45;
            // 
            // txt_TenHangSX
            // 
            this.txt_TenHangSX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TenHangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHangSX.Location = new System.Drawing.Point(586, 151);
            this.txt_TenHangSX.Name = "txt_TenHangSX";
            this.txt_TenHangSX.ReadOnly = true;
            this.txt_TenHangSX.Size = new System.Drawing.Size(244, 27);
            this.txt_TenHangSX.TabIndex = 44;
            // 
            // txt_MaHangSX
            // 
            this.txt_MaHangSX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaHangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHangSX.Location = new System.Drawing.Point(586, 89);
            this.txt_MaHangSX.Name = "txt_MaHangSX";
            this.txt_MaHangSX.ReadOnly = true;
            this.txt_MaHangSX.Size = new System.Drawing.Size(244, 27);
            this.txt_MaHangSX.TabIndex = 43;
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label35.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label35.Location = new System.Drawing.Point(39, 210);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(167, 25);
            this.label35.TabIndex = 41;
            this.label35.Text = "Số Lượng Đã Bán";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label31.Location = new System.Drawing.Point(479, 150);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(99, 25);
            this.label31.TabIndex = 40;
            this.label31.Text = "Tên Hãng";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label32.Location = new System.Drawing.Point(479, 88);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(92, 25);
            this.label32.TabIndex = 39;
            this.label32.Text = "Mã Hãng";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label33.Location = new System.Drawing.Point(39, 88);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(92, 25);
            this.label33.TabIndex = 38;
            this.label33.Text = "Mã Hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1268, 59);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "BEST SELLER";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.tabControl1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_DoanhThu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoanhThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tp_MHBC.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MHBC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhSP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_DoanhThu;
        private System.Windows.Forms.TabPage tp_MHBC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_DoanhThu;
        private System.Windows.Forms.ComboBox cb_Nam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txt_MaHang;
        private System.Windows.Forms.PictureBox pb_AnhSP;
        private System.Windows.Forms.ComboBox cb_MHBC_Thang;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.TextBox txt_TenHangSX;
        private System.Windows.Forms.TextBox txt_MaHangSX;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_MHBC;
        private System.Windows.Forms.ComboBox cb_MHBC_Nam;
        private System.Windows.Forms.Label label3;
    }
}