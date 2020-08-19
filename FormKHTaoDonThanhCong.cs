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

    public partial class FormKHTaoDonThanhCong : Form
    {
        private String taiKhoanDangNhap;
        private String matKhauDangNhap;
        public String TaiKhoanDangNhap
        {
            get { return taiKhoanDangNhap; }
            set { taiKhoanDangNhap = value; }
        }
        public String MatKhauDangNhap
        {
            get { return matKhauDangNhap; }
            set { matKhauDangNhap = value; }
        }

        public FormKHTaoDonThanhCong()
        {
            InitializeComponent();
        }

        private void btTaoDonHangMoi_Click(object sender, EventArgs e)
        {
            GiaoDienDatHangKH gDKH = new GiaoDienDatHangKH();
            gDKH.TaiKhoanDangNhap = this.taiKhoanDangNhap;
            gDKH.MatKhauDangNhap = this.matKhauDangNhap;
            this.Hide();
            gDKH.ShowDialog();
            this.Close();
        }
    }
}
