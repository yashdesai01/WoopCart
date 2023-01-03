using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WoopCart.Entities;
using WoopCart.Service;

namespace WoopCart.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService categoriesService = new CategoriesService();
        
        public ActionResult Index()
        {
            var category = categoriesService.GetCategorys();
            return View(category);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoriesService.SaveCategory(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = categoriesService.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoriesService.UpdateCategory(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var Category = categoriesService.GetCategory(ID);
            return View(Category);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            category = categoriesService.GetCategory(category.ID);
            categoriesService.DeleteCategory(category.ID);
            return RedirectToAction("Index");
        }
    }
}