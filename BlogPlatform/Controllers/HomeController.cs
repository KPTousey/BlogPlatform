using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
	public class HomeController : Controller
	{
		private ContentContext _db;

		public HomeController(ContentContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			return View(_db.Contents.ToList());
		}
	}
}
