using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EmployeeEntityFramework1.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext() : base("EmployeeConnectionString")
        {

        }

        public DbSet<Employee> EmployeeTable { get; set; }
    }
}