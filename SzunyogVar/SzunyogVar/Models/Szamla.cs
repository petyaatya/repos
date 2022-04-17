using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SzunyogVar.Models
{
   public class Szamla : INotifyPropertyChanged
    {
        public int SzamlaSzama { get; set; }
        public String menuItemName { get; set; }
        public decimal itemPrice { get; set; }
        public int AsztalSzama { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }

        public decimal Osszeg(){
            return itemPrice+=itemPrice;
}
    }
}
