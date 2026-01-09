using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    // App DbContext with Identity and domain entities
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        // DI constructor
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        // Stocks table
        public DbSet<Stock> Stocks { get; set; }
        // Comments table
        public DbSet<Comment> Comments { get; set; }

        // Portfolio join table
        public DbSet<Portfolio> Portfolios { get; set; }

        // Configure relationships and seed roles
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Portfolio>(x=>x.HasKey(p => new {p.AppUserId, p.StockId}));

            builder.Entity<Portfolio>()
                .HasOne(u => u.AppUser)
                .WithMany(u => u.Portfolios)
                .HasForeignKey(p => p.AppUserId);

            builder.Entity<Portfolio>()
                .HasOne(u => u.Stock)
                .WithMany(u => u.Portfolios)
                .HasForeignKey(p => p.StockId);

            // Seed default roles
            List<IdentityRole> roles = new List<IdentityRole>
        {
            new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
            },
            new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER",
            }
        };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
