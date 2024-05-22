using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number the primary key with page level scope
        ProductId = Convert.ToInt32(Session["ProductId"]);
        if (IsPostBack == false) 
        {
            //if this is  the not a new record
            if (ProductId != -1)
            {
                //display the current data for the record
                DisplayProduct();

            }
        } 
        

    }
    void DisplayProduct()
    {
        //create an instance of the Product
        clsStockCollection AStock = new clsStockCollection();
        //find the record to update
        AStock.ThisStock.Find(ProductId);
        //display the values od the properties in the form
        txtProductId.Text = AStock.ThisStock.ProductId.ToString();
        txtName.Text = AStock.ThisStock.Name.ToString();
        txtDescription.Text = AStock.ThisStock.Description.ToString();
        txtPrice.Text = AStock.ThisStock.Price.ToString();
        txtStockQuantity.Text = AStock.ThisStock.StockQuantity.ToString();
        txtDateAdded.Text = AStock.ThisStock.DateAdded.ToString();
        chkAvailable.Checked = AStock.ThisStock.Available;

    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        
        //capture the name 
        string Name = txtName.Text;
        //capture the Description 
        string Description = txtDescription.Text;
        //capture the price 
        string Price = txtPrice.Text;
        //capture the stock quantity
        string StockQuantity = txtStockQuantity.Text;
        //capture the created at
        string DateAdded = txtDateAdded.Text;
        //capture the available check box
        string Available = chkAvailable.Text;
        //variable to store any error messages
        string Error = "";
        Error = AStock.Valid(Name, Description, Price, StockQuantity, DateAdded);
        if (Error == "") 
        {
            //capture the product id 
            AStock.ProductId = ProductId;
            //capture the name 
            AStock.Name = Name;
            //capture the Description 
            AStock.Description = Description;
            //capture the Price 
            AStock.Price = Convert.ToDouble(Price);
            //capture the StockQuantity 
            AStock.StockQuantity = Convert.ToInt32(StockQuantity);
            //capture the Description 
            AStock.DateAdded = Convert.ToDateTime(DateAdded);
            //capture the Available
            AStock.Available = chkAvailable.Checked;
            //create a new insance of the  stock collection
            clsStockCollection StockList = new clsStockCollection();
            //if this is a new record i.e ProductId = -1 then add the data
            if (ProductId == -1)
            {
               
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //add th new record
                StockList.Add();
            }
            else 
            {
                // find the record to update
                StockList.ThisStock.Find(ProductId);
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //update the record
                StockList.Update(); 
            }
            //navigate to the view page
            Response.Redirect("StockList.aspx");
        }
        else 
        {
            //display the error message
            lblError.Text = Error;
        }
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
            txtDateAdded.Text = AStock.DateAdded.ToString();
            chkAvailable.Checked = AStock.Available;
        }
    }

    protected void ButtonCancel_Click(object sender, EventArgs e)
    {
        //navigate to the view page
        Response.Redirect("StockList.aspx");

    }
}