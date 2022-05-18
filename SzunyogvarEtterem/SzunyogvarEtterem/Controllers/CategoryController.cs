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

        
        
        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryModel categoryModel)
        {

            try
            {
                DBHandler.Create(categoryModel);
            List<CategoryModel> categoryList = DBHandler.GetCategories();
                return View("Index",categoryList);//detailsel működik.
                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Problem");
            }

        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            CategoryModel categoryModel = DBHandler.GetEdit(id);
            return View("Edit",categoryModel);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,CategoryModel categoryModel)
        //public ActionResult Edit(CategoryModel categoryModel)
        {
            
            DBHandler.Edit(id,categoryModel);
            List<CategoryModel> categoryList = DBHandler.GetCategories();

                return View("Index",categoryList);
            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //}
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            CategoryModel categoryModel = DBHandler.GetCategoryDetails(id);
           
            return View(categoryModel);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                CategoryModel categoryModel = DBHandler.Delete(id);
                List<CategoryModel> categoryList = DBHandler.GetCategories();
                return View("Index", categoryList);

            }
            catch
            {
                return View("Problem");
            }
        }
    }
}
