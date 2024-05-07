
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstPayments
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPayments APayments = new clsPayments();

            //test to see that it exists
            Assert.IsNotNull(APayments);
        }
    }
}
