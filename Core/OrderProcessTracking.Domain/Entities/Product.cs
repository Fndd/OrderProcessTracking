using OrderProcessTracking.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessTracking.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public ICollection<Demand> Demands { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<PriceList> PriceLists { get; set; }
    }
}
