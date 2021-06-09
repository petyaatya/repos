using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzunyogVar.Models
{
    public class CategoryDataConnection
    {
        public List<string> items = new List<string>();

        public void OpenConnection(string connectionString)
        {
            using (var sqlConn = new SqlConnection(connectionString))
            {

                string query = "SELECT categoryName FROM menuCategory";
                var cmd = new SqlCommand(query, sqlConn);
                cmd.CommandType = CommandType.Text;
                sqlConn.Open();
                using (SqlDataReader objReader = cmd.ExecuteReader())
                {


                    if (objReader.HasRows)
                    {
                        while (objReader.Read())
                        {
                            //I would also check for DB.Null here before reading the value.
                            string item = objReader.GetString(objReader.GetOrdinal("Column1"));
                            items.Add(item);



                        }


                    }
                }
            }
        }
    }
}
    

