﻿// <auto-generated />
using CoffeeShop.GraphQL.CodeFirstDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoffeeShop.GraphQL.Migrations
{
    [DbContext(typeof(CoffeeShopApplicationDbContext))]
    partial class CoffeeShopApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CoffeeShop.GraphQL.CodeFirstDB.Beverage", b =>
                {
                    b.Property<int>("BeverageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("BasePrice")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<double>("SalesPrice")
                        .HasColumnType("REAL");

                    b.HasKey("BeverageId");

                    b.ToTable("Beverages");
                });
#pragma warning restore 612, 618
        }
    }
}
