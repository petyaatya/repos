using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SzunyogvarEtterem.Datas;
using SzunyogvarEtterem.Models;

namespace SzunyogvarEtterem.Controllers
{
    public class DeskController : Controller
    {
        // GET: DeskController
        public ActionResult Index()//todo
        {
           
            List<CategoryModel> categoryList = DBHandler.GetCategories();
            
            return View("_CategoryIndex",categoryList);
        }

        public ActionResult IndexMenu()//todo
        {

            List<MenuItemModel> menuItemList = DBHandler.GetMenuItems();

            return View("_MenuItemIndex", menuItemList);
        }
        public ActionResult DeskIndexMenu() {
            List<CategoryModel> categoryList = DBHandler.GetCategories();
            List<MenuItemModel> menuItemList = DBHandler.GetMenuItems();
            return View("DeskIndex",categoryList);
            
        }

        // GET: DeskController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeskController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: DeskController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeskController/Edit/5
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

        // GET: DeskController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeskController/Delete/5
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
