using HOL__PSD.Factory;
using HOL__PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HOL__PSD.View
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        protected static Product product;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Context.Request.QueryString.Get("id");

                using (WatchShopEntities db = new WatchShopEntities())
                {
                    product = db.Product.Where(x => x.id.ToString() == id).FirstOrDefault();
                    qtyValidator.MaximumValue = product.stock.ToString();
                    qtyValidator.ErrorMessage = "Quantity Must Between 1 and " + qtyValidator.MaximumValue;
                }
            }
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            List<Cart> carts = new List<Cart>();

            bool isExist = false;
            if (Session["cart"] != null)
            {
                carts = (List<Cart>)Session["cart"];
                foreach (Cart item in carts)
                {
                    if (item.Product == product)
                    {
                        item.Quantity += int.Parse(txtQuantity.Text);
                        isExist = true;
                        break;
                    }
                }
            }

            if (!isExist || Session["cart"] == null)
            {
                Cart cart = CartFactory.Create(int.Parse(txtQuantity.Text), product);
                carts.Add(cart);
            }

            Session["cart"] = carts;

            Response.Redirect("Index.aspx");
        }
    }
}