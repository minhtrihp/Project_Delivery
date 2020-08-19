using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace AppGiaoHang
{
    public partial class FormNhanHang : Form
    {
        public FormNhanHang()
        {
            InitializeComponent();
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
