using HOL__PSD.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HOL__PSD.View
{
    public partial class ManageProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove("product_to_edit");

            DataTable dt = DbManager.Get("SELECT * FROM [Product]");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TableRow newRow = new TableRow();
                ProductTable.Controls.Add(newRow);

                TableCell numberCell = new TableCell();
                numberCell.Controls.Add(new Label() { Text = (i + 1) + "." });
                newRow.Cells.Add(numberCell);

                TableCell nameCell = new TableCell();
                nameCell.Controls.Add(new Label() { Text = dt.Rows[i]["name"].ToString() });
                newRow.Cells.Add(nameCell);

                TableCell priceCell = new TableCell();
                priceCell.Controls.Add(new Label() { Text = dt.Rows[i]["price"].ToString() });
                newRow.Cells.Add(priceCell);

                TableCell stockCell = new TableCell();
                stockCell.Controls.Add(new Label() { Text = dt.Rows[i]["stock"].ToString() });
                newRow.Cells.Add(stockCell);

                TableCell editButtonCell = new TableCell();
                Button editButton = new Button() { ID = (i + 1) + "_E", Text = "Edit", CssClass = "btn btn-warning" };
                editButton.Click += EditButton_Click;
                editButtonCell.Controls.Add(editButton);
                newRow.Cells.Add(editButtonCell);

                TableCell deleteButtonCell = new TableCell();
                Button deleteButton = new Button() { ID = (i + 1) + "_D", Text = "Delete", CssClass = "btn btn-danger" };
                deleteButton.Click += DeleteButton_Click;
                deleteButtonCell.Controls.Add(deleteButton);
                newRow.Cells.Add(deleteButtonCell);

                TableCell productIdCell = new TableCell();
                productIdCell.Visible = false;
                productIdCell.Controls.Add(new Label() { Text = dt.Rows[i]["id"].ToString() });
            }
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            int selectedRowIndex = 0;
            if (int.TryParse(currentButton.ID.Substring(0, currentButton.ID.Length - 2), out selectedRowIndex))
            {
                string Productname = ((Label)ProductTable.Rows[selectedRowIndex].Cells[6].Controls[0]).Text;
                DbManager.Execute("DELETE FROM [Product] WHERE id='" + Productname + "'");
                Response.Redirect(Request.RawUrl);
            }
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            int selectedRowIndex = 0;
            if (int.TryParse(currentButton.ID.Substring(0, currentButton.ID.Length - 2), out selectedRowIndex))
            {
                //Product Product = new Product();
                //Product.Productname = ((Label)ProductTable.Rows[selectedRowIndex].Cells[1].Controls[0]).Text;
                //Product.Name = ((Label)ProductTable.Rows[selectedRowIndex].Cells[2].Controls[0]).Text;
                //Product.Password = ((Label)ProductTable.Rows[selectedRowIndex].Cells[3].Controls[0]).Text;
                //Product.Role = ((Label)ProductTable.Rows[selectedRowIndex].Cells[4].Controls[0]).Text;
                //Product.Birthday = DateTime.Parse(((Label)ProductTable.Rows[selectedRowIndex].Cells[5].Controls[0]).Text);

                //Session.Add("product_to_edit", Product);
                Response.Redirect("MasterProduct.aspx");
            }
        }

        protected void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("MasterProduct.aspx");
        }
    }
}