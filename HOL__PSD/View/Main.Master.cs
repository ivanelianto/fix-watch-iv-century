using HOL__PSD.Model;
using HOL__PSD.Util;
using System;
using System.Data;

namespace HOL__PSD.View
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth_user"] == null && 
                (Request.Cookies["auth_user"] == null || 
                 string.IsNullOrEmpty(Request.Cookies["auth_user"].Value) ||
                 Request.Cookies["auth_user"].Expires >= DateTime.Now))
            {
                Cart.Visible = false;
                AuthUserName.Visible = false;
                EditProfile.Visible = false;
                Logout.Visible = false;

                if (Application["count_user"] == null)
                    Application["count_user"] = 0;
            }
            else
            {
                if (Session["auth_user"] == null)
                {
                    DataTable dt = DbManager.Get("SELECT * FROM [User] WHERE username='" + Request.Cookies["auth_user"].Value + "'");
                    User currentUser = new User()
                    {
                        Username = dt.Rows[0]["username"].ToString(),
                        Name = dt.Rows[0]["name"].ToString(),
                        Password = dt.Rows[0]["password"].ToString(),
                        Role = dt.Rows[0]["Role"].ToString(),
                        Birthday = DateTime.Parse(dt.Rows[0]["birthday"].ToString())
                    };
                    Session.Add("auth_user", currentUser);
                }

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

            txtCountUserLoggedIn.Text = Application["count_user"] + " User(s) Online.";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}
