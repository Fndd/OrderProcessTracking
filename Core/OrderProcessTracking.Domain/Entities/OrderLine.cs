using OrderProcessTracking.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessTracking.Domain.Entities
{
    public class OrderLine : BaseEntity
    {
        public double Quantity { get; set; }
        public double Amount { get; set; }
        public int ProductId { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}
