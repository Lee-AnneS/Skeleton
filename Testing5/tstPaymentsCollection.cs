using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstPaymentsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPaymentsCollection AllPayments = new clsPaymentsCollection();
            //test to see that it exists
            Assert.IsNotNull(AllPayments);
        }

        [TestMethod]
        public void PaymentsListOK()
        {
            //Create an instance of the class we want to create
            clsPaymentsCollection AllPayments = new clsPaymentsCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsPayments> TestList = new List<clsPayments>();
            //add an item to the list
            //create the item of test data
            clsPayments TestItem = new clsPayments();
            //set its properties
            TestItem.PaymentsStatus = true;
            TestItem.PaymentsId = 1;
            TestItem.OrderId = 7;
            TestItem.BillingAddress = "Flat 66 Soya Lane NW4 6ZQ";
            TestItem.PaymentsMethod = "Apple Pay";
            TestItem.Amount = 3.8800;
            TestItem.PaymentsDate = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPayments.PaymentsList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.PaymentsList, TestList);
        }
        

        [TestMethod]
        public void ThisPaymentsPropertyOK()
        {
            //Create an instance of the class we want to create
            clsPaymentsCollection AllPayments = new clsPaymentsCollection();
            //create some test data to assign to the property
            clsPayments TestPayments = new clsPayments();
            //set its properties for the test object
            TestPayments.PaymentsStatus = true;
            TestPayments.PaymentsId = 1;
            TestPayments.OrderId = 7;
            TestPayments.BillingAddress = "Flat 66 Soya Lane NW4 6ZQ";
            TestPayments.PaymentsMethod = "Apple Pay";
            TestPayments.Amount = 3.8800;
            TestPayments.PaymentsDate = DateTime.Now;

            //assign the data to the property
            AllPayments.ThisPayments = TestPayments;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.ThisPayments, TestPayments);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsPaymentsCollection AllPayments = new clsPaymentsCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsPayments> TestList = new List<clsPayments>();
            //add an item to the list
            //create the item of test data
            clsPayments TestItem = new clsPayments();
            //set its properties
            TestItem.PaymentsStatus = true;
            TestItem.PaymentsId = 1;
            TestItem.OrderId = 7;
            TestItem.BillingAddress = "Flat 66 Soya Lane NW4 6ZQ";
            TestItem.PaymentsMethod = "Apple Pay";
            TestItem.Amount = 3.8800;
            TestItem.PaymentsDate = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPayments.PaymentsList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.Count, TestList.Count);    
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsPaymentsCollection AllPayments = new clsPaymentsCollection();
            //create the item of test data
            clsPayments TestItem = new clsPayments();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PaymentsStatus = true;
            TestItem.PaymentsId = 2;
            TestItem.OrderId = 2;
            TestItem.BillingAddress = "57 Tattenham Crescent, Epsom KT18 5NX";
            TestItem.PaymentsMethod = "Debit Card";
            TestItem.Amount = 4.8800;
            TestItem.PaymentsDate = DateTime.Now;
            //set ThisPayments to the test data
            AllPayments.ThisPayments = TestItem;
            //add the record
            PrimaryKey = AllPayments.Add();
            //set the primary key of the test data
            TestItem.PaymentsId = PrimaryKey;
            //find the record
            AllPayments.ThisPayments.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllPayments.ThisPayments, TestItem);

        }


    }
}
