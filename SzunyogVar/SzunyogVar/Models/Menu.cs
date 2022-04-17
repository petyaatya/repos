using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzunyogVar.Models
{
    public class Menu :INotifyPropertyChanged
    {
        public int MenuItemID { get; set; }
        public String MenuItemName { get; set; }
        //public Byte HalfOrNot { get; set; }
        public Decimal ItemPrice { get; set; }
        public List<Menu> menulista = new List<Menu>() { };
        
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) {
            if (PropertyChanged !=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        
        }

        //public Menu(string menuItemName, decimal itemPrice)
        //{
        //    MenuItemName = menuItemName;
        //    ItemPrice = itemPrice;
        //}

        public Menu()
        { }
        //public double CalculateHalfFood()
        //{
        //    return itemPrice / 2;
        //}
        //public event 
    }
}
