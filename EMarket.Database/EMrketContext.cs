using EMarket.Entitie;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMarket.Database
{
    public class EMrketContext:DbContext
    {
        public EMrketContext():base("EMarket")
        {

        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
