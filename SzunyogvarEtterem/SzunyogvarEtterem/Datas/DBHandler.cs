using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.Data.SqlClient;
using SzunyogvarEtterem.Models;

namespace SzunyogvarEtterem.Datas
{
    public class DBHandler
    {

        public static List<MenuItemModel> GetMenuItems()
        {
            DataTable dt = new DataTable();
            dt = DataTableHandler.GetData("SELECT * from menu");
            List<MenuItemModel> menuItemList = new List<MenuItemModel>();

            foreach (DataRow dr in dt.Rows)
            {
                MenuItemModel menuItemModel = new MenuItemModel();
                menuItemModel.MenuItemName = dr["menuitemname"].ToString();
                menuItemModel.Price = Convert.ToInt32(dr["itemprice"].ToString());
                menuItemList.Add(menuItemModel);
            }
            return menuItemList;
        }
        public static List<CategoryModel> GetCategories() {
        DataTable dt = new DataTable();
            dt=DataTableHandler.GetData("SELECT * from menuCategory");
            List<CategoryModel> categoryList = new List<CategoryModel>();

            foreach (DataRow dr in dt.Rows)
            {
            CategoryModel categoryModel = new CategoryModel();
                categoryModel.CategoryName = dr["categoryName"].ToString();
                categoryList.Add(categoryModel);
            
            }

            return categoryList;
        }


    }


}
