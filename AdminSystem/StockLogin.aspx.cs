using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the stock user class
        clsStockUser AnUser = new clsStockUser();
        //create the variables to store the UserName and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //create variable to store the result of the find user operation
        Boolean Found = false;
        //get the UserName entered by the user
        UserName = Convert.ToString(txtUserName.Text);
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record 
        Found = AnUser.FindUser(UserName, Password);

        //add a session to capture the UserName
        Session["AnUser"] = AnUser;

        //if UserName and/or password is empty
        if (txtUserName.Text == "")
        {
            //record the error
            lblError.Text = "Please Enter a Username ";
        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Please Enter a password ";
        }
        //if found
        else if (Found == true)
        {
            //redirect to list page
            Response.Redirect("StockList.aspx");
        }
        else if (Found == false)
        {
            //record the error
            lblError.Text = "Login details are incorrect. Please try again!  ";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect user to the main menu page
        Response.Redirect("TeamMainMenu.aspx");
    }

}