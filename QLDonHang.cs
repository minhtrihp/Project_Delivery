using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGiaoHang
{
    class QLDonHang
    {
        public bool khoiTaoDonHang(DonHang donHang)
        {
            using(var db = new QLGiaoHangEntities())
            {
                //Đây là hệ thống tự nhập
                //Lấy ngày
                DateTime ngayLap = DateTime.Now;
                donHang.NgayLap = ngayLap;
                //Lấy giờ
                TimeSpan gioLap = ngayLap.TimeOfDay;
                donHang.GioLap = gioLap;
                donHang.TinhTrang = "Chờ nhận đơn";
                //Nếu không add và save được sẽ trả về thất bại
                try
                {
                    db.DonHangs.Add(donHang);
                    db.SaveChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }
        public bool nhapThongTinChiTietDonHang(ChiTietDonHang cTDH)
        {
            using(var db = new QLGiaoHangEntities())
            {
                try
                {
                    db.ChiTietDonHangs.Add(cTDH);
                    db.SaveChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }
        
        //Hàm này dùng để lấy mã đơn hàng vừa đặt gán qua ChiTietDonHang (Không có relationship nên xử lí code)
        public int layMaDHVuaDat()
        {
            using (var db = new QLGiaoHangEntities())
            {
                var data = db.DaoThuTuMaDH().Single(); //DaoThuTuMaDH là procedure
                return data.MaDH;
            }
        }
        //Shipper sau khi nhận đơn
        public bool shipperNhanDonHang(int maSP, int maDH)
        {
            using(var db = new QLGiaoHangEntities())
            {
                try
                {
                    var update = (from up in db.DonHangs where up.MaDH == maDH select up).Single();
                    update.MaShipper = maSP;
                    update.TinhTrang = "Đã nhận";
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        //Shipper sau khi hoàn thành đơn
        public bool shipperHoanThanhDonHang(int maSP, int maDH)
        {
            using (var db = new QLGiaoHangEntities())
            {
                var update = (from up in db.DonHangs where up.MaDH == maDH select up).Single();
                if (update.TinhTrang.Trim() == "Đã hủy")
                {
                    return false;
                }
                else
                {
                    update.TinhTrang = "Đã hoàn thành";
                    db.SaveChanges();
                    return true;
                }
            }
        }
        //Shipper hủy đơn
        public bool huyDonHang(int maDH)
        {
            using (var db = new QLGiaoHangEntities())
            {
                var update = (from up in db.DonHangs where up.MaDH == maDH select up).Single();
                if (update.TinhTrang.Trim() == "Đã hoàn thành")
                {
                    //Console.WriteLine("Không thể hủy do đơn đã hoàn thành");
                    return false;
                }
                else if(update.TinhTrang.Trim() == "Đã hủy")
                {
                    return false;
                }
                else
                {
                    try
                    {
                        update.TinhTrang = "Đã hủy";
                        db.SaveChanges();
                    }
                    catch
                    {
                        return false;
                    }
                    //Console.WriteLine("Shipper đã hủy đơn hàng");
                    return true;
                }
            }
        }
        //Trích xuất đơn hàng chưa nhận theo quận
        public void layDSDonHangChuaNhanTheoQuan(String quan)
        {
            bool kiemTraNull = true;
            using (var db = new QLGiaoHangEntities())
            {

                using (var DSDH = db.DSDHChuaNhanTheoQuan(quan)) //procedure
                {
                    foreach(var data in DSDH)
                    {
                        kiemTraNull = false;
                        break;
                    }
                    if (kiemTraNull == false)
                    {
                        Console.WriteLine("Có đơn hàng trong quận này");
                    }
                    else
                    {
                        Console.WriteLine("Không có đơn hàng trong quận này");
                    }
                }
            }
        }
        //Trả ra Mã KH từ TK
        public int traVeMaTheoTKKH(String tenTaiKhoan)
        {
            using(var db = new QLGiaoHangEntities())
            {
                //Vì SDT chỉ có 1 nên sẽ chắc chắn ra single
                var select = (from se in db.KhachHangs where se.TenTaiKhoan == tenTaiKhoan select se).Single();
                return select.MaKH;
            }
        }
        //Trả ra Mã Shippers từ TK
        public int traVeMaTheoTKShippers(String tenTaiKhoan)
        {
            using (var db = new QLGiaoHangEntities())
            {
                //Vì SDT chỉ có 1 nên sẽ chắc chắn ra single
                //Luôn phải Trim để cắt chuỗi dư
                try
                {
                    var select = (from se in db.Shippers where se.TenTaiKhoan.Trim() == tenTaiKhoan select se).Single();
                    return select.MaShipper;
                }
                catch
                {
                    return 0; //0 là không có KH
                }
            } 
        }
        //Xóa dữ liệu của 1 KH
        public bool xoaThongTin1KH(int maKH)
        {
            using(var db = new QLGiaoHangEntities())
            {
                
                try//Trường hợp bảng rỗng
                {
                    //var select = db.TimKHTheoMa(maKH);
                    var select = (from se in db.KhachHangs where se.MaKH == maKH select se).Single();
                    db.KhachHangs.Remove(select);
                }
                catch
                {
                    return false;
                }
                db.SaveChanges();
                return true;
            }
        }
        //Xóa dữ liệu của 1 Shippers
        public bool xoaThongTin1Shippers(int maShippers)
        {
            using (var db = new QLGiaoHangEntities())
            {

                try//Trường hợp bảng rỗng
                {
                    var select = (from se in db.Shippers where se.MaShipper == maShippers select se).Single();
                    db.Shippers.Remove(select);

                }
                catch
                {
                    return false;
                }
                db.SaveChanges();
                return true;
            }
        }
        //Lấy họ tên theo mã
        public String layHoTenTheoTKShippers(String tenTaiKhoan)
        {
            int ma = traVeMaTheoTKShippers(tenTaiKhoan);
            using (var db = new QLGiaoHangEntities())
            {
                try
                {
                    var select = (from se in db.Shippers where se.MaShipper == ma select se).Single();
                    String hoTen = "";
                    //Trường họ bằng null;
                    if(select.Ho == null)
                    {
                        //Trim để xóa hết khoảng trắng của SQL
                        hoTen = String.Format("{0}", select.Ten.Trim());
                    }
                    else
                    {
                        //Trim để xóa hết khoảng trắng SQL
                        hoTen = String.Format("{0} {1}", select.Ho.Trim(), select.Ten.Trim());
                    }
                    return hoTen;
                }
                catch
                {
                    return "Lỗi";
                }
            }
        }
        public String layHoTenTheoMaKH(int maKH)
        {
            using (var db = new QLGiaoHangEntities())
            {
                try
                {
                    var select = db.TimKHTheoMa(maKH).Single();
                    String hoTen = "";
                    //Trường họ bằng null;
                    if (select.Ho == null)
                    {
                        //Trim để xóa hết khoảng trắng của SQL
                        hoTen = String.Format("{0}", select.Ten.Trim());
                    }
                    else
                    {
                        //Trim để xóa hết khoảng trắng SQL
                        hoTen = String.Format("{0} {1}", select.Ho.Trim(), select.Ten.Trim());
                    }
                    return hoTen;
                }
                catch
                {
                    return "Lỗi";
                }
            }
        }
        public String laySDTTheoMaKH(int maKH)
        {
            using (var db = new QLGiaoHangEntities())
            {
                try
                {
                    var select = db.TimKHTheoMa(maKH).Single();
                    String sDT = "";
                    //Trim để xóa hết khoảng trắng SQL
                    sDT = String.Format("{0}", select.SDT.Trim());
                    return sDT;
                }
                catch
                {
                    return "Lỗi";
                }
            }
        }
    }
}
