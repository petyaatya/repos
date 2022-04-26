using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SzunyogvarEtterem.Datas;
using SzunyogvarEtterem.Models;

namespace SzunyogvarEtterem.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            CategoryModel categoryModel = DBHandler.GetCategoryDetails(id);
            return View("Details",categoryModel);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
          return View("CreateCategoryView");
        }
        public ActionResult GetCategory()
        {
            List<CategoryModel> categoryList = DBHandler.GetCategories();
            return View("Index",categoryList);
        }

        public ActionResult DeleteCategory(int id) {
            //"SELECT * from menuCategory WHERE categoryID=@id"
            return View();
        }

        
        
        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryModel categoryModel)
        {
            
                DBHandler.Create(categoryModel);

            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Index", categoryModel);//detailsel működik.
            }

        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
