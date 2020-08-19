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
            this.SuspendLayout();
            // 
            // lblNhanHang
            // 
            this.lblNhanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanHang.ForeColor = System.Drawing.Color.White;
            this.lblNhanHang.Location = new System.Drawing.Point(113, 9);
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
            this.lVDonChuaNhan.Location = new System.Drawing.Point(1, 81);
            this.lVDonChuaNhan.Name = "lVDonChuaNhan";
            this.lVDonChuaNhan.Size = new System.Drawing.Size(841, 234);
            this.lVDonChuaNhan.TabIndex = 3;
            this.lVDonChuaNhan.UseCompatibleStateImageBehavior = false;
            this.lVDonChuaNhan.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lVXemChiTietDonHang
            // 
            this.lVXemChiTietDonHang.Location = new System.Drawing.Point(1, 364);
            this.lVXemChiTietDonHang.Name = "lVXemChiTietDonHang";
            this.lVXemChiTietDonHang.Size = new System.Drawing.Size(841, 85);
            this.lVXemChiTietDonHang.TabIndex = 3;
            this.lVXemChiTietDonHang.UseCompatibleStateImageBehavior = false;
            // 
            // FormNhanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(841, 461);
            this.Controls.Add(this.lVXemChiTietDonHang);
            this.Controls.Add(this.lVDonChuaNhan);
            this.Controls.Add(this.btnCaiDat);
            this.Controls.Add(this.btnViDienTu);
            this.Controls.Add(this.btnDonHang);
            this.Controls.Add(this.btnNhanHang);
            this.Controls.Add(this.lblNhanHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNhanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhận hàng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNhanHang;
        private System.Windows.Forms.Button btnNhanHang;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnViDienTu;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.ListView lVDonChuaNhan;
        private System.Windows.Forms.ListView lVXemChiTietDonHang;
    }
}