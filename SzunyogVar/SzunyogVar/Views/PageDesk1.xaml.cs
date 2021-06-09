using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SzunyogVar.Models;
using SzunyogVar.ViewModel;

namespace SzunyogVar
{
    /// <summary>
    /// Interaction logic for PageDesk1.xaml
    /// </summary>
    public partial class PageDesk1 : Page
    {
        
        CategoryDataAccess dataAccess;
        public List<string> items = new List<string>();
        String connectionString = "Server=.;Database=szunyogvar;Initial Catalog=szunyogvar;Trusted_Connection=True;";


        public PageDesk1()
        {
            InitializeComponent();


        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            DeskClearConfirmWindow dccw = new DeskClearConfirmWindow();
            dccw.Show();
            txtPrintable.Clear();
        }

        private void lstCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
                    //private void PageDesk1_Loaded(object sender, RoutedEventArgs e) {
                    //    BindData();

                    //}

                    //private void BindData()
                    //{
                    //    SqlDataAdapter adapter = new SqlDataAdapter();
                    //    adapter.SelectCommand = command;
                    //    command = new SqlCommand(sql, connection);
                    //}

                }
            }
        }
    }
}
    
