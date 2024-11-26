using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkingAndProjecting.Domain.Entities;

[Table("Workers")]
public class Worker
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;
    public double? Salary {  get; set; }
    public string? Gender { get; set;}
    public string? Email { get; set; }
    public DateOnly DateOfHire { get; set; }
    public int? ManagerdId { get; set; }
    public int? DepartmentId { get; set; }
}
