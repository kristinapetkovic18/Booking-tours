﻿// <auto-generated />
using System;
using HospitalLibrary.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HospitalLibrary.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    [Migration("20240822171649_T")]
    partial class T
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("HospitalLibrary.Core.Model.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<int>("TourId")
                        .HasColumnType("integer");

                    b.Property<int>("TouristId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.ToTable("CartItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Count = 1,
                            Deleted = false,
                            TourId = 1,
                            TouristId = 1
                        });
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<int>("InterestTypeName")
                        .HasColumnType("integer");

                    b.Property<int>("TourId")
                        .HasColumnType("integer");

                    b.Property<int>("TouristId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            InterestTypeName = 4,
                            TourId = 0,
                            TouristId = 1
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            InterestTypeName = 0,
                            TourId = 0,
                            TouristId = 1
                        },
                        new
                        {
                            Id = 3,
                            Deleted = false,
                            InterestTypeName = 4,
                            TourId = 1,
                            TouristId = 0
                        });
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AdminId")
                        .HasColumnType("integer");

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<int>("TourId")
                        .HasColumnType("integer");

                    b.Property<int>("TouristId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.IssueStatusChange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("ChangedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ChangedBy")
                        .HasColumnType("integer");

                    b.Property<int>("IssueId")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IssueId");

                    b.ToTable("IssueStatusChange");
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.KeyPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<int>("TourId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("KeyPoints");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            Description = "spomenik kulture",
                            Image = "spomenik3.jpg",
                            Latitude = 38.895099999999999,
                            Longitude = -77.0364,
                            Name = "kp ture 1",
                            Order = 1,
                            TourId = 1
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            Description = "spomenik kulture",
                            Image = "spomenik3.jpg",
                            Latitude = 39.895099999999999,
                            Longitude = -77.0364,
                            Name = "kp ture 1, drugi po redu",
                            Order = 2,
                            TourId = 1
                        });
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("TourId")
                        .HasColumnType("integer");

                    b.Property<string>("TourName")
                        .HasColumnType("text");

                    b.Property<int>("TouristId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Purchases");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 2,
                            Count = 0,
                            Deleted = false,
                            Price = 10.0,
                            PurchaseDate = new DateTime(2024, 8, 22, 19, 16, 48, 644, DateTimeKind.Local).AddTicks(5634),
                            TourId = 1,
                            TourName = "tura autora broj 1",
                            TouristId = 1
                        });
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<int>("LeastSellingTourCount")
                        .HasColumnType("integer");

                    b.Property<int>("LeastSellingTourId")
                        .HasColumnType("integer");

                    b.Property<string>("SalesIncreasePercentage")
                        .HasColumnType("text");

                    b.Property<int>("SoldToursCount")
                        .HasColumnType("integer");

                    b.Property<int>("TopSellingTourCount")
                        .HasColumnType("integer");

                    b.Property<int>("TopSellingTourId")
                        .HasColumnType("integer");

                    b.Property<double>("TotalProfit")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.Tour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Difficulty")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<bool>("NoSalesInLastThreeMonths")
                        .HasColumnType("boolean");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("TicketCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Tours");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 2,
                            Deleted = false,
                            Description = "prva tura",
                            Difficulty = 0,
                            Name = "tura autora broj 1",
                            NoSalesInLastThreeMonths = false,
                            Price = 10,
                            Status = 1,
                            TicketCount = 150
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Deleted = false,
                            Description = "druga tura",
                            Difficulty = 0,
                            Name = "tura autora broj 1",
                            NoSalesInLastThreeMonths = false,
                            Price = 10,
                            Status = 0,
                            TicketCount = 150
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            Deleted = false,
                            Description = "treca tura",
                            Difficulty = 2,
                            Name = "tura autora broj 1",
                            NoSalesInLastThreeMonths = false,
                            Price = 10,
                            Status = 1,
                            TicketCount = 150
                        });
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuthorPoints")
                        .HasColumnType("integer");

                    b.Property<bool>("Blocked")
                        .HasColumnType("boolean");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<int>("IssueCount")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool>("Malicious")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<bool>("TopAuthor")
                        .HasColumnType("boolean");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorPoints = 0,
                            Blocked = false,
                            Deleted = false,
                            Email = "kpetkovic18@gmail.com",
                            FirstName = "Kristina",
                            IssueCount = 0,
                            LastName = "Petkovic",
                            Malicious = false,
                            Password = "$2b$10$yvoVI2N1YDsn4XIc07FjVOd2uRA7DOsjJ/kjLuPoD/blUyrNT3W9O",
                            Role = 0,
                            TopAuthor = false,
                            Username = "tourist1"
                        },
                        new
                        {
                            Id = 2,
                            AuthorPoints = 0,
                            Blocked = false,
                            Deleted = false,
                            Email = "kpetkovic18@gmail.com",
                            FirstName = "Bjanka",
                            IssueCount = 0,
                            LastName = "Tijodorovic",
                            Malicious = false,
                            Password = "$2b$10$PAsomxwK/45hVLFf3R.tauK51.q52rGq1u7gQ/XWTjDvWlQdiYYmi",
                            Role = 1,
                            TopAuthor = false,
                            Username = "author2"
                        },
                        new
                        {
                            Id = 3,
                            AuthorPoints = 0,
                            Blocked = false,
                            Deleted = false,
                            Email = "kpetkovic18@gmail.com",
                            FirstName = "Jelena",
                            IssueCount = 0,
                            LastName = "Petkovic",
                            Malicious = false,
                            Password = "$2b$10$yklAvqx98jOG6fq4UBaNbedozjiFTxNDkXqGb15UJ0xqAQiGMg8Sa",
                            Role = 2,
                            TopAuthor = false,
                            Username = "admin3"
                        });
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.CartItem", b =>
                {
                    b.HasOne("HospitalLibrary.Core.Model.Tour", "Tour")
                        .WithMany()
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.IssueStatusChange", b =>
                {
                    b.HasOne("HospitalLibrary.Core.Model.Issue", null)
                        .WithMany("StatusChanges")
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.Issue", b =>
                {
                    b.Navigation("StatusChanges");
                });
#pragma warning restore 612, 618
        }
    }
}