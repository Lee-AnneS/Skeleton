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
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the staff full name
        string StaffFullName = txtStaffFullName.Text;
        //capture the staff DoB
        string StaffDoB = txtStaffDoB.Text;
        //capture the Staff Email
        string StaffEmail = txtStaffEmail.Text;
        //capture the NI Number name
        string NINumber = txtNINumber.Text;
        //capture the Salary
        string Salary = txtSalary.Text;
        //capture the staff full name
        string PresentInBuilding = chkPresentInBuilding.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStaff.Valid(StaffFullName, StaffDoB, StaffEmail, NINumber, Salary);
        if (Error == "")
        {
            //capture the Staff Full Name
            AStaff.StaffFullName = StaffFullName;
            //capture Staff DoB -- AStaff.StaffDoB = Convert.ToDateTime(txtStaffDoB.Text); use date format given in examples
            AStaff.StaffDoB = Convert.ToDateTime(StaffDoB);
            //capture Staff Email
            AStaff.StaffEmail = StaffEmail;
            //capture NI Number
            AStaff.NINumber = NINumber;
            //capture Salary
            AStaff.Salary = Convert.ToDouble(Salary);

            //store the Staff Full Name in the session object
            Session["AStaff"] = AStaff;

            //navigate to the view page
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create and instance of the staff class
        clsStaff AStaff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user 
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = AStaff.Find(StaffId); 
        //if found
        if (Found == true)
        {
            txtStaffId.Text = StaffId.ToString();
            txtStaffFullName.Text = AStaff.StaffFullName;
            txtStaffDoB.Text = AStaff.StaffDoB.ToString();
            txtStaffEmail.Text = AStaff.StaffEmail;
            txtNINumber.Text = AStaff.NINumber;
            txtSalary.Text = AStaff.Salary.ToString();
            chkPresentInBuilding.Text = AStaff.PresentInBuilding.ToString();
        }
    }
    protected void txtStaffId_TextChanged(object sender, EventArgs e){}
}