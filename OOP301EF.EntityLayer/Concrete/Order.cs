using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP301EF.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product{ get; set; }


    }
}
