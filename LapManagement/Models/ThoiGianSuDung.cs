namespace LapManagement.Models
{
    public class ThoiGianSuDung
    {
        public string? MaPhieuDK { get; set; }
        public string? MaThietBi { get; set; }
        public string? MaNV { get; set; }
        public int Nam { get; set; }
        public int Thang { get; set; }
        public int Ngay { get; set; }
        public int SoGio { get; set; }
        public object NhanVien { get; internal set; }
        public object ThietBi { get; internal set; }
        public object PhieuDangKi { get; internal set; }
    }
}
