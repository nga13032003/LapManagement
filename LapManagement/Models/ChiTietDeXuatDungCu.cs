namespace LapManagement.Models
{
    public class ChiTietDeXuatDungCu
    {
        public string? MaPhieuPDX { get; set; }
        public string? MaDungCu { get; set; }
        public int SoLuongDeXuat { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public string? LyDoDeXuat { get; set; }
        public object DungCu { get; internal set; }
        public object PhieuDeXuat { get; internal set; }
        public object MaPhieu { get; internal set; }
    }
}
