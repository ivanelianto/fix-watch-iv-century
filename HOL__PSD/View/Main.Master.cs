using HOL__PSD.Model;
using System;

namespace HOL__PSD.View
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth_user"] == null)
            {
                Cart.Visible = false;
                AuthUserName.Visible = false;
                EditProfile.Visible = false;
                Logout.Visible = false;
            }
            else
            {
                AuthUserName.Visible = true;
                AuthUserName.Text = "Welcome, " + ((User)Session["auth_user"]).Name;
                LoginButton.Visible = false;
                AuthUserName.Visible = true;

                if (((User)Session["auth_user"]).Role == "Admin")
                {
                    ManageUser.Visible = true;
                    ManageProduct.Visible = true;
                    Report.Visible = true;
                }

                EditProfile.Visible = true;
                Logout.Visible = true;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}
