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

        public bool Find(int PaymentsId)
        {
            // set the private data memeber to the test data value
            mPaymentsId = 22;
            mPaymentsDate = Convert.ToDateTime("22/02/2022");
            mOrderId = 20;
            mBillingAddress = "Flat 6 St.Matthews house NG4 5LX";
            mPaymentMethod = "Apple Pay";
            mAmount = 2.22;
            mPaymentsStatus = true;
            // always return true
            return true;
        }
    }
}