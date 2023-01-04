using System.ComponentModel.DataAnnotations;

namespace DangThiAnh037.Models;
public class DTA0037{
    [Key]
    [StringLength(20)]
    public string? DTAId {get; set;}

    [StringLength(50)]
    [Required(ErrorMessage = "not null")]
    public string? DTAName {get; set;}
    [Required(ErrorMessage = "not null")]
    public Boolean DTAGender {get; set;}
}