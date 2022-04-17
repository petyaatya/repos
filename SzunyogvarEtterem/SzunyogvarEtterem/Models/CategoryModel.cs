namespace SzunyogvarEtterem.Models
{
    public class CategoryModel
    {
        private int categoryID;
        public int CategoryID
        {
            get { return categoryID; }
            set
            {
                categoryID = value;
                //OnPropertyChanged("categoryID");
            }
        }
        private string categoryName;
        public String CategoryName
        {
            get { return categoryName; }
            set
            {
                categoryName = value;
                //OnPropertyChanged("categoryName");
            }

        }

        public CategoryModel(int categoryID, string categoryName)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
        }

        public CategoryModel(string categoryName)
        {
            this.categoryName = categoryName;
        }

    }
}
