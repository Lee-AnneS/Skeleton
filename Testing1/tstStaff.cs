using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass the method
        string StaffFullName = "Lee-Anne Starkie";
        string StaffDoB = DateTime.Now.ToShortDateString();
        string StaffEmail = "p17206496@my365.dmu.ac.uk";
        string NINumber = "AB123456C";
        double Salary = 1000000.00;




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

        //PRACTICAL 10

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the new class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            string Error = "";

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /*******************************************************/
        /************* STAFF FULL NAME TESTING *****************/
        /*******************************************************/
        [TestMethod]
        public void StaffFullNameMinLessOne()
        {
            //create an instance of the new class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the method
            string StaffFullName = ""; //this should trigger an error

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffFullNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StaffFullName = "a"; //this should be ok
            
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);
            
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffFullNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StaffFullName = "aa"; //this should be ok

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffFullNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StaffFullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void StaffFullNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StaffFullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void StaffFullNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StaffFullName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void StaffFullNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StaffFullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void StaffFullNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StaffFullName = "";
            StaffFullName = StaffFullName.PadRight(500, 'a');//this should fail

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*******************************************************/
        /***************** STAFF DoB TESTING *****************/
        /*******************************************************/

        [TestMethod]
        public void StaffDoBExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);

            //convert the date variable to a string variable 
            string StaffDoB = TestDate.ToString();

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffDoBMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);

            //convert the date variable to a string variable 
            string StaffDoB = TestDate.ToString();

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        
        [TestMethod]
        public void StaffDoBMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //convert the date variable to a string variable 
            string StaffDoB = TestDate.ToString();

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffDoBMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);

            //convert the date variable to a string variable 
            string StaffDoB = TestDate.ToString();

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffDoBExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);

            //convert the date variable to a string variable 
            string StaffDoB = TestDate.ToString();

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffDoBInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //set the StafDob to a non date value
            string StaffDoB = "this is not a date!";

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        /*******************************************************/
        /***************** STAFF EMAIL TESTING *****************/
        /*******************************************************/


        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            //create an instance of the new class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the method
            string StaffEmail = ""; //this should trigger an error

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffEmailMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StaffEmail = "a"; //this should be ok

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffEmailPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StaffEmail = "aa"; //this should be ok

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(74, 'a');

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void StaffEmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(75, 'a');

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(76, 'a'); //this should fail

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffEmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(37, 'a');

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(500, 'a');//this should fail

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*******************************************************/
        /***************** NI Number TESTING *****************/
        /*******************************************************/


        [TestMethod]
        public void NINumberMinLessOne()
        {
            //create an instance of the new class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the method
            string NINumber = ""; //this should trigger an error

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void NINumberMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string NINumber = "a"; //this should be ok

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NINumberPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string NINumber = "aa"; //this should be ok

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NINumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string NINumber = "aaaaaaaa";

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void NINumberMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string NINumber = "aaaaaaaaa";

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NINumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string NINumber = "aaaaaaaaaa";

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void NINumberMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string NINumber = "aaaaa";

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void NINumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string NINumber = "";
            NINumber = NINumber.PadRight(50, 'a');//this should fail

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        /*******************************************************/
        /***************** SALARY TESTING *****************/
        /*******************************************************/

        [TestMethod]
        public void SalaryExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            double Salary = 0.00;
         
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void SalaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            double Salary = 0.00;

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void SalaryMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            double Salary = 0.01;

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void SalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            double Salary = 0.02;

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void SalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            double Salary = 999999999999999999.98;

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void SalaryMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            double Salary = 999999999999999999.99;

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SalaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            double Salary = 1000000000000000000.00;

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void SalaryMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            double Salary = 500000000000000000.00;

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            double Salary = 9999999999999999999999.99;

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        /** [TestMethod]
        public void SalaryInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //string variable to store any error message
            String Error = "";
          
            //create some test data to pass to the method
            string Salary = "this is not a number!";

            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        } **/

    }
}


