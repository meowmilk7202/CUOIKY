
namespace WDF_CuoiKy_N12.GUI
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
            this.thoat = new System.Windows.Forms.Button();
            this.dannhap = new System.Windows.Forms.Button();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.taikhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(236, 151);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 23);
            this.thoat.TabIndex = 13;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            // 
            // dannhap
            // 
            this.dannhap.Location = new System.Drawing.Point(39, 151);
            this.dannhap.Name = "dannhap";
            this.dannhap.Size = new System.Drawing.Size(75, 23);
            this.dannhap.TabIndex = 12;
            this.dannhap.Text = "Đăng nhập";
            this.dannhap.UseVisualStyleBackColor = true;
            // 
            // matkhau
            // 
            this.matkhau.Location = new System.Drawing.Point(160, 92);
            this.matkhau.Name = "matkhau";
            this.matkhau.PasswordChar = '*';
            this.matkhau.Size = new System.Drawing.Size(151, 20);
            this.matkhau.TabIndex = 11;
            // 
            // taikhoan
            // 
            this.taikhoan.Location = new System.Drawing.Point(160, 66);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(151, 20);
            this.taikhoan.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đăng nhập hệ thống";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.thoat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dannhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.matkhau);
            this.panel1.Controls.Add(this.taikhoan);
            this.panel1.Location = new System.Drawing.Point(17, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 214);
            this.panel1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Thư Viện ĐH Sư Phạm Kỹ Thuật";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 302);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "fLogin";
            this.Text = "fLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button dannhap;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.TextBox taikhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}