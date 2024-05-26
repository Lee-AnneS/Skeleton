using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //crceate an instance of the staff user class
        clsStaffUser AnUser = new clsStaffUser();   
        //create the variables to store the username and password 
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        //create variable to store the result of the find user operation
        Boolean Found = false;
        //get the username entered by the user
        Username = Convert.ToString(txtUsername.Text);
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record 
        Found = AnUser.FindUser(Username, Password);
        //if username and/or password is empty
        if (txtUsername.Text =="")
        {
            //record the error
            lblError.Text = "Please Enter a username ";
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
            Response.Redirect("StaffList.aspx");
        }
        else if (Found == false)
        {
            //record the error
            lblError.Text = "Login details are incorrect. Please try again!  ";
        }
    }
}