using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       //create a new instance of clsPayments
       clsPayments APayments = new clsPayments();
        // get the data from the session object
        APayments = (clsPayments)Session["APayments"];
        //display the OrderID for this entry
        Response.Write(APayments.OrderId);
        //display the Biiling Address
        Response.Write(APayments.BillingAddress);
        //display the Payment Method
        Response.Write(APayments.PaymentsMethod);
        //display the Amount
        Response.Write(APayments.Amount);
        //display the Payments Date
        Response.Write(APayments.PaymentsDate);
        //display the payments status
        Response.Write(APayments.PaymentsStatus);
        
    }
}