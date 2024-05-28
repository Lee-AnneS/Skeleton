using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstPaymentsUser
    {

        [TestMethod]
        public void InstanceOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsPaymentsUser AnUser = new clsPaymentsUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsPaymentsUser AnUser = new clsPaymentsUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to see that it exists
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsPaymentsUser AnUser = new clsPaymentsUser();
            //create some test data to assign to the property
            string TestData = "itsnot6abriela";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that it exists
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsPaymentsUser AnUser = new clsPaymentsUser();
            //create some test data to assign to the property
            string TestData = "giraffe22";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that it exists
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsPaymentsUser AnUser = new clsPaymentsUser();
            //create some test data to assign to the property
            string TestData = "Payments Plaza";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that it exists
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsPaymentsUser AnUser = new clsPaymentsUser();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "itsnot6abriela";
            string Password = "giraffe22";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsPaymentsUser AnUser = new clsPaymentsUser();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "itsnot6abriela";
            string Password = "giraffe22";
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
