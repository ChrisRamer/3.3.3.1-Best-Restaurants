using System.ComponentModel.DataAnnotations;

namespace BestRestaurants.Models
{
	public class Cuisine
	{
		[Key]
		public string Name { get; set; }
		public int Price { get; set; }
		public virtual Restaurant Restaurant { get; set; }
	}
}