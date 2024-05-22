using System.Collections.Generic;
using System;
namespace ClassLibrary
{
    public class clsPaymentsCollection
    {
        // constructor for the class
        public clsPaymentsCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0; 
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblPayments_SelectAll");
            //get the count of records
               RecordCount = DB.Count;
              //WHILE THERE ARE RECORDS TO PROCESS
             while (Index < RecordCount)
            {
                //create a blank address
                clsPayments APayments = new clsPayments();
                //read in the fields for the current record 
                APayments.PaymentsStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["PaymentsStatus"]);
                APayments.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                APayments.PaymentsId = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentsId"]);
                APayments.BillingAddress = Convert.ToString(DB.DataTable.Rows[Index]["BillingAddress"]);
                APayments.PaymentsMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentsMethod"]);
                APayments.Amount = Convert.ToDouble(DB.DataTable.Rows[Index]["Amount"]);
                APayments.PaymentsDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["PaymentsDate"]);

                //add the record to the private data memberfdgkjl
                mPaymentsList.Add(APayments);
                //point at the next record
                Index++;

            }
        }


        //private data member for the list
        List<clsPayments> mPaymentsList = new List<clsPayments>();
        //public property for the payments list
        //private member
        clsPayments mThisPayments = new clsPayments();
        public List<clsPayments> PaymentsList
        { 
            get
            {    //return the private data
                return mPaymentsList;
            }
            
            set
            {   //set the private data
                mPaymentsList = value;
            }

        }
        public int Count 
        {
            get
            {
               return PaymentsList.Count;
            }

            set
            {
                //get back to you later 
            }
        
        }

        public clsPayments ThisPayments 
        {

            get
            {   //return the private data
                return mThisPayments;

            }
            set
            {     //set the private data
                mThisPayments = value;
            }
        
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisPayments
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("OrderId", mThisPayments.OrderId);
            DB.AddParameter("BillingAddress", mThisPayments.BillingAddress);
            DB.AddParameter("PaymentsMethod", mThisPayments.PaymentsMethod);
            DB.AddParameter("Amount", mThisPayments.Amount);
            DB.AddParameter("PaymentsDate", mThisPayments.PaymentsDate);
            DB.AddParameter("PaymentsStatus", mThisPayments.PaymentsStatus);
            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblPayments_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisPayments
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PaymentsId", mThisPayments.PaymentsId);
            DB.AddParameter("@OrderId", mThisPayments.OrderId);
            DB.AddParameter("@BillingAddress", mThisPayments.BillingAddress);
            DB.AddParameter("@PaymentsMethod", mThisPayments.PaymentsMethod);
            DB.AddParameter("@Amount", mThisPayments.Amount);
            DB.AddParameter("@PaymentsDate", mThisPayments.PaymentsDate);
            DB.AddParameter("@PaymentsStatus", mThisPayments.PaymentsStatus);
            //execute the stored procedure
            DB.Execute("sproc_tblPayments_Update");
           
        }
    }
}