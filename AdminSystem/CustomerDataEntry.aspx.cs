using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary; 

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();

        //capture the customer name 
        ACustomer.CustomerName = txtCustomerName.Text;

        //capture the customer DoB
        ACustomer.CustomerDoB = Convert.ToDateTime(txtCustomerDoB.Text);

        //capture the customer email
        ACustomer.CustomerEmail = txtCustomerEmail.Text;

        //capture the customer address
        ACustomer.CustomerAddress = txtCustomerAddress.Text;      
        
        //capture the customer numOfOrder
        ACustomer.NumOrder = Convert.ToInt32(txtNumOrder.Text); 

        //capture Active check box
        ACustomer.Active = chkActive.Checked;

        //store the name in the session object
        Session["ACustomer"] = ACustomer;

        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");

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
}