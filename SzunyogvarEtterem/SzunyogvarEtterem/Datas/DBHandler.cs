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
using Microsoft.Extensions.Configuration;
using SzunyogvarEtterem.Models;

namespace SzunyogvarEtterem.Datas
{
    public class DBHandler
    {
        
        public static string connString = SETClass.GetConnectionString();
        public CategoryModel model = new CategoryModel();
        public static List<MenuItemModel> GetMenuItems()
        {
            DataTable dt = new DataTable();
            dt = DataTableHandler.GetData("SELECT menuitemID, menuitemname, itemprice, menuCategory.categoryName as 'categoryName' FROM menu join menuCategory on menu.menuitemcategoryID = menuCategory.categoryID");
            List<MenuItemModel> menuItemList = new List<MenuItemModel>();

            foreach (DataRow dr in dt.Rows)
            {
                MenuItemModel menuItemModel = new MenuItemModel();
                menuItemModel.MenuItemID = Convert.ToInt32(dr["menuitemID"]);
                menuItemModel.MenuItemName = dr["menuitemname"].ToString();
                menuItemModel.Price = Convert.ToInt32(dr["itemprice"].ToString());
                menuItemModel.CategoryName = dr["categoryName"].ToString();
                menuItemList.Add(menuItemModel);
            }
            return menuItemList;
        }

        public static MenuItemModel MenuitemDetails(int id) { 
       MenuItemModel menuItemModel = new MenuItemModel();
            menuItemModel.MenuItemID = Convert.ToInt32(DataTableHandler.GetSingleField("SELECT menuitemID from menu where menuitemID=" + id));
            menuItemModel.MenuItemName = DataTableHandler.GetSingleField("SELECT menuitemname from menu where menuitemID=" + id).ToString();
            menuItemModel.Price = Convert.ToInt32(DataTableHandler.GetSingleField("Select itemprice from menu where menuitemID=" + id));
            menuItemModel.CategoryID = Convert.ToInt32(DataTableHandler.GetSingleField("select menuCategory.categoryID FROM menu join menuCategory on menu.menuitemcategoryID = menuCategory.categoryID where menuitemID="+id));
            menuItemModel.CategoryName = DataTableHandler.GetSingleField("select menuCategory.categoryName FROM menu join menuCategory on menu.menuitemcategoryID = menuCategory.categoryID where menuitemID="+id);
            //List<MenuItemModel> menuItemList = new List<MenuItemModel>();
            return menuItemModel;        
        }

        public static List<MenuItemModel> GetMenuCategories() {
            MenuItemModel menuItemModel = new MenuItemModel();
            List<MenuItemModel> menuItemCategoriesList = new List<MenuItemModel>();
            DataTable dt = new DataTable();
            dt=DataTableHandler.GetData("select distinct menuCategory.categoryName as categoryName FROM menu join menuCategory on menu.menuitemcategoryID = menuCategory.categoryID");
            foreach (DataRow dr in dt.Rows)
            {
                menuItemModel.CategoryName = dr["categoryName"].ToString();
                menuItemCategoriesList.Add(menuItemModel);
            }
              return menuItemCategoriesList;
            }

        public static MenuItemModel CreateMenuItemModel(MenuItemModel menuItemModel) {
            using (SqlConnection sqlConnection = new SqlConnection(connString)) {
                string sql = "INSERT INTO dbo.menu(menuitemname,itemprice,menuitemcategoryID) values (@menuitemname,@itemprice,@menuitemcategoryID)";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.Parameters.Add("@menuitemname", System.Data.SqlDbType.VarChar, 1000).Value = menuItemModel.MenuItemName;
                command.Parameters.Add("@itemprice",System.Data.SqlDbType.Int,250).Value=menuItemModel.Price;
                command.Parameters.Add("@menuitemcategoryID", System.Data.SqlDbType.Int,255).Value = menuItemModel.CategoryID;
                sqlConnection.Open();
                command.ExecuteNonQuery();
               }
            return menuItemModel;
        }
        public static MenuItemModel DeleteMenuItemModel(int id) { 
        MenuItemModel menuItemModel = new MenuItemModel();
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                string sql = "Delete from menu where menuitemID=" + id;
                SqlCommand command = new SqlCommand(sql,sqlConnection);
                sqlConnection.Open();
                command.ExecuteNonQuery();
                    }
            return menuItemModel;
        }

        public static List<CategoryModel> GetCategories()
        {
            DataTable dt = new DataTable();
            dt = DataTableHandler.GetData("SELECT * from menuCategory");
            List<CategoryModel> categoryList = new List<CategoryModel>();

            foreach (DataRow dr in dt.Rows)
            {
                CategoryModel categoryModel = new CategoryModel();
                categoryModel.CategoryId = Convert.ToInt32(dr["categoryId"].ToString());
                categoryModel.CategoryName = Convert.ToString(dr["categoryName"]);
                categoryList.Add(categoryModel);
            }
            return categoryList;
        }

