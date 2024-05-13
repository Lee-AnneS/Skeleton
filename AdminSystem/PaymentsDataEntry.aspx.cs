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
        
        //capture Payment Status
        APayments.PaymentsStatus = chkPaymentsStatus.Checked;

        // Capture the payment details
        APayments.OrderId = Convert.ToInt32(txtOrderId.Text);

        APayments.BillingAddress = txtBillingAddress.Text;

        APayments.PaymentMethod = txtPaymentsMethod.Text;

        APayments.Amount = Convert.ToDouble(txtAmount.Text); 

        APayments.PaymentsDate = Convert.ToDateTime(DateTime.Now);  

       
        // Store the payment properties in the session object
        Session["APayment"] = APayments;

        // navigate to the view page
        Response.Redirect("PaymentsViewer.aspx");
    }
}