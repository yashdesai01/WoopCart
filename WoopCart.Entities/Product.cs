using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoopCart.Entities
{
    public class Product : BaseEntitity
    {
        public decimal  Price { get; set; }
        public Category Category { get; set; }
        
    }
}
