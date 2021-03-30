using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using BestRestaurants.Models;

namespace BestRestaurants.Controllers
{
	public class RestaurantsController : Controller
	{
		private readonly RestaurantContext _db;

		public RestaurantsController(RestaurantContext db)
		{
			_db = db;
		}

		public ActionResult Index()
		{
			List<Restaurant> model = _db.Restaurants.ToList();
			return View(model);
		}
	}
}