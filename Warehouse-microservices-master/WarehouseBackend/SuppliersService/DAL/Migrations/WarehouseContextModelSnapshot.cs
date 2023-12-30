﻿// <auto-generated />
using DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(WarehouseContext))]
    partial class WarehouseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DAL.Entities.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Mason company",
                            FirstName = "Alex",
                            PhoneNumber = "050-111-11-11",
                            Surname = "Mason"
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "Hudson warehouse",
                            FirstName = "Jason",
                            PhoneNumber = "050-222-22-22",
                            Surname = "Hudson"
                        },
                        new
                        {
                            Id = 3,
                            CompanyName = "Woods storage",
                            FirstName = "Frank",
                            PhoneNumber = "050-333-33-33",
                            Surname = "Woods"
                        },
                        new
                        {
                            Id = 4,
                            CompanyName = "Bowman delivery",
                            FirstName = "Joseph",
                            PhoneNumber = "050-444-44-44",
                            Surname = "Bowman"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}