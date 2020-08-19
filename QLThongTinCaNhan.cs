using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGiaoHang
{
    public class QLThongTinCaNhan
    {
        String hoSP;
        String tenSP;
        String sDTSP;
        DateTime ngaySinh;
        String gioiTinh;
        String diaChi;
        String cMND;   
        DateTime ngayVaoLam;
        String tenTaiKhoan;

        #region Get-Set Method
        public String HoSP
        {
            get { return hoSP; }
            set { hoSP = value; }
        }
        

        public String TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        public String SDTSP
        {
            get { return sDTSP; }
            set { sDTSP = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public String GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public String CMND
        {
            get { return cMND; }
            set { cMND = value; }
        }

        public DateTime NgayVaoLam
        {
            get { return ngayVaoLam; }
            set { ngayVaoLam = value; }
        }
       

        public String TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }
        #endregion
        public QLThongTinCaNhan()
        {
        }
        #region Test Method
        //Hàm KT CMNDTrung
        public bool kTCMND_Trung(string cMND)
        {
            using (var db = new QLGiaoHangEntities())
            {
                //Lấy số CMND bị trùng
                var select = from kT
                             in db.Shippers
                             where kT.SoCMND == cMND
                             select kT;
                foreach (var data in select)
                {
                    if (data.SoCMND.Trim() == cMND) //Cắt khoảng trắng còn dư ở dữ liệu SQL
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        #endregion
        #region Method To Use
        public bool nhapThongTinSP(Shipper QLTTSP)
        {
            using (var db = new QLGiaoHangEntities())
            {
               
                QLTTSP.NgayVaoLam = DateTime.Now; //Ngày vào làm hệ thống tự set khi thông qua câu lệnh này
                if (kTCMND_Trung(QLTTSP.SoCMND))
                {
                    //CMND bị trùng
                    return false;
                }
                else
                {
                    //CMND không trùng
                    db.Shippers.Add(QLTTSP);
                    db.SaveChanges();
                    return true;
                }
            }
        }
        public bool nhapThongTinKH(KhachHang QLTTKH)
        {
            using (var db = new QLGiaoHangEntities())
            {
                QLTTKH.NgayTao = DateTime.Now; //Tương tự ngày vào làm của SP
                db.KhachHangs.Add(QLTTKH);
                db.SaveChanges();
                return true;
            }
        }

        public bool nhapThongTinNV(NhanVien QLTTNV)
        {
            using (var db = new QLGiaoHangEntities())
            {
                db.NhanViens.Add(QLTTNV);
                db.SaveChanges();
                return true;
            }
        }
        #endregion
    }
}
