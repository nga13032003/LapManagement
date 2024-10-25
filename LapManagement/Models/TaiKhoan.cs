using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LapManagement.Models
{
    public class TaiKhoan
    {
        public string? MaNV { get; set; }
        public string? TenNguoiDung { get; set; }
        public string? MatKhau { get; set; }
        public string? MaNhom { get; set; }
    }   
}
