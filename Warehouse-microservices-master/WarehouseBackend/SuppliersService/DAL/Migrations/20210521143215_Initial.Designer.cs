﻿// <auto-generated />
using DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(WarehouseContext))]
    [Migration("20210521143215_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            CompanyName = "Sidorov company",
                            FirstName = "Nikita",
                            PhoneNumber = "050-111-11-11",
                            Surname = "Sidorov"
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "Stepaniuk warehouse",
                            FirstName = "Ira",
                            PhoneNumber = "050-222-22-22",
                            Surname = "Stepaniuk"
                        },
                        new
                        {
                            Id = 3,
                            CompanyName = "Fedorenko storage",
                            FirstName = "Danial",
                            PhoneNumber = "050-333-33-33",
                            Surname = "Fedorenko"
                        },
                        new
                        {
                            Id = 4,
                            CompanyName = "Dolid delivery",
                            FirstName = "Vova",
                            PhoneNumber = "050-444-44-44",
                            Surname = "Dolid"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
