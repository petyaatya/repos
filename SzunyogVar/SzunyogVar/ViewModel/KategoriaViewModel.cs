using System.Collections.Generic;
using SzunyogVar.Data;
using SzunyogVar.Models;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections;
using System.Windows.Input;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SzunyogVar.ViewModel
{
    class KategoriaViewModel
    {


        Kategoria kategoria;


        //public KategoriaViewModel(Kategoria kategoria)
        //{
        //    this.kategoria = kategoria;
        //}
        //public KategoriaViewModel() { 
        //_Kategoriak=new List<Kategoria>();
        //}

        //Kategoria kategoria;
        private IList<Kategoria> _Kategoriak
        {
            get { return _Kategoriak; }
            set { _Kategoriak = value; }
        }
        public List<Kategoria> _KategoriaList
        {
            get { return _KategoriaList; }
            set { _KategoriaList = value; }
        }

        
        
        
        public IList<Kategoria> KategoriaFeltoltes()
        {
            
            string sql = "select categoryName from menuCategory";
            //_Kategoriak.Clear();

          foreach (DataRow categoryRow in DataTableHandler.GetData(sql).Rows)
            {

                //CategoryID = Convert.ToInt32(categoryRow["CategoryID"]);
                kategoria.CategoryName = categoryRow["categoryName"].ToString();
                
                //_KategoriaList.Add(new Kategoria(CategoryID, CategoryName));
                _Kategoriak.Add(new Kategoria(kategoria.CategoryName));
                _KategoriaList.Add(new Kategoria(kategoria.CategoryName));
                
            }
            return _Kategoriak;
        }


        
    }
}
