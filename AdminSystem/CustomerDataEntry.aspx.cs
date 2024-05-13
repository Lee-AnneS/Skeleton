using System;
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

    
}