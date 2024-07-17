using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Hoadons = new HashSet<Hoadon>();
            Phieunhaps = new HashSet<Phieunhap>();
        }

        public int IdNhanVien { get; set; }
        public string? TenNhanVien { get; set; }
        public string? DiaChi { get; set; }
        public string? SoCccd { get; set; }
        public string? TrangThai { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string? NguoiTao { get; set; }
        public string? NguoiCapNhat { get; set; }
        public int? IdTaiKhoan { get; set; }

        public virtual Taikhoan? IdTaiKhoanNavigation { get; set; }
        public virtual ICollection<Hoadon> Hoadons { get; set; }
        public virtual ICollection<Phieunhap> Phieunhaps { get; set; }
    }
}
