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









    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["PaymentsId"] = -1;
        //redirect to the data entry page
        Response.Redirect("PaymentsDataEntry.aspx");
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 PaymentsId;
        //if a record has been selected from the list
        if (lstPaymentsList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            PaymentsId = Convert.ToInt32(lstPaymentsList.SelectedValue);
            //store the data in the session object
            Session["PaymentsId"]= PaymentsId;
            //redirect to the edit page
            Response.Redirect("PaymentsDataEntry.aspx");
        }
        else   //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 PaymentsId;
        //if a record has been selected from the list
        if (lstPaymentsList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            PaymentsId = Convert.ToInt32(lstPaymentsList.SelectedValue);
            //store the data in the session object 
            Session["PaymentsId"] = PaymentsId;
            //redirect to the delete page
            Response.Redirect("PaymentsConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }


    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the payments object
        clsPaymentsCollection APayments = new clsPaymentsCollection();
        //retrieve the value of paymentsmethod from the presentation layer
        APayments.ReportByPaymentsMethod(txtFilter.Text);
        //set the data source to the list of addresses in the collection
        lstPaymentsList.DataSource = APayments.PaymentsList;
        //set the name of the primary key
        lstPaymentsList.DataValueField = "PaymentsId";
        //set the name of the field to display
        lstPaymentsList.DataTextField = "PaymentsMethod";
        //bind the data to the list
        lstPaymentsList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the payments object
        clsPaymentsCollection APayments = new clsPaymentsCollection();
        //set an empty string
        APayments.ReportByPaymentsMethod("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of addresses in the collection
        lstPaymentsList.DataSource = APayments.PaymentsList;
        //set the name of the primary key
        lstPaymentsList.DataValueField = "PaymentsId";
        //set the name of the field to display
        lstPaymentsList.DataTextField = "PaymentsMethod";
        //bind the data to the list
        lstPaymentsList.DataBind();
    }
}