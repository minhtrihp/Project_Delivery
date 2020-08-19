namespace AppGiaoHang
{
    partial class FormNhanVien
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
            this.lvHienThi = new System.Windows.Forms.ListView();
            this.lbChonLoaiThongTin = new System.Windows.Forms.Label();
            this.qLGiaoHangDataSet = new AppGiaoHang.QLGiaoHangDataSet();
            this.btOke = new System.Windows.Forms.Button();
            this.cbChonLoaiThongTin = new System.Windows.Forms.ComboBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lbMa = new System.Windows.Forms.Label();
            this.bTHuyDon = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.lBChonDonHang = new System.Windows.Forms.Label();
            this.cBChonDonHang = new System.Windows.Forms.ComboBox();
            this.btDangXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLGiaoHangDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lvHienThi
            // 
            this.lvHienThi.Location = new System.Drawing.Point(35, 159);
            this.lvHienThi.Name = "lvHienThi";
            this.lvHienThi.Size = new System.Drawing.Size(467, 150);
            this.lvHienThi.TabIndex = 0;
            this.lvHienThi.UseCompatibleStateImageBehavior = false;
            this.lvHienThi.View = System.Windows.Forms.View.Details;
            this.lvHienThi.SelectedIndexChanged += new System.EventHandler(this.lvHienThi_SelectedIndexChanged);
            // 
            // lbChonLoaiThongTin
            // 
            this.lbChonLoaiThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChonLoaiThongTin.Location = new System.Drawing.Point(12, 24);
            this.lbChonLoaiThongTin.Name = "lbChonLoaiThongTin";
            this.lbChonLoaiThongTin.Size = new System.Drawing.Size(100, 23);
            this.lbChonLoaiThongTin.TabIndex = 1;
            this.lbChonLoaiThongTin.Text = "Chọn thông tin:";
            // 
            // qLGiaoHangDataSet
            // 
            this.qLGiaoHangDataSet.DataSetName = "QLGiaoHangDataSet";
            this.qLGiaoHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btOke
            // 
            this.btOke.Location = new System.Drawing.Point(35, 106);
            this.btOke.Name = "btOke";
            this.btOke.Size = new System.Drawing.Size(75, 23);
            this.btOke.TabIndex = 2;
            this.btOke.Text = "Oke";
            this.btOke.UseVisualStyleBackColor = true;
            this.btOke.Click += new System.EventHandler(this.btOke_Click);
            // 
            // cbChonLoaiThongTin
            // 
            this.cbChonLoaiThongTin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonLoaiThongTin.FormattingEnabled = true;
            this.cbChonLoaiThongTin.Location = new System.Drawing.Point(119, 24);
            this.cbChonLoaiThongTin.Name = "cbChonLoaiThongTin";
            this.cbChonLoaiThongTin.Size = new System.Drawing.Size(121, 21);
            this.cbChonLoaiThongTin.TabIndex = 3;
            this.cbChonLoaiThongTin.SelectedIndexChanged += new System.EventHandler(this.cbChonLoaiThongTin_SelectedIndexChanged);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(398, 42);
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.Size = new System.Drawing.Size(100, 20);
            this.txtText.TabIndex = 4;
            // 
            // lbMa
            // 
            this.lbMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMa.Location = new System.Drawing.Point(362, 43);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(30, 20);
            this.lbMa.TabIndex = 6;
            this.lbMa.Text = "Mã:";
            // 
            // bTHuyDon
            // 
            this.bTHuyDon.Location = new System.Drawing.Point(139, 106);
            this.bTHuyDon.Name = "bTHuyDon";
            this.bTHuyDon.Size = new System.Drawing.Size(75, 23);
            this.bTHuyDon.TabIndex = 2;
            this.bTHuyDon.Text = "Hủy đơn";
            this.bTHuyDon.UseVisualStyleBackColor = true;
            this.bTHuyDon.Visible = false;
            this.bTHuyDon.Click += new System.EventHandler(this.bTHuyDon_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(365, 106);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Visible = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // lBChonDonHang
            // 
            this.lBChonDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lBChonDonHang.Location = new System.Drawing.Point(12, 57);
            this.lBChonDonHang.Name = "lBChonDonHang";
            this.lBChonDonHang.Size = new System.Drawing.Size(101, 23);
            this.lBChonDonHang.TabIndex = 1;
            this.lBChonDonHang.Text = "Chọn đơn hàng:";
            this.lBChonDonHang.Visible = false;
            // 
            // cBChonDonHang
            // 
            this.cBChonDonHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBChonDonHang.FormattingEnabled = true;
            this.cBChonDonHang.Location = new System.Drawing.Point(119, 57);
            this.cBChonDonHang.Name = "cBChonDonHang";
            this.cBChonDonHang.Size = new System.Drawing.Size(121, 21);
            this.cBChonDonHang.TabIndex = 3;
            this.cBChonDonHang.Visible = false;
            this.cBChonDonHang.SelectedIndexChanged += new System.EventHandler(this.cBChonDonHang_SelectedIndexChanged);
            // 
            // btDangXuat
            // 
            this.btDangXuat.BackColor = System.Drawing.Color.DarkOrange;
            this.btDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDangXuat.ForeColor = System.Drawing.Color.White;
            this.btDangXuat.Location = new System.Drawing.Point(408, -2);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(112, 38);
            this.btDangXuat.TabIndex = 12;
            this.btDangXuat.Text = "Đăng xuất";
            this.btDangXuat.UseVisualStyleBackColor = false;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 329);
            this.Controls.Add(this.btDangXuat);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.cBChonDonHang);
            this.Controls.Add(this.cbChonLoaiThongTin);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.bTHuyDon);
            this.Controls.Add(this.btOke);
            this.Controls.Add(this.lBChonDonHang);
            this.Controls.Add(this.lbChonLoaiThongTin);
            this.Controls.Add(this.lvHienThi);
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Nhân Viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLGiaoHangDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvHienThi;
        private System.Windows.Forms.Label lbChonLoaiThongTin;
        private QLGiaoHangDataSet qLGiaoHangDataSet;
        private System.Windows.Forms.Button btOke;
        private System.Windows.Forms.ComboBox cbChonLoaiThongTin;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Button bTHuyDon;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label lBChonDonHang;
        private System.Windows.Forms.ComboBox cBChonDonHang;
        private System.Windows.Forms.Button btDangXuat;

    }
}