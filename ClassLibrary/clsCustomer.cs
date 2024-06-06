using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer id property
        private Int32 mCustomerId;

        //private data member for the customer name property
        private String mCustomerName;

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
        public String CustomerName
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

        /****** FIND METHOD ******/
        /*************************/

        public bool Find(int CustomerId)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the customer id to serach for
            DB.AddParameter("@CustomerId", CustomerId);

            //excute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");

            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerDoB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDoB"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mNumOrder = Convert.ToInt32(DB.DataTable.Rows[0]["NumOrder"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);

                //return that everything worked OK
                return true;
            }

            //if no record found
            else
            {
                //return flase indicatinf there is a problem
                return false;
            }
    
        }

        /****** VALID METHOD ******/
        /**************************/

        public string Valid(string customerName, string customerDoB, string customerEmail, string customerAddress, string numOrder)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the data values
            DateTime DateTemp;
            
            //if the customerName is blank
            if (customerName.Length == 0)
            {
                //record the error
                Error = Error + "The CustomerName may not be blank : ";
            }
            //if the customerName is greater than 50
            if (customerName.Length > 50)
            {
                //record the error
                Error = Error + "The CustomerName must be less than 50 characters : ";
            }

            //create an instance of DateTime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the customerDoB value to the DateTemp variable
                DateTemp = Convert.ToDateTime(customerDoB);
                if (DateTemp < DateComp)//compare customerDoB added with date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //if the customerEmail is blank
            if (customerEmail.Length == 0)
            {
                //record the error
                Error = Error + "";
            }

            //if the customerEmail is greater than 75
            if (customerEmail.Length > 75)
            {
                //record the error
                Error = Error + "The CustomerEmail must be less than 75 characters : ";
            }

            //if the customerAddress is blank
            if (customerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The CustomerAddress may not be blank : ";
            }
            //if the customerAddress is greater than 100
            if (customerAddress.Length > 100)
            {
                //record the error
                Error = Error + "The CustomerAddress must be less than 100 characters : ";
            }


            /*// check ifnumOrder is a valid number
            if (!int.TryParse(numOrder, out _))
            {
                Error = Error + "The Numorder must be a valid number : ";
            }*/

            //if the numOtrder is blank
            if (numOrder.Length == 0)
            {
                //record the error
                Error = Error + "The NumOrder should be set to 0, if no orders have been placed : ";
            }

            //if the NumOrder is greater than 100
            if (numOrder.Length > 100)
            {
                //record the error
                Error = Error + "The NumOrder must be less than 100 characters : ";
            }

            

            //return any error messages
            return Error;
        }



    }
}