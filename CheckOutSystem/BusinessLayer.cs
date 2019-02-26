using System;
using System.Collections.Generic;

namespace CheckOutSystem
{
    internal class BusinessLayer
    {
        /// <summary>
        /// section 1 
        /// </summary>
        
         IList<Product> listOfProducts = new List<Product>();
        public void AddToBasket(Product product) => listOfProducts.Add(product);

        public void DeleteFromBasket(Product product)
        {
            if (listOfProducts.Count > 0)
            {
                listOfProducts.Remove(product);
            }

        }

        public void UpdateBasket(Product product, int updateQuantity) => product.Quantity = updateQuantity;

        /// <summary>
        /// section 2
        /// </summary>
        public double TotalCost()
        {
            double totalCost = 0;
            double subTotal = 0;
            try
            {
                if (listOfProducts.Count > 0)
                {
                    foreach (var item in listOfProducts)
                    {
                        subTotal = item.Price * item.Quantity;
                        totalCost = totalCost + subTotal;
                    }
                }
                return totalCost;
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
