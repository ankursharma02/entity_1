﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication1.Models
{
    public class NorthWindContext:DbContext
    {
        public NorthWindContext()
            :base("name=NorthWindConnection")
        {

        }
        public DbSet<Category> CategoriesTable { get; set;  }
        public DbSet<Product> ProductsTable { get; set; }
    }
}