using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LapManagement.Models
{
    public class ThietBi
    {
        public string? MaThietBi { get; set; }
        public string? TenThietBi { get; set; }
        public string? MaLoaiThietBi { get; set; }
        public int SoLuong { get; set; }
        public string? TinhTrang { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public DateTime? NgaySX { get; set; }
        public string? NhaSX { get; set; }
        public DateTime? NgayBaoHanh { get; set; }
        public string? XuatXu { get; set; }
        public string? MaNCC { get; set; }
        public object LoaiThietBi { get; internal set; }
        public object NhaCungCap { get; internal set; }
    }
}
