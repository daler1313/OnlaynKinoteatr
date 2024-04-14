using Domain;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Data.Configurations
{
    public class ProduccerConfiguration : IEntityTypeConfiguration<Produccer>
    {
        public void Configure(EntityTypeBuilder<Produccer> builder)
        {
            builder.
        }
    }
}