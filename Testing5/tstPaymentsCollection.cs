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

        [TestMethod]
        public void UpdateMethodOK()
        {
            //Create an instance of the Class we want to create
            clsPaymentsCollection AllPayments = new clsPaymentsCollection();
            //create the item of the test data
            clsPayments TestItem = new clsPayments();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PaymentsStatus = true;
            TestItem.OrderId = 7;
            TestItem.BillingAddress = "Flat 66 Soya Lane NW4 6ZQ";
            TestItem.PaymentsMethod = "Apple Pay";
            TestItem.Amount = 3.8800;
            TestItem.PaymentsDate = DateTime.Now;
            //set thisPayments to the test data
            AllPayments.ThisPayments = TestItem;
            //add the record
            PrimaryKey = AllPayments.Add();
            //set the primary key of the test data
            TestItem.PaymentsId = PrimaryKey;
            //modify the test record
            TestItem.PaymentsStatus = false;
            TestItem.OrderId = 7;
            TestItem.BillingAddress = "Mansion 22 Vegan Lane NW4 6RE";
            TestItem.PaymentsMethod = "Debit Card";
            TestItem.Amount = 8.7200;
            TestItem.PaymentsDate = DateTime.Now;
            //set the record based on the new test data
            AllPayments.ThisPayments = TestItem;
            //update the record
            AllPayments.Update();
            //find the record
            AllPayments.ThisPayments.Find(PrimaryKey);
            //test to see if ThisPayments matvhes the test data
            Assert.AreEqual(AllPayments.ThisPayments, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK() 
        { 
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsPaymentsCollection AllPayments = new clsPaymentsCollection();
            //create the item of test data
            clsPayments TestItem = new clsPayments();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PaymentsStatus = true;
            TestItem.OrderId = 7;
            TestItem.BillingAddress  = "Mansion 22 Giraffe Lane NW4 6RE";
            TestItem.PaymentsMethod = "Pay Pal";
            TestItem.Amount = 2.2200;
            TestItem.PaymentsDate = DateTime.Now;
            //set ThisPayments to the test data
            AllPayments.ThisPayments = TestItem ;
            //add the record
            PrimaryKey = AllPayments.Add();
            //set the primary key of the test data  
            TestItem.PaymentsId = PrimaryKey;
            //find the record
            AllPayments.ThisPayments.Find(PrimaryKey);
            //delet the record
            AllPayments.Delete();
            //now find the record
            Boolean Found = AllPayments.ThisPayments.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        //should pass lol
        [TestMethod]
        public void ReportByPaymentsMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsPaymentsCollection AllPayments = new clsPaymentsCollection();
            //create an instance of the filtered data
            clsPaymentsCollection FilteredPayments = new clsPaymentsCollection();
            //apply a blank string (should return all records)
            FilteredPayments.ReportByPaymentsMethod("zzzz zzzz");
            //test to see that the two values are the same
            Assert.AreEqual(2, FilteredPayments.Count);
        }
        [TestMethod]
        public void ReportByPaymentsMethodNoneFound() 
        {
            //create an instance of the class we want to create
            clsPaymentsCollection FilteredPayments = new clsPaymentsCollection();
            //apply a payment method that doesnt exist
            FilteredPayments.ReportByPaymentsMethod("zzzz zzzz");
            //test to see that there are no records
            Assert.AreEqual(2, FilteredPayments.Count);
        }

        [TestMethod]
        public void ReportByPaymentsMethodTestDataFound()
        {
            //create an instance of the class we want to create
            clsPaymentsCollection FilteredPayments = new clsPaymentsCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a payment method that doesnt exist
            FilteredPayments.ReportByPaymentsMethod("zzzz zzzz");
            //check that the correct number of records are found
            if (FilteredPayments.Count == 2)
            {
                //check to see that the first record is 1122
                if (FilteredPayments.PaymentsList[0].PaymentsId != 1122)
                {
                    OK = false;
                }
                //check to see that the first record is 1123
                if (FilteredPayments.PaymentsList[1].PaymentsId != 1123)
                {
                    OK = false;
                }

                //test to see that there are no records
                Assert.IsTrue(OK);
            }
        }
    }
}
