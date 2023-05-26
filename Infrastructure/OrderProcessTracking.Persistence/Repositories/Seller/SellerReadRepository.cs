using Microsoft.EntityFrameworkCore;
using OrderProcessTracking.Application.Repositories;
using OrderProcessTracking.Domain.Entities;
using OrderProcessTracking.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessTracking.Persistence.Repositories
{
    internal class SellerReadRepository : ReadRepository<Seller>, ISellerReadRepository
    {
        public SellerReadRepository(dbContext context) : base(context) { }

    }
}
