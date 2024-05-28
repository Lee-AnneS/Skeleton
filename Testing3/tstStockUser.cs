using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing3
{
    [TestClass]
    public class tstStockUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
        //**************** Properties Method ******************
        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create sometest data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to see that it exists
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create sometest data to assign to the property
            string TestData = "Alexandre";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that it exists
            Assert.AreEqual(AnUser.UserName, TestData);
        } [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create sometest data to assign to the property
            string TestData = "password456";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that it exists
            Assert.AreEqual(AnUser.Password, TestData);
        } 
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create sometest data to assign to the property
            string TestData = "Stock";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that it exists
            Assert.AreEqual(AnUser.Department, TestData);
        }
        //**************** FindUser Method ******************
        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create boolean variable to store the results od the validation
            Boolean Found = false;
            //create sometest data to use with the method
            string UserName = "Alexandre";
            string Password = "password456";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        //**************** Test User name found Method ******************
        [TestMethod]
        public void TestUserNamePWFoundOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create boolean variable to store the results od the validation
            Boolean Found = false;
            //create boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create sometest data to use with the method
            string UserName = "Alexandre";
            string Password = "password456";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //check the user id property
            if (AnUser.UserName != UserName && AnUser.Password != Password) 
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
    }
}
