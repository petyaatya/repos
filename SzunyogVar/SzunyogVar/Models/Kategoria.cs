using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using SzunyogVar.ViewModel;

namespace SzunyogVar.Models
{
    public class Kategoria : INotifyPropertyChanged
    {
        private int categoryID;
        public int CategoryID
        {
            get { return categoryID; }
            set
            {
                categoryID = value;
                OnPropertyChanged("categoryID");
            }
        }
        private string categoryName;
        public String CategoryName
        {
            get { return categoryName; }
            set
            {
                categoryName = value;
                OnPropertyChanged("categoryName");
            }

        }

        public Kategoria(int categoryID, string categoryName)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
        }

        public Kategoria(string categoryName)
        {
            this.categoryName = categoryName;
        }

       

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

        private System.Collections.IEnumerable kategoriaViewModel;

        public System.Collections.IEnumerable KategoriaViewModel { get => kategoriaViewModel; set => SetProperty(ref kategoriaViewModel, value); }
    }
}


