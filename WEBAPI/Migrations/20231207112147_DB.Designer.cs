﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBAPI.Models;

#nullable disable

namespace WEBAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231207112147_DB")]
    partial class DB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("WEBAPI.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Remarks")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Christian Nagel",
                            CreatedBy = "",
                            Description = "A true masterclass in C# and .NET programming",
                            Genre = "Software",
                            Price = 50m,
                            PublishDate = new DateTime(2016, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Professional C# 6 and .NET Core 1.0",
                            UpdatedBy = ""
                        },
                        new
                        {
                            Id = 2,
                            Author = "Christian Nagel",
                            CreatedBy = "",
                            Description = "A true masterclass in C# and .NET programming",
                            Genre = "Software",
                            Price = 50m,
                            PublishDate = new DateTime(2018, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Professional C# 7 and .NET Core 2.0",
                            UpdatedBy = ""
                        },
                        new
                        {
                            Id = 3,
                            Author = "Christian Nagel",
                            CreatedBy = "",
                            Description = "A true masterclass in C# and .NET programming",
                            Genre = "Software",
                            Price = 50m,
                            PublishDate = new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Professional C# 8 and .NET Core 3.0",
                            UpdatedBy = ""
                        },
                        new
                        {
                            Id = 4,
                            Author = "Christian Nagel",
                            CreatedBy = "",
                            Description = "A true masterclass in C# and .NET programming",
                            Genre = "Software",
                            Price = 50m,
                            PublishDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Professional C# 9 and .NET 5",
                            UpdatedBy = ""
                        },
                        new
                        {
                            Id = 5,
                            Author = "Perkins, Reid, and Hammer",
                            CreatedBy = "",
                            Description = "The perfect guide to Visual C#",
                            Genre = "Software",
                            Price = 45m,
                            PublishDate = new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Beginning Visual C# 2019",
                            UpdatedBy = ""
                        },
                        new
                        {
                            Id = 6,
                            Author = "Andrew Troelsen",
                            CreatedBy = "",
                            Description = "The ultimate C# resource",
                            Genre = "Software",
                            Price = 50m,
                            PublishDate = new DateTime(2017, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pro C# 7",
                            UpdatedBy = ""
                        });
                });

            modelBuilder.Entity("WEBAPI.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Identifiant")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "",
                            FirstName = "Professional1",
                            Identifiant = "test1",
                            Key = "50fdgdsfgrgsgrggefsegfdh",
                            LastName = "Christian Nagel",
                            Password = "Software1",
                            UpdatedBy = ""
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "",
                            FirstName = "Professional2",
                            Identifiant = "test2",
                            Key = "50sdusfhufxchvuoxgnrsuo",
                            LastName = "Christian Nagel",
                            Password = "Software2",
                            UpdatedBy = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
