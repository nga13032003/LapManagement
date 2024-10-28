namespace LapManagement.Models
{
    public class PhieuDeXuat
    {
        public string? MaPhieuPDX { get; set; }
        public string? MaDungCu { get; set; }
        public string? MaThietBi { get; set; }
        public DateTime? NgayTao { get; set; }
        public object? MaPhieu { get; internal set; }
        public object DungCu { get; internal set; }
        public object ThietBi { get; internal set; }
    }
}
