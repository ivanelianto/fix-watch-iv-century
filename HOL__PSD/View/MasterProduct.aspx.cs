using HOL__PSD.Model;
using System;

namespace HOL__PSD.View
{
    public partial class MasterProduct : System.Web.UI.Page
    {
        Product currentProduct;

        int productId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            currentProduct = ((Product)Session["product_to_edit"]);

            if (currentProduct != null && !IsPostBack)
            {
                productId = currentProduct.id;
                txtName.Text = currentProduct.name;
                txtPrice.Text = currentProduct.price.ToString();
                txtStock.Text = currentProduct.stock.ToString();
            }
        }

        protected void btnProcess_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            using (WatchShopEntities db = new WatchShopEntities())
            {
                if (currentProduct == null)
                {
                    // Operasi Insert
                    currentProduct = new Product();
                    currentProduct.name = txtName.Text;
                    currentProduct.price = decimal.Parse(txtPrice.Text);
                    currentProduct.stock = int.Parse(txtStock.Text);

                    db.Product.Add(currentProduct);
                }
                else
                {
                    Product toUpdateProduct = db.Product.Find(currentProduct.id);

                    // Operasi Update
                    toUpdateProduct.name = txtName.Text;
                    toUpdateProduct.price = decimal.Parse(txtPrice.Text);
                    toUpdateProduct.stock = int.Parse(txtStock.Text);
                }

                db.SaveChanges();

                Response.Redirect("ManageProduct.aspx");
            }
=======
            Page.Validate();
>>>>>>> a88ac2cb43467ed5e0a7bdbb967cd13e1aede8db
        }
    }
}