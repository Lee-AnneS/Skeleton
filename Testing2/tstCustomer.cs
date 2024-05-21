using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq.Expressions;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {

        //good test data 
        //create some test data to pass method
        string CustomerName = "tavleen kaur";
        string CustomerDoB = DateTime.Now.ToShortDateString();
        string CustomerEmail = "tkaur@gmail.com";
        string CustomerAddress = "12 Ash Road, XXX XXX";
        string NumOrder = "25";

        /******************INSTANCE OF THE CLASS TEST******************/
        /**************************************************************/

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        /******************PROPERTY OK TESTS******************/
        /*****************************************************/

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property
            Int32 TestData = 1;

            //assign the data to the property
            ACustomer.CustomerId = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property  
            string TestData = "Peter Smith";

            //assign the data to the property  
            ACustomer.CustomerName = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerDoBPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property  
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property  
            ACustomer.CustomerDoB = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.CustomerDoB, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property  
            string TestData = "Peters11@gmail.com";

            //assign the data to the property  
            ACustomer.CustomerEmail = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property  
            string TestData = "72 Hampden Lane, London,N17 0AS";

            //assign the data to the property  
            ACustomer.CustomerAddress = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }

        [TestMethod]
        public void NumOrderPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property  
            int TestData = 5;

            //assign the data to the property  
            ACustomer.NumOrder = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.NumOrder, TestData);

        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property  
            Boolean TestData = true;

            //assign the data to the property  
            ACustomer.Active = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        /******************FIND METHOD TEST******************/
        /****************************************************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();

            //create a Boolean variable to store the results of the validation
            Boolean Found = false;

            //create some test data to use with the method
            Int32 CustomerId = 5;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //test to see if the result is true 
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/
        /*******************************************************/

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create a Boolean variable to store the result of the search 
            Boolean Found = false;

            //create a Boolean  variable to record if the data is OK )assume it is)
            Boolean OK = true;

            //create some test data to use with the method 
            Int32 CustomerId = 5;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer id 
            if (ACustomer.CustomerId != 5)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();

            //create a boolean variable to store the result of the search 
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assme it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerId = 5;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the name property
            if (ACustomer.CustomerName != "Kim Kardashian")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerDoBFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerId = 5;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer Date of birth
            if (ACustomer.CustomerDoB != Convert.ToDateTime("30/01/1996"))
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerId = 5;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer email
            if (ACustomer.CustomerEmail != "kim1996@hotmail.com")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerId = 5;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer address
            if (ACustomer.CustomerAddress != "18 Princes Road, Doncaster,DN4 5LW")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNumOrderFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerId = 5;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer address
            if (ACustomer.NumOrder != 2)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerId = 5;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer address
            if (ACustomer.Active != false)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /******************VALID METHOD TEST******************/
        /*****************************************************/

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we wan to create 
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message 
            string Error = "";

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        /******************CUSTOMER NAME TESTING******************/
        /*********************************************************/

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();

            //string c=variable to store any arror message 
            String Error = "";

            //create some test data to pass to the method 
            string CustomerName = "";//this should trigger an error

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerName = "a"; //this should be ok

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerName = "aa"; //this should be ok

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(49, 'a'); //this should be ok

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(50, 'a'); //this should be ok

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(25, 'a'); //this should be ok

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(51, 'a'); //this should fail

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a'); //this should fail

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /******************CUSTOMER DOB TESTING******************/
        /********************************************************/

        [TestMethod]
        public void CustomerDoBExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);

            //convert the date variable to a string variable
            string CustomerDoB = TestDate.ToString();

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDoBMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date totodays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);

            //convert the date variable to a string variable
            string CustomerDoB = TestDate.ToString();

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDoBMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date totodays date
            TestDate = DateTime.Now.Date;

            //convert the date variable to a string variable
            string CustomerDoB = TestDate.ToString();

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDoBMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date totodays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);

            //convert the date variable to a string variable
            string CustomerDoB = TestDate.ToString();

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDoBExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date totodays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);

            //convert the date variable to a string variable
            string CustomerDoB = TestDate.ToString();

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDoBInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //set the CustomerDoB to a nin date value
            string CustomerDoB = "this is not a date!";

            //invoke the method 
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        /******************CUSTOMER EMAIL TESTING******************/
        /**********************************************************/

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the new class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the method
            string CustomerEmail = ""; //this should trigger an error

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerEmail = "a"; //this should be ok

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerEmail = "aa"; //this should be ok

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(74, 'a');

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(75, 'a');

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(76, 'a'); //this should fail

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(38, 'a');

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(500, 'a');//this should fail

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /******************CUSTOMER ADDRESS TESTING******************/
        /************************************************************/

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();

            //string c=variable to store any arror message 
            String Error = "";

            //create some test data to pass to the method 
            string CustomerAddress = "";//this should trigger an error

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerAddress = "a"; //this should be ok

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerAddress = "aa"; //this should be ok

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(99, 'a'); //this should be ok

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(100, 'a'); //this should be ok

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(50, 'a'); //this should be ok

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(101, 'a'); //this should fail

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(1000, 'a'); //this should fail

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /******************NUMORDER TESTING******************/
        /**********************************************************/

        [TestMethod]
        public void NumOrderMinLessOne()
        {
            //create an instance of the new class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the method
            string NumOrder = ""; //this should trigger an error

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumOrderMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string NumOrder = ""; //this should be ok

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumOrderMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string NumOrder = "aa"; //this should be ok

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumOrderMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string NumOrder = "";
            NumOrder = NumOrder.PadRight(99, 'a');

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumOrderMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string NumOrder = "";
            NumOrder = NumOrder.PadRight(100, 'a');

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumOrderMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string NumOrder = "";
            NumOrder = NumOrder.PadRight(101, 'a'); //this should fail

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumOrderMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string NumOrder = "";
            NumOrder = NumOrder.PadRight(50, 'a');

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumOrderExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string NumOrder = "";
            NumOrder = NumOrder.PadRight(500, 'a');//this should fail

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        
    }
}

