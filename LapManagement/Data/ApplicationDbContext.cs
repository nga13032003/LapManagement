using Microsoft.EntityFrameworkCore;
using LapManagement.Models;

namespace LabEquipmentManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ChiTietBaoDuongTB> chiTietBaoDuongTBs { get; set; }
        public DbSet<ChiTietDeXuatDungCu> chiTietDeXuatDungCus { get; set; }
        public DbSet<ChiTietNhapDC> chiTietNhapDCs { get; set; }
        public DbSet<ChucVu> chucVus { get; set; }  
        public DbSet<CongTyThanhLy> congTyThanhLies { get; set; }
        public DbSet<DangKiDungCu> dangKiDungCus { get; set; }
        public DbSet<DangKiThietBi> dangKiThietBis { get; set; }
        public DbSet<DungCu> dungCu { get; set; }

        public DbSet<DuyetPhieu> duyetPhieus { get; set; }
        public DbSet<DuyetPhieuDK> duyetPhieuDKs { get; set; }
        public DbSet<DuyetPhieuThanhLy> duyetPhieuThanhLies { get; set; }
        public DbSet<LoaiDungCu> loaiDungCus { get; set; }
        public DbSet<LoaiThietBi> loaiThietBis { get; set; }
        public DbSet<LuanChuyenDC> luanChuyenDCs { get; set; }
        public DbSet<LuanChuyenTB> luanChuyenTBs { get; set; }
        public DbSet<NhaCungCap> nhaCungCaps { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<NhomQuyen> nhomQuyens { get; set; }
        public DbSet<PhanBoDC> phanBoDCs { get; set; }
        public DbSet<PhieuBaoDuong> phieuBaoDuongs { get; set; }
        public DbSet<PhieuDangKi> phieuDangKis { get; set; }
        public DbSet<PhieuDeXuat> phieuDeXuats { get; set; }
        public DbSet<PhieuNhap> phieuNhaps { get; set; }    
        public DbSet<PhieuPhanBoTB> phieuPhanBoTBs { get; set; }
        public DbSet<PhieuThanhLy> phieuThanhLies { get; set; }
        public DbSet<PhongThiNghiem> phongThiNghiems { get; set; }
        public DbSet<QLTaiKhoan> qLTaiKhoans { get; set; }
        public DbSet<ThietBi> thietBis { get; set; }
        public DbSet<ThoiGianSuDung> thoiGianSuDungs { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.MaCV);
                entity.Property(e => e.TenCV).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<LoaiDungCu>(entity =>
            {
                entity.HasKey(e => e.MaLoaiDC);
                entity.Property(e => e.TenLoaiDC).IsRequired().HasMaxLength(100);
                entity.Property(e => e.MoTa).HasMaxLength(255);
            });

            modelBuilder.Entity<LoaiThietBi>(entity =>
            {
                entity.HasKey(e => e.MaLoaiThietBi);
                entity.Property(e => e.TenLoaiThietBi).IsRequired().HasMaxLength(100);
                entity.Property(e => e.MoTa).HasMaxLength(255);
            });

            modelBuilder.Entity<NhomQuyen>(entity =>
            {
                entity.HasKey(e => e.MaNhom);
                entity.Property(e => e.TenNhom).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNV);
                entity.Property(e => e.TenNV).IsRequired().HasMaxLength(100);
                entity.Property(e => e.GioiTinh).HasMaxLength(10);
                entity.Property(e => e.DiaChi).HasMaxLength(255);
                entity.HasOne(e => e.ChucVu)
                    .WithMany()
                    .HasForeignKey(e => e.MaCV);
                entity.HasOne(e => e.NhomQuyen)
                    .WithMany()
                    .HasForeignKey(e => e.MaNhom);
            });


            modelBuilder.Entity<QLTaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaNV);
                entity.Property(e => e.TenNguoiDung).IsRequired().HasMaxLength(100);
                entity.Property(e => e.MatKhau).IsRequired().HasMaxLength(255);
                entity.HasOne(e => e.NhanVien)
                    .WithOne()
                    .HasForeignKey<QLTaiKhoan>(e => e.MaNV);
            });

            modelBuilder.Entity<CongTyThanhLy>(entity =>
            {
                entity.HasKey(e => e.MaCty);
                entity.Property(e => e.TenCty).IsRequired().HasMaxLength(100);
                entity.Property(e => e.DiaChi).HasMaxLength(255);
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.HasKey(e => e.MaNCC);
                entity.Property(e => e.TenNCC).IsRequired().HasMaxLength(100);
                entity.Property(e => e.DiaChi).HasMaxLength(255);
            });

            modelBuilder.Entity<DungCu>(entity =>
            {
                entity.HasKey(e => e.MaDungCu);
                entity.Property(e => e.TenDungCu).IsRequired().HasMaxLength(100);
                entity.Property(e => e.TinhTrang).HasMaxLength(50);
                entity.Property(e => e.ViTri).HasMaxLength(255);
                entity.Property(e => e.NhaSX).HasMaxLength(100);
                entity.Property(e => e.XuatXu).HasMaxLength(100);
                entity.HasOne(e => e.LoaiDungCu)
                    .WithMany()
                    .HasForeignKey(e => e.MaLoaiDC);
                entity.HasOne(e => e.NhaCungCap)
                    .WithMany()
                    .HasForeignKey(e => e.MaNCC);
            });

            modelBuilder.Entity<ThietBi>(entity =>
            {
                entity.HasKey(e => e.MaThietBi);
                entity.Property(e => e.TenThietBi).IsRequired().HasMaxLength(100);
                entity.Property(e => e.TinhTrang).HasMaxLength(50);
                entity.Property(e => e.NhaSX).HasMaxLength(100);
                entity.Property(e => e.XuatXu).HasMaxLength(100);
                entity.HasOne(e => e.LoaiThietBi)
                    .WithMany()
                    .HasForeignKey(e => e.MaLoaiThietBi);
                entity.HasOne(e => e.NhaCungCap)
                    .WithMany()
                    .HasForeignKey(e => e.MaNCC);
            });

            modelBuilder.Entity<PhieuDeXuat>(entity =>
            {
                entity.HasKey(e => e.MaPhieu);
                entity.HasOne(e => e.DungCu)
                    .WithMany()
                    .HasForeignKey(e => e.MaDungCu);
                entity.HasOne(e => e.ThietBi)
                    .WithMany()
                    .HasForeignKey(e => e.MaThietBi);
            });

            modelBuilder.Entity<DuyetPhieu>(entity =>
            {
                entity.HasKey(e => e.MaPhieu);
                entity.Property(e => e.TrangThai).HasMaxLength(100);
                entity.HasOne(e => e.PhieuDeXuat)
                    .WithOne()
                    .HasForeignKey<DuyetPhieu>(e => e.MaPhieu);
                entity.HasOne(e => e.NhanVien)
                    .WithMany()
                    .HasForeignKey(e => e.MaNV);
            });

            modelBuilder.Entity<ChiTietDeXuatDungCu>(entity =>
            {
                entity.HasKey(e => new { e.MaPhieu, e.MaDungCu });
                entity.Property(e => e.LyDoDeXuat).HasMaxLength(100);
                entity.HasOne(e => e.PhieuDeXuat)
                    .WithMany()
                    .HasForeignKey(e => e.MaPhieu);
                entity.HasOne(e => e.DungCu)
                    .WithMany()
                    .HasForeignKey(e => e.MaDungCu);
            });

            modelBuilder.Entity<PhieuNhap>(entity =>
            {
                entity.HasKey(e => e.MaPhieuNhap);
                entity.HasOne(e => e.DungCu)
                    .WithMany()
                    .HasForeignKey(e => e.MaDungCu);
                entity.HasOne(e => e.ThietBi)
                    .WithMany()
                    .HasForeignKey(e => e.MaThietBi);
                entity.HasOne(e => e.NhanVien)
                    .WithMany()
                    .HasForeignKey(e => e.MaNV);
            });

            modelBuilder.Entity<PhieuDangKi>(entity =>
            {
                entity.HasKey(e => e.MaPhieuDK);
                entity.Property(e => e.NgayDangKi).IsRequired();
                entity.HasOne(e => e.NhanVien)
                    .WithMany()
                    .HasForeignKey(e => e.MaNV);
                entity.HasOne(e => e.ThietBi)
                    .WithMany()
                    .HasForeignKey(e => e.MaThietBi);
            });




        }
    }
}
