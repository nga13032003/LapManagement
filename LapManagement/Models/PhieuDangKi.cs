namespace LapManagement.Models
{
    public class PhieuDangKi
    {
        public string? MaPhieuDK { get; set; }
        public string? MaThietBi { get; set; }
        public string? MaNV { get; set; }
        public DateTime? NgaySuDung { get; set; }
        public string? MaDungCu { get; set; }
        public object NgayDangKi { get; internal set; }
        public object NhanVien { get; internal set; }
        public object ThietBi { get; internal set; }
    }
}
