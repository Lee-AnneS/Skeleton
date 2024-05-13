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
        //capture the Staff Full Name
        AStaff.StaffFullName = txtStaffFullName.Text;


        //capture Staff DoB
        // AStaff.StaffDoB = Convert.ToDateTime(txtStaffDoB.Text); CODE DOESNT WORK
        AStaff.StaffDoB = Convert.ToDateTime(DateTime.Now);
        //capture Staff Email
        AStaff.StaffEmail = txtStaffEmail.Text;
        //capture NI Number
        AStaff.NINumber = txtNINumber.Text;
        //capture Salary
        AStaff.Salary = Convert.ToDouble(txtSalary.Text);
        //capture Present In Building
        AStaff.PresentInBuilding = chkPresentInBuilding.Checked;


        //store the Staff Full Name in the session object
        Session["AStaff"] = AStaff;

        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
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


    protected void txtStaffId_TextChanged(object sender, EventArgs e)
    {

    }
}