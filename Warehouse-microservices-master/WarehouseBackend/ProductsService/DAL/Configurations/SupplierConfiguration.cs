﻿using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder
                    .Property(s => s.CompanyName)
                    .HasMaxLength(100)
                    .IsRequired();

            builder
                    .Property(s => s.Id)
                    .ValueGeneratedNever();
        }
    }
}