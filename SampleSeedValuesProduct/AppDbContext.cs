﻿using Microsoft.EntityFrameworkCore;
using SampleSeedValuesProduct.Models;

namespace SampleSeedValuesProduct
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(SeedData.Products());
        }

    }
}
