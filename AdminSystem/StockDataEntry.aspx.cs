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


    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //capture the productid no
        AStock.ProductId = Convert.ToInt32(txtProductId.Text);
        //capture the name 
        AStock.Name = txtName.Text;
        //capture the Description 
        AStock.Description = txtDescription.Text;
        //capture the price 
        AStock.Price = Convert.ToDouble(txtPrice.Text);
        //capture the stock quantity
        AStock.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);
        //capture the created at
        AStock.CreatedAt = Convert.ToDateTime(DateTime.Now);
        //capture the available check box
        AStock.Available = chkAvailable.Checked;
        //store the Product in the session object
        Session["AStock"] = AStock;
        //navigate to the view page
        Response.Redirect("StockViewer.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock AStock = new clsStock();
        //create a variable to store the primary key
        Int32 ProductId;
        //create a variable to store the result of the find oparation
        Boolean Found = false;
        //get the primary key entered by the user
        ProductId = Convert.ToInt32(txtProductId.Text);
        //find the record
        Found = AStock.Find(ProductId);
        //if found
        if (Found == true)
        {
            //display the values od the properties in the form
            txtProductId.Text = AStock.ProductId.ToString();
            txtName.Text = AStock.Name;
            txtDescription.Text = AStock.Description;
            txtPrice.Text = AStock.Price.ToString();
            txtStockQuantity.Text = AStock.StockQuantity.ToString();
            txtCreatedAt.Text = AStock.CreatedAt.ToString();
            chkAvailable.Checked = AStock.Available;
        }
    }
}