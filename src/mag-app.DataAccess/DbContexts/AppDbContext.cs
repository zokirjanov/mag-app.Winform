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

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		base.OnConfiguring(optionsBuilder);
		var path = (Environment.CurrentDirectory);
		optionsBuilder.UseSqlite("Data Source=" + path + "\\LocalDatabase.db");
	}

}
