using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Entity
{
    public class Product:BaseEntity
    {

        //public int ID { get; set; }
        //public string Name { get; set; }
        //public string Description { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }

    }
}
