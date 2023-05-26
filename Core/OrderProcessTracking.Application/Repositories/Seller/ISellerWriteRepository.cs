﻿using OrderProcessTracking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessTracking.Application.Repositories
{
    public interface ISellerWriteRepository : IWriteRepository<Seller>
    {
    }
}
