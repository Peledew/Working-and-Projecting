using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkingAndProjecting.Domain.Entities
{
    [Table("WorkerProjects")]
    [PrimaryKey(nameof(UserId), nameof(ProjectId))]
    public class WorkerProject
    {
        public int UserId { get; set; }
        public int ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        [JsonIgnore]
        public Project Project { get; set; } = null!;

        [ForeignKey("UserId")]
        [JsonIgnore]
        public User User { get; set; } = null!;
    }
}
