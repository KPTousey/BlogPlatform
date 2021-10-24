using BlogPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
	public class ContentController : Controller
	{
		private readonly ContentContext _db;

		public ContentController(ContentContext db)
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
			ViewBag.Categories = _db.Categories.ToList();
			return View();
		}

		//post - create
		[HttpPost]
		public IActionResult Create(Content content)
		{
			ViewBag.Categories = _db.Categories.ToList();
			content.PublishDate = DateTime.Now;
			_db.Add(content);
			_db.SaveChanges();
			//return View();
			return RedirectToAction("Index", "Home");
		}

		// get - edit
		public IActionResult Edit(int? id)
		{
			ViewBag.Categories = _db.Categories.ToList();
			var content = _db.Contents.Find(id);
			return View(content);
		}


		// post - edit
		[HttpPost]
		public IActionResult Edit(Content model)
		{
			ViewBag.Categories = _db.Categories.ToList();
			model.PublishDate = DateTime.Now;
			_db.Update(model);
			_db.SaveChanges();
			return RedirectToAction("Index", "Home");
		}

		// get - delete
		public IActionResult Delete(int? id)
		{
			var content = _db.Contents.Find(id);
			_db.Contents.Remove(content);
			_db.SaveChanges();
			return RedirectToAction("Index", "Home");
		}

	}
}
