namespace AppGiaoHang
{
    partial class FormViDienTu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.btnViDienTu = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnNhanHang = new System.Windows.Forms.Button();
            this.lblCommingSoon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ví điện tử";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCaiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.Location = new System.Drawing.Point(284, 411);
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
            this.btnViDienTu.Location = new System.Drawing.Point(193, 411);
            this.btnViDienTu.Name = "btnViDienTu";
            this.btnViDienTu.Size = new System.Drawing.Size(100, 50);
            this.btnViDienTu.TabIndex = 4;
            this.btnViDienTu.Text = "Ví điện tử";
            this.btnViDienTu.UseVisualStyleBackColor = true;
            // 
            // btnDonHang
            // 
            this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.Location = new System.Drawing.Point(96, 411);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(100, 50);
            this.btnDonHang.TabIndex = 5;
            this.btnDonHang.Text = "Đơn hàng";
            this.btnDonHang.UseVisualStyleBackColor = true;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // btnNhanHang
            // 
            this.btnNhanHang.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNhanHang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNhanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanHang.Location = new System.Drawing.Point(0, 411);
            this.btnNhanHang.Name = "btnNhanHang";
            this.btnNhanHang.Size = new System.Drawing.Size(100, 50);
            this.btnNhanHang.TabIndex = 6;
            this.btnNhanHang.Text = "Nhận hàng";
            this.btnNhanHang.UseVisualStyleBackColor = false;
            this.btnNhanHang.Click += new System.EventHandler(this.btnNhanHang_Click);
            // 
            // lblCommingSoon
            // 
            this.lblCommingSoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommingSoon.Location = new System.Drawing.Point(86, 108);
            this.lblCommingSoon.Name = "lblCommingSoon";
            this.lblCommingSoon.Size = new System.Drawing.Size(213, 244);
            this.lblCommingSoon.TabIndex = 7;
            this.lblCommingSoon.Text = "COMMING SOON";
            this.lblCommingSoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormViDienTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.lblCommingSoon);
            this.Controls.Add(this.btnCaiDat);
            this.Controls.Add(this.btnViDienTu);
            this.Controls.Add(this.btnDonHang);
            this.Controls.Add(this.btnNhanHang);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormViDienTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ví điện tử";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Button btnViDienTu;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnNhanHang;
        private System.Windows.Forms.Label lblCommingSoon;
    }
}