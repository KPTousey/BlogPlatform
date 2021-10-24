using BlogPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using System;
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
			return View();
		}

		//post - create
		[HttpPost]
		public IActionResult Create(Content content)
		{
			content.PublishDate = DateTime.Now;
			_db.Add(content);
			_db.SaveChangesAsync();
			//return View();
			return RedirectToAction("Index", "Home");
		}

		// get - edit
		public IActionResult Edit(int? id)
		{
			var content = _db.Contents.Find(id);
			return View(content);
		}


		// post - edit
		[HttpPost]
		public IActionResult Edit(int id, Content model)
		{
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
