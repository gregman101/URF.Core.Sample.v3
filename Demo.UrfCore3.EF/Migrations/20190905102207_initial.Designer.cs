﻿// <auto-generated />
using Demo.UrfCore3.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Demo.UrfCore3.EF.Migrations
{
    [DbContext(typeof(UrfDemoContext))]
    [Migration("20190905102207_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview7.19362.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Demo.UrfCore3.EF.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductName = "Chai",
                            UnitPrice = 1m
                        },
                        new
                        {
                            Id = 2,
                            ProductName = "Chang",
                            UnitPrice = 2m
                        },
                        new
                        {
                            Id = 3,
                            ProductName = "Cappuccino",
                            UnitPrice = 3m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}