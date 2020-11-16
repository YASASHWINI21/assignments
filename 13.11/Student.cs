using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudentEntity.Models
{
	public class Student
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Course { get; set; }

	}
}