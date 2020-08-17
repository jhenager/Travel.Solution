﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Models;

namespace travel.Migrations
{
    [DbContext(typeof(TravelContext))]
    [Migration("20200817182135_seedDatabase")]
    partial class seedDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Travel.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int?>("Rating")
                        .IsRequired();

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Country = "USA",
                            Description = "lots of above ground cemetaries",
                            Destination = "La Brea Tar Pits",
                            Rating = 4
                        },
                        new
                        {
                            ReviewId = 2,
                            Country = "USA",
                            Description = "More above ground cemetaries than everywhere else",
                            Destination = "New Orleans",
                            Rating = 1
                        },
                        new
                        {
                            ReviewId = 3,
                            Country = "Germany",
                            Description = "lots of above ground cemetaries",
                            Destination = "Baseball Town",
                            Rating = 1
                        },
                        new
                        {
                            ReviewId = 4,
                            Country = "Greece",
                            Description = "lots of above ground cemetaries",
                            Destination = "Mykonos",
                            Rating = 1
                        },
                        new
                        {
                            ReviewId = 5,
                            Country = "USA",
                            Description = "lots of above ground cemetaries",
                            Destination = "Yosemite",
                            Rating = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
