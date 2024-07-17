using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Thuonghieu
    {
        public Thuonghieu()
        {
            Chitietsanphams = new HashSet<Chitietsanpham>();
        }

        public int IdThuongHieu { get; set; }
        public string? TenThuongHieu { get; set; }
        public string? TrangThai { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string? NguoiTao { get; set; }
        public string? NguoiCapNhat { get; set; }

        public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; }
    }
}
