using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LapManagement.Models
{
    public class DungCu
    {
        public string? MaDungCu { get; set; }
        public string? TenDungCu { get; set; }
        public string? MaLoaiDC { get; set; }
        public int SoLuong { get; set; }
        public string? TinhTrang { get; set; }
        public string? ViTri { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public DateTime? NgaySX { get; set; }
        public string? NhaSX { get; set; }
        public DateTime? NgayBaoHanh { get; set; }
        public string? XuatXu { get; set; }
        public string? MaNCC { get; set; }
    }
}
