﻿// <auto-generated />
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TinyShop.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200622075854_Add_xinxi")]
    partial class Add_xinxi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("Data.Models.ProductDO", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<double>("Price")
                        .HasColumnType("REAL")
                        .HasMaxLength(100);

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("ProductNumber")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("ProductType")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Data.Models.UserDO", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<string>("Date")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<string>("Radio")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("UserNumber")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("UserPassword")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
