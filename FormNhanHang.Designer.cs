namespace AppGiaoHang
{
    partial class FormNhanHang
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
            this.lblNhanHang = new System.Windows.Forms.Label();
            this.btnNhanHang = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnViDienTu = new System.Windows.Forms.Button();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.lVDonChuaNhan = new System.Windows.Forms.ListView();
            this.lVXemChiTietDonHang = new System.Windows.Forms.ListView();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.lbMaDH = new System.Windows.Forms.Label();
            this.lbTaiKhoanDangNhap = new System.Windows.Forms.Label();
            this.lbLayTenDangNhap = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbLayHoTen = new System.Windows.Forms.Label();
            this.lbXemChiTietDonHang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNhanHang
            // 
            this.lblNhanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanHang.ForeColor = System.Drawing.Color.White;
            this.lblNhanHang.Location = new System.Drawing.Point(266, 75);
            this.lblNhanHang.Name = "lblNhanHang";
            this.lblNhanHang.Size = new System.Drawing.Size(159, 32);
            this.lblNhanHang.TabIndex = 0;
            this.lblNhanHang.Text = "Nhận hàng";
            this.lblNhanHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNhanHang
            // 
            this.btnNhanHang.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNhanHang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNhanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanHang.Location = new System.Drawing.Point(458, 5);
            this.btnNhanHang.Name = "btnNhanHang";
            this.btnNhanHang.Size = new System.Drawing.Size(100, 50);
            this.btnNhanHang.TabIndex = 2;
            this.btnNhanHang.Text = "Nhận hàng";
            this.btnNhanHang.UseVisualStyleBackColor = false;
            this.btnNhanHang.Click += new System.EventHandler(this.btnNhanHang_Click);
            // 
            // btnDonHang
            // 
            this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.Location = new System.Drawing.Point(554, 5);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(100, 50);
            this.btnDonHang.TabIndex = 2;
            this.btnDonHang.Text = "Đơn hàng";
            this.btnDonHang.UseVisualStyleBackColor = true;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // btnViDienTu
            // 
            this.btnViDienTu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViDienTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViDienTu.Location = new System.Drawing.Point(651, 5);
            this.btnViDienTu.Name = "btnViDienTu";
            this.btnViDienTu.Size = new System.Drawing.Size(100, 50);
            this.btnViDienTu.TabIndex = 2;
            this.btnViDienTu.Text = "Ví điện tử";
            this.btnViDienTu.UseVisualStyleBackColor = true;
            this.btnViDienTu.Click += new System.EventHandler(this.btnViDienTu_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCaiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.Location = new System.Drawing.Point(742, 5);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(100, 50);
            this.btnCaiDat.TabIndex = 2;
            this.btnCaiDat.Text = "Cài đặt";
            this.btnCaiDat.UseVisualStyleBackColor = true;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // lVDonChuaNhan
            // 
            this.lVDonChuaNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lVDonChuaNhan.FullRowSelect = true;
            this.lVDonChuaNhan.GridLines = true;
            this.lVDonChuaNhan.Location = new System.Drawing.Point(1, 122);
            this.lVDonChuaNhan.Name = "lVDonChuaNhan";
            this.lVDonChuaNhan.Size = new System.Drawing.Size(841, 217);
            this.lVDonChuaNhan.TabIndex = 3;
            this.lVDonChuaNhan.UseCompatibleStateImageBehavior = false;
            this.lVDonChuaNhan.View = System.Windows.Forms.View.Details;
            this.lVDonChuaNhan.SelectedIndexChanged += new System.EventHandler(this.lVDonChuaNhan_SelectedIndexChanged);
            // 
            // lVXemChiTietDonHang
            // 
            this.lVXemChiTietDonHang.FullRowSelect = true;
            this.lVXemChiTietDonHang.GridLines = true;
            this.lVXemChiTietDonHang.Location = new System.Drawing.Point(1, 370);
            this.lVXemChiTietDonHang.Name = "lVXemChiTietDonHang";
            this.lVXemChiTietDonHang.Size = new System.Drawing.Size(841, 91);
            this.lVXemChiTietDonHang.TabIndex = 3;
            this.lVXemChiTietDonHang.UseCompatibleStateImageBehavior = false;
            this.lVXemChiTietDonHang.View = System.Windows.Forms.View.Details;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(119, 75);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(100, 20);
            this.txtMaDH.TabIndex = 4;
            // 
            // lbMaDH
            // 
            this.lbMaDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaDH.ForeColor = System.Drawing.Color.White;
            this.lbMaDH.Location = new System.Drawing.Point(1, 67);
            this.lbMaDH.Name = "lbMaDH";
            this.lbMaDH.Size = new System.Drawing.Size(112, 32);
            this.lbMaDH.TabIndex = 0;
            this.lbMaDH.Text = "Mã đơn hàng:";
            this.lbMaDH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTaiKhoanDangNhap
            // 
            this.lbTaiKhoanDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTaiKhoanDangNhap.ForeColor = System.Drawing.Color.White;
            this.lbTaiKhoanDangNhap.Location = new System.Drawing.Point(-3, 5);
            this.lbTaiKhoanDangNhap.Name = "lbTaiKhoanDangNhap";
            this.lbTaiKhoanDangNhap.Size = new System.Drawing.Size(134, 32);
            this.lbTaiKhoanDangNhap.TabIndex = 0;
            this.lbTaiKhoanDangNhap.Text = "Đăng nhập với:";
            this.lbTaiKhoanDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLayTenDangNhap
            // 
            this.lbLayTenDangNhap.AutoSize = true;
            this.lbLayTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLayTenDangNhap.ForeColor = System.Drawing.Color.White;
            this.lbLayTenDangNhap.Location = new System.Drawing.Point(115, 11);
            this.lbLayTenDangNhap.Name = "lbLayTenDangNhap";
            this.lbLayTenDangNhap.Size = new System.Drawing.Size(40, 20);
            this.lbLayTenDangNhap.TabIndex = 0;
            this.lbLayTenDangNhap.Text = "Test";
            this.lbLayTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHoTen
            // 
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHoTen.ForeColor = System.Drawing.Color.White;
            this.lbHoTen.Location = new System.Drawing.Point(-3, 35);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(134, 32);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Tài xế:";
            this.lbHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLayHoTen
            // 
            this.lbLayHoTen.AutoSize = true;
            this.lbLayHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLayHoTen.ForeColor = System.Drawing.Color.White;
            this.lbLayHoTen.Location = new System.Drawing.Point(115, 41);
            this.lbLayHoTen.Name = "lbLayHoTen";
            this.lbLayHoTen.Size = new System.Drawing.Size(40, 20);
            this.lbLayHoTen.TabIndex = 0;
            this.lbLayHoTen.Text = "Test";
            this.lbLayHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbXemChiTietDonHang
            // 
            this.lbXemChiTietDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXemChiTietDonHang.ForeColor = System.Drawing.Color.White;
            this.lbXemChiTietDonHang.Location = new System.Drawing.Point(231, 335);
            this.lbXemChiTietDonHang.Name = "lbXemChiTietDonHang";
            this.lbXemChiTietDonHang.Size = new System.Drawing.Size(245, 32);
            this.lbXemChiTietDonHang.TabIndex = 0;
            this.lbXemChiTietDonHang.Text = "Chi tiết đơn hàng";
            this.lbXemChiTietDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNhanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(841, 461);
            this.Controls.Add(this.txtMaDH);
            this.Controls.Add(this.lVXemChiTietDonHang);
            this.Controls.Add(this.lVDonChuaNhan);
            this.Controls.Add(this.btnCaiDat);
            this.Controls.Add(this.btnViDienTu);
            this.Controls.Add(this.btnDonHang);
            this.Controls.Add(this.btnNhanHang);
            this.Controls.Add(this.lbLayHoTen);
            this.Controls.Add(this.lbLayTenDangNhap);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.lbTaiKhoanDangNhap);
            this.Controls.Add(this.lbMaDH);
            this.Controls.Add(this.lbXemChiTietDonHang);
            this.Controls.Add(this.lblNhanHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNhanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhận hàng";
            this.Load += new System.EventHandler(this.FormNhanHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhanHang;
        private System.Windows.Forms.Button btnNhanHang;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnViDienTu;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.ListView lVDonChuaNhan;
        private System.Windows.Forms.ListView lVXemChiTietDonHang;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.Label lbMaDH;
        private System.Windows.Forms.Label lbTaiKhoanDangNhap;
        private System.Windows.Forms.Label lbLayTenDangNhap;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbLayHoTen;
        private System.Windows.Forms.Label lbXemChiTietDonHang;
    }
}