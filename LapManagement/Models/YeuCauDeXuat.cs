using System;
using System.ComponentModel.DataAnnotations;

namespace LabEquipmentManagement.Models
{
    public class YeuCauDeXuat
    {
        [Key]
        public int ProposalID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public int EquipmentID { get; set; }

        public DateTime NgayYeuCau { get; set; } = DateTime.Now;

        [Required]
        [StringLength(20)]
        public required string TrangThai { get; set; }

        public int? NguoiDuyet { get; set; }
    }
}
