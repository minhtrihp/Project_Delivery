namespace AppGiaoHang
{
    partial class FormDonHang
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
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.btnViDienTu = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnNhanHang = new System.Windows.Forms.Button();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cBLoc = new System.Windows.Forms.ComboBox();
            this.lVCacDonHang = new System.Windows.Forms.ListView();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCaiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.Location = new System.Drawing.Point(284, 413);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(100, 50);
            this.btnCaiDat.TabIndex = 3;
            this.btnCaiDat.Text = "Cài đặt";
            this.btnCaiDat.UseVisualStyleBackColor = true;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // btnViDienTu
            // 
            this.btnViDienTu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViDienTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViDienTu.Location = new System.Drawing.Point(193, 413);
            this.btnViDienTu.Name = "btnViDienTu";
            this.btnViDienTu.Size = new System.Drawing.Size(100, 50);
            this.btnViDienTu.TabIndex = 4;
            this.btnViDienTu.Text = "Ví điện tử";
            this.btnViDienTu.UseVisualStyleBackColor = true;
            this.btnViDienTu.Click += new System.EventHandler(this.btnViDienTu_Click);
            // 
            // btnDonHang
            // 
            this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.Location = new System.Drawing.Point(96, 413);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(100, 50);
            this.btnDonHang.TabIndex = 5;
            this.btnDonHang.Text = "Đơn hàng";
            this.btnDonHang.UseVisualStyleBackColor = true;
            // 
            // btnNhanHang
            // 
            this.btnNhanHang.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNhanHang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNhanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanHang.Location = new System.Drawing.Point(0, 413);
            this.btnNhanHang.Name = "btnNhanHang";
            this.btnNhanHang.Size = new System.Drawing.Size(100, 50);
            this.btnNhanHang.TabIndex = 6;
            this.btnNhanHang.Text = "Nhận hàng";
            this.btnNhanHang.UseVisualStyleBackColor = false;
            this.btnNhanHang.Click += new System.EventHandler(this.btnNhanHang_Click);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.White;
            this.lblTrangThai.Location = new System.Drawing.Point(114, 6);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(156, 76);
            this.lblTrangThai.TabIndex = 7;
            this.lblTrangThai.Text = " \" \"";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBLoc
            // 
            this.cBLoc.FormattingEnabled = true;
            this.cBLoc.Location = new System.Drawing.Point(284, 41);
            this.cBLoc.Name = "cBLoc";
            this.cBLoc.Size = new System.Drawing.Size(96, 21);
            this.cBLoc.Sorted = true;
            this.cBLoc.TabIndex = 8;
            this.cBLoc.Text = "Đã nhận";
            this.cBLoc.SelectedIndexChanged += new System.EventHandler(this.cBLoc_SelectedIndexChanged);
            this.cBLoc.TextChanged += new System.EventHandler(this.cbLoc_TextChanged);
            // 
            // lVCacDonHang
            // 
            this.lVCacDonHang.FullRowSelect = true;
            this.lVCacDonHang.GridLines = true;
            this.lVCacDonHang.Location = new System.Drawing.Point(21, 105);
            this.lVCacDonHang.Name = "lVCacDonHang";
            this.lVCacDonHang.Size = new System.Drawing.Size(349, 283);
            this.lVCacDonHang.TabIndex = 9;
            this.lVCacDonHang.UseCompatibleStateImageBehavior = false;
            this.lVCacDonHang.View = System.Windows.Forms.View.Details;
            this.lVCacDonHang.SelectedIndexChanged += new System.EventHandler(this.lVCacDonHang_SelectedIndexChanged);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.AutoSize = true;
            this.btnXemChiTiet.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXemChiTiet.Location = new System.Drawing.Point(21, 65);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(119, 34);
            this.btnXemChiTiet.TabIndex = 10;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // FormDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.lVCacDonHang);
            this.Controls.Add(this.cBLoc);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.btnCaiDat);
            this.Controls.Add(this.btnViDienTu);
            this.Controls.Add(this.btnDonHang);
            this.Controls.Add(this.btnNhanHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng";
            this.Load += new System.EventHandler(this.FormDonHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Button btnViDienTu;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnNhanHang;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cBLoc;
        private System.Windows.Forms.ListView lVCacDonHang;
        private System.Windows.Forms.Button btnXemChiTiet;
    }
}