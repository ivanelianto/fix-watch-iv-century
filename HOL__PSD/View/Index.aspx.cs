using System;
using System.Web;

namespace HOL__PSD.View
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["logout"] == "true")
            {
                Application["count_user"] = ((int)Application["count_user"]) - 1;

                Session.Clear();

                HttpCookie authUser = Request.Cookies["auth_user"];

                if (authUser != null)
                {
                    authUser.Value = "";
                    authUser.Expires = DateTime.Now.AddYears(-1);
                    Response.SetCookie(authUser);
                }

                Response.Redirect("Index.aspx");
            }
        }
    }
}