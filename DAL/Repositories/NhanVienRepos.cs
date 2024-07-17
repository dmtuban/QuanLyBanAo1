using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{

    public class NhanVienRepos
    {
        QuanLyBanAoContext _context;
        public NhanVienRepos()
        {
            _context = new QuanLyBanAoContext();
        }
        public List<Nhanvien> GetAll()
        {
            return _context.Nhanviens.ToList();

        }
        public List<Nhanvien> GetNV( string ten)
        {
            return _context.Nhanviens.Where(p => p.TenNhanVien == ten).ToList();
        }

        public bool ThemNV(Nhanvien nv)
        {
            try
            {
                _context.Nhanviens.Add(nv);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool SuaNV(Nhanvien nv)
        {
            try
            {
                var updateItem = _context.Nhanviens.Find(nv.IdNhanVien);
                updateItem.TenNhanVien = nv.TenNhanVien;
                updateItem.DiaChi = nv.DiaChi;
                updateItem.SoCccd = nv.SoCccd;
                updateItem.NgayTao = nv.NgayTao;
                updateItem.NgayCapNhat = nv.NgayCapNhat;
                updateItem.NguoiTao = nv.NguoiTao;
                updateItem.NguoiCapNhat = nv.NguoiCapNhat;
                _context.Nhanviens.Update(nv);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

            

        }
    }
}
