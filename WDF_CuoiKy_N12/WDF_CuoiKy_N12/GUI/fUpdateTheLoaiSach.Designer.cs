
namespace WDF_CuoiKy_N12.GUI
{
    partial class fUpdateTheLoaiSach
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
            this.luu = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.txttentheloai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmatheloai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.luoi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.SuspendLayout();
            // 
            // luu
            // 
            this.luu.Enabled = false;
            this.luu.Location = new System.Drawing.Point(318, 232);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(75, 23);
            this.luu.TabIndex = 21;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(318, 273);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 23);
            this.thoat.TabIndex = 20;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(318, 194);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 19;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(318, 153);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 18;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(318, 107);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 17;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            // 
            // txttentheloai
            // 
            this.txttentheloai.Location = new System.Drawing.Point(135, 120);
            this.txttentheloai.Name = "txttentheloai";
            this.txttentheloai.Size = new System.Drawing.Size(130, 20);
            this.txttentheloai.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(20, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên thể loại";
            // 
            // txtmatheloai
            // 
            this.txtmatheloai.Location = new System.Drawing.Point(135, 79);
            this.txtmatheloai.Name = "txtmatheloai";
            this.txtmatheloai.Size = new System.Drawing.Size(130, 20);
            this.txtmatheloai.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã thể loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(81, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "CẬP NHẬT THỂ LOẠI SÁCH";
            // 
            // luoi
            // 
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Location = new System.Drawing.Point(20, 153);
            this.luoi.Name = "luoi";
            this.luoi.Size = new System.Drawing.Size(291, 189);
            this.luoi.TabIndex = 11;
            // 
            // FUpdateTheLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 353);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.txttentheloai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmatheloai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.luoi);
            this.Name = "FUpdateTheLoaiSach";
            this.Text = "FUpdateTheLoaiSach";
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.TextBox txttentheloai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmatheloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView luoi;
    }
}