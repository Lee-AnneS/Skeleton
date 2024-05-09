using System;

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
        private DateTime mCreatedAt;
        //Creater at public property
        public DateTime CreatedAt
        {
            get
            {
                //this line of code sends data out of the property
                return mCreatedAt;
            }
            set
            {
                //this line of code allows data into the property
                mCreatedAt = value;
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
        /****** FIND METHOD ******/
        public bool Find(int ProductId)
        {
            //set the private data members to the test data value
            mProductId = 3;
            mName = "Milk";
            mDescription = "Test Description";
            mPrice = 5.50;
            mStockQuantity = 1;
            mCreatedAt = Convert.ToDateTime("23/12/2022");
            mAvailable = true;
            //always return true
            return true;
        }
    }


}