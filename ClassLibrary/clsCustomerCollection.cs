﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private member data for thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

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

        //constructor for the class
        public clsCustomerCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();

            //excute the stored procedure 
            DB.Execute("sproc_tblCustomer_SelectAll");

            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public property for ThisAddress
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        /****** ADD METHOD ******/
        /************************/

        public int Add()
        {
            //adds a record to the database based on the values of mThisCustomer
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure 
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerDoB", mThisCustomer.CustomerDoB);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@NumOrder", mThisCustomer.NumOrder);
            DB.AddParameter("@Active", mThisCustomer.Active);

            //execute the query returning primary key value 
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        /****** UPDATE METHOD ******/
        /***************************/

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the new stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerDoB", mThisCustomer.CustomerDoB);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@NumOrder", mThisCustomer.NumOrder);
            DB.AddParameter("@Active", mThisCustomer.Active);

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        /****** DELETE METHOD ******/
        /***************************/

        public void Delete()
        {
            //delete the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure 
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");

        }

        /****** FILTER METHOD ******/
        /***************************/

        public void ReportByCustomerName(string CustomerName)
        {
            //filters the records based on a full or partial customer name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //send the CustomerName parameter to the database
            DB.AddParameter("@CustomerName", CustomerName);

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerName");

            //populate the array list with the data table
            PopulateArray(DB);

        }

        /*****************************/
        /*****************************/

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount;

            //get the count of records
            RecordCount = DB.Count;

            //clear the private array list 
            mCustomerList = new List<clsCustomer>();

            //while there are records to process
            while(Index < RecordCount)
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