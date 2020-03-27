using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rent_A_Car.Models
{
	public class Manufacturer
	{
		[Required]
		public int Id { get; set; }
		
		[Required]
		public string ManufacturerName { get; set; }
	}
}