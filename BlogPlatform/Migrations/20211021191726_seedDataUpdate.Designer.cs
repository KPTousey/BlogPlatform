﻿// <auto-generated />
using System;
using BlogPlatform;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(ContentContext))]
    [Migration("20211021191726_seedDataUpdate")]
    partial class seedDataUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogPlatform.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "private"
                        },
                        new
                        {
                            Id = 2,
                            Name = "public"
                        },
                        new
                        {
                            Id = 3,
                            Name = "advertising"
                        });
                });

            modelBuilder.Entity("BlogPlatform.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Kevin Tousey",
                            Body = "Hello World!  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?",
                            CategoryId = 1,
                            PublishDate = new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Getting Started"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Emeril Lagasse",
                            Body = "Love me some frog legs...  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?",
                            CategoryId = 1,
                            PublishDate = new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Eating Dinner"
                        },
                        new
                        {
                            Id = 3,
                            Author = "The MVC Team",
                            Body = "Call us for a free estimate on your MVC project...  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?",
                            CategoryId = 3,
                            PublishDate = new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "100% Free"
                        },
                        new
                        {
                            Id = 4,
                            Author = "The C# Network",
                            Body = "Are you having problems getting your project to compile, call us!  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?",
                            CategoryId = 3,
                            PublishDate = new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Call Now"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Anonymous",
                            Body = "Meet me tomorrow at the Burger King on Front Street.  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?",
                            CategoryId = 1,
                            PublishDate = new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Don't Tell"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Marty McFly",
                            Body = "There's a party at my house, bring a friend!  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?",
                            CategoryId = 2,
                            PublishDate = new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Tell Everybody!"
                        });
                });

            modelBuilder.Entity("BlogPlatform.Models.Content", b =>
                {
                    b.HasOne("BlogPlatform.Models.Category", "category")
                        .WithMany("Content")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("BlogPlatform.Models.Category", b =>
                {
                    b.Navigation("Content");
                });
#pragma warning restore 612, 618
        }
    }
}