using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configurations
{
    public class FilmsConfiguration : IEntityTypeConfiguration<Films>
    {
        public void Configure(EntityTypeBuilder<Films> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name)
                .IsRequired();

            builder.HasOne(a => a.Zhanrs)
                .WithMany(az => az.Films)
                .HasForeignKey(a => a.Zhanr_id)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Produccers)
                .WithMany(az => az.Films)
                .HasForeignKey(a => a.Produccer_id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}