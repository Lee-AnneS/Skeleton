using System;

namespace ClassLibrary
{
    public class clsPayments
    {
        //private data member for payments status
        private Boolean mPaymentsStatus;

        public bool PaymentsStatus 
        {
            get
            { // this line of code sends data out of the property
                return mPaymentsStatus;
            }     
            set
            {
                mPaymentsStatus = value;
            }
        }

        // private data member for the date addded property
        private DateTime mPaymentsDate;
        public DateTime PaymentsDate 
        { 
            get
            {   //this line of code sends data out of the property
                return mPaymentsDate; 
            }
            set    
            {    // this line of code allows data into the property
                mPaymentsDate = value; 
            }
        }

        //Private data memeber for the payments id property
        private Int32 mPaymentsId;

        //paymentsId public property
        public Int32 PaymentsId 
        {
            get
            {
                // this line of code sends data out of the property
                return mPaymentsId;
            }
            set 
            {
                // this line of code allows data into the property
                mPaymentsId = value;
            }
        }
        //private data member for the Order Id property
        private int mOrderId;
        // OrderID public property
        public int OrderId 
        {
            get
            {  //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {    //this line of code allows data into the property
                mOrderId = value;
            }
        }
        // private data member for billing address
        private string mBillingAddress;
        public string BillingAddress
        {
            get 
            {  // this line of code sends out data of the property
                return mBillingAddress;
            }
            set
            {  //this line of code allows data into the property
                mBillingAddress = value;
            }
        }
        // private data member for the paymentmethod property
        private String mPaymentsMethod;
        // paymentmethod public property
        public string PaymentsMethod 
        {
            get
            {     // this line of code sends data out of the property
                return mPaymentsMethod;
            }
            set
            {  // this line of code allows data into the property
                mPaymentsMethod = value;
            }
        }
        // private data member for amount property
        private double mAmount;
        public double Amount
        { 
            get
            {  //this line of code sends data out of the property
                return mAmount; 
            }
            set
            {    // this line of code allows data into the property
                mAmount = value;
            }
        }
        //..............000000000000.....FIND METHOD............000000000......//
        public bool Find(int PaymentsId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the Payment id to search for
            DB.AddParameter("@PaymentsId", PaymentsId);
            // execute the stored procedure
            DB.Execute("sproc_tblPayments_FilterByPaymentsId");
            // if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mPaymentsId = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentsId"]);
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mBillingAddress = Convert.ToString(DB.DataTable.Rows[0]["BillingAddress"]);
                mPaymentsMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentsMethod"]);
                mAmount = Convert.ToDouble(DB.DataTable.Rows[0]["Amount"]);
                mPaymentsDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PaymentsDate"]);
                mPaymentsStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["PaymentsStatus"]);

                // return that everything worked OK
                return true;
            }

            // if no record was found
            else
            {    // return false
                return false;
            }

        }

        public string Valid(string orderId, string billingAddress, string paymentsMethod, string amount, object paymentsDate)
        {
            return "";
        }
    }
}