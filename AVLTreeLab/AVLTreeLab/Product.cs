using System;
using Binary_Search_Tree;

namespace AVLTreeLab
{ 
    public class Product : IComparable
    {
        private string ProductNO;
        public int occurrences;

        public Product(string ProductNo, int occurrences )
        {
            this.ProductNO = ProductNO;
            this.occurrences = occurrences;
        }

        public int CompareTo(Object obj)
        {
            Product other = (Product)obj;
            return productNO.CompareTo(other.productNO);
        }
        public int productNO
        {
            get { return productNO; }
            set { productNO = value; }
        }
        public int Occurrences
        {
            get { return Occurrences; }
            set { Occurrences = value; }
        }

        public string ToString()
        {
            return $"{ProductNO} {Occurrences}";
        }
    }
}