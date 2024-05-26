using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffId != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        //create an instance of the Staff 
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        StaffBook.ThisStaff.Find(StaffId);
        //display the data for the record
        txtStaffId.Text = StaffBook.ThisStaff.StaffID.ToString();
        txtStaffFullName.Text = StaffBook.ThisStaff.StaffFullName.ToString();
        txtStaffDoB.Text = StaffBook.ThisStaff.StaffDoB.ToString();
        txtStaffEmail.Text = StaffBook.ThisStaff.StaffEmail.ToString();
        txtNINumber.Text = StaffBook.ThisStaff.NINumber.ToString();
        txtSalary.Text = StaffBook.ThisStaff.Salary.ToString();
        chkPresentInBuilding.Text = StaffBook.ThisStaff.PresentInBuilding.ToString();
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
            //CAPTURE STAFF ID
            AStaff.StaffID = StaffId; //IMPORTANT!!
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
            //capture PresentInBuilding
            AStaff.PresentInBuilding = chkPresentInBuilding.Checked;
            //create a new instance of the address collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i.e. StaffID =-1 then add the data
            if (StaffId == -1)
            {
                //set ThisStaff property
                StaffList.ThisStaff = AStaff;
                //add the new record 
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffId);
                //set ThisStaff property
                StaffList.ThisStaff = AStaff;
                //update the record
                StaffList.Update();
            }
            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
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
            txtStaffFullName.Text = AStaff.StaffFullName.ToString();
            txtStaffDoB.Text = AStaff.StaffDoB.ToString();
            txtStaffEmail.Text = AStaff.StaffEmail.ToString();
            txtNINumber.Text = AStaff.NINumber.ToString();
            txtSalary.Text = AStaff.Salary.ToString();
            chkPresentInBuilding.Text = AStaff.PresentInBuilding.ToString();
        }
    }
    protected void txtStaffId_TextChanged(object sender, EventArgs e){}
}
