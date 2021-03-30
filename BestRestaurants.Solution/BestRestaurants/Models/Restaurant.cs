using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BestRestaurants.Models
{
	public class Restaurant
	{
		[Key]
		public string Name { get; set; }
		public int Rating { get; set; }
		public virtual ICollection<Cuisine> Cuisine { get; set; }
	}
}