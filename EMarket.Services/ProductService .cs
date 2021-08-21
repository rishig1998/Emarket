using EMarket.Database;
using EMarket.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMarket.Services
{
    public class ProductService
    {
      public void Createproduct(Product product)
        {
            using(var context=new EMrketContext())
            {
                context.products.Add(product);
                context.SaveChanges();
            }
        }
        public List<Product> Showproduct()
        {
            using (var context = new EMrketContext())
            {
                return context.products.ToList();
             
            }
        }
        public Product Editproduct(int ID)
        {
            using (var context = new EMrketContext())
            {

                return context.products.Find(ID);
             
            }
        }
        public void Updatproduct(Product product)
        {
            using (var context= new EMrketContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Deleteproduct(int ID)
        {
            using (var context = new EMrketContext())

            {
                var category = context.products.Find(ID);
                context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
