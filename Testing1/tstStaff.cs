using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }


        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //create some test data to assign to the property
            Int32 TestData = 1;

            //assign the data to the property
            AStaff.StaffID = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }


        [TestMethod]
        public void StaffFullNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //create some test data to assign to the property
            string TestData = "Lee-Anne Starkie";

            //assign the data to the property
            AStaff.StaffFullName = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffFullName, TestData);
        }


        [TestMethod]
        public void StaffDoBPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //create some test data to assign to the property
            DateTime TestData = DateTime.FromOADate(10/04/1999);

            //assign the data to the property
            AStaff.StaffDoB = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffDoB, TestData);
        }


        [TestMethod]
        public void StaffEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //create some test data to assign to the property
            string TestData = "p17206496@my365.dmu.ac.uk";

            //assign the data to the property
            AStaff.StaffEmail = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffEmail, TestData);
        }

    
        [TestMethod]
        public void NINumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //create some test data to assign to the property
            string TestData = "AB123456C";

            //assign the data to the property
            AStaff.NINumber = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AStaff.NINumber, TestData);
        }

        [TestMethod]
        public void SalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //create some test data to assign to the property
            Double TestData = 1000000.00;

            //assign the data to the property
            AStaff.Salary = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Salary, TestData);
        }



        [TestMethod]
        public void PresentInBuildingPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //create some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            AStaff.PresentInBuilding = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AStaff.PresentInBuilding, TestData);
        }
    }
}
