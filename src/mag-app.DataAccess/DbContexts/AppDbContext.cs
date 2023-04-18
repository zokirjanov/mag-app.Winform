using mag_app.Domain.Constant;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Domain.Entities.SubCategories;
using mag_app.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

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
    public virtual DbSet<Cash> Cashes { get; set; } = default!;
    public virtual DbSet<TabController> Tabs { get; set; } = default!;
    public virtual DbSet<TabProduct> Tabproducts { get; set; } = default!;
    public virtual DbSet<SaleDetail> SaleDetails { get; set; } = default!;
    public virtual DbSet<SaleGlobal> SaleGlobal { get; set; } = default!;
    public virtual DbSet<ReturnProduct> ReturnProducts { get; set; } = default!;




    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source = LocalDatabase.db");
        // optionsBuilder.UseSqlite("Data Source" + "../../../../../LocalDatabase.db");
    }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        // ReturnedProducts
        modelBuilder.Entity<ReturnProduct>()
                    .HasOne<SaleGlobal>(sd => sd.SaleGlobal)
                    .WithMany(sg => sg.ReturnProducts)
                    .HasForeignKey(sd => sd.SaleGlobalId)
                    .OnDelete(DeleteBehavior.SetNull);


        // Sales Global
        modelBuilder.Entity<SaleDetail>()
                    .HasOne<Cash>(sd => sd.Cash)
                    .WithMany(sg => sg.SalesGlobals)
                    .HasForeignKey(sd => sd.CashId)
                    .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<SaleDetail>()
                    .HasOne<Store>(sd => sd.Store)
                    .WithMany(sg => sg.SalesGlobal)
                    .HasForeignKey(sd => sd.StoreId)
                    .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<SaleDetail>()
                    .Property(sg => sg.PaymentType)
                    .HasConversion<string>();

        modelBuilder.Entity<SaleDetail>()
                    .HasIndex(sg => sg.PaymentType);


        // Sales Details
        modelBuilder.Entity<SaleGlobal>()
                    .HasOne<SaleDetail>(sd => sd.SalesGlobal)
                    .WithMany(sg => sg.SaleDetails)
                    .HasForeignKey(sd => sd.SaleId)
                    .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<SaleGlobal>()
                    .HasOne<AllProduct>(sd => sd.AllProduct)
                    .WithMany(sd => sd.SaleDetails)
                    .HasForeignKey(sd => sd.ProductId)
                    .OnDelete(DeleteBehavior.SetNull);
        

        // TabProducts
        modelBuilder.Entity<TabProduct>()
                    .HasOne<TabController>(e => e.TabController)
                    .WithMany(d => d.TabProducts)
                    .HasForeignKey(e => e.TabControllerId)
                    .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<TabProduct>()
                    .HasOne<AllProduct>(e => e.AllProduct)
                    .WithMany(d => d.TabProducts)
                    .HasForeignKey(e => e.ProductId);
        

        // Cash_Registers
        modelBuilder.Entity<Cash>()
                    .HasOne<Store>(e => e.Store)
                    .WithMany(d => d.Cashes)
                    .HasForeignKey(e => e.StoreId)
                    .OnDelete(DeleteBehavior.Cascade);

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
