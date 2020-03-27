using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rent_A_Car.Models
{
	public class Rental
	{
		[Required]
		public int Id { get; set; }
		
		[DataType(DataType.Currency)]
		public double Fee { get; set; }
		
		[DisplayFormat(DataFormatString = "{0: dd MMM yyyy}")]
		public DateTime? RentalDate { get; set; }

		[DisplayFormat(DataFormatString = "{0: dd MMM yyyy}")]
		public DateTime? ReturnDate { get; set; }
				
		[Required]
		public int CarId { get; set; }
		public Car Car { get; set; }
		
		[Required]
		public int CustomerId { get; set; }
		public Customer Customer { get; set; }
	}
}