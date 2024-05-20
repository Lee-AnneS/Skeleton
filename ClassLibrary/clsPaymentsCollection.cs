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
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblPayments_SelectAll");
            //get the count of records
            //RecordCount = DB.Count;
            //WHILE THERE ARE RECORDS TO PROCESS
           // while (Index < RecordCount)
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
        public clsPayments ThisPayments { get; set; }
    }
}