        public static CategoryModel GetCategoryDetails(int id)
        {
            CategoryModel categoryModel = new CategoryModel();
            categoryModel.CategoryId = Convert.ToInt32(DataTableHandler.GetSingleField("SELECT categoryId from menuCategory WHERE categoryID=" + id));//categoryModel.CategoryName = DataTableHandler.GetSingleField("SELECT categoryName from menuCategory WHERE categoryID=categoryID");
            categoryModel.CategoryName = Convert.ToString(DataTableHandler.GetSingleField("SELECT categoryName from menuCategory WHERE categoryID=" + id));
            return categoryModel;
        }
        public static CategoryModel Create(CategoryModel categoryModel)
        {
            using (SqlConnection myConnection = new SqlConnection(connString))
            {
                string sql = "INSERT INTO dbo.menuCategory(categoryName) VALUES (@categoryName)";
                SqlCommand command = new SqlCommand(sql, myConnection);
                command.Parameters.Add("@categoryName", System.Data.SqlDbType.VarChar, 1000).Value = categoryModel.CategoryName;

                myConnection.Open();
                command.ExecuteNonQuery();
            }

            return categoryModel;//todo meghivni controllerbe
        }
        //DETAILS

        public static CategoryModel Delete(int id)
        {
            CategoryModel categoryModel = new CategoryModel();
            using (SqlConnection myConnection = new SqlConnection(connString))
            {
                string sql = "Delete from dbo.menuCategory where categoryID="+id;
                SqlCommand command = new SqlCommand(sql,myConnection);
              

                myConnection.Open();
                command.ExecuteNonQuery();
            }
                return categoryModel;
        }
        public static MenuItemModel GetMenuEdit(int id)
        {
            MenuItemModel menuItemModel = new MenuItemModel();
            menuItemModel.MenuItemID = Convert.ToInt32(DataTableHandler.GetSingleField("SELECT menuitemID from menu where menuitemID=" + id));
            menuItemModel.MenuItemName = DataTableHandler.GetSingleField("SELECT menuitemname from menu where menuitemID=" + id).ToString();
            menuItemModel.Price = Convert.ToInt32(DataTableHandler.GetSingleField("Select itemprice from menu where menuitemID=" + id));
            menuItemModel.CategoryID = Convert.ToInt32(DataTableHandler.GetSingleField("select menuCategory.categoryID FROM menu join menuCategory on menu.menuitemcategoryID = menuCategory.categoryID where menuitemID=" + id));
            menuItemModel.CategoryName = DataTableHandler.GetSingleField("select menuCategory.categoryName FROM menu join menuCategory on menu.menuitemcategoryID = menuCategory.categoryID where menuitemID=" + id);

            return menuItemModel;
        }
        public static MenuItemModel MenuEdit(int id, MenuItemModel menuItemModel) { 
        var newId = GetMenuEdit(id).MenuItemID;
            using (SqlConnection myConnection = new SqlConnection(connString)) {
                string sql = "UPDATE menu set menuitemname=@menuitemname, itemprice=@itemprice, menuitemcategoryID=@menuitemcategoryID where menuitemid=" + newId;
               SqlCommand command =new SqlCommand(sql,myConnection);
                command.Parameters.Add("@menuitemname", System.Data.SqlDbType.VarChar, 1000).Value = menuItemModel.MenuItemName;
                command.Parameters.Add("@itemprice", System.Data.SqlDbType.Int, 250).Value = menuItemModel.Price;
                command.Parameters.Add("@menuitemcategoryID", System.Data.SqlDbType.Int, 255).Value = menuItemModel.CategoryID;
                myConnection.Open();
                command.ExecuteNonQuery();
            }
            return menuItemModel;
            
        }

        public static CategoryModel GetEdit(int id)
        {
            CategoryModel categoryModel = new CategoryModel();
            categoryModel.CategoryId = Convert.ToInt32(DataTableHandler.GetSingleField("SELECT categoryId from menuCategory WHERE categoryID=" + id));//categoryModel.CategoryName = DataTableHandler.GetSingleField("SELECT categoryName from menuCategory WHERE categoryID=categoryID");
            categoryModel.CategoryName = Convert.ToString(DataTableHandler.GetSingleField("SELECT categoryName from menuCategory WHERE categoryID=" + id));
            return categoryModel;
        }
        public static CategoryModel Edit(int id,CategoryModel categoryModel)
        {
           var newId = GetEdit(id).CategoryId;
            using (SqlConnection myConnection = new SqlConnection(connString))
            {
                 string sql = "UPDATE dbo.menuCategory set categoryName=@categoryName where categoryID=" + newId;
                SqlCommand command = new SqlCommand(sql, myConnection);
                command.Parameters.Add("@categoryName", System.Data.SqlDbType.VarChar, 1000).Value = categoryModel.CategoryName;

                myConnection.Open();
                command.ExecuteNonQuery();
            }

            return categoryModel;//todo meghivni controllerbe
        }

            
        }
    }




