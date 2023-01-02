using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoopCart.Entities;

namespace WoopCart.Database
{
    public class WCContext : DbContext, IDisposable
    {
        public WCContext() : base("WoopCartConnection")
        {

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
