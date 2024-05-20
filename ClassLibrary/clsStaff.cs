using System;
using System.Data.Common;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the Staff ID property
        private Int32 mStaffId;
        //Staff Id public property
        public int StaffID
        {
            get
            {  //this line of code sends data out of the property
                return mStaffId;
            }
            set
            { //this line of code allows data into the property
                mStaffId = value;
            }
        }
        //private data member for the Staff Full Name property
        private String mStaffFullName;
        //Staff Full Name public property
        public String StaffFullName
        {
            get
            {  //this line of code sends data out of the property
                return mStaffFullName;
            }
            set
            { //this line of code allows data into the property
                mStaffFullName = value;
            }
        }
        //private data member for the Staff DoB property
        private DateTime mStaffDoB;
        //Staff DoB public property
        public DateTime StaffDoB
        {
            get
            {  //this line of code sends data out of the property
                return mStaffDoB;
            }
            set
            { //this line of code allows data into the property
                mStaffDoB = value;
            }
        }
        //private data member for the Staff Email property
        private string mStaffEmail;
        //Staff Email public property
        public string StaffEmail
        {
            get
            {  //this line of code sends data out of the property
                return mStaffEmail;
            }
            set
            { //this line of code allows data into the property
                mStaffEmail = value;
            }
        }
        //private data member for the NINumber property
        private string mNINumber;
        //NI Number public property
        public string NINumber
        {
            get
            {  //this line of code sends data out of the property
                return mNINumber;
            }
            set
            { //this line of code allows data into the property
                mNINumber = value;
            }
        }
        // private data member for the Salary property
        private double mSalary;
        //Salary public property
        public double Salary
        {
            get
            {  //this line of code sends data out of the property
                return mSalary;
            }
            set
            { //this line of code allows data into the property
                mSalary = value;
            }
        }
        //private data member for Present In Building property
        private bool mPresentInBuilding;
        //Present In Building public property
        public bool PresentInBuilding
        {
            get
            {  //this line of code sends data out of the property
                return mPresentInBuilding;
            }
            set
            { //this line of code allows data into the property
                mPresentInBuilding = value;
            }
        }

        /****** FIND METHOD ******/
        public bool Find(int StaffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for staff id to search for 
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found(there should either be one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffFullName = Convert.ToString(DB.DataTable.Rows[0]["StaffFullName"]);
                mStaffDoB = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDoB"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mNINumber = Convert.ToString(DB.DataTable.Rows[0]["NINumber"]);
                mSalary = Convert.ToDouble(DB.DataTable.Rows[0]["Salary"]);
                mPresentInBuilding = Convert.ToBoolean(DB.DataTable.Rows[0]["PresentInBuilding"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string staffFullName, string staffDoB, string staffEmail, string nINumber, string salary)
        {
            /***************** Variables *****************/
            //create string variable to store the error
            String Error = "";
            //create a temporary variable to store the data values
            DateTime DateTemp;

            /***************** Staff Full Name *****************/
            //if the StaffFullName  is blank
            if (staffFullName.Length == 0)
            {
                //record the error
                Error = Error + "Error:The Staff Full Name may not be blank : ";
            }
            //if the Staff Name is greater than 50 characters
            if (staffFullName.Length > 50)
            {
                //record the error
                Error = Error + "Error:The Staff Full Name must be less than 50 characters : ";
            }

            /***************** Staff DoB *****************/
            //create an instance of DateTime tot compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the staff DoB value to the DateTemp variable
                DateTemp = Convert.ToDateTime(staffDoB);
                if (DateTemp < DateComp)//compare staff DoB added with date
                {
                    //record the error
                    Error = Error + "Error:The Staff DoB cannot be in the past : ";
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "Error:The Staff DoB cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "Error: You need to enter a date or the date entered was not a valid date : ";
            }

            /***************** Staff Email *****************/
            //if the staffEmail is greater than 75 characters
            if (staffEmail.Length > 75)
            {
                //record the error
                Error = Error + "Error:The Staff Email must be less than 75 characters : ";
            }

            /***************** NI Number *****************/
            if (nINumber.Length == 0)
            {
                //record the error
                Error = Error + "";
            }
            //if the NINumber is less than 9 characters and more than 0 characters
            if (nINumber.Length < 9)
            { 
                //record the error
                Error = Error + "Error:The Staff NI Number cannot be less than 9 characters : ";
            }
            //if the NINumber is greater than 9 characters
            if (nINumber.Length > 9)
            {
                //record the error
                Error = Error + "Error:The Staff NI Number cannot be more than 9 characters : ";
            }

            /********************* Salary **************************/
            //if the Salary  is blank 
            if (salary.Length == 0)
            {
                //record the error 
                Error = Error + "Error:The Salary value may not be blank : ";
            }
            //if the Salary is greater than 20 characters (data type == decimal(18,2))
            if (salary.Length > 20)
            {
                //record the error 
                Error = Error + "Error:The Salary must be less than £999999999999999999.99 : ";
            }
         //return any error messages 
         return Error;
        }
    }
}