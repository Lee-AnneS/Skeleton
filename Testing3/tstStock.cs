using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {/******** INSTANCE OF THE CLASS TEST********/
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //test to check if it exists
            Assert.IsNotNull(AStock);
        }
        [TestMethod]
        /******** PROPERTY OK  TEST********/
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStock.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Available, TestData);
        }
        [TestMethod]
        public void CreatedAtPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStock.CreatedAt = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.CreatedAt, TestData);
        }
        [TestMethod]
        public void ProductIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.ProductId, TestData);
        }
        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.StockQuantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockQuantity, TestData);
        }
        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Milk";
            //assign the data to the property
            AStock.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Name, TestData);
        }
        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "A refreshing combination of brewed black tea, milk, and (optional)" +
                " tapioca pearls. Thai Tea: A strong black tea combined with sweetened condensed";
            //assign the data to the property
            AStock.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Description, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Double TestData = 5.50;
            //assign the data to the property
            AStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Price, TestData);
        }
        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductId = 3;
            //invoke the method
            Found = AStock.Find(ProductId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestProductIdFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 3;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the address id property
            if (AStock.ProductId != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 3;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the Name property
            if (AStock.Name != "Milk")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 3;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the Description property
            if (AStock.Description != "Test Description")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 3;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the post code property
            if (AStock.Price != 5.5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 3;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the county code property
            if (AStock.StockQuantity != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCreatedAtFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 3;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the date added property
            if (AStock.CreatedAt != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 3;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the Available property
            if (AStock.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}