using BlogPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
	public class CategoryController : Controller
	{

		private readonly ContentContext _db;

		public CategoryController(ContentContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			return View();
		}

		// get - create
		public IActionResult Create()
		{
			return View();
		}

		//post - create
		[HttpPost]
		public IActionResult Create(Category category)
		{
			_db.Add(category);
			_db.SaveChanges();
			//return View();
			return RedirectToAction("Create", "Content");
		}
	}
}
