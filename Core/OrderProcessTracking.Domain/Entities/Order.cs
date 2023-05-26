using OrderProcessTracking.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessTracking.Domain.Entities
{
    public class Order : BaseEntity
    {
        public double TotalAmount { get; set; }
        public string Description { get; set; }
        public OrderState State { get; set; }
        public Guid SellerId { get; set; }
        public Seller Seller { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
    }
    public enum OrderState
    {
        Bekliyor,
        Yolda,
        Tamamlandı,
    }
}
