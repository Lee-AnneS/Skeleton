using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //practical 9 - private data member for the Staff ID property
        private Int32 mStaffId;

        //practical 9 - Staff Id public property
        public int StaffID 
        {       get 
                {  //this line of code sends data out of the property
                    return mStaffId;
                }
                set 
                { //this line of code allows data into the property
                    mStaffId = value;
                } 
            }
        //practical 9 - private data member for the Staff Full Name property
        private String mStaffFullName;

        //practical 9 - Staff Full Name public property
        public String StaffFullName
        {   get
            {  //this line of code sends data out of the property
                return mStaffFullName;
            }
            set
            { //this line of code allows data into the property
                mStaffFullName = value;
            }
        }


        //practical 9 - private data member for the Staff DoB property
        private DateTime mStaffDoB;
        //practical 9 - Staff DoB public property
        public DateTime StaffDoB
        {   get
            {  //this line of code sends data out of the property
                return mStaffDoB;
            }
            set
            { //this line of code allows data into the property
                mStaffDoB = value;
            }
        }


        //practical 9 - private data member for the Staff Email property
        private string mStaffEmail;
        //practical 9 - Staff Email public property
        public string StaffEmail
        {   get
            {  //this line of code sends data out of the property
                return mStaffEmail;
            }
            set
            { //this line of code allows data into the property
                mStaffEmail = value;
            }
        }


        //practical 9 - private data member for the NINumber property
        private string mNINumber;
        //practical 9 - Staff Id public property
        public string NINumber
        {    get
            {  //this line of code sends data out of the property
                return mNINumber;
            }
            set
            { //this line of code allows data into the property
                mNINumber = value;
            }
        }


        //practical 9 - private data member for the Salary property
        private double mSalary;
        //practical 9 - Salary public property
        public double Salary
        {   get
            {  //this line of code sends data out of the property
                return mSalary;
            }
            set
            { //this line of code allows data into the property
                mSalary = value;
            }
        }


        //practical 9 - private data member for Present In Building property
        private bool mPresentInBuilding;
        //practical 9 - Present In Building public property
        public bool PresentInBuilding
        {   get
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
            //set the private data members to the test data value
            mStaffId = 1;
            mStaffFullName = "Lee-Anne Starkie";
            mStaffDoB = Convert.ToDateTime("10/04/1999");
            mStaffEmail = "p17206496@my365.dmu.ac.uk";
            mNINumber = "AB123456C";
            mSalary = 1000000.0000;
            mPresentInBuilding = true;
            //always return true
            return true;
        }
    }
}