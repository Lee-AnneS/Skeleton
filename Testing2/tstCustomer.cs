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
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsCustomer ACustomer = new clsCustomer();
            // test to see if that exists
            Assert.IsNotNull(ACustomer);
        }
    }
}
