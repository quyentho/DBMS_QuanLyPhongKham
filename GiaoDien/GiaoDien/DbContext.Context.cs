﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GiaoDien
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanLyPhongKhamEntities : DbContext
    {
        public QuanLyPhongKhamEntities()
            : base("name=QuanLyPhongKhamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACCount> ACCounts { get; set; }
        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<DoanhThu> DoanhThus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Thuoc> Thuocs { get; set; }
        public virtual DbSet<ToaThuoc> ToaThuocs { get; set; }
    
        [DbFunction("QuanLyPhongKhamEntities", "DangNhap")]
        public virtual IQueryable<DangNhap_Result> DangNhap(string tenTaiKhoan, string passWord)
        {
            var tenTaiKhoanParameter = tenTaiKhoan != null ?
                new ObjectParameter("TenTaiKhoan", tenTaiKhoan) :
                new ObjectParameter("TenTaiKhoan", typeof(string));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("PassWord", passWord) :
                new ObjectParameter("PassWord", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DangNhap_Result>("[QuanLyPhongKhamEntities].[DangNhap](@TenTaiKhoan, @PassWord)", tenTaiKhoanParameter, passWordParameter);
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "DanhSachBN")]
        public virtual IQueryable<DanhSachBN_Result> DanhSachBN()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DanhSachBN_Result>("[QuanLyPhongKhamEntities].[DanhSachBN]()");
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "DanhSachDV")]
        public virtual IQueryable<DanhSachDV_Result> DanhSachDV()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DanhSachDV_Result>("[QuanLyPhongKhamEntities].[DanhSachDV]()");
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "DanhSachHDChuaTra")]
        public virtual IQueryable<DanhSachHDChuaTra_Result> DanhSachHDChuaTra()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DanhSachHDChuaTra_Result>("[QuanLyPhongKhamEntities].[DanhSachHDChuaTra]()");
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "DanhSachNV")]
        public virtual IQueryable<DanhSachNV_Result> DanhSachNV()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DanhSachNV_Result>("[QuanLyPhongKhamEntities].[DanhSachNV]()");
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "DanhSachThuoc")]
        public virtual IQueryable<DanhSachThuoc_Result> DanhSachThuoc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DanhSachThuoc_Result>("[QuanLyPhongKhamEntities].[DanhSachThuoc]()");
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "DanhSachToaThuocBN")]
        public virtual IQueryable<DanhSachToaThuocBN_Result> DanhSachToaThuocBN(Nullable<int> ma_BN)
        {
            var ma_BNParameter = ma_BN.HasValue ?
                new ObjectParameter("Ma_BN", ma_BN) :
                new ObjectParameter("Ma_BN", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DanhSachToaThuocBN_Result>("[QuanLyPhongKhamEntities].[DanhSachToaThuocBN](@Ma_BN)", ma_BNParameter);
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "HienDoanhThuNam")]
        public virtual IQueryable<HienDoanhThuNam_Result> HienDoanhThuNam()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<HienDoanhThuNam_Result>("[QuanLyPhongKhamEntities].[HienDoanhThuNam]()");
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "HienDoanhThuNgay")]
        public virtual IQueryable<HienDoanhThuNgay_Result> HienDoanhThuNgay(Nullable<System.DateTime> ngay)
        {
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("ngay", ngay) :
                new ObjectParameter("ngay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<HienDoanhThuNgay_Result>("[QuanLyPhongKhamEntities].[HienDoanhThuNgay](@ngay)", ngayParameter);
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "HienDoanhThuThang")]
        public virtual IQueryable<HienDoanhThuThang_Result> HienDoanhThuThang(Nullable<System.DateTime> ngay)
        {
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("Ngay", ngay) :
                new ObjectParameter("Ngay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<HienDoanhThuThang_Result>("[QuanLyPhongKhamEntities].[HienDoanhThuThang](@Ngay)", ngayParameter);
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "TenDV")]
        public virtual IQueryable<TenDV_Result> TenDV()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TenDV_Result>("[QuanLyPhongKhamEntities].[TenDV]()");
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "TimBNTheoSDT")]
        public virtual IQueryable<TimBNTheoSDT_Result> TimBNTheoSDT(string sDT)
        {
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TimBNTheoSDT_Result>("[QuanLyPhongKhamEntities].[TimBNTheoSDT](@SDT)", sDTParameter);
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "TimBNTheoTen")]
        public virtual IQueryable<TimBNTheoTen_Result> TimBNTheoTen(string ten)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("Ten", ten) :
                new ObjectParameter("Ten", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TimBNTheoTen_Result>("[QuanLyPhongKhamEntities].[TimBNTheoTen](@Ten)", tenParameter);
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "TimDVTheoMa")]
        public virtual IQueryable<TimDVTheoMa_Result> TimDVTheoMa(Nullable<int> ma_DV)
        {
            var ma_DVParameter = ma_DV.HasValue ?
                new ObjectParameter("Ma_DV", ma_DV) :
                new ObjectParameter("Ma_DV", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TimDVTheoMa_Result>("[QuanLyPhongKhamEntities].[TimDVTheoMa](@Ma_DV)", ma_DVParameter);
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "TimNVTheoChuc")]
        public virtual IQueryable<TimNVTheoChuc_Result> TimNVTheoChuc(string chuc)
        {
            var chucParameter = chuc != null ?
                new ObjectParameter("Chuc", chuc) :
                new ObjectParameter("Chuc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TimNVTheoChuc_Result>("[QuanLyPhongKhamEntities].[TimNVTheoChuc](@Chuc)", chucParameter);
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "TimNVTheoMa")]
        public virtual IQueryable<TimNVTheoMa_Result> TimNVTheoMa(Nullable<int> maNhanVien)
        {
            var maNhanVienParameter = maNhanVien.HasValue ?
                new ObjectParameter("MaNhanVien", maNhanVien) :
                new ObjectParameter("MaNhanVien", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TimNVTheoMa_Result>("[QuanLyPhongKhamEntities].[TimNVTheoMa](@MaNhanVien)", maNhanVienParameter);
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "TimNVTheoTen")]
        public virtual IQueryable<TimNVTheoTen_Result> TimNVTheoTen(string hoTen)
        {
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("HoTen", hoTen) :
                new ObjectParameter("HoTen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TimNVTheoTen_Result>("[QuanLyPhongKhamEntities].[TimNVTheoTen](@HoTen)", hoTenParameter);
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "TimThuocTheoMa")]
        public virtual IQueryable<TimThuocTheoMa_Result> TimThuocTheoMa(Nullable<int> ma_Thuoc)
        {
            var ma_ThuocParameter = ma_Thuoc.HasValue ?
                new ObjectParameter("Ma_Thuoc", ma_Thuoc) :
                new ObjectParameter("Ma_Thuoc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TimThuocTheoMa_Result>("[QuanLyPhongKhamEntities].[TimThuocTheoMa](@Ma_Thuoc)", ma_ThuocParameter);
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "TimThuocTheoTen")]
        public virtual IQueryable<TimThuocTheoTen_Result> TimThuocTheoTen(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TimThuocTheoTen_Result>("[QuanLyPhongKhamEntities].[TimThuocTheoTen](@name)", nameParameter);
        }
    
        public virtual int ChiDinhDV(Nullable<int> ma_BN, Nullable<int> ma_DV)
        {
            var ma_BNParameter = ma_BN.HasValue ?
                new ObjectParameter("Ma_BN", ma_BN) :
                new ObjectParameter("Ma_BN", typeof(int));
    
            var ma_DVParameter = ma_DV.HasValue ?
                new ObjectParameter("Ma_DV", ma_DV) :
                new ObjectParameter("Ma_DV", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ChiDinhDV", ma_BNParameter, ma_DVParameter);
        }
    
        public virtual int DoiMatKhau(Nullable<int> ma_NV, string passWord)
        {
            var ma_NVParameter = ma_NV.HasValue ?
                new ObjectParameter("Ma_NV", ma_NV) :
                new ObjectParameter("Ma_NV", typeof(int));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("PassWord", passWord) :
                new ObjectParameter("PassWord", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DoiMatKhau", ma_NVParameter, passWordParameter);
        }
    
        public virtual int SuaBenhNan(Nullable<int> ma_BN, string hoTen, Nullable<int> tuoi, Nullable<int> gioiTinh, Nullable<int> sDT)
        {
            var ma_BNParameter = ma_BN.HasValue ?
                new ObjectParameter("Ma_BN", ma_BN) :
                new ObjectParameter("Ma_BN", typeof(int));
    
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("HoTen", hoTen) :
                new ObjectParameter("HoTen", typeof(string));
    
            var tuoiParameter = tuoi.HasValue ?
                new ObjectParameter("Tuoi", tuoi) :
                new ObjectParameter("Tuoi", typeof(int));
    
            var gioiTinhParameter = gioiTinh.HasValue ?
                new ObjectParameter("GioiTinh", gioiTinh) :
                new ObjectParameter("GioiTinh", typeof(int));
    
            var sDTParameter = sDT.HasValue ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuaBenhNan", ma_BNParameter, hoTenParameter, tuoiParameter, gioiTinhParameter, sDTParameter);
        }
    
        public virtual int SuaDichVu(Nullable<int> ma_DV, string tenDV, Nullable<int> gia)
        {
            var ma_DVParameter = ma_DV.HasValue ?
                new ObjectParameter("Ma_DV", ma_DV) :
                new ObjectParameter("Ma_DV", typeof(int));
    
            var tenDVParameter = tenDV != null ?
                new ObjectParameter("TenDV", tenDV) :
                new ObjectParameter("TenDV", typeof(string));
    
            var giaParameter = gia.HasValue ?
                new ObjectParameter("Gia", gia) :
                new ObjectParameter("Gia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuaDichVu", ma_DVParameter, tenDVParameter, giaParameter);
        }
    
        public virtual int SuaNhanVien(Nullable<int> ma_NV, string hoTen, Nullable<System.DateTime> ngaySinh, string sDT, string chuc, Nullable<int> luong, Nullable<int> tangCa)
        {
            var ma_NVParameter = ma_NV.HasValue ?
                new ObjectParameter("Ma_NV", ma_NV) :
                new ObjectParameter("Ma_NV", typeof(int));
    
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("HoTen", hoTen) :
                new ObjectParameter("HoTen", typeof(string));
    
            var ngaySinhParameter = ngaySinh.HasValue ?
                new ObjectParameter("NgaySinh", ngaySinh) :
                new ObjectParameter("NgaySinh", typeof(System.DateTime));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var chucParameter = chuc != null ?
                new ObjectParameter("Chuc", chuc) :
                new ObjectParameter("Chuc", typeof(string));
    
            var luongParameter = luong.HasValue ?
                new ObjectParameter("Luong", luong) :
                new ObjectParameter("Luong", typeof(int));
    
            var tangCaParameter = tangCa.HasValue ?
                new ObjectParameter("TangCa", tangCa) :
                new ObjectParameter("TangCa", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuaNhanVien", ma_NVParameter, hoTenParameter, ngaySinhParameter, sDTParameter, chucParameter, luongParameter, tangCaParameter);
        }
    
        public virtual int SuaThuocCu(Nullable<int> ma_Thuoc, string ten, Nullable<int> soLuong, string donVi, Nullable<int> gia)
        {
            var ma_ThuocParameter = ma_Thuoc.HasValue ?
                new ObjectParameter("Ma_Thuoc", ma_Thuoc) :
                new ObjectParameter("Ma_Thuoc", typeof(int));
    
            var tenParameter = ten != null ?
                new ObjectParameter("Ten", ten) :
                new ObjectParameter("Ten", typeof(string));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            var donViParameter = donVi != null ?
                new ObjectParameter("DonVi", donVi) :
                new ObjectParameter("DonVi", typeof(string));
    
            var giaParameter = gia.HasValue ?
                new ObjectParameter("Gia", gia) :
                new ObjectParameter("Gia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuaThuocCu", ma_ThuocParameter, tenParameter, soLuongParameter, donViParameter, giaParameter);
        }
    
        public virtual int ThanhToanHoaDon(Nullable<int> ma_HoaDon)
        {
            var ma_HoaDonParameter = ma_HoaDon.HasValue ?
                new ObjectParameter("Ma_HoaDon", ma_HoaDon) :
                new ObjectParameter("Ma_HoaDon", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThanhToanHoaDon", ma_HoaDonParameter);
        }
    
        public virtual int ThemBenhNhan(string hoTen, Nullable<int> tuoi, string gioiTinh, string sDT)
        {
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("HoTen", hoTen) :
                new ObjectParameter("HoTen", typeof(string));
    
            var tuoiParameter = tuoi.HasValue ?
                new ObjectParameter("Tuoi", tuoi) :
                new ObjectParameter("Tuoi", typeof(int));
    
            var gioiTinhParameter = gioiTinh != null ?
                new ObjectParameter("GioiTinh", gioiTinh) :
                new ObjectParameter("GioiTinh", typeof(string));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemBenhNhan", hoTenParameter, tuoiParameter, gioiTinhParameter, sDTParameter);
        }
    
        public virtual int ThemDichVu(string tenDV, Nullable<int> gia)
        {
            var tenDVParameter = tenDV != null ?
                new ObjectParameter("TenDV", tenDV) :
                new ObjectParameter("TenDV", typeof(string));
    
            var giaParameter = gia.HasValue ?
                new ObjectParameter("Gia", gia) :
                new ObjectParameter("Gia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemDichVu", tenDVParameter, giaParameter);
        }
    
        public virtual int ThemHoaDon(Nullable<int> ma_BN)
        {
            var ma_BNParameter = ma_BN.HasValue ?
                new ObjectParameter("Ma_BN", ma_BN) :
                new ObjectParameter("Ma_BN", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemHoaDon", ma_BNParameter);
        }
    
        public virtual int ThemNhanVien(string hoTen, Nullable<System.DateTime> ngaySinh, string sDT, string chuc, Nullable<int> luong)
        {
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("HoTen", hoTen) :
                new ObjectParameter("HoTen", typeof(string));
    
            var ngaySinhParameter = ngaySinh.HasValue ?
                new ObjectParameter("NgaySinh", ngaySinh) :
                new ObjectParameter("NgaySinh", typeof(System.DateTime));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var chucParameter = chuc != null ?
                new ObjectParameter("Chuc", chuc) :
                new ObjectParameter("Chuc", typeof(string));
    
            var luongParameter = luong.HasValue ?
                new ObjectParameter("Luong", luong) :
                new ObjectParameter("Luong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemNhanVien", hoTenParameter, ngaySinhParameter, sDTParameter, chucParameter, luongParameter);
        }
    
        public virtual int ThemThuocMoi(string ten, Nullable<int> soLuong, string donVi, Nullable<int> gia)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("Ten", ten) :
                new ObjectParameter("Ten", typeof(string));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            var donViParameter = donVi != null ?
                new ObjectParameter("DonVi", donVi) :
                new ObjectParameter("DonVi", typeof(string));
    
            var giaParameter = gia.HasValue ?
                new ObjectParameter("Gia", gia) :
                new ObjectParameter("Gia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemThuocMoi", tenParameter, soLuongParameter, donViParameter, giaParameter);
        }
    
        public virtual int ThemToaThuoc(Nullable<int> ma_BN, string tenThuoc, Nullable<decimal> soLuong, Nullable<int> ma_NV, string huongDanSD)
        {
            var ma_BNParameter = ma_BN.HasValue ?
                new ObjectParameter("Ma_BN", ma_BN) :
                new ObjectParameter("Ma_BN", typeof(int));
    
            var tenThuocParameter = tenThuoc != null ?
                new ObjectParameter("TenThuoc", tenThuoc) :
                new ObjectParameter("TenThuoc", typeof(string));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(decimal));
    
            var ma_NVParameter = ma_NV.HasValue ?
                new ObjectParameter("Ma_NV", ma_NV) :
                new ObjectParameter("Ma_NV", typeof(int));
    
            var huongDanSDParameter = huongDanSD != null ?
                new ObjectParameter("HuongDanSD", huongDanSD) :
                new ObjectParameter("HuongDanSD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemToaThuoc", ma_BNParameter, tenThuocParameter, soLuongParameter, ma_NVParameter, huongDanSDParameter);
        }
    
        public virtual int XoaDichVu(Nullable<int> ma_DV)
        {
            var ma_DVParameter = ma_DV.HasValue ?
                new ObjectParameter("Ma_DV", ma_DV) :
                new ObjectParameter("Ma_DV", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaDichVu", ma_DVParameter);
        }
    
        public virtual int XoaNhanVien(Nullable<int> ma_NV)
        {
            var ma_NVParameter = ma_NV.HasValue ?
                new ObjectParameter("Ma_NV", ma_NV) :
                new ObjectParameter("Ma_NV", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaNhanVien", ma_NVParameter);
        }
    
        public virtual int XoaThuoc(Nullable<int> ma_Thuoc)
        {
            var ma_ThuocParameter = ma_Thuoc.HasValue ?
                new ObjectParameter("Ma_Thuoc", ma_Thuoc) :
                new ObjectParameter("Ma_Thuoc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaThuoc", ma_ThuocParameter);
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "ThongTinInDichVu")]
        public virtual IQueryable<ThongTinInDichVu_Result> ThongTinInDichVu(Nullable<int> ma_HoaDon)
        {
            var ma_HoaDonParameter = ma_HoaDon.HasValue ?
                new ObjectParameter("Ma_HoaDon", ma_HoaDon) :
                new ObjectParameter("Ma_HoaDon", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ThongTinInDichVu_Result>("[QuanLyPhongKhamEntities].[ThongTinInDichVu](@Ma_HoaDon)", ma_HoaDonParameter);
        }
    
        [DbFunction("QuanLyPhongKhamEntities", "ThongTinInToaThuoc")]
        public virtual IQueryable<ThongTinInToaThuoc_Result> ThongTinInToaThuoc(Nullable<int> ma_HoaDon)
        {
            var ma_HoaDonParameter = ma_HoaDon.HasValue ?
                new ObjectParameter("Ma_HoaDon", ma_HoaDon) :
                new ObjectParameter("Ma_HoaDon", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ThongTinInToaThuoc_Result>("[QuanLyPhongKhamEntities].[ThongTinInToaThuoc](@Ma_HoaDon)", ma_HoaDonParameter);
        }
    }
}