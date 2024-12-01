using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingAndProjecting.Domain.Entities;

namespace WorkingAndProjecting.Contracts.DTOs
{
    public class UserDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Role { get; set; }
        public double? Salary { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public DateOnly? DateOfHire { get; set; }
        public int? ManagerdId { get; set; }
        public int? DepartmentId { get; set; }
        public ICollection<WorkerProject>? Projects { get; set; }


    }
}
