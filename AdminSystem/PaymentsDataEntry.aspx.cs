using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


//there was an error in the code
//to fix it i added USING SYSTEM

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 PaymentsId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        PaymentsId = Convert.ToInt32(Session["PaymentsId"]);
        if (IsPostBack== false)
        {
            //if this is not a new record
            if(PaymentsId != -1 )
            {
                //display the current data for the record
                DisplayPayments();
            }
        }
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

        //variable to store any error messages
        string Error = "";
        // validate the data
        Error = APayments.Valid(OrderId, BillingAddress, PaymentsMethod, Amount, PaymentsDate);
        if (Error == "")
        {
            // Capture the payment details
            APayments.PaymentsId = PaymentsId; //IMPORTANT

            APayments.OrderId = Convert.ToInt32(OrderId);

            APayments.BillingAddress = BillingAddress;

            APayments.PaymentsMethod = PaymentsMethod;

            APayments.Amount = Convert.ToDouble(Amount);

            APayments.PaymentsDate = Convert.ToDateTime(PaymentsDate);

            APayments.PaymentsStatus = chkPaymentsStatus.Checked;

            //Create a new instance of the payments collection
            clsPaymentsCollection PaymentsList = new clsPaymentsCollection();

            if (PaymentsId == -1)
            { 
                 //set the ThisPayments property
                 PaymentsList.ThisPayments = APayments;
                 //update the record
                 PaymentsList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                PaymentsList.ThisPayments.Find(PaymentsId);
                //SET THE ThisPayments property
                PaymentsList.ThisPayments = APayments;
                //Update the record
                PaymentsList.Update();
            }
            // redirect back to the LIST page
            Response.Redirect("PaymentsList.aspx");
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
            txtBillingAddress.Text = APayments.BillingAddress.ToString();
            txtPaymentsMethod.Text = APayments.PaymentsMethod.ToString();
            txtAmount.Text = APayments.Amount.ToString();
            txtPaymentsDate.Text = APayments.PaymentsDate.ToString();
            chkPaymentsStatus.Checked = APayments.PaymentsStatus;
        }
    }
    void DisplayPayments()
    {
        //create an instance of the payments
        clsPaymentsCollection Payments = new clsPaymentsCollection();
        //find the record to update
        Payments.ThisPayments.Find(PaymentsId);
        //display the data for the record
        txtPaymentsId.Text = Payments.ThisPayments.PaymentsId.ToString();
        txtOrderId.Text = Payments.ThisPayments.OrderId.ToString();
        txtBillingAddress.Text = Payments.ThisPayments.BillingAddress.ToString();
        txtPaymentsMethod.Text = Payments.ThisPayments.PaymentsMethod.ToString();
        txtAmount.Text = Payments.ThisPayments.Amount.ToString();
        txtPaymentsDate.Text = Payments.ThisPayments.PaymentsDate.ToString();
        chkPaymentsStatus.Checked = Payments.ThisPayments.PaymentsStatus;
        
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the list page
        Response.Redirect("PaymentsList.aspx");
    }
}