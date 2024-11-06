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
            this.tp_MHBC = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tp_DoanhThu.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tp_DoanhThu.Controls.Add(this.groupBox1);
            this.tp_DoanhThu.Controls.Add(this.panel1);
            this.tp_DoanhThu.Location = new System.Drawing.Point(4, 25);
            this.tp_DoanhThu.Name = "tp_DoanhThu";
            this.tp_DoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tp_DoanhThu.Size = new System.Drawing.Size(1274, 674);
            this.tp_DoanhThu.TabIndex = 0;
            this.tp_DoanhThu.Text = "Doanh Thu";
            this.tp_DoanhThu.UseVisualStyleBackColor = true;
            // 
            // tp_MHBC
            // 
            this.tp_MHBC.Location = new System.Drawing.Point(4, 25);
            this.tp_MHBC.Name = "tp_MHBC";
            this.tp_MHBC.Padding = new System.Windows.Forms.Padding(3);
            this.tp_MHBC.Size = new System.Drawing.Size(1274, 674);
            this.tp_MHBC.TabIndex = 1;
            this.tp_MHBC.Text = "Mặt hàng bán chạy";
            this.tp_MHBC.UseVisualStyleBackColor = true;
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1268, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.tabControl1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.tabControl1.ResumeLayout(false);
            this.tp_DoanhThu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_DoanhThu;
        private System.Windows.Forms.TabPage tp_MHBC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}