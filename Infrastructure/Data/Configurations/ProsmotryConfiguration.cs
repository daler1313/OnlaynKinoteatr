using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configurations
{
    public class ProsmotryConfiguration : IEntityTypeConfiguration<Prosmotry>
    {
        public void Configure(EntityTypeBuilder<Prosmotry> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Ocenki)
                .IsRequired();
            builder.Property(a => a.Kol_vo)
                .IsRequired();

            builder.HasOne(a => a.Users)
                .WithMany(az => az.Prosmotrys)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.Films)
                .WithMany(a => a.Prosmotrys)
                .HasForeignKey(a => a.FilmsId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}