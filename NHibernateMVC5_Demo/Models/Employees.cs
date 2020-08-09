using System;
using System.ComponentModel.DataAnnotations;

namespace NHibernateMVC5_Demo.Models
{
    public class Employees
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Position { get; set; }
        public virtual string Office { get; set; }
        public virtual int Age { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual int Salary { get; set; }

        [Display(Name = "Department Id")]
        public virtual int DepartmentId { get; set; }
    }
}