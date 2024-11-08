namespace Main.TaiKhoan
{
    partial class TaiKhoan
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
            this.pb_Anh = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TaiAnh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Anh)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Anh
            // 
            this.pb_Anh.Location = new System.Drawing.Point(536, 8);
            this.pb_Anh.Name = "pb_Anh";
            this.pb_Anh.Size = new System.Drawing.Size(184, 184);
            this.pb_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Anh.TabIndex = 0;
            this.pb_Anh.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 65);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Tài Khoản";
            // 
            // btn_TaiAnh
            // 
            this.btn_TaiAnh.Location = new System.Drawing.Point(582, 202);
            this.btn_TaiAnh.Name = "btn_TaiAnh";
            this.btn_TaiAnh.Size = new System.Drawing.Size(92, 28);
            this.btn_TaiAnh.TabIndex = 2;
            this.btn_TaiAnh.Text = "Tải ảnh";
            this.btn_TaiAnh.UseVisualStyleBackColor = true;
            this.btn_TaiAnh.Click += new System.EventHandler(this.btn_TaiAnh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Huy);
            this.panel2.Controls.Add(this.btn_Luu);
            this.panel2.Controls.Add(this.btn_CapNhat);
            this.panel2.Controls.Add(this.txt_MK);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_TenTK);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_TaiAnh);
            this.panel2.Controls.Add(this.pb_Anh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 638);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên tài khoản";
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTK.Location = new System.Drawing.Point(522, 277);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.ReadOnly = true;
            this.txt_TenTK.Size = new System.Drawing.Size(285, 27);
            this.txt_TenTK.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu";
            // 
            // txt_MK
            // 
            this.txt_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MK.Location = new System.Drawing.Point(522, 324);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(285, 27);
            this.txt_MK.TabIndex = 4;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(400, 425);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(95, 42);
            this.btn_CapNhat.TabIndex = 5;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(569, 425);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(95, 42);
            this.btn_Luu.TabIndex = 5;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(738, 425);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(95, 42);
            this.btn_Huy.TabIndex = 5;
            this.btn_Huy.Text = "Huỷ";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Anh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Anh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TaiAnh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenTK;
    }
}