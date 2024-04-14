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
            builder.
        }
    }
}