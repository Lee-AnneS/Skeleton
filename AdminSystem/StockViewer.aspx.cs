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
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //get the data from the session object
        AStock = (clsStock)Session["AStock"];
        //display the product id for this entry
        Response.Write(AStock.ProductId + "<br />");
        //display the name for this entry
        Response.Write(AStock.Name + "<br />");
        //display the description for this entry
        Response.Write(AStock.Description + "<br />");
        //display the price for this entry
        Response.Write(AStock.Price + "<br />");
        //display the stock quantity for this entry
        Response.Write(AStock.StockQuantity + "<br />");
        //display the created at for this entry
        Response.Write(AStock.DateAdded + "<br />");
        //display the Available for this entry
        Response.Write(AStock.Available + "<br />");

    }
}