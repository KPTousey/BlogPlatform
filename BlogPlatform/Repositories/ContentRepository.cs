using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
	public class ContentRepository : IRepository<Content>
	{

		public ContentContext db;

		public ContentRepository(ContentContext db)
		{
			this.db = db;
		}

		// create
		public void Create(Content obj)
		{
			db.Contents.Add(obj);
			db.SaveChanges();
		}

		// update
		public void Update(Content obj)
		{
			db.Contents.Update(obj);
			db.SaveChanges();
		}

		// delete
		public void Delete(Content obj)
		{
			db.Contents.Remove(obj);
			db.SaveChanges();
		}

		public IEnumerable<Content> GetAll()
		{
			return db.Contents.ToList();
		}

		public Content GetByID(int id)
		{
			return db.Contents.Find(id);
		}

		public List<Category> PopulateCategoryList()
		{
			return db.Categories.ToList();
		}
	}
}
