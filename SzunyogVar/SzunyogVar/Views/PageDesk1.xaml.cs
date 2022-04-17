using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using SzunyogVar.Models;
using SzunyogVar.Data;
using SzunyogVar.ViewModel;

namespace SzunyogVar
{
    /// <summary>
    /// Interaction logic for PageDesk1.xaml
    /// </summary>
    public partial class PageDesk1 : Page
    {

        public List<string> CategoryList = new List<string>();


        public SqlConnection Conn { get; set; }

        
        Models.Menu menu1 = new Models.Menu();
        //Menu menu1;
        Kategoria kategoria;
        KategoriaViewModel _viewModel=new KategoriaViewModel();
        

        public PageDesk1()
        {
            InitializeComponent();
            KategoriaFeltoltes();
            FillMenuItem();
        }

        
        public void KategoriaFeltoltes()
        {
            InitializeComponent();
            this.DataContext = _viewModel;
            //var kategoriaLista = new List<Kategoria>();
            lstCategory.Items.Refresh();
           
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            DeskClearConfirmWindow dccw = new DeskClearConfirmWindow();
            dccw.Show();

        }

        public void FillMenuItem()
        {
            lstCategory.Items.Refresh();

            //string sql = "SELECT menuitemname, itemPrice FROM menu";
            //DataTableHandler.GetData(sql);

            //foreach (DataRow row in DataTableHandler.GetData(sql).Rows)
            //{

            //    menu1.MenuItemName = row["MenuItemName"].ToString();
            //    menu1.ItemPrice = Convert.ToDecimal(row["itemPrice"].ToString());

            //    //Console.WriteLine(menu1.MenuItemName + "" + menu1.ItemPrice);
            //    lstMenuItem.Items.Add(menu1.MenuItemName);
            //    //lstMenuItem.Items.Add(menu1.MenuItemName + "-" + menu1.ItemPrice);

            //}

        }

        public void lstCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstMenuItem.Items.Clear();
            lstMenuItem.Items.Refresh();

            string chosenCategory = lstCategory.SelectedValue.ToString();
            Console.WriteLine(chosenCategory);
            //String sql = "select * from menu join menuCategory on menu.menuitemcategoryID = menuCategory.categoryID where categoryName = '" + chosenCategory + "'";

            //DataTableHandler.GetData(sql);

            //foreach (DataRow row in DataTableHandler.GetData(sql).Rows)
            //{

            //    menu1.MenuItemName = row["MenuItemName"].ToString();
            //    menu1.ItemPrice = Convert.ToDecimal(row["itemPrice"].ToString());

            //    //Console.WriteLine(menu1.MenuItemName + "" + menu1.ItemPrice);
            //    lstMenuItem.Items.Add(menu1.MenuItemName);
            //    //lstMenuItem.Items.Add(menu1.MenuItemName + "-" + menu1.ItemPrice);
            //}


        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            string chosenItem = lstMenuItem.SelectedValue.ToString();
            //string sql = "select * from menu where menuitemname='" + chosenItem + "'";
            //DataTableHandler.GetData(sql);


            Console.WriteLine(menu1.MenuItemName + menu1.ItemPrice);

            //Menu menu1 = (Menu)lstMenuItem.SelectedValue;

            DataTable dt = new DataTable();


            txtPrintable.Items.Add(dt.Rows.Add(menu1.MenuItemName.ToString()));
            txtPrintable.Items.Add(dt.Rows.Add(menu1.ItemPrice.ToString()));
            dt.Columns.Add(menu1.MenuItemName);

        }
    }


}

