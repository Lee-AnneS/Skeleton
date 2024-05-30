using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the classs we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create some test data to assign to the property 
            //in this case the sata needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();

            //add an Item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();  

            //set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.CustomerName = "Tavleen kaur";
            TestItem.CustomerDoB = DateTime.Now;
            TestItem.CustomerEmail = "tkaur@gmail.com";
            TestItem.CustomerAddress = "12 Ash Road, XXX XXX";
            TestItem.NumOrder = 5;

            //add the item to the test list 
            TestList.Add(TestItem);

            //add the data to the property 
            AllCustomers.CustomerList = TestList;

            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create some test data to assign to the property 
            clsCustomer TestCustomer = new clsCustomer();

            //set the properties of the test object
            TestCustomer.Active = true;
            TestCustomer.CustomerId = 1;
            TestCustomer.CustomerName = "Tavleen kaur";
            TestCustomer.CustomerDoB = DateTime.Now;
            TestCustomer.CustomerEmail = "tkaur@gmail.com";
            TestCustomer.CustomerAddress = "12 Ash Road, XXX XXX";
            TestCustomer.NumOrder = 5;

            //assign the data to the property 
            AllCustomers.ThisCustomer = TestCustomer;

            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();

            //add an Item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();

            //set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.CustomerName = "Tavleen kaur";
            TestItem.CustomerDoB = DateTime.Now;
            TestItem.CustomerEmail = "tkaur@gmail.com";
            TestItem.CustomerAddress = "12 Ash Road, XXX XXX";
            TestItem.NumOrder = 5;

            //add the item to the test list 
            TestList.Add(TestItem);

            //assign the data to the property 
            AllCustomers.CustomerList = TestList;

            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        /*[TestMethod]
        public void TwoRecodsPresent()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.Count, 2);
        }*/

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create the item of test data 
            clsCustomer TestItem = new clsCustomer();

            //variable to store the primary key 
            Int32 PrimaryKey = 0;

            //set its properties 
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.CustomerName = "Tavleen kaur";
            TestItem.CustomerDoB = DateTime.Now;
            TestItem.CustomerEmail = "tkaur@gmail.com";
            TestItem.CustomerAddress = "12 Ash Road, XXX XXX";
            TestItem.NumOrder = 5;

            //set ThisCustomer to the test data 
            AllCustomers.ThisCustomer = TestItem;

            //add the record
            PrimaryKey = AllCustomers.Add();

            //set the primary key of the test data 
            TestItem.CustomerId = PrimaryKey;

            //find the record 
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create the item of test data 
            clsCustomer TestItem = new clsCustomer();

            //variable to store the primary key 
            Int32 PrimaryKey = 0;

            //set its properties 
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.CustomerName = "Tavleen kaur";
            TestItem.CustomerDoB = DateTime.Now;
            TestItem.CustomerEmail = "tkaur@gmail.com";
            TestItem.CustomerAddress = "12 Ash Road, XXX XXX";
            TestItem.NumOrder = 5;

            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;

            //add the record 
            PrimaryKey = AllCustomers.Add();

            //set the primary key of the test data 
            TestItem.CustomerId = PrimaryKey;

            //modify the test record
            TestItem.Active = false;
            TestItem.CustomerName = "My Name";
            TestItem.CustomerDoB = DateTime.Now;
            TestItem.CustomerEmail = "name@gmail.com";
            TestItem.CustomerAddress = " 16 Some Street, XXX XXX";
            TestItem.NumOrder = 3;

            //set the record based on the new test data 
            AllCustomers.ThisCustomer = TestItem;

            //update the record 
            AllCustomers.Update();

            //find the record 
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            //test to see if ThisCustomer matches test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create the item of test data 
            clsCustomer TestItem = new clsCustomer();

            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.CustomerName = "Tavleen kaur";
            TestItem.CustomerDoB = DateTime.Now;
            TestItem.CustomerEmail = "tkaur@gmail.com";
            TestItem.CustomerAddress = "12 Ash Road, XXX XXX";
            TestItem.NumOrder = 5;

            //set ThisCustomer to the test data 
            AllCustomers.ThisCustomer = TestItem;

            //add the record
            PrimaryKey = AllCustomers.Add();

            //set the primary key of the test data 
            TestItem.CustomerId = PrimaryKey;

            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            //delete the record
            AllCustomers.Delete();

            //now find the record 
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);

            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCustomerNameMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create an instance of the filtered data 
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            //apply a blank string  (should return all records);
            FilteredCustomers.ReportByCustomerName("");

            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerNameFound() 
        {
            //create an instance of the class we want to create
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            //apply a customer name that doesnt exist
            FilteredCustomers.ReportByCustomerName("Any Name");

            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerNameTestDatFound()
        {
            //create an instance of the class we want to create
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            //variable to store the outcome 

        }

    }
}
