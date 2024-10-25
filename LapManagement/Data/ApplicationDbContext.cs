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
        public DbSet<TaiKhoan> taiKhoans { get; set; }
        public DbSet<ThietBi> thietBis { get; set; }
        public DbSet<ThoiGianSuDung> thoiGianSuDungs { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
        }
    }
}
