using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance od the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see tha is exists
            Assert.IsNotNull(AllStocks);
        }
        [TestMethod]
        public void StockListOk()
        {
            //create an instance od the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an Item to the list
            //create the item of test data
            clsStock TestStock = new clsStock();
            //set its properties
            TestStock.Available = true;
            TestStock.ProductId = 1;
            TestStock.Name = "Chocolate";
            TestStock.DateAdded = DateTime.Now;
            TestStock.Description = "test";
            TestStock.Price = 5.50;
            TestStock.StockQuantity = 100;
            //add the items to the test list
            TestList.Add(TestStock);
            //assign the data to the property 
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockList, TestList);
        }
        [TestMethod]
        public void CountPropertyOk()
        {
            //create an instance od the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 3;
            //assign the data to the property
            AllStocks.Count = SomeCount;
            //test to see that two values are the same
            Assert.AreEqual(AllStocks.Count, SomeCount);

        }
        [TestMethod]
        public void ThisStockProtertyOk()
        {
            //create an instance od the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set its properties
            TestStock.Available = true;
            TestStock.ProductId = 3;
            TestStock.Name = "Test";
            TestStock.DateAdded = DateTime.Now;
            TestStock.Description = "This is a test";
            TestStock.Price = 5.00;
            TestStock.StockQuantity = 100;
            //assign the data to the property 
            AllStocks.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance od the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an Item to the list
            //create the item of test data
            clsStock TestStock = new clsStock();
            //set its properties
            TestStock.Available = true;
            TestStock.ProductId = 3;
            TestStock.Name = "Test";
            TestStock.DateAdded = DateTime.Now;
            TestStock.Description = "This is a test";
            TestStock.Price = 5.00;
            TestStock.StockQuantity = 100;
            //add the items to the test list
            TestList.Add(TestStock);
            //assign the data to the property 
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent() 
        {
            clsStockCollection AllStocks = new clsStockCollection();
            Assert.AreEqual(AllStocks.Count, 3);
        }


    }
}

