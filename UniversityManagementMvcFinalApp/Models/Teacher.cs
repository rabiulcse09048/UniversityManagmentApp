using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace UniversityManagementMvcFinalApp.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your email address")]
        [Display(Name = "Email Address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public double CreditToBeTaken { get; set; }
        public int DesignationId { get; set; }
        public virtual Designation Designations { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department TeacherDepartment { get; set; }

    }
}