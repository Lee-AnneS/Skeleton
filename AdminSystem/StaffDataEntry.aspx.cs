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
}