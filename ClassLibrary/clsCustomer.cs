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

        //private data member for the customer email property
        private string mCustomerEmail;

        //private data member for the customer address property
        private string mCustomerAddress;

        //private data member for the number of order property
        private Int32 mNumOrder;

        //private data member for the number of order property
        private Boolean mActive;

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

        //customerEmail public property
        public String CustomerEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerEmail;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmail = value;
            }
        }

        //customerAddress public property
        public String CustomerAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerAddress;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerAddress = value;
            }
        }

        //NumOrder public property
        public Int32 NumOrder
        {
            get
            {
                //this line of code sends data out of the property
                return mNumOrder;
            }
            set
            {
                //this line of code allows data into the property
                mNumOrder = value;
            }
        }

        //Acvite public property
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }

        public bool Find(int customerId)
        {
            //set the private data members to the test data value 
            mCustomerId = 5;
            mCustomerName = "Tavleen Kaur";
            mCustomerDoB = Convert.ToDateTime("01/01/2000");
            mCustomerEmail = "tkaur@gmail.com";
            mCustomerAddress = "12 Ash Road, XXX XXX";
            mNumOrder = 10;
            mActive = true;

            //always return true 
            return true;
        }
    }
}