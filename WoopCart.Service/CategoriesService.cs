using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoopCart.Database;
using WoopCart.Entities;

namespace WoopCart.Service
{
    public class CategoriesService
    {
        public Category GetCategory(int ID)
        {
            using (var context = new WCContext())
            {
                return context.Category.Find(ID);
            }
        }
        public List<Category> GetCategorys()
        {
            using (var context = new WCContext())
            {
                return context.Category.ToList();
            }
        }
        public void SaveCategory(Category category)
         {
            using(var context = new WCContext())
            {
                context.Category.Add(category);
                context.SaveChanges();
            }
         }

        public void UpdateCategory(Category category)
        {
            using (var context = new WCContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteCategory(int ID)
        {
            using (var context = new WCContext())
            {
                var category = context.Category.Find(ID);
                //context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                context.Category.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
