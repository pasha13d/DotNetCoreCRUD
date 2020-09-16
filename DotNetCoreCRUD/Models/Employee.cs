using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName = "nvarchar(250)")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Display(Name = "Employee Code")]
        public string EmpCode { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Position { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Display(Name = "Office Location")]
        public string OfficeLocation { get; set; }
    }
}
