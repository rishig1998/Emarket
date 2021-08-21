using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMarket.Entitie
{
    public class Category:BaseEntitie
    {
        public List<Product> products { get; set; }
    }
}
