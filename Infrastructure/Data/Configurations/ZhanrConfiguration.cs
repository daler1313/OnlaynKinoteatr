﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configurations
{
    public class ZhanrConfiguration : IEntityTypeConfiguration<Zhanr>
    {
        public void Configure(EntityTypeBuilder<Zhanr> builder)
        {
            builder.
        }
    }
}