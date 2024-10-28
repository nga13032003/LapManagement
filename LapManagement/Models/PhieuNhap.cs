namespace LapManagement.Models
{
    public class PhieuNhap
    {
        public string? MaPhieuNhap { get; set; }
        public string? MaDungCu { get; set; }
        public string? MaThietBi { get; set; }
        public string? MaNV { get; set; }
        public DateTime? NgayNhap { get; set; }
        public decimal TongTien { get; set; }
        public object DungCu { get; internal set; }
        public object ThietBi { get; internal set; }
        public object NhanVien { get; internal set; }
    }
}
