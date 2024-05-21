using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        // constructor for the class
        public clsStockCollection() 
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblProducts_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStock AStock = new clsStock();
                //read in the fields for the current record
                AStock.ProductId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                AStock.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AStock.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AStock.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                AStock.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                AStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                //point at the next record
                Index++;

            }
        }
        //privare data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //privat member data for thisStock
        clsStock mThisStock = new clsStock();
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        public int Count
        {
            get 
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //
            }
        }
        public clsStock ThisStock 
        {
            get
            {
                //return propterty for thisStock
                return mThisStock;
            }
            set 
            {
                //set the private data
                mThisStock = value; 
            }
        }

        /**************** Add Method *******************************/
        public int Add()
        {
            //adds a record to the database based on the values of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisStock.Name);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Available", mThisStock.Available);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblProducts_Insert");
        }

        /**************** Update Method *******************************/
        public int Update()
        {
            //update an existing record to the database based on the values of ThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductId", mThisStock.ProductId);
            DB.AddParameter("@Name", mThisStock.Name);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Available", mThisStock.Available);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblProducts_Update");
        }
    }
}