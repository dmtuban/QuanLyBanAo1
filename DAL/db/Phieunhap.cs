using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Phieunhap
    {
        public Phieunhap()
        {
            Ctphieunhaps = new HashSet<Ctphieunhap>();
        }

        public int IdPhieuNhap { get; set; }
        public string? NguoiNhap { get; set; }
        public DateTime? NgayNhap { get; set; }
        public double? TongTien { get; set; }
        public string? TrangThai { get; set; }
        public int? IdNhanVien { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string? NguoiTao { get; set; }
        public string? NguoiCapNhat { get; set; }

        public virtual Nhanvien? IdNhanVienNavigation { get; set; }
        public virtual ICollection<Ctphieunhap> Ctphieunhaps { get; set; }
    }
}
