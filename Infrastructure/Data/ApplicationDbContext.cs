using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
        public DbSet<Films> Films { get; set; }
        public DbSet<Produccer> produccers { get; set; }
        public DbSet<Prosmotry> prosmotries { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Zhanr> zhanrs { get; set; }
    }
}