using System;
using System.Collections.Generic;

namespace CheckOutSystem
{
    public class Product
    {
        public int ProductId;
        public string ProductName;
        public double Price;
        public int Quantity;
        public IList<Product> listOfProducts;
    }
}
