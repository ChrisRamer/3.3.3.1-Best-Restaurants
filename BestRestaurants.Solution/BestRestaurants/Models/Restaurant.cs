using System.Collections.Generic;

namespace BestRestaurants.Models
{
	public class Restaurant
	{
		public string Name { get; set; }
		public int Rating { get; set; }
		public virtual ICollection<Cuisine> Cuisine { get; set; }
	}
}