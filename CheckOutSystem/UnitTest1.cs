using CheckOutSystem;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        public Product productApple;
        public Product productOrange;
         

        [SetUp]
        public void Setup()
        {
            #region Create data
            productApple = new Product
            {
                ProductId = 1001,
                ProductName = "Apple",
                Price = 0.6,
                Quantity = 2
            };
            productOrange = new Product
            {
                ProductId = 1002,
                ProductName = "Orange",
                Price = 0.25,
                Quantity = 1
            };

            #endregion

        }


        [Test]
        public void Test1()
        {
            //To add 2 apples and 1 orange to the basket and verify Total Cost
            BusinessLayer action = new BusinessLayer();
            action.AddToBasket(productApple);
            action.AddToBasket(productOrange);
            double actual = action.TotalCost();
            double expected = 1.45;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test2()
        {
            //To add 2 apples and 1 orange to the basket,
            // then update quantity of apples as 1 and delete the product Orange
            //and Verify Total cost
            BusinessLayer action = new BusinessLayer();
            action.AddToBasket(productApple);
            action.AddToBasket(productOrange);
            action.UpdateBasket(productApple, 1);
            action.DeleteFromBasket(productOrange);
            double actual = action.TotalCost();
            double expected = 0.6;
            Assert.AreEqual(expected, actual);
        }


    }
}