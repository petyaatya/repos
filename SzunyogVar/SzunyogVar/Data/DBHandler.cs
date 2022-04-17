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


namespace SzunyogVar.Data
{

    public class DBHandler
    {

        public static string GetSingleField(String sql)
        {
            string connString = SETClass.GetConnectionString();

            using (SqlConnection myConnection = new SqlConnection(connString))
            {
                using (SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, myConnection))
                {
                    using (DataTable dtData = new DataTable())
                    {
                        myDataAdapter.Fill(dtData);
                        if (dtData.Rows.Count > 0)
                        {
                            return dtData.Rows[0][0].ToString();
                        }
                        else
                        {
                            return "";
                        }
                    }

                }

            }


        }



    }


}