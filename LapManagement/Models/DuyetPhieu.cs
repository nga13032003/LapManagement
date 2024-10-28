namespace LapManagement.Models
{
    public class DuyetPhieu
    {
        public string? MaPhieu { get; set; }
        public string? MaNV { get; set; }
        public DateTime? NgayDuyet { get; set; }
        public string? TrangThai { get; set; }
        public object PhieuDeXuat { get; internal set; }
        public object NhanVien { get; internal set; }
    }
}
