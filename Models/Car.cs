using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rent_A_Car.Models
{
	public class Car
	{
		[Required]
		public int Id { get; set; }

		[Required]
		public string CarRegNo { get; set; }

		[Required]
		[DataType(DataType.ImageUrl)]
		public string ImageUrl { get; set; }

		[Required]
		public string Make { get; set; }

		[Required]
		public string Model { get; set; }

		[Required]
		public string Availability { get; set; }

		[Required]
		public int ManufacturerId { get; set; }
		public Manufacturer Manufacturer { get; set; }
		
		
	}
}