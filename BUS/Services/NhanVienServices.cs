using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class NhanVienServices
    {
        NhanVienRepos _repo = new NhanVienRepos();
        public NhanVienServices() 
        {
            _repo = new NhanVienRepos();
        }

        public List<Nhanvien> CNShow()
        {
            return _repo.GetAll();
        }

        public List <Nhanvien> CNTim(string ten)   
        {
            return _repo.GetNV(ten);
        }

        public string CNThem( string ten, string diachi, )

    }
}
