using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary; 

public partial class _1_DataEntry : System.Web.UI.Page
{

    //variable to store the primary key with page level scope
    Int32 CustomerId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number o fthe customer to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);

        if (IsPostBack == false)
        {
            //if this is not a new record 
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();

        //capture the customer name 
        String CustomerName = txtCustomerName.Text;

        //capture the customer DoB
         String CustomerDoB = txtCustomerDoB.Text;

        //capture the customer email
        String CustomerEmail = txtCustomerEmail.Text;

        //capture the customer address
        String CustomerAddress = txtCustomerAddress.Text;      
        
        //capture the customer numOfOrder
        String NumOrder = txtNumOrder.Text; 

        //capture Active check box
        String Active = chkActive.Text;

        //variable to store any error messages
        String Error = "";

        //validate the data
        Error = ACustomer.Valid(CustomerName, CustomerDoB, CustomerEmail, CustomerAddress, NumOrder);
        if (Error == "")
        {
            //capture the customer id
            ACustomer.CustomerId = CustomerId;

            //capture the CustomerName
            ACustomer.CustomerName = CustomerName;

            //capture the CustomerDoB
            ACustomer.CustomerDoB = Convert.ToDateTime(CustomerDoB);

            //capture the CustomerEmail
            ACustomer.CustomerEmail = CustomerEmail;

            //capture the CustomerAddress
            ACustomer.CustomerAddress = CustomerAddress;

            //capture the NumOrder
            ACustomer.NumOrder = Convert.ToInt32(NumOrder);

            //capture active
            ACustomer.Active = chkActive.Checked;

            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();   

            //if this is a new record i.e Customer = -1 then add the data 
            if (CustomerId == -1)
            {
                //set the ThisCustomer property 
                CustomerList.ThisCustomer = ACustomer;

                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerId);

                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;

                //update the record 
                CustomerList.Update();
            }

            //redirect back to the list page 
            Response.Redirect("CustomerList.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class 
        clsCustomer ACustomer = new clsCustomer();

        //create a variable to store the primary key 
        Int32 CustomerId;

        //create a variable to store the result of the find operation 
        Boolean Found = false;
        
        //get the primary key entered bu the user 
        CustomerId = Convert.ToInt32(txtCustomerId.Text);

        //find the record
        Found = ACustomer.Find(CustomerId);

        //if found 
        if (Found == true)
        {
            //display the values of the properties in the form 
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerDoB.Text = ACustomer.CustomerDoB.ToString();
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
            txtNumOrder.Text = ACustomer.NumOrder.ToString();
            chkActive.Checked = ACustomer.Active;
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the Customer Book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();

        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerId);

        //display the data for the record
        txtCustomerId.Text = CustomerBook.ThisCustomer.CustomerId.ToString();
        txtCustomerName.Text = CustomerBook.ThisCustomer.CustomerName;
        txtCustomerDoB.Text = CustomerBook.ThisCustomer.CustomerDoB.ToString();
        txtCustomerEmail.Text = CustomerBook.ThisCustomer.CustomerEmail;
        txtCustomerAddress.Text = CustomerBook.ThisCustomer.CustomerAddress;
        txtNumOrder.Text = CustomerBook.ThisCustomer.NumOrder.ToString();
        chkActive.Checked = CustomerBook.ThisCustomer.Active;

    }
}