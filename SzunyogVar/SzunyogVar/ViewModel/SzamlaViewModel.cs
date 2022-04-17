using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzunyogVar.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace SzunyogVar.ViewModel
{
     class SzamlaViewModel
    {
        private IList<Szamla> _SzamlaList;

        public SzamlaViewModel()
        {
            _SzamlaList = new List<Szamla>();
        }
    }
}
