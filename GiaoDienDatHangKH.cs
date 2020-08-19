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
    public partial class GiaoDienDatHangKH : Form
    {
        private String tempQuanHuyenNhanHang;
        private String tempQuanHuyenGiaoHang;
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

        public GiaoDienDatHangKH()
        {
            InitializeComponent();
            txbSDTNguoiNhan.MaxLength = 10;
        }

        public void layQuanHuyenTuCSDLGanVaoCB()
        {
            using(var db = new CSDLQuanHuyenPhuongXaTPHCMEntities())
            {
                foreach(var data in db.QuanHuyens)
                {
                    cbQuanHuyenNhanHang.Items.Add(data.TenQuanHuyen);
                    cbQuanHuyenGiaoHang.Items.Add(data.TenQuanHuyen);
                }
            }
        }
        //Loại 1: Nhận hàng
        //Loại 2: Giao hàng
        public void layPhuongXaTuCSDLGanCB(string tenQuanHuyen, int loaiCB)
        {
            using (var db = new CSDLQuanHuyenPhuongXaTPHCMEntities())
            {
                using(var dSPXNhanHang = db.TimPhuongXaTheoQuanHuyen(tenQuanHuyen))
                {
                    foreach (var data in dSPXNhanHang)
                    {
                        if(loaiCB == 1)
                            cbPhuongXaNhanHang.Items.Add(data.TenPhuongXa);
                        else
                            cbPhuongXaGiaoHang.Items.Add(data.TenPhuongXa);
                    }
                }
            }
        }
        //Xóa các DS phường trước đó trong CB
        //Loại 1: Nhận hàng
        //Loại 2: Giao hàng
        public void xoaPhuongXaTrongCB(string tenQuanHuyen, int loaiCB)
        {
            using (var db = new CSDLQuanHuyenPhuongXaTPHCMEntities())
            {
                using (var dSPXNhanHang = db.TimPhuongXaTheoQuanHuyen(tenQuanHuyen))
                {
                    foreach (var data in dSPXNhanHang)
                    {
                        if(loaiCB == 1)
                            cbPhuongXaNhanHang.Items.Remove(data.TenPhuongXa);
                        else
                            cbPhuongXaGiaoHang.Items.Remove(data.TenPhuongXa);
                    }
                }
            }
        }

        private void lbNhanHang_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GiaoDienDatHangKH_Load(object sender, EventArgs e)
        {
            layQuanHuyenTuCSDLGanVaoCB();       
        }

        private void cbQuanHuyenNhanHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            xoaPhuongXaTrongCB(tempQuanHuyenNhanHang, 1);
            layPhuongXaTuCSDLGanCB(cbQuanHuyenNhanHang.Text, 1);
            tempQuanHuyenNhanHang = cbQuanHuyenNhanHang.Text;
        }

        private void cbPhuongXaGiaoHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbQuanHuyenGiaoHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            xoaPhuongXaTrongCB(tempQuanHuyenGiaoHang, 2);
            layPhuongXaTuCSDLGanCB(cbQuanHuyenGiaoHang.Text, 2);
            tempQuanHuyenGiaoHang = cbQuanHuyenGiaoHang.Text;
        }

        private void btnDatDon_Click(object sender, EventArgs e)
        {
            QLDonHang qLDH = new QLDonHang();
            DonHang dH = new DonHang(); //Nhập các giá trị còn lại vào DonHang
            
            if(isDienDuThongTin())
            {
                dH.MaKH = qLDH.traVeMaTheoTKKH(taiKhoanDangNhap); //Lấy Mã KH từ tên đăng nhập. Rồi gán vào
                dH.TienUng = int.Parse(txbTienUng.Text);
                dH.GhiChu = txbGhiChu.Text;
                bool kiemTraKhoiTaoDonHang = qLDH.khoiTaoDonHang(dH);              
                if (kiemTraKhoiTaoDonHang)
                {
                    
                    ChiTietDonHang cTDH = new ChiTietDonHang();
                    cTDH.MaDH = qLDH.layMaDHVuaDat();
                    //Nhận hàng
                    cTDH.DiaChiNhanHang = txbDiaChiNhanHang.Text;
                    cTDH.PhuongNhanHang = cbPhuongXaNhanHang.Text;
                    cTDH.QuanNhanHang = cbQuanHuyenNhanHang.Text;
                    //Giao hàng
                    cTDH.TenNguoiNhanHang = txbTenNguoiNhan.Text;
                    cTDH.SDTNguoiNhanHang = txbSDTNguoiNhan.Text;
                    cTDH.DiaChiGiaoHang = txbDiaChiGiaoHang.Text;
                    cTDH.PhuongGiaoHang = cbPhuongXaGiaoHang.Text;
                    cTDH.QuanGiaoHang = cbQuanHuyenGiaoHang.Text;
                    //Thông tin còn lại
                    cTDH.PhiShip = int.Parse(txbPhiShip.Text);
                    //Add vào database
                    qLDH.nhapThongTinChiTietDonHang(cTDH);
                    MessageBox.Show("Tạo thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormKHTaoDonThanhCong dHTC = new FormKHTaoDonThanhCong();
                    dHTC.TaiKhoanDangNhap = this.taiKhoanDangNhap;
                    dHTC.MatKhauDangNhap = this.matKhauDangNhap;
                    this.Hide();
                    dHTC.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Tạo đơn thất bại hoặc chưa nhập đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //MessageBox.Show("Tạo thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //FormKHTaoDonThanhCong dHTC = new FormKHTaoDonThanhCong();
            //dHTC.TaiKhoanDangNhap = this.taiKhoanDangNhap;
            //dHTC.MatKhauDangNhap = this.matKhauDangNhap;
            //this.Hide();
            //dHTC.ShowDialog();
            //this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất hay không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormLoaiDangNhap fLoaiDangNhap = new FormLoaiDangNhap();
                this.Hide();
                fLoaiDangNhap.ShowDialog();
                this.Close();
            }
        }

        private void txbDiaChiNhanHang_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbDiaChiNhanHang.Text.Trim()))
            {
                e.Cancel = true;
                txbDiaChiNhanHang.Focus();
                errorProvider1.SetError(txbDiaChiNhanHang, "Vui lòng nhập địa chỉ nhận hàng!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txbDiaChiNhanHang, null);
            }
        }

        private void txbDiaChiGiaoHang_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbDiaChiGiaoHang.Text.Trim()))
            {
                e.Cancel = true;
                txbDiaChiGiaoHang.Focus();
                errorProvider1.SetError(txbDiaChiGiaoHang, "Vui lòng nhập địa chỉ giao hàng!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txbDiaChiGiaoHang, null);
            }
        }

        private void cbQuanHuyenNhanHang_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbQuanHuyenNhanHang.Text))
            {
                e.Cancel = true;
                cbQuanHuyenNhanHang.Focus();
                errorProvider3.SetError(cbQuanHuyenNhanHang, "Vui lòng chọn quận huyện nhận hàng!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(cbQuanHuyenNhanHang, null);
            }
        }

        private void cbQuanHuyenGiaoHang_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbQuanHuyenGiaoHang.Text))
            {
                e.Cancel = true;
                cbQuanHuyenGiaoHang.Focus();
                errorProvider4.SetError(cbQuanHuyenGiaoHang, "Vui lòng chọn quận huyện giao hàng!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(cbQuanHuyenGiaoHang, null);
            }
        }

        private void cbPhuongXaGiaoHang_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbPhuongXaGiaoHang.Text))
            {
                e.Cancel = true;
                cbPhuongXaGiaoHang.Focus();
                errorProvider6.SetError(cbPhuongXaGiaoHang, "Vui lòng chọn phường xã giao hàng!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider6.SetError(cbPhuongXaGiaoHang, null);
            }
        }

        private void txbTenNguoiNhan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbTenNguoiNhan.Text.Trim()))
            {
                e.Cancel = true;
                txbTenNguoiNhan.Focus();
                errorProvider7.SetError(txbTenNguoiNhan, "Vui lòng nhập họ tên người nhận hàng !!");
            }
            else
            {
                e.Cancel = false;
                errorProvider7.SetError(txbTenNguoiNhan, null);
            }
        }

        private void txbTenNguoiNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txbTenNguoiNhan, "Vui lòng không nhập số!!");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txbTenNguoiNhan, null);
            }
        }

        private void txbTienUng_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbTienUng.Text.Trim()))
            {
                e.Cancel = true;
                txbTienUng.Focus();
                errorProvider9.SetError(txbTienUng, "Vui lòng nhập số tiền ứng!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider9.SetError(txbTienUng, null);
            }
        }

        private void txbTienUng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider9.SetError(txbTienUng, "Vui lòng không nhập chữ cái và khoảng trống!!");
            }
            else
            {
                e.Handled = false;
                errorProvider9.SetError(txbTienUng, null);
            }
        }

        private void txbPhiShip_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbPhiShip.Text.Trim()))
            {
                e.Cancel = true;
                txbPhiShip.Focus();
                errorProvider10.SetError(txbPhiShip, "Vui lòng nhập số tiền ship!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider10.SetError(txbPhiShip, null);
            }
        }

        private void txbPhiShip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider10.SetError(txbPhiShip, "Vui lòng không nhập chữ cái và khoảng trống!!");
            }
            else
            {
                e.Handled = false;
                errorProvider10.SetError(txbTienUng, null);
            }
        }

        private void txbSDTNguoiNhan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbSDTNguoiNhan.Text.Trim()))
            {
                e.Cancel = true;
                txbSDTNguoiNhan.Focus();
                errorProvider8.SetError(txbSDTNguoiNhan, "Vui lòng nhập số điện thoại người nhận!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider8.SetError(txbSDTNguoiNhan, null);
            }
        }

        private void txbSDTNguoiNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider10.SetError(txbSDTNguoiNhan, "Vui lòng không nhập chữ cái và khoảng trống!!");
            }
            else
            {
                e.Handled = false;
                errorProvider10.SetError(txbSDTNguoiNhan, null);
            }
        }
        private bool isDienDuThongTin()
        {
            if (!String.IsNullOrEmpty(txbDiaChiNhanHang.Text.Trim()))
                if (!string.IsNullOrEmpty(txbDiaChiGiaoHang.Text.Trim()))
                    if (!string.IsNullOrEmpty(cbQuanHuyenNhanHang.Text))
                        if (!string.IsNullOrEmpty(cbQuanHuyenGiaoHang.Text))
                            if (!string.IsNullOrEmpty(cbPhuongXaNhanHang.Text))
                                if (!string.IsNullOrEmpty(cbPhuongXaGiaoHang.Text))
                                    if (!string.IsNullOrEmpty(txbTenNguoiNhan.Text.Trim()))
                                        if (!string.IsNullOrEmpty(txbTienUng.Text.Trim()))
                                            if (!string.IsNullOrEmpty(txbPhiShip.Text.Trim()))
                                                if (!string.IsNullOrEmpty(txbSDTNguoiNhan.Text.Trim()))
                                                    return true;
            return false;
        }


         

    }
}
