﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomerUser
    {

        /******************INSTANCE OF THE CLASS TEST******************/
        /**************************************************************/

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsCustomerUser AnUser = new clsCustomerUser();

            //test to see that it exits
            Assert.IsNotNull(AnUser);
        }

        /******************PROPERTY OK TESTS******************/
        /*****************************************************/

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();

            //create some test data to assign to the property 
            Int32 TestData = 1;
            
            //assign the data to the property 
            AnUser.UserID = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();

            //create some test data to assign to the property
            string TestData = "Tavleen";

            //assign the data to the property
            AnUser.UserName = TestData;

            //test to see that the two value are the same 
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();

            //create some test data to assign to the property
            string TestData = "helloworld";

            //assign the data to the property
            AnUser.Password = TestData;

            //test to see that the two value are the same 
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();

            //create some test data to assign to the property
            string TestData = "Customer Management System";

            //assign the data to the property
            AnUser.Department = TestData;

            //test to see that the two value are the same 
            Assert.AreEqual(AnUser.Department, TestData);
        }

        /******************FIND METHOD TEST******************/
        /****************************************************/

        [TestMethod]
        public void FindUserMethod() 
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();

            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;

            //create some test data to use with the method 
            string UserName = "Tavleen";
            string Password = "helloworld";

            //invoke the method
            Found = AnUser.FindUser(UserName, Password);

            //test to see if the results is true
            Assert.IsTrue(Found);
        }

        /******************USERNAME TEST******************/
        /****************************************************/

        [TestMethod]
        public void TestUsernamePWFound()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();

            //create a Boolean variable to store the results of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            string UserName = "Tavleen";
            string Password = "helloworld";

            //invoke the method
            Found = AnUser.FindUser(UserName, Password);

            //check the user id property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }

            //test to see that if the result is correct
            Assert.IsTrue(OK);
        }
    }
}
