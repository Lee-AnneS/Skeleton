﻿using System;
using System.IO;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsStockUser
    {
        //private data member for the user id property
        private Int32 mUserID;
        //private data member for the user name property
        private string mUserName;
         //private data member for the password property
        private string mPassword;
         //private data member for the department property
        private string mDepartment;



        public int UserID
        {
            get
            { 
                //return the private date
                return mUserID;
            }
            set
            {
                //set the private date
                mUserID = value;
            }
        }
        public string UserName 
        {
            get 
            {
                //return the private date
                return mUserName;
            }
            set 
            {
                //set private date
                mUserName = value;
            }
        }
        public string Password
        {
            get 
            {
                //return the private date
                return mPassword;
            }
            set 
            {
                //set the private date
                mPassword = value;
            } 
        }
        public string Department 
        {
            get 
            {
                //return the private date
                return mDepartment;
            }
            set 
            {
                //set the private date
                mDepartment = value;
            }
        }

        public bool FindUser(string UserName, string Password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the user username and password to search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found ( there should be either one or none)
            if (DB.Count ==1) 
            {
                //copy the data from the database to tghe private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everthing worked ok
                return true;
            }
            else 
            {
                return false;
            }
            
        }
    }
}