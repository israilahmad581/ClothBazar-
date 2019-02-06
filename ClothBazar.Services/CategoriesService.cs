using ClothBazar.Database;
using ClothBazar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Services
{
    public class CategoriesService
    {

     

        public List<Category> GetAllllCategory()
        {
            using (var context = new CBContext())
            {
                 
                return context.Categories.ToList();
                
            }

        }
        public void SaveCategory(Category category)
        {
            using (var context = new CBContext())
            {
                Category cat = new Category();
                cat.Name = category.Name;
                cat.Description = category.Description;
                context.Categories.Add(cat);
                context.SaveChanges();
            }

        }
        public void Updatecategory(Category category)
        {
            using (var context = new CBContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }

        }
        public Category GetCategoryByID(int ID)
        {
            using (var context = new CBContext())
            {

                return context.Categories.Find(ID);

            }
        }

        public void Deletecategory(int ID)
        {
            using (var context = new CBContext())
            {
              //  context.Entry(category).State = System.Data.Entity.EntityState.Deleted;

                var category = context.Categories.Find(ID);
                context.Categories.Remove(category);
                context.SaveChanges();
            }

        }


    }
}
