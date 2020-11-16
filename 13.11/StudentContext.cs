using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentEntity.Models
{
	public class StudentContext:DbContext
	{
		public StudentContext()
			: base("name=Student")
		{
		}

		public DbSet<Student> StudentTable { get; set; }
	}

}