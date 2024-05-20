using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {

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
    }

}

