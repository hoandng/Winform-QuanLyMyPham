namespace Login
{
    partial class fLogin
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
            this.lb_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(3, 12);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(131, 19);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Tên đăng nhập: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu:";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(160, 10);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(210, 22);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(160, 7);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(210, 22);
            this.txt_password.TabIndex = 2;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(32, 0);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(110, 34);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "Đăng nhập";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(148, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(107, 34);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 111);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_password);
            this.panel3.Location = new System.Drawing.Point(7, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 42);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_username);
            this.panel2.Controls.Add(this.txt_username);
            this.panel2.Location = new System.Drawing.Point(7, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 43);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_submit);
            this.panel4.Controls.Add(this.btn_exit);
            this.panel4.Location = new System.Drawing.Point(114, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 52);
            this.panel4.TabIndex = 7;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 205);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}

