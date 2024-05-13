using System;

namespace ClassLibrary
{
    public class clsPayments
    {
        //private data member for payments status
        private Boolean mPaymentStatus;

        public bool PaymentStatus 
        {
            get
            { // this line of code sends data out of the property
                return mPaymentStatus;
            }     
            set
            {
                mPaymentStatus = value;
            }
        }

        // private data member for the date addded property
        private DateTime mPaymentDate;
        public DateTime PaymentDate 
        { 
            get
            {   //this line of code sends data out of the property
                return mPaymentDate; 
            }
            set    
            {    // this line of code allows data into the property
                mPaymentDate = value; 
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
        private String mPaymentMethod;
        // paymentmethod public property
        public string PaymentMethod 
        {
            get
            {     // this line of code sends data out of the property
                return mPaymentMethod;
            }
            set
            {  // this line of code allows data into the property
                mPaymentMethod = value;
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
            DB.Execute("sproc_tblPayment_FilterByAddressId");
            // if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mPaymentsId = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentsId"]);
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mBillingAddress = Convert.ToString(DB.DataTable.Rows[0]["BillingAddress"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
                mAmount = Convert.ToDouble(DB.DataTable.Rows[0]["Amount"]);
                mPaymentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PaymentDate"]);
                mPaymentStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["PaymentStatus"]);

                // return that everything worked OK
                return true;
            }

            // if no record was found
            else
            {    // return false
                return false;
            }

        }

    }
}