using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LapManagement.Models
{
    public class QLTaiKhoan
    {
        public string? MaNV { get; set; }
        public string? TenNguoiDung { get; set; }
        public string? MatKhau { get; set; }
        public string? MaNhom { get; set; }
        public object NhanVien { get; internal set; }
    }   
}
