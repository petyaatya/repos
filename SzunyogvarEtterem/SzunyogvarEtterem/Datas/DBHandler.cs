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
        public CategoryModel model = new CategoryModel();
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
          //  var idCount= DBHandler.GetCategories().Count();
             //   categoryModel.CategoryId = idCount + 1;
            string connString = SETClass.GetConnectionString();
            using (SqlConnection myConnection = new SqlConnection(connString))
            {
                string sql = "INSERT INTO dbo.menuCategory(categoryName) VALUES (@categoryName)";
                SqlCommand command = new SqlCommand(sql, myConnection);
                command.Parameters.Add("@categoryName", System.Data.SqlDbType.VarChar,1000).Value = categoryModel.CategoryName;

                myConnection.Open();
                command.ExecuteNonQuery();
            }

            return categoryModel;//todo meghivni controllerbe
            }
            //DETAILS
        }

    }



