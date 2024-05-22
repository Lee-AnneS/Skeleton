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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PresentInBuilding = true;
            TestItem.StaffID = 1;
            TestItem.StaffFullName = "Lee-Anne Starkie";
            TestItem.StaffDoB = DateTime.Now;
            TestItem.StaffEmail = "p17206496@my365.dmu.ac.uk";
            TestItem.NINumber = "AB123456C";
            TestItem.Salary = 1000000.00;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PresentInBuilding = true;
            TestItem.StaffID = 1;
            TestItem.StaffFullName = "Lee-Anne Starkie";
            TestItem.StaffDoB = DateTime.Now;
            TestItem.StaffEmail = "p17206496@my365.dmu.ac.uk";
            TestItem.NINumber = "AB123456C";
            TestItem.Salary = 1000000.00;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //modify the test record
            TestItem.PresentInBuilding = false;
            TestItem.StaffID = 9;
            TestItem.StaffFullName = "Another Name";
            TestItem.StaffDoB = DateTime.Now;
            TestItem.StaffEmail = "AnotherEmail@google.co.uk";
            TestItem.NINumber = "ANOTHERNI";
            TestItem.Salary = 7600000.00;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the rcord
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see if ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
    }

}
