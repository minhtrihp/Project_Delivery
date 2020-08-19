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
    public partial class FormNhanVien : Form
    {
        //2 biến này sẽ lấy thông tin qua select index change
        private String loaiThongTin;
        private String loaiThongTinDonHang;
        //Tạo object này để gọi các hàm bên QLDonHang
        QLDonHang qLDH = new QLDonHang();
        public FormNhanVien()
        {
            InitializeComponent();
        }
        public ListView taoListViewMoi()
        {
            lvHienThi.Dispose();//Xóa hết các item trong listview hiện tại
            ListView lV = new ListView();
            lV.Name = "lvHienThi";
            lV.Size = new Size(467, 150);//Kích thước
            lV.Location = new Point(35, 159);//Vị trí
            lV.View = View.Details;
            lV.BackColor = Color.White;
            lV.Parent = this;
            //
            lV.FullRowSelect = true;
            lV.GridLines = true;
            //
            //Xóa dữ liệu ở txtText
            txtText.Text = "";
            //Thêm sự kiện chọn cho lV
            lV.SelectedIndexChanged += lV_SelectedIndexChanged;
            return lV;
        }
        void lV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHienThi.SelectedItems.Count > 0) //Phải có count > 0 vì sau khi chọn lại sẽ có bước refresh select
            {
                txtText.Text = lvHienThi.SelectedItems[0].Text;
            }
        }
       
        
        public void ganItemChoCBChonThongTin()
        {
            //Loại thông tin
            cbChonLoaiThongTin.Items.Add("Khách hàng");
            cbChonLoaiThongTin.Items.Add("Shippers");
            cbChonLoaiThongTin.Items.Add("Đơn hàng");
            //Loại đơn hàng
            cBChonDonHang.Items.Add("Chờ nhận đơn");
            cBChonDonHang.Items.Add("Đã nhận");
            cBChonDonHang.Items.Add("Đã hoàn thành");
            cBChonDonHang.Items.Add("Đã hủy");
            cBChonDonHang.SelectedItem = "Chờ nhận đơn"; //Mặc định chờ nhận đơn
        }
       
        
        public void layThongTinKHLenListView()
        {
            String[] tTKH = { "Mã KH", "Họ", "Tên", "SĐT", "Ngày sinh", "Giới tính", "Địa chỉ", "Ngày tạo", "Tên tài khoản" };
            lvHienThi.Columns.Add("Mã KH");
            lvHienThi.Columns.Add("Họ");
            lvHienThi.Columns.Add("Tên");
            lvHienThi.Columns.Add("SĐT");
            lvHienThi.Columns.Add("Ngày sinh");
            lvHienThi.Columns.Add("Giới tính");
            lvHienThi.Columns.Add("Địa chỉ");
            lvHienThi.Columns.Add("Ngày tạo");
            lvHienThi.Columns.Add("Tên tài khoản");
            using (var db = new QLGiaoHangEntities())
            {
                var select = from se in db.KhachHangs select se;
                foreach (var data in select)
                {
                    //ToString() để hết sang kiểu chuỗi, vì listview không nhận giá trị khác
                    ListViewItem item = new ListViewItem(data.MaKH.ToString());
                    item.SubItems.Add(data.Ho);
                    item.SubItems.Add(data.Ten);
                    item.SubItems.Add(data.SDT);
                    item.SubItems.Add(data.NgaySinh.ToString());
                    item.SubItems.Add(data.GT);
                    item.SubItems.Add(data.DiaChi);
                    item.SubItems.Add(data.NgayTao.ToString());
                    item.SubItems.Add(data.TenTaiKhoan);
                    lvHienThi.Items.Add(item);
                }
            }
        }
        public void layThongTinShippersLenListView()
        {
            lvHienThi.Columns.Add("Mã NV");
            lvHienThi.Columns.Add("Họ");
            lvHienThi.Columns.Add("Tên");
            lvHienThi.Columns.Add("SĐT");
            lvHienThi.Columns.Add("Ngày sinh");
            lvHienThi.Columns.Add("Giới tính");
            lvHienThi.Columns.Add("Địa chỉ");
            lvHienThi.Columns.Add("Chức vụ");
            lvHienThi.Columns.Add("Tên tài khoản");
            using (var db = new QLGiaoHangEntities())
            {
                var select = from se in db.NhanViens select se;
                foreach (var data in select)
                {
                    //ToString() để hết sang kiểu chuỗi, vì listview không nhận giá trị khác
                    ListViewItem item = new ListViewItem(data.MaNV.ToString());
                    item.SubItems.Add(data.Ho);
                    item.SubItems.Add(data.Ten);
                    item.SubItems.Add(data.SDT);
                    item.SubItems.Add(data.NgaySinh.ToString());
                    item.SubItems.Add(data.GioiTinh);
                    item.SubItems.Add(data.DiaChi);
                    item.SubItems.Add(data.ChucVu);
                    item.SubItems.Add(data.TenTaiKhoan);
                    lvHienThi.Items.Add(item);
                }
            }
        }
        public void layCacDonHangLenListView()
        {
            lvHienThi.Columns.Add("Mã ĐH");
            lvHienThi.Columns.Add("Ngày lập");
            lvHienThi.Columns.Add("Giờ lập");
            lvHienThi.Columns.Add("Tiền ứng");
            lvHienThi.Columns.Add("Tình trạng");
            lvHienThi.Columns.Add("Mã KH");
            lvHienThi.Columns.Add("Mã Shippers");
            lvHienThi.Columns.Add("Ghi chú");
            using (var db = new QLGiaoHangEntities())
            {
                var select = db.LayCacDonHang("Chờ nhận đơn");
                //ToString() để hết sang kiểu chuỗi, vì listview không nhận giá trị khác
                if (loaiThongTinDonHang == "Đã nhận")
                {
                    select = db.LayCacDonHang("Đã nhận");
                }
                else if (loaiThongTinDonHang == "Đã hoàn thành")
                {
                    select = db.LayCacDonHang("Đã hoàn thành");
                }
                else if (loaiThongTinDonHang == "Đã hủy")
                {
                    select = db.LayCacDonHang("Đã hủy");
                }
                foreach(var data in select)
                {
                    ListViewItem item = new ListViewItem(data.MaDH.ToString());
                    item.SubItems.Add(data.NgayLap.ToString());
                    item.SubItems.Add(data.GioLap.ToString());
                    item.SubItems.Add(data.TienUng.ToString());
                    item.SubItems.Add(data.TinhTrang);
                    item.SubItems.Add(data.MaKH.ToString());
                    item.SubItems.Add(data.MaShipper.ToString());
                    item.SubItems.Add(data.GhiChu);
                    lvHienThi.Items.Add(item);
                }
            }
        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            ganItemChoCBChonThongTin(); //Load dữ liệu cho ComboBox
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void btOke_Click(object sender, EventArgs e)
        {
            //String loaiThongTin  = cbChonLoaiThongTin.Text; //Lấy loại thông tin từ combobox
            if(loaiThongTin == "Khách hàng")
            {
                //Lấy TT của KH
                layThongTinKHLenListView();
                btXoa.Visible = true; //Hiện button xóa
                //bTXoaDuLieu = taoButtonXoaDuLieu();
            }
            else if (loaiThongTin == "Shippers")
            {
                //Lấy TT của Shippers
                layThongTinShippersLenListView();
                btXoa.Visible = true; //Hiện button xóa
                //bTXoaDuLieu = taoButtonXoaDuLieu();
            }
            else if(loaiThongTin == "Đơn hàng")
            {
                //Lấy TT của đơn hàng
                layCacDonHangLenListView(); //Load
                bTHuyDon.Visible = true; //Hiện button hủy
            }
        }

        private void cbChonLoaiThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            bTHuyDon.Visible = false; //Xóa button hủy
            btXoa.Visible = false; //Xóa button xóa
            loaiThongTin = cbChonLoaiThongTin.Text; //Lấy loại thông tin ở đây
            if(loaiThongTin == "Khách hàng" || loaiThongTin == "Shippers")
            {
                lBChonDonHang.Visible = false; //Ân
                cBChonDonHang.Visible = false; //Ân
            }
            else if(loaiThongTin == "Đơn hàng")
            {
                lBChonDonHang.Visible = true; //Ân
                cBChonDonHang.Visible = true; //Ẩn
            }
            lvHienThi = taoListViewMoi(); //lvHienThi.Dispose() bị xóa bên trong nhưng vẫn giữ lại được tên biến
        }

        private void lvHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //Button hủy đơn
        private void bTHuyDon_Click(object sender, EventArgs e)
        {
            bool kiemTraHuy = qLDH.huyDonHang(int.Parse(txtText.Text));
            if (kiemTraHuy == true)
            {
                MessageBox.Show("Hủy thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hủy thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Refresh ListView
            lvHienThi = taoListViewMoi();
            layCacDonHangLenListView(); //Có thế refresh lại LV theo loại đơn hàng vì biến chonLoaiDonHang còn lưu giá trị cũ
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            /*
             * biến khởi tạo để refresh
             * 1 là KH
             * 2 là Shippers
             */
            int giaTriRefresh = 0;
            bool kiemTraXoa = false;
            //Lấy loại thông tin rồi mới xóa
            if (loaiThongTin == "Khách hàng")
            {
                kiemTraXoa = qLDH.xoaThongTin1KH(int.Parse(txtText.Text));
                giaTriRefresh = 1;
            }
            else if (loaiThongTin == "Shippers")
            {
                kiemTraXoa = qLDH.xoaThongTin1Shippers(int.Parse(txtText.Text));
                giaTriRefresh = 2;
            }
            //Kiểm tra xóa
            if (kiemTraXoa == true)
            {
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Refresh lại bảng
            //Tạo listview mới
            lvHienThi = taoListViewMoi();
            if (giaTriRefresh == 1)
            {
                //Khách hàng
                layThongTinKHLenListView();
            }
            else if (giaTriRefresh == 2)
            {
                //Shippers
                layThongTinShippersLenListView();
            }
        }

        private void cBChonDonHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaiThongTinDonHang = cBChonDonHang.Text; //Lấy loại thông tin ở đây
            lvHienThi = taoListViewMoi(); //Tạo list view mới
        }

        private void btDangXuat_Click(object sender, EventArgs e)
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
