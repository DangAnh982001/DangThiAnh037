using System.ComponentModel.DataAnnotations;

namespace DangThiAnh037.Models;
public class DTA0037{
    [Key]
    [StringLength(20)]
    public string? DTAId {get; set;}
    [StringLength(50)]
    public string? DTAName {get; set;}
    public string? DTAGender {get; set;}
}