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

            modelBuilder.Entity("DAL.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandName = "Sandora"
                        },
                        new
                        {
                            Id = 2,
                            BrandName = "OKZDP"
                        },
                        new
                        {
                            Id = 3,
                            BrandName = "PepsiCo"
                        },
                        new
                        {
                            Id = 4,
                            BrandName = "Coca-Cola Company"
                        },
                        new
                        {
                            Id = 5,
                            BrandName = "Guinness"
                        },
                        new
                        {
                            Id = 6,
                            BrandName = "Hoegaarden"
                        },
                        new
                        {
                            Id = 7,
                            BrandName = "Morshynska"
                        },
                        new
                        {
                            Id = 8,
                            BrandName = "Jameson"
                        },
                        new
                        {
                            Id = 9,
                            BrandName = "Jack Daniel's"
                        },
                        new
                        {
                            Id = 10,
                            BrandName = "French rose"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
