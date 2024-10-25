using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LapManagement.Models
{
    public class NhanVien
    {
        public string? MaNV { get; set; }
        public string? TenNV { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public string? MaCV { get; set; }
        public string? SoDT { get; set; }
        public string? MaNhom { get; set; }
    }
}
