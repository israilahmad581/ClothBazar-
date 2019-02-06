using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClothBazar.Entity;

namespace ClothBazar.Database
{
    public class CBContext:DbContext,IDisposable
    {


        public CBContext() : base("Conn")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }



    }
}
