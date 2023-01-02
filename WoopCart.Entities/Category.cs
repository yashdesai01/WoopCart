using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoopCart.Entities
{
    public class Category : BaseEntitity
    {
        public List<Product> products  { get; set; }
    }
}
