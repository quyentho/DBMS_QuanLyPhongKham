//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ToaThuoc
    {
        public int Ma_HoaDon { get; set; }
        public int Ma_Thuoc { get; set; }
        public int SoLuong { get; set; }
        public string DonVi { get; set; }
        public string HuongDanSD { get; set; }
        public int Gia { get; set; }
        public Nullable<int> BacSi { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual Thuoc Thuoc { get; set; }
    }
}