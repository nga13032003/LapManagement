using System;
using System.ComponentModel.DataAnnotations;

namespace LabEquipmentManagement.Models
{
    public class BaoCao
{
    public int ReportID { get; set; }
    public DateTime NgayTao { get; set; } = DateTime.Now;
    
    public required string LoaiBaoCao { get; set; } 
    public required string ChiTiet { get; set; }
}

}
