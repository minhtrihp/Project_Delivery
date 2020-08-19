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
    public partial class FormLoaiDangNhap : Form
    {
        int loaiTaiKhoan;
        public FormLoaiDangNhap()
        {
            InitializeComponent();
        }

        private void btnShipper_Click(object sender, EventArgs e)
        {
            loaiTaiKhoan = 2;
            formDangNhap fDangNhap = new formDangNhap();
            fDangNhap.LoaiDangNhap = loaiTaiKhoan;
            this.Hide();
            fDangNhap.ShowDialog();
            this.Close();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            loaiTaiKhoan = 1;
            formDangNhap fDangNhap = new formDangNhap();
            fDangNhap.LoaiDangNhap = loaiTaiKhoan;
            this.Hide();
            fDangNhap.ShowDialog();
            this.Close();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            loaiTaiKhoan = 3;
            formDangNhap fDangNhap = new formDangNhap();
            fDangNhap.LoaiDangNhap = loaiTaiKhoan;
            this.Hide();
            fDangNhap.ShowDialog();
            this.Close();
        }
    }
}
