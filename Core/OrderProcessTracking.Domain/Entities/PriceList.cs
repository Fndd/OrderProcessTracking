using OrderProcessTracking.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessTracking.Domain.Entities
{
    public class PriceList : BaseEntity
    {
        public double Price { get; set; }
        public Guid SellerId { get; set; }
        public Seller Seller { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
