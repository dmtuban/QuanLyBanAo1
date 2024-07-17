using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Kichco
    {
        public Kichco()
        {
            Chitietsanphams = new HashSet<Chitietsanpham>();
        }

        public int IdKichCo { get; set; }
        public string? KichCo1 { get; set; }
        public string? TrangThai { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string? NguoiTao { get; set; }
        public string? NguoiCapNhat { get; set; }

        public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; }
    }
}
