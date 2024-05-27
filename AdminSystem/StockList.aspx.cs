using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayName();
        }
        //create new instance of clsStockuser
        clsStockUser AnUser = new clsStockUser();
        //get data from the session object 
        AnUser = (clsStockUser)Session["AnUser"];
        //display the username
        Response.Write("Logged in as: " + AnUser.UserName);
    }
    void DisplayName()
    {
        //create an instance of the Stock collection
        clsStockCollection stockCollection = new clsStockCollection();
        //set the data source to list of stock collection
        lstStockList.DataSource = stockCollection.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ProductId";
        //set the data field to display
        lstStockList.DataTextField = "Name";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ProductId"] = -1;
        //Redirect to the date entry page
        Response.Redirect("StockDataEntry.aspx");
    }



    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value od the record to be edited
        Int32 ProductId;
        //if a record has been seleced from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to be edit
            ProductId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ProductId"] = ProductId;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else 
        {
            //if no record has been selected
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value od the record to be delete
        Int32 ProductId;
        //if a record has been seleced from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to be delete
            ProductId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ProductId"] = ProductId;
            //redirect to the edit page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            //if no record has been selected
            lblError.Text = "Please select a record from the list to delete";
        }

    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the stock object
        clsStockCollection AStock = new clsStockCollection();
        //retrieve the value of name from the presentation layer
        AStock.ReportByName(txtNameFilter.Text);
        //set the data source to the list of stock in the collection
        lstStockList.DataSource = AStock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ProductId";
        //set the name of the field to display
        lstStockList.DataTextField = "Name";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the stock object
        clsStockCollection AStock = new clsStockCollection();
        //set an empty string
        AStock.ReportByName("");
        //clear any existing filter to tidy up the interface
        txtNameFilter.Text = "";
        //set the data source to the list of stock in the collection
        lstStockList.DataSource = AStock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ProductId";
        //set the name of the field to display
        lstStockList.DataTextField = "Name";
        //bind the data to the list
        lstStockList.DataBind();

    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu page
        Response.Redirect("TeamMainMenu.aspx");
    }
}

