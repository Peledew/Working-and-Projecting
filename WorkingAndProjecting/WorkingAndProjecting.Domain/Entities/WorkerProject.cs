using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingAndProjecting.Domain.Entities
{
    [Table("WorkerProjects")]
    [PrimaryKey(nameof(WorkerId), nameof(ProjectId))]
    public class WorkerProject
    {
        public int WorkerId { get; set; }
        public int ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public required Project Project { get; set; }

        [ForeignKey("WorkerId")]
        public required Worker Worker { get; set; }
    }
}
