//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NCL_DATN.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblLichSuTrangThaiDonHang
    {
        public int FK_MaDonHang { get; set; }
        public string TenTrangThaiDonHang { get; set; }
        public System.DateTime ThoiGianCapNhat { get; set; }
        public string TenNguoiCapNhat { get; set; }
    
        public virtual tblDonHang tblDonHang { get; set; }
    }
}
