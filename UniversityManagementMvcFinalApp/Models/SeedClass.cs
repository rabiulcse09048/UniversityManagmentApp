using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityManagementMvcFinalApp.Models
{
    public class SeedClass:DropCreateDatabaseIfModelChanges<UniversityDbContext>
    {
        protected override void Seed(UniversityDbContext context)
        {
            context.Semesters.Add(new Semester() {Name = "First Semester"});
            context.Semesters.Add(new Semester() {Name = "Second Semester"});
            context.Semesters.Add(new Semester() {Name = "Third Semester"});
            context.SaveChanges();

            context.Designations.Add(new Designation() {Name = "Lecturer"});
            context.Designations.Add(new Designation() {Name = "Assistant Professor"});
            context.Designations.Add(new Designation() { Name = "Associate Professor" });
            context.Designations.Add(new Designation() { Name = "Professor" });
            context.SaveChanges();


        }
    }
}