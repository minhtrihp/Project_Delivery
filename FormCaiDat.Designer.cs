namespace AppGiaoHang
{
    partial class FormCaiDat
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
            this.lblCaiDat = new System.Windows.Forms.Label();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.btnViDienTu = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnNhanHang = new System.Windows.Forms.Button();
            this.lblDangXuat = new System.Windows.Forms.Label();
            this.grbLalamove = new System.Windows.Forms.GroupBox();
            this.lblYKien = new System.Windows.Forms.Label();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.grbTaiKhoan = new System.Windows.Forms.GroupBox();
            this.lblDanhGia = new System.Windows.Forms.Label();
            this.lblHoSo = new System.Windows.Forms.Label();
            this.grbLalamove.SuspendLayout();
            this.grbTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaiDat
            // 
            this.lblCaiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaiDat.ForeColor = System.Drawing.Color.White;
            this.lblCaiDat.Location = new System.Drawing.Point(140, 9);
            this.lblCaiDat.Name = "lblCaiDat";
            this.lblCaiDat.Size = new System.Drawing.Size(105, 31);
            this.lblCaiDat.TabIndex = 0;
            this.lblCaiDat.Text = "Cài đặt ";
            this.lblCaiDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCaiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.Location = new System.Drawing.Point(284, 412);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(100, 50);
            this.btnCaiDat.TabIndex = 7;
            this.btnCaiDat.Text = "Cài đặt";
            this.btnCaiDat.UseVisualStyleBackColor = true;
            // 
            // btnViDienTu
            // 
            this.btnViDienTu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViDienTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViDienTu.Location = new System.Drawing.Point(193, 412);
            this.btnViDienTu.Name = "btnViDienTu";
            this.btnViDienTu.Size = new System.Drawing.Size(100, 50);
            this.btnViDienTu.TabIndex = 8;
            this.btnViDienTu.Text = "Ví điện tử";
            this.btnViDienTu.UseVisualStyleBackColor = true;
            this.btnViDienTu.Click += new System.EventHandler(this.btnViDienTu_Click);
            // 
            // btnDonHang
            // 
            this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.Location = new System.Drawing.Point(96, 412);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(100, 50);
            this.btnDonHang.TabIndex = 9;
            this.btnDonHang.Text = "Đơn hàng";
            this.btnDonHang.UseVisualStyleBackColor = true;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // btnNhanHang
            // 
            this.btnNhanHang.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNhanHang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNhanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanHang.Location = new System.Drawing.Point(0, 412);
            this.btnNhanHang.Name = "btnNhanHang";
            this.btnNhanHang.Size = new System.Drawing.Size(100, 50);
            this.btnNhanHang.TabIndex = 10;
            this.btnNhanHang.Text = "Nhận hàng";
            this.btnNhanHang.UseVisualStyleBackColor = false;
            this.btnNhanHang.Click += new System.EventHandler(this.btnNhanHang_Click);
            // 
            // lblDangXuat
            // 
            this.lblDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangXuat.ForeColor = System.Drawing.Color.White;
            this.lblDangXuat.Location = new System.Drawing.Point(244, 7);
            this.lblDangXuat.Name = "lblDangXuat";
            this.lblDangXuat.Size = new System.Drawing.Size(140, 35);
            this.lblDangXuat.TabIndex = 11;
            this.lblDangXuat.Text = "Đăng xuất";
            this.lblDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDangXuat.Click += new System.EventHandler(this.lblDangXuat_Click);
            // 
            // grbLalamove
            // 
            this.grbLalamove.Controls.Add(this.lblVersion);
            this.grbLalamove.Controls.Add(this.lblAboutUs);
            this.grbLalamove.Controls.Add(this.lblYKien);
            this.grbLalamove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLalamove.ForeColor = System.Drawing.Color.DimGray;
            this.grbLalamove.Location = new System.Drawing.Point(12, 134);
            this.grbLalamove.Name = "grbLalamove";
            this.grbLalamove.Size = new System.Drawing.Size(360, 106);
            this.grbLalamove.TabIndex = 12;
            this.grbLalamove.TabStop = false;
            this.grbLalamove.Text = "Lalamove";
            // 
            // lblYKien
            // 
            this.lblYKien.ForeColor = System.Drawing.Color.White;
            this.lblYKien.Location = new System.Drawing.Point(18, 25);
            this.lblYKien.Name = "lblYKien";
            this.lblYKien.Size = new System.Drawing.Size(70, 27);
            this.lblYKien.TabIndex = 0;
            this.lblYKien.Text = "Ý kiến";
            this.lblYKien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.ForeColor = System.Drawing.Color.White;
            this.lblAboutUs.Location = new System.Drawing.Point(18, 52);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(121, 27);
            this.lblAboutUs.TabIndex = 0;
            this.lblAboutUs.Text = "Về chúng tôi";
            this.lblAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(18, 76);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(295, 27);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Phiên bản tài xế. 3.17.0.1 (SEA)";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbTaiKhoan
            // 
            this.grbTaiKhoan.Controls.Add(this.lblDanhGia);
            this.grbTaiKhoan.Controls.Add(this.lblHoSo);
            this.grbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTaiKhoan.ForeColor = System.Drawing.Color.DimGray;
            this.grbTaiKhoan.Location = new System.Drawing.Point(12, 45);
            this.grbTaiKhoan.Name = "grbTaiKhoan";
            this.grbTaiKhoan.Size = new System.Drawing.Size(360, 83);
            this.grbTaiKhoan.TabIndex = 12;
            this.grbTaiKhoan.TabStop = false;
            this.grbTaiKhoan.Text = "Tài khoản";
            // 
            // lblDanhGia
            // 
            this.lblDanhGia.ForeColor = System.Drawing.Color.White;
            this.lblDanhGia.Location = new System.Drawing.Point(18, 52);
            this.lblDanhGia.Name = "lblDanhGia";
            this.lblDanhGia.Size = new System.Drawing.Size(89, 27);
            this.lblDanhGia.TabIndex = 0;
            this.lblDanhGia.Text = "Đánh giá";
            this.lblDanhGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHoSo
            // 
            this.lblHoSo.ForeColor = System.Drawing.Color.White;
            this.lblHoSo.Location = new System.Drawing.Point(18, 25);
            this.lblHoSo.Name = "lblHoSo";
            this.lblHoSo.Size = new System.Drawing.Size(70, 27);
            this.lblHoSo.TabIndex = 0;
            this.lblHoSo.Text = "Hồ sơ";
            this.lblHoSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.grbTaiKhoan);
            this.Controls.Add(this.grbLalamove);
            this.Controls.Add(this.lblDangXuat);
            this.Controls.Add(this.btnCaiDat);
            this.Controls.Add(this.btnViDienTu);
            this.Controls.Add(this.btnDonHang);
            this.Controls.Add(this.btnNhanHang);
            this.Controls.Add(this.lblCaiDat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCaiDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt";
            this.grbLalamove.ResumeLayout(false);
            this.grbTaiKhoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCaiDat;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Button btnViDienTu;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnNhanHang;
        private System.Windows.Forms.Label lblDangXuat;
        private System.Windows.Forms.GroupBox grbLalamove;
        private System.Windows.Forms.Label lblYKien;
        private System.Windows.Forms.Label lblAboutUs;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.GroupBox grbTaiKhoan;
        private System.Windows.Forms.Label lblDanhGia;
        private System.Windows.Forms.Label lblHoSo;
    }
}