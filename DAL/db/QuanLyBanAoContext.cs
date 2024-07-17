using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class QuanLyBanAoContext : DbContext
    {
        public QuanLyBanAoContext()
        {
        }

        public QuanLyBanAoContext(DbContextOptions<QuanLyBanAoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chitietsanpham> Chitietsanphams { get; set; } = null!;
        public virtual DbSet<Ctphieunhap> Ctphieunhaps { get; set; } = null!;
        public virtual DbSet<Hoadon> Hoadons { get; set; } = null!;
        public virtual DbSet<Hoadonchitiet> Hoadonchitiets { get; set; } = null!;
        public virtual DbSet<Khachhang> Khachhangs { get; set; } = null!;
        public virtual DbSet<Kichco> Kichcos { get; set; } = null!;
        public virtual DbSet<Mausac> Mausacs { get; set; } = null!;
        public virtual DbSet<Nhanvien> Nhanviens { get; set; } = null!;
        public virtual DbSet<Phieunhap> Phieunhaps { get; set; } = null!;
        public virtual DbSet<Sanpham> Sanphams { get; set; } = null!;
        public virtual DbSet<Taikhoan> Taikhoans { get; set; } = null!;
        public virtual DbSet<Thuonghieu> Thuonghieus { get; set; } = null!;
        public virtual DbSet<Voucher> Vouchers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=NGOCHAOBUI\\SQLEXPRESS;Database=QuanLyBanAo;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chitietsanpham>(entity =>
            {
                entity.HasKey(e => e.IdChiTietSp)
                    .HasName("PK__CHITIETS__E41F4D256AC8396E");

                entity.ToTable("CHITIETSANPHAM");

                entity.Property(e => e.IdChiTietSp).HasColumnName("ID_ChiTietSP");

                entity.Property(e => e.HinhAnh).HasMaxLength(255);

                entity.Property(e => e.IdKichCo).HasColumnName("ID_KichCo");

                entity.Property(e => e.IdMauSac).HasColumnName("ID_MauSac");

                entity.Property(e => e.IdSanPham).HasColumnName("ID_SanPham");

                entity.Property(e => e.IdThuongHieu).HasColumnName("ID_ThuongHieu");

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenSanPham).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(20);

                entity.HasOne(d => d.IdKichCoNavigation)
                    .WithMany(p => p.Chitietsanphams)
                    .HasForeignKey(d => d.IdKichCo)
                    .HasConstraintName("FK__CHITIETSA__ID_Ki__797309D9");

                entity.HasOne(d => d.IdMauSacNavigation)
                    .WithMany(p => p.Chitietsanphams)
                    .HasForeignKey(d => d.IdMauSac)
                    .HasConstraintName("FK__CHITIETSA__ID_Ma__787EE5A0");

                entity.HasOne(d => d.IdSanPhamNavigation)
                    .WithMany(p => p.Chitietsanphams)
                    .HasForeignKey(d => d.IdSanPham)
                    .HasConstraintName("FK__CHITIETSA__ID_Sa__76969D2E");

                entity.HasOne(d => d.IdThuongHieuNavigation)
                    .WithMany(p => p.Chitietsanphams)
                    .HasForeignKey(d => d.IdThuongHieu)
                    .HasConstraintName("FK__CHITIETSA__ID_Th__778AC167");
            });

            modelBuilder.Entity<Ctphieunhap>(entity =>
            {
                entity.HasKey(e => e.IdChiTietPhieuNhap)
                    .HasName("PK__CTPHIEUN__F7359670142D8B6B");

                entity.ToTable("CTPHIEUNHAP");

                entity.Property(e => e.IdChiTietPhieuNhap).HasColumnName("ID_ChiTietPhieuNhap");

                entity.Property(e => e.IdPhieuNhap).HasColumnName("ID_PhieuNhap");

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(100);

                entity.Property(e => e.NguoiTao).HasMaxLength(100);

                entity.Property(e => e.TenSp)
                    .HasMaxLength(100)
                    .HasColumnName("TenSP");

                entity.HasOne(d => d.IdPhieuNhapNavigation)
                    .WithMany(p => p.Ctphieunhaps)
                    .HasForeignKey(d => d.IdPhieuNhap)
                    .HasConstraintName("FK__CTPHIEUNH__ID_Ph__19DFD96B");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.IdHoaDon)
                    .HasName("PK__HOADON__14AFCFC515D57562");

                entity.ToTable("HOADON");

                entity.Property(e => e.IdHoaDon).HasColumnName("ID_HoaDon");

                entity.Property(e => e.IdKhachHang).HasColumnName("ID_KhachHang");

                entity.Property(e => e.IdNhanVien).HasColumnName("ID_NhanVien");

                entity.Property(e => e.IdVoucher).HasColumnName("ID_Voucher");

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(100);

                entity.Property(e => e.NguoiTao).HasMaxLength(100);

                entity.Property(e => e.TenKh)
                    .HasMaxLength(100)
                    .HasColumnName("TenKH");

                entity.Property(e => e.TrangThai).HasMaxLength(20);

                entity.HasOne(d => d.IdKhachHangNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.IdKhachHang)
                    .HasConstraintName("FK__HOADON__ID_Khach__07C12930");

                entity.HasOne(d => d.IdNhanVienNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.IdNhanVien)
                    .HasConstraintName("FK__HOADON__ID_NhanV__08B54D69");

                entity.HasOne(d => d.IdVoucherNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.IdVoucher)
                    .HasConstraintName("FK__HOADON__ID_Vouch__09A971A2");
            });

            modelBuilder.Entity<Hoadonchitiet>(entity =>
            {
                entity.HasKey(e => e.IdHoaDonChiTiet)
                    .HasName("PK__HOADONCH__A6583769986679CB");

                entity.ToTable("HOADONCHITIET");

                entity.Property(e => e.IdHoaDonChiTiet).HasColumnName("ID_HoaDonChiTiet");

                entity.Property(e => e.IdChiTietSp).HasColumnName("ID_ChiTietSP");

                entity.Property(e => e.IdHoaDon).HasColumnName("ID_HoaDon");

                entity.Property(e => e.MauSac).HasMaxLength(50);

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(100);

                entity.Property(e => e.NguoiTao).HasMaxLength(100);

                entity.Property(e => e.Size).HasMaxLength(10);

                entity.Property(e => e.TenSp)
                    .HasMaxLength(100)
                    .HasColumnName("TenSP");

                entity.Property(e => e.ThuongHieu).HasMaxLength(100);

                entity.HasOne(d => d.IdChiTietSpNavigation)
                    .WithMany(p => p.Hoadonchitiets)
                    .HasForeignKey(d => d.IdChiTietSp)
                    .HasConstraintName("FK__HOADONCHI__ID_Ch__0F624AF8");

                entity.HasOne(d => d.IdHoaDonNavigation)
                    .WithMany(p => p.Hoadonchitiets)
                    .HasForeignKey(d => d.IdHoaDon)
                    .HasConstraintName("FK__HOADONCHI__ID_Ho__0E6E26BF");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.IdKhachHang)
                    .HasName("PK__KHACHHAN__263C4E85B0C44B05");

                entity.ToTable("KHACHHANG");

                entity.HasIndex(e => e.SoDienThoai, "UQ__KHACHHAN__0389B7BDB73AF790")
                    .IsUnique();

                entity.Property(e => e.IdKhachHang).HasColumnName("ID_KhachHang");

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.GioiTinh).HasMaxLength(10);

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(100);

                entity.Property(e => e.NguoiTao).HasMaxLength(100);

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TenKhachHang).HasMaxLength(100);
            });

            modelBuilder.Entity<Kichco>(entity =>
            {
                entity.HasKey(e => e.IdKichCo)
                    .HasName("PK__KICHCO__884F2E89E4E5DA56");

                entity.ToTable("KICHCO");

                entity.Property(e => e.IdKichCo).HasColumnName("ID_KichCo");

                entity.Property(e => e.KichCo1)
                    .HasMaxLength(10)
                    .HasColumnName("KichCo");

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(100);

                entity.Property(e => e.NguoiTao).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(20);
            });

            modelBuilder.Entity<Mausac>(entity =>
            {
                entity.HasKey(e => e.IdMauSac)
                    .HasName("PK__MAUSAC__D35485FEB2A9B94C");

                entity.ToTable("MAUSAC");

                entity.Property(e => e.IdMauSac).HasColumnName("ID_MauSac");

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(100);

                entity.Property(e => e.NguoiTao).HasMaxLength(100);

                entity.Property(e => e.TenMauSac).HasMaxLength(50);

                entity.Property(e => e.TrangThai).HasMaxLength(20);
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.IdNhanVien)
                    .HasName("PK__NHANVIEN__EF603D1284BC916F");

                entity.ToTable("NHANVIEN");

                entity.HasIndex(e => e.SoCccd, "UQ__NHANVIEN__8A547D3A57DA7B24")
                    .IsUnique();

                entity.Property(e => e.IdNhanVien).HasColumnName("ID_NhanVien");

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.IdTaiKhoan).HasColumnName("ID_TaiKhoan");

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(100);

                entity.Property(e => e.NguoiTao).HasMaxLength(100);

                entity.Property(e => e.SoCccd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SoCCCD");

                entity.Property(e => e.TenNhanVien).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(20);

                entity.HasOne(d => d.IdTaiKhoanNavigation)
                    .WithMany(p => p.Nhanviens)
                    .HasForeignKey(d => d.IdTaiKhoan)
                    .HasConstraintName("FK__NHANVIEN__ID_Tai__7F2BE32F");
            });

            modelBuilder.Entity<Phieunhap>(entity =>
            {
                entity.HasKey(e => e.IdPhieuNhap)
                    .HasName("PK__PHIEUNHA__D260B289BF276995");

                entity.ToTable("PHIEUNHAP");

                entity.Property(e => e.IdPhieuNhap).HasColumnName("ID_PhieuNhap");

                entity.Property(e => e.IdNhanVien).HasColumnName("ID_NhanVien");

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayNhap)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(100);

                entity.Property(e => e.NguoiNhap).HasMaxLength(100);

                entity.Property(e => e.NguoiTao).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(20);

                entity.HasOne(d => d.IdNhanVienNavigation)
                    .WithMany(p => p.Phieunhaps)
                    .HasForeignKey(d => d.IdNhanVien)
                    .HasConstraintName("FK__PHIEUNHAP__ID_Nh__151B244E");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.IdSanPham)
                    .HasName("PK__SANPHAM__617EA392FC70AD29");

                entity.ToTable("SANPHAM");

                entity.Property(e => e.IdSanPham).HasColumnName("ID_SanPham");

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(100);

                entity.Property(e => e.NguoiTao).HasMaxLength(100);

                entity.Property(e => e.TenSanPham).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(20);
            });

            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.HasKey(e => e.IdTaiKhoan)
                    .HasName("PK__TAIKHOAN__0E3EC210096A9BC8");

                entity.ToTable("TAIKHOAN");

                entity.Property(e => e.IdTaiKhoan).HasColumnName("ID_TaiKhoan");

                entity.Property(e => e.MatKhau).HasMaxLength(50);

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(100);

                entity.Property(e => e.NguoiTao).HasMaxLength(100);

                entity.Property(e => e.TenNguoiDung).HasMaxLength(50);
            });

            modelBuilder.Entity<Thuonghieu>(entity =>
            {
                entity.HasKey(e => e.IdThuongHieu)
                    .HasName("PK__THUONGHI__AB2A011A47F21B6B");

                entity.ToTable("THUONGHIEU");

                entity.Property(e => e.IdThuongHieu).HasColumnName("ID_ThuongHieu");

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(100);

                entity.Property(e => e.NguoiTao).HasMaxLength(100);

                entity.Property(e => e.TenThuongHieu).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(20);
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasKey(e => e.IdVoucher)
                    .HasName("PK__VOUCHER__7D975E3E4FED7419");

                entity.ToTable("VOUCHER");

                entity.Property(e => e.IdVoucher).HasColumnName("ID_Voucher");

                entity.Property(e => e.HanSuDung).HasColumnType("datetime");

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(100);

                entity.Property(e => e.NguoiTao).HasMaxLength(100);

                entity.Property(e => e.TenVoucher).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
