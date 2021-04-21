using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide a value for Name field"), MaxLength(50, ErrorMessage = "Name cannot exceed 50 character")]
        public string Name { get; set; }
        [Required, RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-]+$", ErrorMessage = "Invalid email format")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public string PhotoPath { get; set; }
    }
}
