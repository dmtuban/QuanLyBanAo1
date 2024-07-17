using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Hoadonchitiets = new HashSet<Hoadonchitiet>();
        }

        public int IdHoaDon { get; set; }
        public string? TenKh { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string? NguoiTao { get; set; }
        public string? NguoiCapNhat { get; set; }
        public double? TongTien { get; set; }
        public string? TrangThai { get; set; }
        public int? IdKhachHang { get; set; }
        public int? IdNhanVien { get; set; }
        public int? IdVoucher { get; set; }

        public virtual Khachhang? IdKhachHangNavigation { get; set; }
        public virtual Nhanvien? IdNhanVienNavigation { get; set; }
        public virtual Voucher? IdVoucherNavigation { get; set; }
        public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; }
    }
}
