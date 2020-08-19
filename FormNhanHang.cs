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
        //Khai báo các object
        QLDonHang qLDH = new QLDonHang();
        //Khai báo các biến
        String tenTaiKhoan = "Chưa có";
        String matKhau = "Chưa có";
        int maShippers = 0; //Mã này được lưu dưới SQL
        int maDH = 0;

        public String TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }
        public String MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public FormNhanHang()
        {
            InitializeComponent();
        }

        public ListView taoListViewXemCTDHMoi()
        {
            lVXemChiTietDonHang.Dispose();//Xóa hết các item trong listview hiện tại
            ListView lV = new ListView();
            lV.Name = "lVXemChiTietDonHang";
            lV.Size = new Size(841, 91);//Kích thước
            lV.Location = new Point(1, 370);//Vị trí
            lV.View = View.Details;
            lV.BackColor = Color.White;
            lV.Parent = this;
            //
            lV.FullRowSelect = true;
            lV.GridLines = true;
            //Thêm sự kiện chọn cho lV
            lV.SelectedIndexChanged += lV_SelectedIndexChanged;
            return lV;
        }
        //Lấy tài khoản
        public void layTaiKhoanKHGanVaoLB()
        {
            lbLayTenDangNhap.Text = tenTaiKhoan;
        }
        //Lấy họ tên
        public void layHoTenKHGanVaoLB()
        {
            lbLayHoTen.Text = qLDH.layHoTenTheoTKShippers(tenTaiKhoan);
            //lbLayHoTen.Text = qLDH.traVeMaTheoTKShipper(tenTaiKhoan).ToString();
        }
        public void setAutoSizeChoLV(ListView lV)
        {
            int cotThu = 0;
            foreach (var cot in lV.Items[0].SubItems)
            {
                //Cột 0 là Item, còn lại là Subitems
                lV.AutoResizeColumn(cotThu, ColumnHeaderAutoResizeStyle.ColumnContent); //Auto theo nội dung
                cotThu++;
            }
        }
        void lV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lVDonChuaNhan.SelectedItems.Count > 0)
            {
                
            }
        }
        private void btnDonHang_Click(object sender, EventArgs e)
        {
            FormDonHang fDonHang = new FormDonHang();
            fDonHang.MaShippers = this.maShippers; //Gán mã đơn qua from đơn hàng
            fDonHang.TaiKhoanShipper = this.tenTaiKhoan; //Gán TKSP
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
        //15-11-2019
        public void layThongTinDonChuaNhanGanVaoLV()
        {
            lVDonChuaNhan.Columns.Add("Mã ĐH");
            lVDonChuaNhan.Columns.Add("Ngày lập");
            lVDonChuaNhan.Columns.Add("Giờ lập");
            lVDonChuaNhan.Columns.Add("Tiền ứng");
            lVDonChuaNhan.Columns.Add("Tình trạng");
            lVDonChuaNhan.Columns.Add("Ghi chú");        
            using (var db = new QLGiaoHangEntities())
            {
                var select = db.LayCacDonHang("Chờ nhận đơn");
                foreach (var data in select)
                {
                    Char[] kiTuSplitNgay = { ' ' };
                    Char[] kiTuSplitGio = { '.' };
                    //Split ngày
                    String[] ngayLap = (data.NgayLap.ToString()).Split(kiTuSplitNgay);
                    //Split giờ
                    String[] gioLap = (data.GioLap.ToString()).Split(kiTuSplitGio);
                    ListViewItem item = new ListViewItem(data.MaDH.ToString());
                    item.SubItems.Add(ngayLap[0]);//Phần đầu của ngayLap là ngày/tháng/năm
                    item.SubItems.Add(gioLap[0]);//Phần đầu của gioLap là giờ/phút/giây
                    item.SubItems.Add(data.TienUng.ToString());
                    item.SubItems.Add(data.TinhTrang);
                    //item.SubItems.Add(data.MaKH.ToString());
                    //item.SubItems.Add(data.MaShipper.ToString());
                    item.SubItems.Add(data.GhiChu.Trim());//Trim bớt khoản trống vì quá dài
                    lVDonChuaNhan.Items.Add(item);
                }
            }
        }
        public void layCTDHlenLV()
        {
            lVXemChiTietDonHang.Columns.Add("Mã ĐH");
            lVXemChiTietDonHang.Columns.Add("Địa chỉ lấy hàng");
            lVXemChiTietDonHang.Columns.Add("Phường lấy hàng");
            lVXemChiTietDonHang.Columns.Add("Quận lấy hàng");
            lVXemChiTietDonHang.Columns.Add("Tên người nhận");
            lVXemChiTietDonHang.Columns.Add("SĐT người nhận");
            lVXemChiTietDonHang.Columns.Add("Địa chỉ giao hàng");
            lVXemChiTietDonHang.Columns.Add("Phường giao hàng");
            lVXemChiTietDonHang.Columns.Add("Quận giao hàng");
            lVXemChiTietDonHang.Columns.Add("Phí ship");
            //Set auto size
            int cotThu = 1;
            foreach(var cot in lVXemChiTietDonHang.Items)
            {
                lVXemChiTietDonHang.AutoResizeColumn(cotThu, ColumnHeaderAutoResizeStyle.ColumnContent); //Auto theo nội dung
                cotThu++;
            }
            
        }
        private void lVDonChuaNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lVDonChuaNhan.SelectedItems.Count > 0)
            {
                txtMaDH.Text = lVDonChuaNhan.SelectedItems[0].Text;//Lấy mã đơn hàng
                maDH = int.Parse(txtMaDH.Text);
                //Xem chi tiết đơn hàng
                using (var db = new QLGiaoHangEntities())
                {
                    var select = db.LayChiTietDHTheoMaDH(int.Parse(txtMaDH.Text));
                    foreach (var data in select)
                    {
                        //ToString() để hết sang kiểu chuỗi, vì listview không nhận giá trị khác
                        ListViewItem item = new ListViewItem(data.MaDH.ToString());
                        item.SubItems.Add(data.DiaChiNhanHang);
                        item.SubItems.Add(data.PhuongNhanHang);
                        item.SubItems.Add(data.QuanNhanHang);
                        item.SubItems.Add(data.TenNguoiNhanHang);
                        item.SubItems.Add(data.SDTNguoiNhanHang);
                        item.SubItems.Add(data.DiaChiGiaoHang);
                        item.SubItems.Add(data.PhuongGiaoHang);
                        item.SubItems.Add(data.QuanGiaoHang);
                        item.SubItems.Add(data.PhiShip.ToString());
                        lVXemChiTietDonHang.Items.Add(item);
                    }
                }
                //Set AutoSize cho Listview chưa nhận đơn
                setAutoSizeChoLV(lVDonChuaNhan);
                //Set AutoSize cho Listview xem chi tiết đơn hàng
                setAutoSizeChoLV(lVXemChiTietDonHang);
            }
            else
            {
                lVXemChiTietDonHang = taoListViewXemCTDHMoi();
                layCTDHlenLV();
            }
        }
        //Nhận hàng
        private void btnNhanHang_Click(object sender, EventArgs e)
        {
            //16/11/2019
            if(lVDonChuaNhan.SelectedItems.Count <= 0)//Bắt được lỗi chưa nhận đơn
            {
                //if (MessageBox.Show("Bạn có muốn đăng xuất hay không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //{
                //    formDangNhap fDangNhap = new formDangNhap();
                //    this.Hide();
                //    fDangNhap.ShowDialog();
                //    this.Close();
                //}
                MessageBox.Show("Vui lòng chọn đơn hàng trước khi nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);              
            }
            else
            {
                bool kiemTraNhanDon = qLDH.shipperNhanDonHang(maShippers, maDH);
                if (kiemTraNhanDon == true)
                {
                    if (MessageBox.Show("Nhận đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        FormDonHang fDonHang = new FormDonHang();
                        fDonHang.MaShippers = this.maShippers; //Gán mã đơn qua from đơn hàng
                        fDonHang.TaiKhoanShipper = this.tenTaiKhoan; //Gán TKSP
                        this.Hide();
                        fDonHang.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Nhận đơn thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }    
            }
            lVXemChiTietDonHang = taoListViewXemCTDHMoi();
            layCTDHlenLV();
        }
        private void FormNhanHang_Load(object sender, EventArgs e)
        {
            //Lấy mã Shippers
            maShippers = qLDH.traVeMaTheoTKShippers(tenTaiKhoan);
            //Load thông tin các đơn hàng
            layThongTinDonChuaNhanGanVaoLV();
            layCTDHlenLV();
            //Load thông tin cá nhân
            layTaiKhoanKHGanVaoLB();
            layHoTenKHGanVaoLB();
        }
        
    }
}
