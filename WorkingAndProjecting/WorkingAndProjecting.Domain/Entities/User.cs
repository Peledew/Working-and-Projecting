using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkingAndProjecting.Domain.Entities;

[Table("Users")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;
    public string? Role { get; set; } = "User";
    public double? Salary {  get; set; }
    public string? Gender { get; set;}
    public string? Email { get; set; }
    public DateOnly DateOfHire { get; set; }
    public int? ManagerdId { get; set; }
    public int? DepartmentId { get; set; }
    public ICollection<WorkerProject>? Projects { get; set; }

    //Foreign key references
    [ForeignKey("ManagerId")]
    public User? Manager { get; set; }
    [ForeignKey("DepartmentId")]
    public required Department Department { get; set; }

}
