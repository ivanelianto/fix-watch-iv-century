using HOL__PSD.Model;
using HOL__PSD.Util;
using System;

namespace HOL__PSD.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                User adminUser = new User("admin", "Administrator", "admin", new DateTime(1990, 10, 10));
                Session.Add("auth_user", adminUser);
                Response.Redirect("Index.aspx");
            }
            else
            {
                String errorMessage = "Invalid username or password!";
                PageUtility.Alert(this, errorMessage);
            }
        }
    }
}
