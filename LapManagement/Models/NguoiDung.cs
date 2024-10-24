using System;
using System.ComponentModel.DataAnnotations;

namespace LabEquipmentManagement.Models
{
    public class NguoiDung
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public required string TenDangNhap { get; set; }

        [Required]
        [StringLength(256)]
        public required string MatKhauHash { get; set; }

        [Required]
        [StringLength(20)]
        public required string VaiTro { get; set; }

        [StringLength(100)]
        public required string HoTen { get; set; }

        [StringLength(100)]
        public required string Email { get; set; }

        public DateTime NgayTao { get; set; } = DateTime.Now;

        public DateTime NgayCapNhat { get; set; } = DateTime.Now;
    }
}
