using System;
using System.ComponentModel.DataAnnotations;

namespace LabEquipmentManagement.Models
{
    public class BaoTri
    {
        [Key]
        public int MaintenanceID { get; set; }

        [Required]
        public int EquipmentID { get; set; }

        [Required]
        public DateTime NgayBaoTri { get; set; }

        [Required]
        public int NguoiThucHien { get; set; }

        public required string ChiTiet { get; set; }

        [Required]
        [StringLength(20)]
        public required string TrangThai { get; set; }
    }
}
