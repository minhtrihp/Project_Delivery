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
    public partial class FormCaiDat : Form
    {
        public FormCaiDat()
        {
            InitializeComponent();
        }

        private void btnNhanHang_Click(object sender, EventArgs e)
        {
            FormNhanHang fNhanHang = new FormNhanHang();
            this.Hide();
            fNhanHang.ShowDialog();
            this.Close();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            FormDonHang fDonHang = new FormDonHang();
            this.Hide();
            fDonHang.ShowDialog();
            this.Close();
        }

        private void btnViDienTu_Click(object sender, EventArgs e)
        {
            FormViDienTu fViDienTu = new FormViDienTu();
            this.Hide();
            fViDienTu.ShowDialog();
            this.Hide();
        }

        private void lblDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất hay không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormLoaiDangNhap fLoaiDangNhap = new FormLoaiDangNhap();
                this.Hide();
                fLoaiDangNhap.ShowDialog();
                this.Close();
            }
        }
    }
}
