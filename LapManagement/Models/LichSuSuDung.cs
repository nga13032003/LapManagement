using System;
using System.ComponentModel.DataAnnotations;

namespace LabEquipmentManagement.Models
{
    public class LichSuSuDung
    {
        [Key]
        public int UsageID { get; set; }

        [Required]
        public int EquipmentID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public DateTime ThoiGianBatDau { get; set; }

        [Required]
        public DateTime ThoiGianKetThuc { get; set; }

        [StringLength(100)]
        public required string TinhTrangTruoc { get; set; }

        [StringLength(100)]
        public required string TinhTrangSau { get; set; }
    }
}
