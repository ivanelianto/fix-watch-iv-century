using HOL__PSD.Handler;
using HOL__PSD.Model;
using System;
using System.Collections.Generic;

namespace HOL__PSD.View
{
    public partial class CartPage : System.Web.UI.Page
    {
        protected static List<Cart> carts = new List<Cart>();

        protected void Page_Load(object sender, EventArgs e)
        {
            carts = (List<Cart>)Session["cart"];
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            User user = (User) Session["auth_user"];

            TransactionHandler.Checkout(user, carts);

            Response.Redirect("Index.aspx");
        }
    }
}
