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
    
    public partial class tblDonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDonHang()
        {
            this.tblChiTietDonHangs = new HashSet<tblChiTietDonHang>();
            this.tblLichSuTrangThaiDonHangs = new HashSet<tblLichSuTrangThaiDonHang>();
        }
    
        public int PK_MaDonHang { get; set; }
        public string TenNguoiNhan { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public string SoDienThoai { get; set; }
        public string GhiChu { get; set; }
        public System.Guid FK_MaNguoiDung { get; set; }
        public Nullable<System.DateTime> ThoiGianTaoDonHang { get; set; }
        public Nullable<System.Guid> FK_MaNhanVienXuLy { get; set; }
        public int FK_MaTrangThaiDonHang { get; set; }
        public Nullable<System.DateTime> ThoiGianCapNhatTrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietDonHang> tblChiTietDonHangs { get; set; }
        public virtual tblNguoiDung tblNguoiDung { get; set; }
        public virtual tblNguoiDung tblNguoiDung1 { get; set; }
        public virtual tblTrangThaiDonHang tblTrangThaiDonHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLichSuTrangThaiDonHang> tblLichSuTrangThaiDonHangs { get; set; }
    }
}