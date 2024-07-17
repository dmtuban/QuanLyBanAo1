using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Ctphieunhap
    {
        public int IdChiTietPhieuNhap { get; set; }
        public string? TenSp { get; set; }
        public double? Gia { get; set; }
        public int? SoLuongNhap { get; set; }
        public int? IdPhieuNhap { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string? NguoiTao { get; set; }
        public string? NguoiCapNhat { get; set; }

        public virtual Phieunhap? IdPhieuNhapNavigation { get; set; }
    }
}
