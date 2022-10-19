using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBoston.DATA
{
    public class Order
    {
        public int TableNo { get; set; }
        public OrderState State { get; set; } = OrderState.Active;
        public DateTime? StartTime { get; set; } = DateTime.Now;
        public DateTime? EndTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; } =new List<OrderDetail>();


        public string TotalPriceTRY => TotalPrice().ToString("c2");
        public decimal TotalPrice()
        {
            decimal TotalPrice=0;
            foreach (var item in OrderDetails)
            {
                TotalPrice += item.TotalPrice();
            }
            return TotalPrice;
        }
        public decimal PaidAmount { get;set; }
    }
}




