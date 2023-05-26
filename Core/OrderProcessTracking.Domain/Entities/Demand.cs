using OrderProcessTracking.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessTracking.Domain.Entities
{
    public class Demand : BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid SellerId { get; set; }
        public Seller Seller { get; set; }
        public ICollection<DemandLine> DemandLines { get; set; }
    }
}
