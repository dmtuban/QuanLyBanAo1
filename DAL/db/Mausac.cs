using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Mausac
    {
        public Mausac()
        {
            Chitietsanphams = new HashSet<Chitietsanpham>();
        }

        public int IdMauSac { get; set; }
        public string? TenMauSac { get; set; }
        public string? TrangThai { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string? NguoiTao { get; set; }
        public string? NguoiCapNhat { get; set; }

        public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; }
    }
}
