using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for thisStaff
        clsStaff mThisStaff = new clsStaff();

        //public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //set the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //set the private data
            }
        }

        //public porperty for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        //constructor for the class
        public clsStaffCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff member
                clsStaff AStaff = new clsStaff();
                //read in the fields for the current record
                AStaff.PresentInBuilding = Convert.ToBoolean(DB.DataTable.Rows[Index]["PresentInBuilding"]);
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.StaffFullName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFullName"]);
                AStaff.StaffDoB = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDoB"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AStaff.NINumber = Convert.ToString(DB.DataTable.Rows[Index]["NINumber"]);
                AStaff.Salary = Convert.ToDouble(DB.DataTable.Rows[Index]["Salary"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point to the next record
                Index++;
            }

           
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffFullName", mThisStaff.StaffFullName);
            DB.AddParameter("@StaffDoB", mThisStaff.StaffDoB);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@NINumber", mThisStaff.NINumber);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@PresentInBuilding", mThisStaff.PresentInBuilding);
            //execute the query returning the primary key value
             return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //update existing record to the database based on the values of mThisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffFullName", mThisStaff.StaffFullName);
            DB.AddParameter("@StaffDoB", mThisStaff.StaffDoB);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@NINumber", mThisStaff.NINumber);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@PresentInBuilding", mThisStaff.PresentInBuilding);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblStaff_Update");
        }
    }
}

