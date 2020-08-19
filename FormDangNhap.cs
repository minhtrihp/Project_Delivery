using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGiaoHang
{
    
    public partial class formDangNhap : Form
    {
        int loaiDangNhap = 0;
        private String taiKhoanDangNhap;
        private String matKhauDangNhap;
        public int LoaiDangNhap
        {
            get { return loaiDangNhap; }
            set { loaiDangNhap = value; }
        }

        public formDangNhap()
        {
            
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            //Khách hàng
            if(loaiDangNhap == 1)
            {
                //Chưa có
            }
            //Shippers
            else if(loaiDangNhap == 2)
            {
                FormDangKiShippers fDangKi = new FormDangKiShippers();
                this.Hide();
                fDangKi.ShowDialog();
                this.Close();
            }
            //Nhân viên
            else if(loaiDangNhap == 3)
            {
                FormDangKiNV fDangKi = new FormDangKiNV();
                this.Hide();
                fDangKi.ShowDialog();
                this.Close();
            }
            
        }
  
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            QLTaiKhoan QLTK = new QLTaiKhoan();
            bool kiemTraDangNhap = QLTK.dangNhapTK(txbSdt.Text, txbMk.Text, loaiDangNhap);
            //Khách hàng
            if (kiemTraDangNhap && loaiDangNhap == 1)
            {
                taiKhoanDangNhap = txbSdt.Text;
                matKhauDangNhap = txbMk.Text;
                GiaoDienDatHangKH fDatHang = new GiaoDienDatHangKH();
                //Lưu lại TK và MK để qua form khác xử lí
                fDatHang.TaiKhoanDangNhap = this.taiKhoanDangNhap;
                fDatHang.MatKhauDangNhap = this.taiKhoanDangNhap;
                this.Hide();
                fDatHang.ShowDialog();
                this.Close();
            }
            //Shippers
            else if (kiemTraDangNhap && loaiDangNhap == 2)
            {
                taiKhoanDangNhap = txbSdt.Text;
                matKhauDangNhap = txbMk.Text;
                FormNhanHang fNhanHang = new FormNhanHang();
                fNhanHang.TenTaiKhoan = this.taiKhoanDangNhap;
                fNhanHang.MatKhau = this.matKhauDangNhap;
                this.Hide();
                fNhanHang.ShowDialog();
                this.Close();
            }
            //Nhân viên
            else if(kiemTraDangNhap && loaiDangNhap == 3)
            {
                taiKhoanDangNhap = txbSdt.Text;
                matKhauDangNhap = txbMk.Text;
                FormNhanVien fNhanVien = new FormNhanVien();
                this.Hide();
                fNhanVien.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập sai mật khẩu hoặc số điện thoại.");
            }

        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            txbSdt.Text = "0902725706";
            txbMk.Text = "123456";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormLoaiDangNhap fLoaiDangNhap = new FormLoaiDangNhap();
            this.Hide();
            fLoaiDangNhap.ShowDialog();
            this.Close();
        }
    }
}
