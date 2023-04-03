using mag_app.Domain.Entities.AllProducts;
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
       // optionsBuilder.UseSqlite("Data Source" + "../../../../../LocalDatabase.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Products
        modelBuilder.Entity<Product>()
                    .HasOne<SubCategory>(e => e.SubCategory)
                    .WithMany(d => d.Products)
                    .HasForeignKey(e => e.SubCategoryId)
                    .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Product>()
                    .HasOne<Category>(e => e.Category)
                    .WithMany(d => d.Products)
                    .HasForeignKey(e => e.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade);

        // Sub-Categroy
        modelBuilder.Entity<SubCategory>()
                    .HasOne<Category>(e => e.Category)
                    .WithMany(d => d.SubCategories)
                    .HasForeignKey(e => e.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade);

        // All products
        modelBuilder.Entity<AllProduct>()
                    .HasOne<SubCategory>(e => e.SubCategory)
                    .WithMany(d => d.AllProducts)
                    .HasForeignKey(e => e.SubCategoryId)
                    .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AllProduct>()
                   .HasOne<Product>(e => e.Product)
                   .WithMany(d => d.AllProducts)
                   .HasForeignKey(e => e.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AllProduct>()
                    .HasOne<Category>(e => e.Category)
                    .WithMany(d => d.AllProducts)
                    .HasForeignKey(e => e.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AllProduct>()
                    .HasOne<Store>(e => e.Store)
                    .WithMany(d => d.AllProducts)
                    .HasForeignKey(e => e.StoreId)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.SetNull);
    }
}
