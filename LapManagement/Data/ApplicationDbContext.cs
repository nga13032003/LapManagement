using Microsoft.EntityFrameworkCore;
using LabEquipmentManagement.Models;

namespace LabEquipmentManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<ThietBi> ThietBis { get; set; }
        public DbSet<YeuCauDeXuat> YeuCauDeXuats { get; set; }
        public DbSet<LichSuSuDung> LichSuSuDungs { get; set; }
        public DbSet<BaoTri> BaoTris { get; set; }
        public DbSet<ThanhLy> ThanhLys { get; set; }
        public DbSet<BaoCao> BaoCaos { get; set; }
    }
}
