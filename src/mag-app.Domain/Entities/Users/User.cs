﻿using mag_app.Domain.Common;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Domain.Entities.SubCategories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.Users;

public class User : IAuditable
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
	public string Login { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string PasswordHash { get; set; } = string.Empty;
	public string Salt { get; set; } = string.Empty;
}
