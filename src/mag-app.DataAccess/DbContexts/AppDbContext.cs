﻿using mag_app.Domain.Entities.AllProducts;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Domain.Entities.SubCategories;
using mag_app.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace mag_app.DataAccess.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
        Database.Migrate();
    }
    public virtual DbSet<User> Users { get; set; } = default!;
    public virtual DbSet<Store> Stores { get; set; } = default!;
    public virtual DbSet<Category> Categories { get; set; } = default!;
    public virtual DbSet<SubCategory> SubCategories { get; set; } = default!;
    public virtual DbSet<Product> Products { get; set; } = default!;
    public virtual DbSet<AllProduct> AllProducts { get; set; } = default!;


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source = LocalDatabase.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder
            .Entity<User>()
            .HasMany(t => t.Stores)
            .WithOne(c => c.User)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder
            .Entity<Store>()
            .HasMany(x => x.Categories)
            .WithOne(c => c.Store)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder
            .Entity<Category>()
            .HasMany(t => t.SubCategories)
            .WithOne(c => c.Category)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder
            .Entity<SubCategory>()
            .HasMany(t => t.Products)
            .WithOne(c => c.SubCategory)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AllProduct>()
            .HasKey(bc => new { bc.StoreId, bc.ProductId });

        modelBuilder.Entity<AllProduct>()
            .HasOne(bc => bc.Stores)
            .WithMany(b => b.AllProducts)
            .HasForeignKey(bc => bc.StoreId);

        modelBuilder.Entity<AllProduct>()
            .HasOne(bc => bc.Products)
            .WithMany(c => c.AllProducts)
            .HasForeignKey(bc => bc.StoreId);
    }
}
