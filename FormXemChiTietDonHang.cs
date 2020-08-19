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
    public partial class FormXemChiTietDonHang : Form
    {     
        int maKHDatDon = 0;
        int maDH = 0;
        int maShipper = 0;

        String taiKhoanShipper = "";
        String tinhTrang = "";

        public String TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public String TaiKhoanShipper
        {
            get { return taiKhoanShipper; }
            set { taiKhoanShipper = value; }
        }

        public int MaShipper
        {
            get { return maShipper; }
            set { maShipper = value; }
        }
        public int MaKHDatDon
        {
            get { return maKHDatDon; }
            set { maKHDatDon = value; }
        }
       
        public int MaDH
        {
            get { return maDH; }
            set { maDH = value; }
        }
        //Khởi tạo các Object
        QLDonHang qLDH = new QLDonHang();
        public FormXemChiTietDonHang()
        {
            InitializeComponent();
        }
        public String ketChuoiDiaChiCuaKH(int maDH, String diaChi, String phuong, String quan)
        {
            String diaChiTong = "";
            using (var db = new QLGiaoHangEntities())
            {

            }
            return diaChiTong;
        }
        public void layCacThongTinLenFrom()
        {
            //Người đặt
            //Lấy từ bảng khách hàng
            txtHoTenDat.Text = qLDH.layHoTenTheoMaKH(maKHDatDon);
            txtSDTDat.Text = qLDH.laySDTTheoMaKH(maKHDatDon);          
            using (var db = new QLGiaoHangEntities())
            {
                //Lấy bảng đơn hàng
                var bangDonHang = db.LayDonHangTheoMaDH(maDH).Single();       

                //Lấy từ bảng chi tiết đơn hàng
                var select = db.TimCTDHTuMaDH(maDH).Single();
                //Kết chuỗi địa chỉ lấy
                String diaChiLay = String.Format("{0} {1} {2}", select.DiaChiNhanHang, select.PhuongNhanHang, select.QuanNhanHang);
                txtDiaChiLay.Text = diaChiLay;
                //Người nhận
                txtHoTenNhan.Text = select.TenNguoiNhanHang;
                txtSDTNhan.Text = select.SDTNguoiNhanHang;
                //Kết chuỗi địa chỉ nhận
                String diaChiNhan = String.Format("{0} {1} {2}", select.DiaChiGiaoHang, select.PhuongGiaoHang, select.QuanGiaoHang);
                txtDiaChiNhan.Text = diaChiNhan;
                //Các thông tin còn lại
                txtPhiShip.Text = select.PhiShip.ToString();
                txtTienUng.Text = bangDonHang.TienUng.ToString();
                txtGhiChu.Text = bangDonHang.GhiChu;              
            }
        }

        private void FormXemChiTietDonHang_Load(object sender, EventArgs e)
        {
            //Kiểm tra là đơn đã hoàn thành chưa
            if (tinhTrang == "Đã nhận")
            {
                btnHoanThanh.Visible = true;
            }
            else
            {
                btnHoanThanh.Visible = false;
            }
            layCacThongTinLenFrom();
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            FormDonHang fDonHang = new FormDonHang();
            fDonHang.TaiKhoanShipper = this.taiKhoanShipper; //Chỉ lấy lại mã shipper vì ĐH và KH luôn thay đổi từ form đơn hàng
            this.Hide();
            fDonHang.ShowDialog();
            this.Close();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            bool kiemTraHoanThanhDon = qLDH.shipperHoanThanhDonHang(maShipper, maDH);
            if(kiemTraHoanThanhDon == true)
            {
                MessageBox.Show("Đã hoàn thành đơn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnHoanThanh.Visible = false; //Sau khi hoàn thành thì không thể hoàn thành nữa
            }
            else
            {
                MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
