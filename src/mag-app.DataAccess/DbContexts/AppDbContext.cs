using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Domain.Entities.SubCategories;
using mag_app.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		base.OnConfiguring(optionsBuilder);
		var path = (Environment.CurrentDirectory);
		optionsBuilder.UseSqlite("Data Source=" + path + "\\LocalDatabase.db");
    }
}
