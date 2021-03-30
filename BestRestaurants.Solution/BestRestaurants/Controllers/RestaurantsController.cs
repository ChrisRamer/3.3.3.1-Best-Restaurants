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

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(Restaurant restaurant)
		{
			_db.Restaurants.Add(restaurant);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}