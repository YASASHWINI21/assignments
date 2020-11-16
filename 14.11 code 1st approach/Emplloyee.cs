using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EmployeeEntityFramework1.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
    }
}
