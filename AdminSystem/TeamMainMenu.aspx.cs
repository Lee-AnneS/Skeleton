using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        //redirect the user to the staff login page
        Response.Redirect("StaffLogin.aspx");
    }

    protected void btnStock_Click(object sender, EventArgs e)
    {
        //redirect the user to the stock login page
        Response.Redirect("StockLogin.aspx");
    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        //redirect the user to the order login page
        Response.Redirect("OrderLogin.aspx");
    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        //redirect the user to the customer login page
        Response.Redirect("CustomerLogin.aspx");
    }

    protected void btnPayments_Click(object sender, EventArgs e)
    {
        //redirect the user to the payments login page
        Response.Redirect("PaymentsLogin.aspx");
    }
}