using System.ComponentModel.DataAnnotations;

namespace DangThiAnh037.Models;
public class CompanyDTA037 {
    [Key]
    [StringLength(20)]
    public string? CompanyId {get;set;}
    
    [StringLength(50)]
    public string? CompanyName {get;set;}
}