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
}
