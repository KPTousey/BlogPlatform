using BlogPlatform;
using BlogPlatform.Controllers;
using BlogPlatform.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using Xunit;

namespace BlogPlatform.Tests
{
	public class ContentControllerTest
	{
		ContentController sut;
		ContentContext contentContext;

		public ContentControllerTest()
		{
			contentContext = Substitute.For<ContentContext>();
			sut = new ContentController(contentContext);
		}

		[Fact]
		public void Index_Returns_A_View()
		{
			//Act

			var result = sut.Index();

			//Assert
			Assert.IsType<Task<IActionResult>>(result);
			
		}

		[Fact]
		public void Confirm_Create_Content_Successfully()
		{
			// Arrange
			var content = new Content();

			content.Title = "test content";

			var result = sut.Create(content);

			// Assert
			Assert.IsType<Task<IActionResult>>(result);
		}
	}
}
