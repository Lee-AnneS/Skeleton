using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        //public property for the address list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data 
                return mCustomerList;
            }
            set
            {
                //set the private data 
                mCustomerList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsCustomer ThisCustomer { get; set; }

        //constructor for the class
        public clsCustomerCollection()
        {
            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount = 0;

            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();

            //excute the stored procedure 
            DB.Execute("sproc_tblCustomer_SelectAll");

            //get the count of records
            RecordCount = DB.Count;

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();

                //read in the fields for the current record
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.CustomerDoB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDoB"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                ACustomer.NumOrder = Convert.ToInt32(DB.DataTable.Rows[Index]["NumOrder"]);

                //add the record to the private data member 
                mCustomerList.Add(ACustomer);

                //point at the next record
                Index++;
            }

        }


    }
}