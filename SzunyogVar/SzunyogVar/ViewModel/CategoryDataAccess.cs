using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzunyogVar.Models;


namespace SzunyogVar.ViewModel
{
    
    public class CategoryDataAccess
    {
       
        public int categoryId;
        public String categoryName;

        private CategoryDataConnection _categoryDataConnection;
        public CategoryDataAccess(CategoryDataConnection categoryDataConnection)
        {
            _categoryDataConnection = categoryDataConnection;
            _categoryDataConnection.OpenConnection(categoryName);
        
        }
        //public List<Kategoria> GetKategoria(string categoryName)
        //{
        //    using (SqlConnection connection = new SqlConnection(Helper.CnnVal("SzunyogVar"))) {
        //        var output =  connection.Query<Kategoria>("select * from menuCategory").ToList();
        //        return output;
        //    }
        //}


    }
}
