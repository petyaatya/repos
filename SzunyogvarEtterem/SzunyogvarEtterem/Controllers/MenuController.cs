using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using SzunyogvarEtterem.Datas;
using SzunyogvarEtterem.Models;

namespace SzunyogvarEtterem.Controllers
{
    public class MenuController : Controller
    {
        // GET: MenuController
        public ActionResult Index()
        {
           
            List<MenuItemModel> menuItemList = DBHandler.GetMenuItems();//
            
            return View(menuItemList);
        }

        // GET: MenuController/Details/5
        public ActionResult Details(int id)
        {
            MenuItemModel menuItemModel = DBHandler.MenuitemDetails(id);
            return View("Details",menuItemModel);
        }

        // GET: MenuController/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CreateDataList()
        {
            MenuItemModel menuItemModel = new MenuItemModel();
             List<MenuItemModel> menuItemList= DBHandler.GetMenuCategories();
            return View(menuItemList);
           
        }

        // POST: MenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MenuItemModel menuItemModel)
        {
            try
            {
            DBHandler.CreateMenuItemModel(menuItemModel);
                List<MenuItemModel> menuItemList = DBHandler.GetMenuItems();
                return View("Index", menuItemList);
            }
            catch
            {
                return View("Problem");
            }
        }

        // GET: MenuController/Edit/5
        public ActionResult Edit(int id)
        {
            MenuItemModel menuItemModel = DBHandler.GetMenuEdit(id);
            return View("Edit",menuItemModel);
        }

        // POST: MenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MenuItemModel menuItemModel)
        {
            try
            {
                DBHandler.MenuEdit(id, menuItemModel);
                List<MenuItemModel> menuItemList = DBHandler.GetMenuItems();
                return View("Index", menuItemList);
            }
            catch
            {
                return View("Problem");
            }
        }

        // GET: MenuController/Delete/5
        public ActionResult Delete(int id)
        {
            MenuItemModel menuItemModel = DBHandler.MenuitemDetails(id);
            return View(menuItemModel);
        }

        // POST: MenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                MenuItemModel menuItemModel = DBHandler.DeleteMenuItemModel(id);
                List<MenuItemModel>menuItemList= DBHandler.GetMenuItems();
                return View("Index",menuItemList);
            }
            catch
            {
                return View();
            }
        }
    }
}
