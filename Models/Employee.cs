using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? EmployeeID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? EmployeeName { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string? Department { get; set; } 
        public int Salary { get; set; }
    }
}