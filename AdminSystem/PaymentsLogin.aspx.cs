using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaymentsLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the payments user class
        clsPaymentsUser AnUser = new clsPaymentsUser();
        //create the variables to store the username and password
        string Username = txtUserName.Text;
        string Password = txtPassword.Text;
        //create a variable to store the result of the find user operation
        Boolean Found = false;
        //get the username entered by the user
        Username = Convert.ToString(txtUserName.Text);
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(Username, Password);
        //add a session to capture the username
        Session["AnUser"] = AnUser;
        //if username and/or password is empty
        if(txtUserName.Text== "")
        {
            //record the error
            lblError.Text = "Please Enter a Username :) ";
        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Please enter a Password :) ";
        }
        //IF FOUND
        else if (Found == true)
        {
            //REDIRECT TO THE LIST PAGE
            Response.Redirect("PaymentsList.aspx");
        }
        else if (Found == false)
        {
            //record the error
            lblError.Text = "Login details are incorrect. Please try again :) ";
        }



    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}