using ClothBazar.Entity;
using ClothBazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService categyservice = new CategoriesService();

        public ActionResult Index()
        {
            var categories = categyservice.GetAllllCategory();

            return View(categories);
        }


        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create( Category category)
        {
            categyservice.SaveCategory(category);
            return RedirectToAction("Index");
        }



        public ActionResult Edit(int ID)
        {
            var category = categyservice.GetCategoryByID(ID);
            return View(category);

        }
         
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categyservice.Updatecategory(category);
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int ID)
        {
            var category = categyservice.GetCategoryByID(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
         // categyservice.GetCategoryByID(category.ID);
            categyservice.Deletecategory(category.ID);
           return RedirectToAction("Index");
           
        }




    }
}