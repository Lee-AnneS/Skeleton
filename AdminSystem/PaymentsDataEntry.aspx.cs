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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsPayments
        clsPayments APayments = new clsPayments();
        //capture the PaymentsOrderID
        string OrderId = txtOrderId.Text;
        //capture the billingaddress
        string BillingAddress = txtBillingAddress.Text;
        //capture the PaymentMethod
        string PaymentsMethod = txtPaymentsMethod.Text;
        //capture the amount
        string Amount = txtAmount.Text;
        //CAPTURE THE PAYMENTSDATE
        string PaymentsDate = txtPaymentsDate.Text;
        //capture payments status
        string PaymentsStatus = chkPaymentsStatus.Text;

        //capture Payment Status

        APayments.PaymentsStatus = chkPaymentsStatus.Checked;

        //APayments.PaymentsStatus = chkPaymentsStatus.Checked;

        //variable to store any error messages
        string Error = "";
        // validate the data
        Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate); 
        if (Error == "")
        {
            // Capture the payment details
            APayments.OrderId = Convert.ToInt32(txtOrderId.Text);

            APayments.BillingAddress = txtBillingAddress.Text;

            APayments.PaymentsMethod = txtPaymentsMethod.Text;

            APayments.Amount = Convert.ToDouble(txtAmount.Text);

            APayments.PaymentsDate = Convert.ToDateTime(DateTime.Now);


            // Store the payment properties in the session object
            Session["APayments"] = APayments;

            // navigate to the view page
            Response.Redirect("PaymentsViewer.aspx");

        }
        else 
        {
            //display the error message
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // create an instance of the Payments class
        clsPayments APayments = new clsPayments();
        // create a variable to store the primary key
        Int32 PaymentsId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        PaymentsId = Convert.ToInt32(txtPaymentsId.Text);
        //FIND THE RECORD
        Found = APayments.Find(PaymentsId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtOrderId.Text = APayments.OrderId.ToString();
            txtBillingAddress.Text = APayments.BillingAddress;
            txtPaymentsMethod.Text = APayments.PaymentsMethod.ToString();
            txtAmount.Text = APayments.Amount.ToString();
            txtPaymentsDate.Text = APayments.PaymentsDate.ToString();
            chkPaymentsStatus.Checked = APayments.PaymentsStatus;



        }
    }
}