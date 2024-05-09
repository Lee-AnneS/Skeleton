using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();

        //get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];

        //display the Staff Full Nmae for this entry
        Response.Write(AStaff.StaffFullName);
        Response.Write(AStaff.StaffDoB);
        Response.Write(AStaff.StaffEmail);
        Response.Write(AStaff.NINumber);
        Response.Write(AStaff.Salary);
        Response.Write(AStaff.PresentInBuilding);




    }
}