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
    public partial class FormViDienTu : Form
    {
        public FormViDienTu()
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

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            FormCaiDat fCaiDat = new FormCaiDat();
            this.Hide();
            fCaiDat.ShowDialog();
            this.Close();
        }
    }
}
