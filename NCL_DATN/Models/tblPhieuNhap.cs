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
    
    public partial class tblPhieuNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPhieuNhap()
        {
            this.tblChiTietPhieuNhaps = new HashSet<tblChiTietPhieuNhap>();
        }
    
        public int PK_MaPhieuNhap { get; set; }
        public System.DateTime NgayNhap { get; set; }
        public string GhiChu { get; set; }
        public System.Guid FK_MaNguoiDung { get; set; }
        public int FK_MaNhaCungCap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietPhieuNhap> tblChiTietPhieuNhaps { get; set; }
        public virtual tblNguoiDung tblNguoiDung { get; set; }
        public virtual tblNhaCungCap tblNhaCungCap { get; set; }
    }
}
