using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        /******************INSTANCE OF THE CLASS TEST******************/
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        /******************PROPERTY OK TESTS******************/

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


        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the new class we want to create
            clsStaff AStaff = new clsStaff();

            //create a Booleanvariable to store the results of the validation
            Boolean Found = false;

            //create some test data to use within the method
            Int32 StaffId = 1;

            //invoke the method
            Found = AStaff.Find(StaffId);

            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the new class we want to create
            clsStaff AStaff = new clsStaff();

            //create a Booleanvariable to store the results of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use within the method
            Int32 StaffId = 1;

            //invoke the method
            Found = AStaff.Find(StaffId);

            //check the Staff ID property
            if (AStaff.StaffID != 1)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestStaffFullNameFound()
        {
            //create an instance of the new class we want to create
            clsStaff AStaff = new clsStaff();

            //create a Booleanvariable to store the results of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use within the method
            Int32 StaffId = 1;

            //invoke the method
            Found = AStaff.Find(StaffId);

            //check the Staff Full Name property
            if (AStaff.StaffFullName != "Lee-Anne Starkie")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestStaffDoBFound()
        {
            //create an instance of the new class we want to create
            clsStaff AStaff = new clsStaff();

            //create a Booleanvariable to store the results of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use within the method
            Int32 StaffId = 1;

            //invoke the method
            Found = AStaff.Find(StaffId);

            //check the Staff DoB property
            if (AStaff.StaffDoB != Convert.ToDateTime("10/04/1999"))
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestStaffEmailFound()
        {
            //create an instance of the new class we want to create
            clsStaff AStaff = new clsStaff();

            //create a Booleanvariable to store the results of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use within the method
            Int32 StaffId = 1;

            //invoke the method
            Found = AStaff.Find(StaffId);

            //check the Staff Email property
            if (AStaff.StaffEmail != "p17206496@my365.dmu.ac.uk")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //  ninumber, salary, present in building

        [TestMethod]
        public void TestNINumberFound()
        {
            //create an instance of the new class we want to create
            clsStaff AStaff = new clsStaff();

            //create a Booleanvariable to store the results of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use within the method
            Int32 StaffId = 1;

            //invoke the method
            Found = AStaff.Find(StaffId);

            //check the NI Number property
            if (AStaff.NINumber != "AB123456C")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of the new class we want to create
            clsStaff AStaff = new clsStaff();

            //create a Booleanvariable to store the results of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use within the method
            Int32 StaffId = 1;

            //invoke the method
            Found = AStaff.Find(StaffId);

            //check the Salary property
            if (AStaff.Salary != 1000000.00)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestPresentInBuildingFound()
        {
            //create an instance of the new class we want to create
            clsStaff AStaff = new clsStaff();

            //create a Booleanvariable to store the results of the search
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use within the method
            Int32 StaffId = 1;

            //invoke the method
            Found = AStaff.Find(StaffId);

            //check the Present In Building property
            if (AStaff.PresentInBuilding != true)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
