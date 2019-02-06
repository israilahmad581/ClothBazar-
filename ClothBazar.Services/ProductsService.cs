using ClothBazar.Database;
using ClothBazar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Services
{
   public class ProductsService
    {
        public List<Product> GetAllProduct()
        {
            using (var context = new CBContext())
            {

                return context.Products.ToList();

            }

        }
        public void SaveCategory(Product product)
        {
            using (var context = new CBContext())
            {
                Product pat = new Product();
                pat.Name = product.Name;
                pat.Description = product.Description;
                pat.Price = product.Price;
           
                pat.Category = product.Category;
                context.Products.Add(pat);
                context.SaveChanges();
            }

        }

        public void Updateproduct(Product p)
        {
            using (var context = new CBContext())
            {
                context.Entry(p).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }

        }
        public Product GetProductByID(int ID)
        {
            using (var context = new CBContext())
            {

                return context.Products.Find(ID);

            }
        }
        //public Product GetProductDetail(int ID)
        //{
        //    using (var context = new CBContext())
        //    {

        //        return context.Products.Find(ID);

        //    }
        //}




        public void DeleteProduct(int ID)
        {
            using (var context = new CBContext())
            {
                //  context.Entry(category).State = System.Data.Entity.EntityState.Deleted;

                var p = context.Products.Find(ID);
                context.Products.Remove(p);
                context.SaveChanges();
            }

        }







    }
}
