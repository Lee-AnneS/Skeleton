using ClassLibrary;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Security.Policy;
using static System.Net.WebRequestMethods;



namespace Testing5
{
    [TestClass]
    public class tstPayments
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to createe 
            clsPayments APayments = new clsPayments();
            //test to see that it exists 
            Assert.IsNotNull(APayments);
        }

        [TestMethod]
        public void PaymentsStatusOK()
        {
            //create an instance of the class we want to createe 
            clsPayments APayments = new clsPayments();
            //create some test data to assign to the property 
            Boolean TestData = false;
            //assign the data to the property 
            new clsPayments().PaymentsStatus = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(new clsPayments().PaymentsStatus, TestData);
        }

        [TestMethod]
        public void PaymentsDateOK()
        {
            //create an instance of the class we want to createe 
            clsPayments APayments = new clsPayments();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            APayments.PaymentsDate = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APayments.PaymentsDate, TestData);
        }

        [TestMethod]
        public void PaymentsIdOK()
        {
            //create an instance of the class we want to createe 
            clsPayments APayments = new clsPayments();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign the data to the property 
            APayments.PaymentsId = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APayments.PaymentsId, TestData);
        }

        [TestMethod]
        public void OrderIdOK()
        {
            //create an instance of the class we want to createe 
            clsPayments APayments = new clsPayments();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign the data to the property 
            APayments.OrderId = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APayments.OrderId, TestData);
        }

        [TestMethod]
        public void BillingAddressOK()
        {
            //create an instance of the class we want to createe 
            clsPayments APayments = new clsPayments();
            //create some test data to assign to the property 
            string TestData = "Flat 6 St.Matthews house NG4 5LX";
            //assign the data to the property 
            APayments.BillingAddress = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APayments.BillingAddress, TestData);
        }

        [TestMethod]
        public void PaymentMethodOK()
        {
            //create an instance of the class we want to createe 
            clsPayments APayments = new clsPayments();
            //create some test data to assign to the property 
            string TestData = "Apple Pay";
            //assign the data to the property 
            APayments.PaymentMethod = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APayments.PaymentMethod, TestData);
        }

        [TestMethod]
        public void AmountOK()
        {
            //create an instance of the class we want to createe 
            clsPayments APayments = new clsPayments();
            //create some test data to assign to the property 
            double TestData = 2.22;
            //assign the data to the property 
            APayments.Amount = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APayments.Amount, TestData);

        }
        // ......................find test method ...................
        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 PaymentsId = 22;
            //invoke the method
            Found = APayments.Find(PaymentsId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        // ...................property data tests.................
        [TestMethod]
        public void TestPaymentsIdFound()
        {  //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //create a boolean variable to store the result of the serach
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PaymentsId = 22;
            //invoke the method
            Found = APayments.Find(PaymentsId);
            //check the payments ID
            if (APayments.PaymentsId != 22) 
            { 
                OK = false; 
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);  
        }
        [TestMethod]
        public void TestAmountFound()
        {  //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //create a boolean variable to store the result of the serach
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PaymentsId = 22;
            //invoke the method
            Found = APayments.Find(PaymentsId);
            //check the amounts
            if (APayments.Amount != 2.22)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentsDateFound()
        {
            // create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            // create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 PaymentsId = 22;
            //invoke method
            Found = APayments.Find(PaymentsId);
            // check the dateadded property
            if (APayments.PaymentsDate != Convert.ToDateTime("22/02/2022"))
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {  //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //create a boolean variable to store the result of the serach
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 PaymentsId = 22;
            //create some test data to use with the method
            Int32 OrderId = 20;
            //invoke the method
            Found = APayments.Find(OrderId);
            //check the order ID
            if (APayments.OrderId != 20)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestBillingAddressFound()
        {  //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //create a boolean variable to store the result of the serach
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with this method
            Int32 PaymentsId = 22;

            //create some test data to use with the method
            //string BillingAddress = "Flat 6 St.Matthews house NG4 5LX";
            //invoke the method
            Found = APayments.Find(PaymentsId);
            //check the billing address 
            if (APayments.BillingAddress != "Flat 6 St.Matthews house NG4 5LX")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentsStatusFound()
        {  //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //create a boolean variable to store the result of the serach
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with this method
            Int32 PaymentsId = 22;

            //invoke the method
            Found = APayments.Find(PaymentsId);
            //check the billing address ID
            if (APayments.PaymentsStatus != true)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentMethodFound()
        {  //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //create a boolean variable to store the result of the serach
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PaymentsId = 22;
            //invoke the method
            Found = APayments.Find(PaymentsId);
            //check the payment method
            if (APayments.PaymentMethod != "Apple Pay")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }

}


