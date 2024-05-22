using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 PaymentsId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the payments to be deleted from the session object
        PaymentsId = Convert.ToInt32(Session["PaymentsId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the paymentsbook collection
        clsPaymentsCollection PaymentsBook = new clsPaymentsCollection();
        //find the record to delete
        PaymentsBook.Delete();
        //rediract to the main page
        Response.Redirect("PaymentsBookList.aspx");
    }
}