namespace AppGiaoHang
{
    partial class FormDangKiNV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKiNV));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbNgaySinh = new System.Windows.Forms.TextBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblNhapMatKhau = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.lblNhapLaiMatKhau = new System.Windows.Forms.Label();
            this.txbMatKhauNhapLai = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.maskedTxbSdt = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.comboBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(-3, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(390, 98);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(86, 124);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(85, 29);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên";
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(166, 127);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(186, 20);
            this.txbHoTen.TabIndex = 1;
            this.txbHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbHoTen_KeyPress);
            this.txbHoTen.Validating += new System.ComponentModel.CancelEventHandler(this.txbHoTen_Validating);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(86, 157);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(85, 29);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Địa chỉ";
            this.lblDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(72, 186);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(98, 29);
            this.lblNgaySinh.TabIndex = 1;
            this.lblNgaySinh.Text = "Ngày sinh";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(166, 160);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(186, 20);
            this.txbDiaChi.TabIndex = 3;
            this.txbDiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.txbDiaChi_Validating);
            // 
            // txbNgaySinh
            // 
            this.txbNgaySinh.Location = new System.Drawing.Point(166, 193);
            this.txbNgaySinh.Name = "txbNgaySinh";
            this.txbNgaySinh.Size = new System.Drawing.Size(80, 20);
            this.txbNgaySinh.TabIndex = 4;
            this.txbNgaySinh.Validating += new System.ComponentModel.CancelEventHandler(this.txbNgaySinh_Validating);
            // 
            // lblSdt
            // 
            this.lblSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdt.Location = new System.Drawing.Point(44, 216);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(127, 29);
            this.lblSdt.TabIndex = 1;
            this.lblSdt.Text = "Số điện thoại";
            this.lblSdt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDangKi
            // 
            this.btnDangKi.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDangKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKi.ForeColor = System.Drawing.Color.White;
            this.btnDangKi.Location = new System.Drawing.Point(76, 360);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(127, 42);
            this.btnDangKi.TabIndex = 9;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = false;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Orange;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(209, 360);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 42);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblNhapMatKhau
            // 
            this.lblNhapMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapMatKhau.Location = new System.Drawing.Point(25, 245);
            this.lblNhapMatKhau.Name = "lblNhapMatKhau";
            this.lblNhapMatKhau.Size = new System.Drawing.Size(146, 29);
            this.lblNhapMatKhau.TabIndex = 1;
            this.lblNhapMatKhau.Text = "Nhập mật khẩu";
            this.lblNhapMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(166, 248);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.PasswordChar = '*';
            this.txbMatKhau.Size = new System.Drawing.Size(186, 20);
            this.txbMatKhau.TabIndex = 6;
            this.txbMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMatKhau_KeyPress);
            this.txbMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.txbMatKhau_Validating);
            // 
            // lblNhapLaiMatKhau
            // 
            this.lblNhapLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapLaiMatKhau.Location = new System.Drawing.Point(3, 270);
            this.lblNhapLaiMatKhau.Name = "lblNhapLaiMatKhau";
            this.lblNhapLaiMatKhau.Size = new System.Drawing.Size(167, 29);
            this.lblNhapLaiMatKhau.TabIndex = 1;
            this.lblNhapLaiMatKhau.Text = "Nhập lại mật khẩu";
            this.lblNhapLaiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbMatKhauNhapLai
            // 
            this.txbMatKhauNhapLai.Location = new System.Drawing.Point(165, 277);
            this.txbMatKhauNhapLai.Name = "txbMatKhauNhapLai";
            this.txbMatKhauNhapLai.PasswordChar = '*';
            this.txbMatKhauNhapLai.Size = new System.Drawing.Size(187, 20);
            this.txbMatKhauNhapLai.TabIndex = 7;
            this.txbMatKhauNhapLai.Validating += new System.ComponentModel.CancelEventHandler(this.txbMatKhauNhapLai_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // maskedTxbSdt
            // 
            this.maskedTxbSdt.Location = new System.Drawing.Point(166, 223);
            this.maskedTxbSdt.Mask = "0000000000";
            this.maskedTxbSdt.Name = "maskedTxbSdt";
            this.maskedTxbSdt.Size = new System.Drawing.Size(80, 20);
            this.maskedTxbSdt.TabIndex = 5;
            this.maskedTxbSdt.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTxbSdt_Validating);
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(262, 193);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(90, 20);
            this.dateTimePickerNgaySinh.TabIndex = 10;
            this.dateTimePickerNgaySinh.ValueChanged += new System.EventHandler(this.dateTimePickerNgaySinh_ValueChanged);
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(72, 300);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(98, 29);
            this.lblGioiTinh.TabIndex = 1;
            this.lblGioiTinh.Text = "Giới tính";
            this.lblGioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGioiTinh.FormattingEnabled = true;
            this.comboBoxGioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ ",
            "Khác"});
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(166, 303);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(80, 21);
            this.comboBoxGioiTinh.TabIndex = 8;
            this.comboBoxGioiTinh.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxGioiTinh_Validating);
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // FormDangKiNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.comboBoxGioiTinh);
            this.Controls.Add(this.dateTimePickerNgaySinh);
            this.Controls.Add(this.maskedTxbSdt);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.txbNgaySinh);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.txbMatKhauNhapLai);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblNhapLaiMatKhau);
            this.Controls.Add(this.lblNhapMatKhau);
            this.Controls.Add(this.lblSdt);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangKiNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí ";
            this.Load += new System.EventHandler(this.FormDangKiShippers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbNgaySinh;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblNhapMatKhau;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label lblNhapLaiMatKhau;
        private System.Windows.Forms.TextBox txbMatKhauNhapLai;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.MaskedTextBox maskedTxbSdt;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox comboBoxGioiTinh;
        private System.Windows.Forms.ErrorProvider errorProvider8;
    }
}