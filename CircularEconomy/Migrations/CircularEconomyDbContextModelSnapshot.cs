﻿// <auto-generated />
using CircularEconomy.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CircularEconomy.Migrations
{
    [DbContext(typeof(CircularEconomyDbContext))]
    partial class CircularEconomyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("CircularEconomy.Data.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ActivityOption")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CisloPopisne")
                        .HasColumnType("TEXT");

                    b.Property<string>("Contact")
                        .HasColumnType("TEXT");

                    b.Property<string>("ICO")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PSC")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PlaceActivity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Popis")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TypeTag")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ulice")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vlastnik")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vyvoz")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Place");
                });
#pragma warning restore 612, 618
        }
    }
}
