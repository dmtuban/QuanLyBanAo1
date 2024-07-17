using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Chitietsanphams = new HashSet<Chitietsanpham>();
        }

        public int IdSanPham { get; set; }
        public string? TenSanPham { get; set; }
        public double? Gia { get; set; }
        public int? SoLuong { get; set; }
        public string? TrangThai { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string? NguoiTao { get; set; }
        public string? NguoiCapNhat { get; set; }

        public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; }
    }
}
