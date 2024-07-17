using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Voucher
    {
        public Voucher()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        public int IdVoucher { get; set; }
        public string? TenVoucher { get; set; }
        public double? PhanTramGiam { get; set; }
        public int? SoLuong { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string? NguoiTao { get; set; }
        public string? NguoiCapNhat { get; set; }
        public DateTime? HanSuDung { get; set; }
        public string? TrangThai { get; set; }

        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
