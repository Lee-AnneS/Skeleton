using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is being displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayPayments();
        }
    }

    void DisplayPayments()
    {
        //create an instance of the payments collection
        clsPaymentsCollection Payments = new clsPaymentsCollection();
        //set the data source to list of payments in the collection
        lstPaymentsList.DataSource = Payments.PaymentsList;
        //Set the name of the primary key
        lstPaymentsList.DataValueField = "PaymentsId";
        //set the data field to display
        lstPaymentsList.DataTextField = "BillingAddress";
        //bind the data to the list
        lstPaymentsList.DataBind();
    }








}