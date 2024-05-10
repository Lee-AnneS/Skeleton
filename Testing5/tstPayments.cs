using ClassLibrary;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Security.Policy;



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
            double TestData = 3.45;
            //assign the data to the property 
            APayments.Amount = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APayments.Amount, TestData);

        }

    }

}


