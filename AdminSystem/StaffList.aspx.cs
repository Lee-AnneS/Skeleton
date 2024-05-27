using ClassLibrary;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the listbox
            DisplayStaff();
        }

        //create new instance of clsStaffUser
        clsStaffUser AnUser = new clsStaffUser();
        //get data from the session object 
        AnUser = (clsStaffUser)Session["AnUser"];
        //display the username
        Response.Write("Logged in as: " + AnUser.Username);
    }
    void DisplayStaff()
    {
        //create an instance of the Staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to list of staff in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the data field to display
        lstStaffList.DataTextField = "StaffFullName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEnrty.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StaffId;
        //if a record is selected from the list
        if(lstStaffList.SelectedIndex != -1) //first checks to see if the list has been selected
        { 
            //get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);// If it has, pick up the primary key
                                                                  // value via the SelectedValue property of the list box.
                                                                  //store the data in the session object
            Session["StaffId"] = StaffId; // Assuming it has we then place the primary key value into the session object.
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx"); // Then we redirect to the page AnAddress.aspx.
        }
        else //if nbo record has been selected
        {
            //display error message
            lblError.Text = "Please select a record from the list to edit";
            // The error label will display a message to the user if a list item hasn’t been selected.
        }
        //Each item in the list has an index from 0 to N. If the first item is clicked, accessing SelectedIndex will
        //produce a value of 0.If nothing has been selected then the SelectedIndex will be - 1 so we need to tell
        //the user to click something.
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StaffId;
        //if a record is selected from the list
        if (lstStaffList.SelectedIndex != -1) //first checks to see if the list has been selected
        {
            //get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);// If it has, pick up the primary key
                                                                  // value via the SelectedValue property of the list box.
                                                                  //store the data in the session object
            Session["StaffId"] = StaffId; // Assuming it has we then place the primary key value into the session object.
            //redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx"); // Then we redirect to the page StaffConfirmDelete.aspx.
        }
        else //if no record has been selected
        {
            //display error message
            lblError.Text = "Please select a record from the list to delete";
            // The error label will display a message to the user if a list item hasn’t been selected.
        }
        //Each item in the list has an index from 0 to N. If the first item is clicked, accessing SelectedIndex will
        //produce a value of 0.If nothing has been selected then the SelectedIndex will be - 1 so we need to tell
        //the user to click something.
     }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff collection
        clsStaffCollection AStaff = new clsStaffCollection();
        //retrieve the value of full name from presentation layer
        AStaff.ReportByStaffFullName(txtFilterByStaffFullName.Text);
        //set the data sourceto the list of addresses in the collection
        lstStaffList.DataSource = AStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the data field to display
        lstStaffList.DataTextField = "StaffFullName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff collection
        clsStaffCollection AStaff = new clsStaffCollection();
        //set an empty string
        AStaff.ReportByStaffFullName("");
        //clear any existing filter to tidy up the interface
        txtFilterByStaffFullName.Text = "";
        //set the data source to the list of the staff in the collection
        lstStaffList.DataSource = AStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the data field to display
        lstStaffList.DataTextField = "StaffFullName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnRtnToMenu_Click(object sender, EventArgs e)
    {
        //redirect user to the main menu page
        Response.Redirect("TeamMainMenu.aspx");
    }
}





   