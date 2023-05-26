using Microsoft.EntityFrameworkCore;
using OrderProcessTracking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessTracking.Persistence.Contexts
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Demand> Demand { get; set; }
        public DbSet<DemandLine> DemandLines { get; set; }
        public DbSet<PriceList> PriceLists { get; set; }
    }
}
