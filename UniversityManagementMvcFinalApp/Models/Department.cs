using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityManagementMvcFinalApp.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        
        [Required]
        [Remote("IsDeptCodeAvailable", "Department", ErrorMessage = "Dept Code Already Exists")]
        public string Code { get; set; }

        [Required]
        [Remote("IsDeptNameAvailable", "Department", ErrorMessage = "Dept Name Already Exists")]
        public string Name { get; set; }

        public virtual List<Course> Courses { get; set; }
    }
}