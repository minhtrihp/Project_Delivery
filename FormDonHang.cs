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
    public partial class FormDonHang : Form
    {
        //Tạo object
        QLDonHang qLDH = new QLDonHang();
        String taiKhoanShipper = "";

        public String TaiKhoanShipper
        {
            get { return taiKhoanShipper; }
            set { taiKhoanShipper = value; }
        }
        int maShippers = 0;
        int maDH = 0;
        int maKHDatDon = 0;

        public int MaKHDatDon
        {
            get { return maKHDatDon; }
            set { maKHDatDon = value; }
        }
        public int MaShippers
        {
            get { return maShippers; }
            set { maShippers = value; }
        }

        
        public FormDonHang()
        {
            InitializeComponent();
        }

        public void laylVCacDonHang(String tinhTrang)
        {
            //Add column
            lVCacDonHang.Columns.Add("Mã ĐH");
            lVCacDonHang.Columns.Add("Giờ lập");
            lVCacDonHang.Columns.Add("Ngày lập");
            //Add item
            using (var db = new QLGiaoHangEntities())
            {
                var select = db.LayCacDHTheoMaShipper(maShippers, tinhTrang);
                foreach (var data in select)
                {
                    Char[] kiTuSplitNgay = { ' ' };
                    Char[] kiTuSplitGio = { '.' };
                    //Split ngày
                    String[] ngayLap = (data.NgayLap.ToString()).Split(kiTuSplitNgay);
                    //Split giờ
                    String[] gioLap = (data.GioLap.ToString()).Split(kiTuSplitGio);
                    ListViewItem item = new ListViewItem(data.MaDH.ToString());
                    item.SubItems.Add(gioLap[0]);//Phần đầu của gioLap là giờ/phút/giây
                    item.SubItems.Add(ngayLap[0]);//Phần đầu của ngayLap là ngày/tháng/năm
                    lVCacDonHang.Items.Add(item);
                }
            }
        }
        public ListView taoMoiLV()
        {
            lVCacDonHang.Dispose();//Xóa hết các item trong listview hiện tại
            ListView lV = new ListView();
            lV.Name = "lVCacDonHang";
            lV.Size = new Size(349, 283);//Kích thước
            lV.Location = new Point(21, 105);//Vị trí
            lV.View = View.Details;
            lV.BackColor = Color.White;
            lV.Parent = this;
            //
            lV.FullRowSelect = true;
            lV.GridLines = true;
            return lV;
        }
        public void taoGiaTriChoCBLoc()
        {
            cBLoc.Items.Add("Đã hoàn thành");
            cBLoc.Items.Add("Đã hủy");  
            cBLoc.Items.Add("Đã nhận");
            
        }
        private void btnNhanHang_Click(object sender, EventArgs e)
        {
            FormNhanHang fNhanHang = new FormNhanHang();
            fNhanHang.TenTaiKhoan = this.taiKhoanShipper;
            this.Hide();
            fNhanHang.ShowDialog();
            this.Close();
        }

        private void btnViDienTu_Click(object sender, EventArgs e)
        {
            FormViDienTu fViDienTu = new FormViDienTu();
            this.Hide();
            fViDienTu.ShowDialog();
            this.Close();
        }

        private void cbLoc_TextChanged(object sender, EventArgs e)
        {
            lblTrangThai.Text = cBLoc.Text;
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            FormCaiDat fCaiDat = new FormCaiDat();
            this.Hide();
            fCaiDat.ShowDialog();
            this.Close();
        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            maShippers = qLDH.traVeMaTheoTKShippers(taiKhoanShipper);
            taoGiaTriChoCBLoc();
            //Default trạng thái đơn hàng
            lblTrangThai.Text = "Đã nhận";
            laylVCacDonHang("Đã nhận");
        }

        private void cBLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTrangThai.Text = cBLoc.Text;
            lVCacDonHang = taoMoiLV();
            laylVCacDonHang(cBLoc.Text);
        }

        private void lVCacDonHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(lVCacDonHang.SelectedItems.Count > 0)
            //{
            //    using (var db = new QLGiaoHangEntities())
            //    {
            //        maDH = int.Parse(lVCacDonHang.SelectedItems[0].Text);
            //        maKHDatDon = int.Parse(db.LayDonHangTheoMaDH(maDH).Single().MaKH.ToString());
            //    }
            //}
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (lVCacDonHang.SelectedItems.Count > 0) //Đã chọn đơn
            {
                using (var db = new QLGiaoHangEntities())
                {
                    maDH = int.Parse(lVCacDonHang.SelectedItems[0].Text);
                    maKHDatDon = int.Parse(db.LayDonHangTheoMaDH(maDH).Single().MaKH.ToString());
                }
                FormXemChiTietDonHang fXemCTDH = new FormXemChiTietDonHang();
                fXemCTDH.TaiKhoanShipper = this.taiKhoanShipper;//Lưu lại tài khoản shipper
                fXemCTDH.MaDH = this.maDH;//Gán mã đơn hàng
                fXemCTDH.MaKHDatDon = this.maKHDatDon;//Gán mã shipper
                fXemCTDH.TinhTrang = cBLoc.Text; //Gán tình trạng
                this.Hide();
                fXemCTDH.ShowDialog();
                this.Close();
            }         
        }
    }
}
