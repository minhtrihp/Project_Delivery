﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppGiaoHang
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLGiaoHangEntities : DbContext
    {
        public QLGiaoHangEntities()
            : base("name=QLGiaoHangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CapBacTaiKhoanNV> CapBacTaiKhoanNVs { get; set; }
        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoanKH> TaiKhoanKHs { get; set; }
        public virtual DbSet<TaiKhoanNV> TaiKhoanNVs { get; set; }
        public virtual DbSet<TaiKhoanShipper> TaiKhoanShippers { get; set; }
        public virtual DbSet<XacNhanDonHang> XacNhanDonHangs { get; set; }
    
        public virtual ObjectResult<DaoThuTuMaDH_Result> DaoThuTuMaDH()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DaoThuTuMaDH_Result>("DaoThuTuMaDH");
        }
    
        public virtual ObjectResult<Demo_Proc_Result> Demo_Proc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Demo_Proc_Result>("Demo_Proc");
        }
    
        public virtual ObjectResult<DSDHChuaNhanTheoQuan_Result> DSDHChuaNhanTheoQuan(string quan)
        {
            var quanParameter = quan != null ?
                new ObjectParameter("Quan", quan) :
                new ObjectParameter("Quan", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DSDHChuaNhanTheoQuan_Result>("DSDHChuaNhanTheoQuan", quanParameter);
        }
    
        public virtual ObjectResult<LayCacDHTheoMaShipper_Result> LayCacDHTheoMaShipper(Nullable<int> maSP, string loaiDH)
        {
            var maSPParameter = maSP.HasValue ?
                new ObjectParameter("MaSP", maSP) :
                new ObjectParameter("MaSP", typeof(int));
    
            var loaiDHParameter = loaiDH != null ?
                new ObjectParameter("LoaiDH", loaiDH) :
                new ObjectParameter("LoaiDH", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LayCacDHTheoMaShipper_Result>("LayCacDHTheoMaShipper", maSPParameter, loaiDHParameter);
        }
    
        public virtual ObjectResult<LayCacDonHang_Result> LayCacDonHang(string tinhTrang)
        {
            var tinhTrangParameter = tinhTrang != null ?
                new ObjectParameter("TinhTrang", tinhTrang) :
                new ObjectParameter("TinhTrang", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LayCacDonHang_Result>("LayCacDonHang", tinhTrangParameter);
        }
    
        public virtual ObjectResult<LayChiTietDHTheoMaDH_Result> LayChiTietDHTheoMaDH(Nullable<int> maDH)
        {
            var maDHParameter = maDH.HasValue ?
                new ObjectParameter("maDH", maDH) :
                new ObjectParameter("maDH", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LayChiTietDHTheoMaDH_Result>("LayChiTietDHTheoMaDH", maDHParameter);
        }
    
        public virtual ObjectResult<LayDonHangTheoMaDH_Result> LayDonHangTheoMaDH(Nullable<int> maDH)
        {
            var maDHParameter = maDH.HasValue ?
                new ObjectParameter("MaDH", maDH) :
                new ObjectParameter("MaDH", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LayDonHangTheoMaDH_Result>("LayDonHangTheoMaDH", maDHParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<TimCTDHTuMaDH_Result> TimCTDHTuMaDH(Nullable<int> maDH)
        {
            var maDHParameter = maDH.HasValue ?
                new ObjectParameter("MaDH", maDH) :
                new ObjectParameter("MaDH", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimCTDHTuMaDH_Result>("TimCTDHTuMaDH", maDHParameter);
        }
    
        public virtual ObjectResult<TimKHTheoMa_Result> TimKHTheoMa(Nullable<int> maKH)
        {
            var maKHParameter = maKH.HasValue ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimKHTheoMa_Result>("TimKHTheoMa", maKHParameter);
        }
    
        public virtual ObjectResult<TimShippersTheoMa_Result> TimShippersTheoMa(Nullable<int> maShippers)
        {
            var maShippersParameter = maShippers.HasValue ?
                new ObjectParameter("MaShippers", maShippers) :
                new ObjectParameter("MaShippers", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimShippersTheoMa_Result>("TimShippersTheoMa", maShippersParameter);
        }
    }
}
