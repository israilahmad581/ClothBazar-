using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClothBazar.Entity;
using ClothBazar.Services;

namespace ClothBazar.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
       ProductsService Pservice = new ProductsService();

        public ActionResult Index()
        {
            var pcategories = Pservice.GetAllProduct();

            return View(pcategories);
        }


        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            Pservice.SaveCategory(p);
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int ID)
        {
            var p = Pservice.GetProductByID(ID);
            return View(p);

        }

        [HttpPost]
        public ActionResult Edit(Product p)
        {
            Pservice.Updateproduct(p);
            return RedirectToAction("Index");

        }


        //public ActionResult Detail(int ID)
        //{
        //    var p = Pservice.GetProductByID(ID);
        //    return View(p);

        //}



        //[HttpPost]
        //public ActionResult Detail(Product p)
        //{

        //    Pservice.GetProductDetail(p);
        //    return RedirectToAction("Index");

        // }


        public ActionResult Delete(int ID)
        {
            var p = Pservice.GetProductByID(ID);
            return View(p);
        }
        [HttpPost]
        public ActionResult Delete(Product p)
        {
            Pservice.DeleteProduct(p.ID);
            return RedirectToAction("Index");


        }





        }
    }