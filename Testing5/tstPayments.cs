using ClassLibrary;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.IO;
using System.Security.Policy;
using static System.Net.WebRequestMethods;



namespace Testing5
{
    [TestClass]
    public class tstPayments
    {

        // good test data
        //create some test data to pass the method
        string OrderId = "9";
        string BillingAddress = "44 Bath Lane, Corby";
        string PaymentsMethod = "Revolut";
        string Amount = "6.2";
        string PaymentsDate = DateTime.Now.ToShortDateString();


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
        public void PaymentsMethodOK()
        {
            //create an instance of the class we want to createe 
            clsPayments APayments = new clsPayments();
            //create some test data to assign to the property 
            string TestData = "Apple Pay";
            //assign the data to the property 
            APayments.PaymentsMethod = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APayments.PaymentsMethod, TestData);
        }

        [TestMethod]
        public void AmountOK()
        {
            //create an instance of the class we want to createe 
            clsPayments APayments = new clsPayments();
            //create some test data to assign to the property 
            double TestData = 3.8800;
            //assign the data to the property 
            APayments.Amount = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APayments.Amount, TestData);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //Create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
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
            Int32 PaymentsId = 1;
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
            Int32 PaymentsId = 1;
            //invoke the method
            Found = APayments.Find(PaymentsId);
            //check the payments ID
            if (APayments.PaymentsId != 1) 
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
            Int32 PaymentsId = 1;
            //invoke the method
            Found = APayments.Find(PaymentsId);
            //check the amounts
            if (APayments.Amount != 3.8800)
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
            Int32 PaymentsId = 1;
            //invoke method
            Found = APayments.Find(PaymentsId);
            // check the dateadded property
            if (APayments.PaymentsDate != Convert.ToDateTime("16/10/2024"))
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
            //create some test data to use with the method
            Int32 PaymentsId = 1;
            //invoke the method
            Found = APayments.Find(PaymentsId);
            //create some test data to use with the method
            Int32 OrderId = 7;
            //invoke the method
            Found = APayments.Find(PaymentsId);
            //check the order ID
            if (APayments.OrderId != 7)
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
            Int32 PaymentsId = 1;

            //create some test data to use with the method
            //string BillingAddress = "Flat 6 St.Matthews house NG4 5LX";
            //invoke the method
            Found = APayments.Find(PaymentsId);
            //check the billing address 
            if (APayments.BillingAddress != "Flat 66 Soya Lane NW4 6ZQ")
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
            Int32 PaymentsId = 1;

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
        public void TestPaymentsMethodFound()
        {  //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //create a boolean variable to store the result of the serach
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PaymentsId = 1;
            //invoke the method
            Found = APayments.Find(PaymentsId);
            //check the payment method
            if (APayments.PaymentsMethod != "Apple Pay")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        //000000000000000000000000000 PAYMENTS AMOUNT TESTING  00000000000000000000000000000000000 //
        [TestMethod]
        public void AmountExtremeMin()
        {
            //create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Amount = "0";
            //invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AmountMinLessOne()
        {
            //create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Amount = "";
            //invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AmountMin()
        {
            //create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Amount = "a";
            //invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AmountMax()
        {
            //create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Amount = "";
            Amount = Amount.PadRight(20, 'a');
            //invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AmountExtremeMax()
        {
            //create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Amount = "999999999999999999.99";
            //invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AmountMaxPlusOne()
        {
            //create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Amount = "";
            Amount = Amount.PadRight(21, 'a');
            //invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AmountMinPlusOne()
        {
            // Create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string Amount = "aa";
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AmountMid()
        {
            // Create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string Amount = "";
            Amount = Amount.PadRight(10, 'a');
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AmountMaxLessOne()
        {
            // Create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string Amount = "";
            Amount = Amount.PadRight(19, 'a');
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        ///////////////////////////Payments date//////////////////////////////////////////////

        [TestMethod]
        public void PaymentsDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentsDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentsDateMin()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentsDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentsDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentsDateInvalidData()
        {
            // create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            // set the paymentsdate to a non date value
            string PaymentsDate = "this is not a date!";
            //invoke method
            Error = APayments.Valid(OrderId,BillingAddress, PaymentsMethod, Amount,PaymentsDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        ///////////////////////////////Order ID////// //////////////////////////////////////////
        [TestMethod]
        public void OrderIdMin()
        {
            // Create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            // String variable to store any error message
            string Error = "";
            // Test data
            string OrderId = "a"; // this should be ok
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMinPlusOne()
        {
            // Create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            // String variable to store any error message
            string Error = "";
            // Test data
            string OrderId = "aa"; // this should be ok
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMaxLessOne()
        {
            // Create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            // String variable to store any error message
            string Error = "";
            // Test data
            string OrderId = "aaaaaaaaa"; // this should be ok
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMax()
        {
            // Create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            // String variable to store any error message
            string Error = "";
            // Test data
            string OrderId = "aaaaaaaaaa"; // this should be ok
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMid()
        {
            // Create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            // String variable to store any error message
            string Error = "";
            // Test data
            string OrderId = "aaaaa"; // this should be ok
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMaxPlusOne()
        {
            // Create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            // String variable to store any error message
            string Error = "";
            // Test data
            string OrderId = "aaaaaaaaaa"; // this should be ok
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIdExtremeMax()
        {
            // Create an instance of the class we want to test
            clsPayments APayments = new clsPayments();
            // String variable to store any error message
            string Error = "";
            // create some test data to pass to the method
            string OrderId = "aaaaaaa"; // this should fail
            OrderId = OrderId.PadRight(500,'a');
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
         
        //////////////////////////////////BILLING ADDRESS////////////////////////////////
        [TestMethod]
        public void BillingAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BillingAddress = "";
            BillingAddress = BillingAddress.PadRight(500, 'a');//this should fail
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BillingAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BillingAddress = ""; //should fail
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BillingAddressMin()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BillingAddress = "a";
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BillingAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BillingAddress = "aa";
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BillingAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BillingAddress = "";
            BillingAddress = BillingAddress.PadRight(99, 'a');//this should be okay
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BillingAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BillingAddress = "";
            BillingAddress = BillingAddress.PadRight(101, 'a');//this should fail
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BillingAddressMid()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BillingAddress = "";
            BillingAddress = BillingAddress.PadRight(50, 'a');//this should be okay
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //////////////////////////////////PAYMENTS METHOD////////////////////////////////
        [TestMethod]
        public void PaymentsMethodExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentsMethod = "";
            PaymentsMethod = PaymentsMethod.PadRight(100, 'a');//this should fail
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentsMethodMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentsMethod = ""; //should fail
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentsMethodMin()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentsMethod = "a";
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentsMethodMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentsMethod = "aa";
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentsMethodMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentsMethod = "";
            PaymentsMethod = PaymentsMethod.PadRight(59, 'a');//this should be okay
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentsMethodMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentsMethod = "";
            PaymentsMethod = PaymentsMethod.PadRight(51, 'a');//this should fail
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentsMethodMid()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentsMethod = "";
            PaymentsMethod = PaymentsMethod.PadRight(25, 'a');//this should be okay
            // Invoke the method
            Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }

}


