using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Chitietsanpham
    {
        public Chitietsanpham()
        {
            Hoadonchitiets = new HashSet<Hoadonchitiet>();
        }

        public int IdChiTietSp { get; set; }
        public string? TenSanPham { get; set; }
        public string? TrangThai { get; set; }
        public string? HinhAnh { get; set; }
        public int? IdSanPham { get; set; }
        public int? IdThuongHieu { get; set; }
        public int? IdMauSac { get; set; }
        public int? IdKichCo { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }

        public virtual Kichco? IdKichCoNavigation { get; set; }
        public virtual Mausac? IdMauSacNavigation { get; set; }
        public virtual Sanpham? IdSanPhamNavigation { get; set; }
        public virtual Thuonghieu? IdThuongHieuNavigation { get; set; }
        public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; }
    }
}
