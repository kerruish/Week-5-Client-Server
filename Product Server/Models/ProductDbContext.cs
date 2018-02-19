using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Product_Server.Models
{
    public class ProductDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public ProductDbContext(): base ("DefaultConnection")
        {

        }
    }
}