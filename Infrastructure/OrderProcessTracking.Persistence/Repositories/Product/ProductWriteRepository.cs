using Microsoft.EntityFrameworkCore;
using OrderProcessTracking.Application.Repositories;
using OrderProcessTracking.Domain.Entities;
using OrderProcessTracking.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessTracking.Persistence.Repositories
{
    internal class ProductWriteRepository : WriteRepository<Product>,IProductWriteRepository
    {
        public ProductWriteRepository(dbContext context) : base(context) { }
    }
}
