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
    
    public partial class tblGiaThayDoi
    {
        public int FK_MaSanPham { get; set; }
        public System.DateTime ThoiGianThayDoiGia { get; set; }
        public int GiaThayDoi { get; set; }
    
        public virtual tblSanPham tblSanPham { get; set; }
    }
}