using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Taikhoan
    {
        public Taikhoan()
        {
            Nhanviens = new HashSet<Nhanvien>();
        }

        public int IdTaiKhoan { get; set; }
        public string? TenNguoiDung { get; set; }
        public string? MatKhau { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string? NguoiTao { get; set; }
        public string? NguoiCapNhat { get; set; }

        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
    }
}
