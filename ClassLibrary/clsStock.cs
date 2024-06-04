using System;
using System.IO;

namespace ClassLibrary
{
    public class clsStock
    {//private data member for the Product id property
        private Int32 mProductId;
        //ProductId public property
        public int ProductId
        {
            get
            {
                //this line of code sends data out of the property
                return mProductId;
            }
            set
            {
                //this line of code allows data into the property
                mProductId = value;
            }
        }
        //private data member for the Name no property
        private string mName;
        //Name no public property
        public string Name
        {
            get
            {
                //this line of code sends data out of the property
                return mName;
            }
            set
            {
                //this line of code allows data into the property
                mName = value;
            }
        }
        //private data member for the Description property
        private string mDescription;
        //Description public property
        public string Description
        {
            get
            {
                //this line of code sends data out of the property
                return mDescription;
            }
            set
            {
                //this line of code allows data into the property
                mDescription = value;
            }
        }
        //private data member for the Price property
        private Double mPrice;
        //Price public property
        public Double Price
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }
        //private data member for the post code property
        private int mStockQuantity;
        //stock quantity public property
        public int StockQuantity
        {
            get
            {
                //this line of code sends data out of the property
                return mStockQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mStockQuantity = value;
            }
        }
        //private data member for the created at property
        private DateTime mDateAdded;
        //Creater at public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }
        //private data member for the Available property
        private Boolean mAvailable;
        //Available public property
        public bool Available
        {
            get
            {
                //this line of code sends data out of the property
                return mAvailable;
            }
            set
            {
                //this line of code allows data into the property
                mAvailable = value;
            }
        }
        /*******************************************************/
        /********************* FIND METHOD *********************/
        /*******************************************************/

        public bool Find(int ProductId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the Product id to search for
            DB.AddParameter("@ProductId", ProductId);
            // execute the stored procedure
            DB.Execute("sproc_tblProducts_FilterByProductId");
            // if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);

                // return that everything worked OK
                return true;
            }
            // if no record was found
            else
            {    // return false
                return false;
            }
        }
        /*******************************************************/
        /**************** Valid Method *************************/
        /*******************************************************/

        public string Valid(string Name, string Description, string Price, string StockQuantity, string DateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            /**************** Name *************************/
            //if the Name is blank
            if (Name.Length == 0)
            {
                //record the error 
                Error = Error + "The name may not be blank : ";
            }
            if (Name.Length > 15)
            {
                //record the error
                Error = Error + "The name must be less than 10 characters : ";
                
            }
            /**************** Date Added *************************/
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //create an instance of DateTime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
                //check to see if the date is less than today's date
                if (DateTemp < DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //recod the error
                Error = Error + "The date was not a valid date : ";
            }

            /**************** Description *************************/
            //is the Description  blank
            if (Description.Length == 0)
            {
                //record the error
                Error = Error + "The description not be blank : ";
            }
            //if the description is too long
            if (Description.Length > 170)
            {
                //record the error
                Error = Error + "The description must be less than 50 characters : ";
            }
            /**************** Price *************************/
            //is the Price blank
            if (Price.Length == 0)
            {
                //record the error
                Error = Error + "The Price may not be blank : ";
            }
            //if the Price is too long
            if (Price.Length > 20)
            {
                //record the error
                Error = Error + "The Price must be less than 50 characters : ";
            }
            /**************** StockQuantity *************************/
            //is the StockQuantity blank
            if (StockQuantity.Length == 0)
            {
                //record the error
                Error = Error + "The Stock Quantity may not be blank : ";
            }
            //if the town is too long
            if (StockQuantity.Length > 50)
            {
                //record the error
                Error = Error + "The Stock Quantity must be less than 50 characters : ";
            }

            //return the error
            return Error;
        }
    }
}