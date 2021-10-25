using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BlogPlatform.Models;

namespace BlogPlatform.Tests
{
	public class ContentTest
	{
		public Content myBlog = new Content();

		[Fact]
		public void Content_Title_Confirmation_Test()
		{
			myBlog.Id = 1;
			myBlog.Title = "Test Title";
			myBlog.Body = "Test Body";
			myBlog.Author = "author";
			myBlog.PublishDate = DateTime.Now;


			Assert.Equal("Test Title", myBlog.Title);

		}

		[Fact]
		public void Content_Id_Test()
		{
			myBlog.Id = 1;
			Assert.Equal(1, myBlog.Id);
		}

	}
}