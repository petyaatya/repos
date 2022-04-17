using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzunyogVar.ViewModel;

namespace SzunyogVar.Data
{
    public class DataTableHandler
    {
        public static DataTable GetData(string sql, int timeout = 0)
        {
            string connString = SETClass.GetConnectionString();
            using (SqlConnection myConnection = new SqlConnection(connString))
            {
                using (SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, myConnection))
                {
                    using (DataTable dtData = new DataTable())
                    {
                        if (timeout > 0)
                        {
                            myDataAdapter.SelectCommand.CommandTimeout = timeout;
                        }
                        myDataAdapter.Fill(dtData);
                        return dtData;

                    }
                }

            }
            
        }

        
    }
}