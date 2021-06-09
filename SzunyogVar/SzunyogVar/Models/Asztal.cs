using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzunyogVar.Models
{
    public class Asztal
    {
        public int menuItemID { get; set; }
        public String menuItemName { get; set; }
        public Byte halfOrNot { get; set; }
        public Decimal itemPrice { get; set; }

        //public double CalculateHalfFood()
        //{
        //    return itemPrice / 2;
        //}


    }
}
