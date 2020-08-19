using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGiaoHang
{
    public class QLTaiKhoan
    {
        private String taiKhoan;
        private String matKhau;
        private DateTime ngayTao;
        private String tinhTrang;
        private String maCB;
        #region Get-Set Method
        public String TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
        public String MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public DateTime NgayTao
        {
            get { return ngayTao; }
            set { ngayTao = value; }
        }
        public String TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public String MaCB
        {
            get { return maCB; }
            set { maCB = value; }
        }
        #endregion
        public QLTaiKhoan()
        {
        }
        #region Test Method

        /*
         * Hàm này chỉ hỗ trợ kiểm tra tài khoản bị trùng trong đăng kí
         */
        //Method này kiểm tra cho KH
        public bool kiemTraTKTrung(string tenTaiKhoan, TaiKhoanKH TKQL)
        {
            using (var db = new QLGiaoHangEntities()) //using để sau khi sử dụng xong tự giải phóng vùng nhớ
            {
               
                TKQL = db.TaiKhoanKHs.Find(tenTaiKhoan); //Find có thể ra null, null ở object TKKH;
                if (TKQL != null) //Kiểm tra null ở đây
                {
                    if (TKQL.TenTaiKhoan.Trim() == tenTaiKhoan) //Hàm Trim() để cắt các khoảng trắng dư của DL bên SQL
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //Method này kiểm tra cho Shippers
        public bool kiemTraTKTrung(string tenTaiKhoan, TaiKhoanShipper TKQL)
        {
            using (var db = new QLGiaoHangEntities()) //using để sau khi sử dụng xong tự giải phóng vùng nhớ
            {
                TKQL = db.TaiKhoanShippers.Find(tenTaiKhoan); //Find có thể ra null, null ở object TKKH;
                if (TKQL != null) //Kiểm tra null ở đây
                {
                    if (TKQL.TenTaiKhoan.Trim() == tenTaiKhoan) //Hàm Trim() để cắt các khoảng trắng dư của DL bên SQL
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //Method này kiểm tra cho NV
        public bool kiemTraTKTrung(string tenTaiKhoan, TaiKhoanNV TKQL)
        {
            using (var db = new QLGiaoHangEntities()) //using để sau khi sử dụng xong tự giải phóng vùng nhớ
            {
                
                TKQL = db.TaiKhoanNVs.Find(tenTaiKhoan); //Find có thể ra null, null ở object TKKH;
                if (TKQL != null) //Kiểm tra null ở đây
                {
                    if (TKQL.TenTaiKhoan.Trim() == tenTaiKhoan) //Hàm Trim() để cắt các khoảng trắng dư của DL bên SQL
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /*
         * Hàm này kiểm tra tài khoản đã tồn tại trong hệ thống để xét việc đăng nhập
         */
        //Hàm này sử dụng cho KH
        public bool kiemTraTKDaTao(string tenTaiKhoan, string matKhau, TaiKhoanKH taiKhoanTimKiem)
        {
            using (var db = new QLGiaoHangEntities())
            {
                if(kiemTraTKTrung(tenTaiKhoan, taiKhoanTimKiem) == true) //Kiểm tra tài khoản đã tồn tại chưa
                {
                    taiKhoanTimKiem = db.TaiKhoanKHs.Find(tenTaiKhoan); //Lấy dữ liệu từ 1 hàng
                    if(taiKhoanTimKiem.MatKhau.Trim() == matKhau)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //Hàm này sử dụng cho Shippers
        public bool kiemTraTKDaTao(string tenTaiKhoan, string matKhau, TaiKhoanShipper taiKhoanTimKiem)
        {
            using (var db = new QLGiaoHangEntities())
            {
                if (kiemTraTKTrung(tenTaiKhoan, taiKhoanTimKiem) == true) //Kiểm tra tài khoản đã tồn tại chưa
                {
                    taiKhoanTimKiem = db.TaiKhoanShippers.Find(tenTaiKhoan); //Lấy dữ liệu từ 1 hàng
                    if (taiKhoanTimKiem.MatKhau.Trim() == matKhau)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //Hàm này sử dụng cho NV
        public bool kiemTraTKDaTao(string tenTaiKhoan, string matKhau, TaiKhoanNV taiKhoanTimKiem)
        {
            using (var db = new QLGiaoHangEntities())
            {
                if (kiemTraTKTrung(tenTaiKhoan, taiKhoanTimKiem) == true) //Kiểm tra tài khoản đã tồn tại chưa
                {
                    taiKhoanTimKiem = db.TaiKhoanNVs.Find(tenTaiKhoan); //Lấy dữ liệu từ 1 hàng
                    if (taiKhoanTimKiem.MatKhau.Trim() == matKhau)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion

        #region Process Method
        //Method lưu dữ liệu xuống database
        //Method dành cho KH
        public bool nhapDuLieuVaoDB(TaiKhoanKH TKKH, KhachHang QLTTKH)
        {
            using (var db = new QLGiaoHangEntities())
            {
                
                TKKH.NgayTao = DateTime.Now;
                if (kiemTraTKTrung(TKKH.TenTaiKhoan, TKKH) == true)
                {
                    return false;
                }
                else
                {
                    db.TaiKhoanKHs.Add(TKKH);
                    db.SaveChanges();
                    QLThongTinCaNhan TTKH = new QLThongTinCaNhan();
                    if (TTKH.nhapThongTinKH(QLTTKH))
                    {
                        return true;
                    }
                    db.TaiKhoanKHs.Remove(TKKH);
                    db.SaveChanges();
                    return false;
                }
            }
        }
        //Method dành cho Shippers
        public bool nhapDuLieuVaoDB(TaiKhoanShipper TKQL, Shipper QLTTSP)
        {
            using (var db = new QLGiaoHangEntities())
            {
               
                TKQL.NgayTao = DateTime.Now;
                if (kiemTraTKTrung(TKQL.TenTaiKhoan, TKQL) == true)
                {
                    return false;
                }
                else
                {
                    db.TaiKhoanShippers.Add(TKQL);
                    db.SaveChanges();
                    QLThongTinCaNhan TTSP = new QLThongTinCaNhan();
                    if (TTSP.nhapThongTinSP(QLTTSP))
                    {
                        return true;
                    }
                    db.TaiKhoanShippers.Remove(TKQL);
                    db.SaveChanges();
                    return false;
                }
            }
        }
        //Method dành cho NV
        public bool nhapDuLieuVaoDB(TaiKhoanNV TKNV, NhanVien QLTTNV)
        {
            using (var db = new QLGiaoHangEntities())
            {
                TKNV.NgayTao = DateTime.Now;
                if (kiemTraTKTrung(TKNV.TenTaiKhoan, TKNV) == true)
                {
                    return false;
                }
                else
                {
                    db.TaiKhoanNVs.Add(TKNV);
                    db.SaveChanges();
                    QLThongTinCaNhan TTNV = new QLThongTinCaNhan();
                    if (TTNV.nhapThongTinNV(QLTTNV))
                    {
                        return true;
                    }
                    db.TaiKhoanNVs.Remove(TKNV);
                    db.SaveChanges();
                    return false;
                }
            }
        }
        #endregion
        #region Method To Use
        /*
         * Các phương thức cho front-end gọi
         */
        public void dangKiTK(TaiKhoanShipper TKSP, Shipper QLTTSP)
        {
            Console.WriteLine("Đăng kí với TKSP.");
            nhapDuLieuVaoDB(TKSP, QLTTSP);

        }
        public void dangKiTK(TaiKhoanKH TKKH, KhachHang QLTTKH)
        {
            Console.WriteLine("Đăng kí với TKKH.");
            nhapDuLieuVaoDB(TKKH, QLTTKH);

        }

        public void dangKiTK(TaiKhoanNV TKNV, NhanVien QLTTNV)
        {
            Console.WriteLine("Đăng kí với TKNV.");
            nhapDuLieuVaoDB(TKNV, QLTTNV);

        }
        public bool dangNhapTK(string tenTaiKhoan, string matKhau, int loaiTK)
        {
            bool kiemTraDangNhap = false;
            switch(loaiTK)
            {
                case 1:
                    Console.WriteLine("Đăng nhập với TKKH.");
                    TaiKhoanKH TKKH = new TaiKhoanKH();
                    kiemTraDangNhap = kiemTraTKDaTao(tenTaiKhoan, matKhau, TKKH);
                    break;
                case 2:
                    Console.WriteLine("Đăng nhập với TKSP.");
                    TaiKhoanShipper TKSP = new TaiKhoanShipper();
                    kiemTraDangNhap = kiemTraTKDaTao(tenTaiKhoan, matKhau, TKSP);
                    break;
                case 3:
                    Console.WriteLine("Đăng nhập với TKNV.");
                    TaiKhoanNV TKNV = new TaiKhoanNV();
                    kiemTraDangNhap = kiemTraTKDaTao(tenTaiKhoan, matKhau, TKNV);
                    break;
            }
            return kiemTraDangNhap;
        }
        #endregion
    }
}
