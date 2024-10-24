using System;
using System.ComponentModel.DataAnnotations;

namespace LabEquipmentManagement.Models
{
    public class ThanhLy
    {
        [Key]
        public int DisposalID { get; set; }

        [Required]
        public int EquipmentID { get; set; }

        [Required]
        public DateTime NgayThanhLy { get; set; }

        [Required]
        public int NguoiThanhLy { get; set; }

        public required string LyDo { get; set; }
    }
}
