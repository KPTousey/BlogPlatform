using BlogPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform
{
	public class ContentContext : DbContext
	{
		public DbSet<Content> Contents { get; set; }

		public DbSet<Category> Categories { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var connectionString = @"Server=(localdb)\mssqllocaldb; Database=BlogDB_101121; Trusted_Connection=True";

			optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();

			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
			new Category()
			{
				Id = 1,
				Name = "private"
			},
			new Category()
			{
				Id = 2,
				Name = "public"
			},
			new Category()
			{
				Id = 3,
				Name = "advertising"
			}
		);

			modelBuilder.Entity<Content>().HasData(
			new Content()
			{
				Id = 1,
				Title = "Getting Started",
				Body = "Hello World!  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?",
				Author = "Kevin Tousey",
				PublishDate = DateTime.Parse("10/11/2021"),
				CategoryId = 1
			},
			new Content()
			{
				Id = 2,
				Title = "Eating Dinner",
				Body = "Love me some frog legs...  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?",
				Author = "Emeril Lagasse",
				PublishDate = DateTime.Parse("10/11/2021"),
				CategoryId = 1
			},
			new Content()
			{
				Id = 3,
				Title = "100% Free",
				Body = "Call us for a free estimate on your MVC project...  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?",
				Author = "The MVC Team",
				PublishDate = DateTime.Parse("10/11/2021"),
				CategoryId = 3
			},
			new Content()
			{
				Id = 4,
				Title = "Call Now",
				Body = "Are you having problems getting your project to compile, call us!  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?",
				Author = "The C# Network",
				PublishDate = DateTime.Parse("10/11/2021"),
				CategoryId = 3
			},
			new Content()
			{
				Id = 5,
				Title = "Don't Tell",
				Body = "Meet me tomorrow at the Burger King on Front Street.  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?",
				Author = "Anonymous",
				PublishDate = DateTime.Parse("10/11/2021"),
				CategoryId = 1
			},
			new Content()
			{
				Id = 6,
				Title = "Tell Everybody!",
				Body = "There's a party at my house, bring a friend!  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?",
				Author = "Marty McFly",
				PublishDate = DateTime.Parse("10/11/2021"),
				CategoryId = 2
			});

			base.OnModelCreating(modelBuilder);
		}

	}
}
