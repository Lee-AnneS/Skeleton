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
            TestStock.Name = "Chocolate";
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
            TestStock.Name = "Chocolate";
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
            TestItem.Name = "Add";
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
        /**************** Update Method *******************************/
        [TestMethod]
        public void UpdateMethodOK()
        {
            //crete an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //crete the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Name = "Gelato";
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
            //modify the test record
            TestItem.Name = "modified";
            TestItem.Description = "Another test";
            TestItem.Price = 7.00;
            TestItem.StockQuantity = 2;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Available = false;
            //set ThisStock to the test date
            AllStock.ThisStock = TestItem;
            //update the record
            PrimaryKey = AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        /**************** Delete Method *******************************/
        [TestMethod]
        public void DeleteMethodOK()
        {
            //crete an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //crete the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductId = 1;
            TestItem.Name = "Delete";
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
            //delete the record
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that record was not found
            Assert.IsFalse(Found);
        }
        /****************  filter by name Method *******************************/
        [TestMethod]
        public void ReportByNameMethodOK() 
        {
            //crete an instance of the class containg unifiltered results
            clsStockCollection AllStock = new clsStockCollection();
            //crete an instance of the filtered data
            clsStockCollection FilterStock = new clsStockCollection();
            //apply a Name doesn't exist
            FilterStock.ReportByName("xxxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilterStock.Count);
        }
        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //crete an instance of the filtered data
            clsStockCollection FilterStock = new clsStockCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a Name doesn't exist
            FilterStock.ReportByName("Milk");
            //check that the correct number of records are found
            if (FilterStock.Count == 2) 
            {
                //check to see that the first record is 5
                if (FilterStock.StockList[0].ProductId != 5) 
                {
                    OK = false;
                }
                //check to see that the first record is 1164
                if (FilterStock.StockList[1].ProductId != 1164) 
                {
                    OK = false;
                }
            }
            else 
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);  
        }
    }   

}

