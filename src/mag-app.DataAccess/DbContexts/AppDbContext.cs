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
        //optionsBuilder.UseSqlite("Data Source = LocalDatabase.db");
        optionsBuilder.UseSqlite("Data Source" + "../../../../../LocalDatabase.db");
    }
}
