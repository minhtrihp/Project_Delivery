namespace AppGiaoHang
{
    partial class FormKHTaoDonThanhCong
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
            this.lbTaoDonThanhCong = new System.Windows.Forms.Label();
            this.btTaoDonHangMoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTaoDonThanhCong
            // 
            this.lbTaoDonThanhCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTaoDonThanhCong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTaoDonThanhCong.Location = new System.Drawing.Point(101, 53);
            this.lbTaoDonThanhCong.Name = "lbTaoDonThanhCong";
            this.lbTaoDonThanhCong.Size = new System.Drawing.Size(177, 92);
            this.lbTaoDonThanhCong.TabIndex = 0;
            this.lbTaoDonThanhCong.Text = "Tạo đơn thành công";
            this.lbTaoDonThanhCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btTaoDonHangMoi
            // 
            this.btTaoDonHangMoi.BackColor = System.Drawing.Color.DarkOrange;
            this.btTaoDonHangMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTaoDonHangMoi.ForeColor = System.Drawing.Color.White;
            this.btTaoDonHangMoi.Location = new System.Drawing.Point(12, 12);
            this.btTaoDonHangMoi.Name = "btTaoDonHangMoi";
            this.btTaoDonHangMoi.Size = new System.Drawing.Size(112, 38);
            this.btTaoDonHangMoi.TabIndex = 11;
            this.btTaoDonHangMoi.Text = "Quay lại";
            this.btTaoDonHangMoi.UseVisualStyleBackColor = false;
            this.btTaoDonHangMoi.Click += new System.EventHandler(this.btTaoDonHangMoi_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(86, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Some new features: Comming Soon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormKHTaoDonThanhCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btTaoDonHangMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTaoDonThanhCong);
            this.Name = "FormKHTaoDonThanhCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt hàng thành công";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTaoDonThanhCong;
        private System.Windows.Forms.Button btTaoDonHangMoi;
        private System.Windows.Forms.Label label1;
    }
}