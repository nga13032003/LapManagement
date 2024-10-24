using System;
using System.ComponentModel.DataAnnotations;

namespace LabEquipmentManagement.Models
{
    public class ThietBi
    {
        [Key]
        public int EquipmentID { get; set; }

        [Required]
        [StringLength(50)]
        public required string MaThietBi { get; set; }

        [Required]
        [StringLength(100)]
        public required string Ten { get; set; }

        [Required]
        [StringLength(20)]
        public required string TrangThai { get; set; }

        [StringLength(50)]
        public required string PhongThiNghiem { get; set; }

        public DateTime? NgayBaoTri { get; set; }
    }
}
