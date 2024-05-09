using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property
            Int32 TestData = 1;

            //assign the data to the property
            ACustomer.CustomerID = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
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
    }
}
