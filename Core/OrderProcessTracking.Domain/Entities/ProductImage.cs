using OrderProcessTracking.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessTracking.Domain.Entities
{
    public class ProductImage : BaseEntity
    {
        public string Path { get; set; }
        public string Title { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
