using EMarket.Database;
using EMarket.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMarket.Services
{
    public class EMarketService
    {
      public void Createemarket(Category category)
        {
            using(var context=new EMrketContext())
            {
                context.categories.Add(category);
                context.SaveChanges();
            }
        }
        public List<Category> Showemarket()
        {
            using (var context = new EMrketContext())
            {
                return context.categories.ToList();
             
            }
        }
        public Category Editemarket(int ID)
        {
            using (var context = new EMrketContext())
            {

                return context.categories.Find(ID);
             
            }
        }
        public void Updatemarket(Category category)
        {
            using (var context= new EMrketContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Deleteemarket(int ID)
        {
            using (var context = new EMrketContext())

            {
                var category = context.categories.Find(ID);
                context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
