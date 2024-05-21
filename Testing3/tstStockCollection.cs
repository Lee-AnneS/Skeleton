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
       
        /**************** Add Method *******************************/
        [TestMethod]
        public void AddMethodOK() 
        {
            //crete an instance of the class we want to create
            clsStockCollection AllStock  = new clsStockCollection();
            //crete the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductId = 1;
            TestItem.Name = "test";
            TestItem.Description = "This is a test";
            TestItem.Price = 5.00;
            TestItem.StockQuantity = 100;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Available = true;
            //set ThisStock to the test date
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set this product to the test data
            TestItem.ProductId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
    }
}

