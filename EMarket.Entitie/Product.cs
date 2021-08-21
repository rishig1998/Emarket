using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMarket.Entitie
{
    public class Product:BaseEntitie
    {
        public Category category { get; set; }
        public decimal Price { get; set; }
    }
}
