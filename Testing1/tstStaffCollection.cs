using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property 
            //in this case data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.PresentInBuilding = true;
            TestItem.StaffID = 1;
            TestItem.StaffFullName = "Lee-Anne Starkie";
            TestItem.StaffDoB = DateTime.Now;
            TestItem.StaffEmail = "p17206496@my365.dmu.ac.uk";
            TestItem.NINumber = "AB123456C";
            TestItem.Salary = 1000000.00;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the test object
            clsStaff TestStaff = new clsStaff();
            //set its properties
            TestStaff.PresentInBuilding = true;
            TestStaff.StaffID = 1;
            TestStaff.StaffFullName = "Lee-Anne Starkie";
            TestStaff.StaffDoB = DateTime.Now;
            TestStaff.StaffEmail = "p17206496@my365.dmu.ac.uk";
            TestStaff.NINumber = "AB123456C";
            TestStaff.Salary = 1000000.00;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property 
            //in this case data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.PresentInBuilding = true;
            TestItem.StaffID = 1;
            TestItem.StaffFullName = "Lee-Anne Starkie";
            TestItem.StaffDoB = DateTime.Now;
            TestItem.StaffEmail = "p17206496@my365.dmu.ac.uk";
            TestItem.NINumber = "AB123456C";
            TestItem.Salary = 1000000.00;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

    }
}
