using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rent_A_Car.Models
{
	public class Customer
	{
		[Required]
		public int Id { get; set; }

		[Required]
		public string FName { get; set; }

		[Required]
		public string LName { get; set; }

		[Required]
		public string Address { get; set; }

		[Required]
		public int Mobile { get; set; }
	}
}