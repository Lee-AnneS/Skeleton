using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer id property
        private Int32 mCustomerId;

        //private data member for the customer name property
        private string mCustomerName;

        //private data member for the customer DoB property
        private DateTime mCustomerDoB;

        //customerId public property
        public Int32 CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property 
                mCustomerId = value;
            }
        }

        //customerName public property
        public string CustomerName
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerName = value;
            }
        }

        //customerDoB public property
        public DateTime CustomerDoB
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerDoB;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerDoB = value;
            }
        }

        public string CustomerEmail { get; set; }

        public string CustomerAddress { get; set; }

        public int NumOrder { get; set; }

        public bool Active { get; set; }

        public bool Find(int customerId)
        {
            //set the private data members to the test data value 
            mCustomerId = 5;
            mCustomerName = "Tavleen Kaur";
            mCustomerDoB = Convert.ToDateTime("01/01/2000");

            //always return true 
            return true;
        }
    }
}