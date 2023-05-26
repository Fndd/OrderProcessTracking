using OrderProcessTracking.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessTracking.Domain.Entities
{
    public class DemandLine : BaseEntity
    {
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public double Amount { get; set; }
        public Guid DemandId { get; set; }
        public Demand Demand { get; set; }
    }
}
