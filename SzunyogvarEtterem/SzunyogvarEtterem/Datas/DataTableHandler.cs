using System.Data;
using Microsoft.Data.SqlClient;

namespace SzunyogvarEtterem
{
    public class DataTableHandler
    {
        static string connString = @"Server=.\SQLEXPRESS;Database=szunyogvar;Trusted_Connection=True";
        public static DataTable GetData(string sql, int timeout = 0)
        {

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
        public static string GetSingleField(String sql)
        {


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