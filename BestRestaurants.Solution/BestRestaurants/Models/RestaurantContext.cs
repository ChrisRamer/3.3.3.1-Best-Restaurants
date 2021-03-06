using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
	public class RestaurantContext : DbContext
	{
		public virtual DbSet<Restaurant> Restaurants { get; set; }
		public virtual DbSet<Cuisine> Cuisines { get; set; }

		public RestaurantContext(DbContextOptions options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseLazyLoadingProxies();
		}
	}
}