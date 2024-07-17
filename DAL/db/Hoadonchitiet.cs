using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Hoadonchitiet
    {
        public int IdHoaDonChiTiet { get; set; }
        public string? TenSp { get; set; }
        public string? ThuongHieu { get; set; }
        public string? MauSac { get; set; }
        public string? Size { get; set; }
        public int? SoLuong { get; set; }
        public double? PhanTramGiam { get; set; }
        public double? Gia { get; set; }
        public int? IdHoaDon { get; set; }
        public int? IdChiTietSp { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string? NguoiTao { get; set; }
        public string? NguoiCapNhat { get; set; }

        public virtual Chitietsanpham? IdChiTietSpNavigation { get; set; }
        public virtual Hoadon? IdHoaDonNavigation { get; set; }
    }
}
