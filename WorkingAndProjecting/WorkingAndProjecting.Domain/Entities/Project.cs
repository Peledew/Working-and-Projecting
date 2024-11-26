using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingAndProjecting.Domain.Entities
{
    [Table("Projects")]
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [StringLength(1500)]
        public string? Description { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public double? Budget { get; set; }
        public int? ManagerId { get; set; }
        public int StatusId { get; set; }
        public ICollection<WorkerProject>? Workers { get; set; }

        //Foreign key references
        [ForeignKey("ManagerId")]
        public User? Manager { get; set; }

        [ForeignKey("StatusId")]
        public required ProjectStatus Status { get; set; }

    }
}
