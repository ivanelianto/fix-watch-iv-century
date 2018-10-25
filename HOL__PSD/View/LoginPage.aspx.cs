using HOL__PSD.Model;
using HOL__PSD.Util;
using System;
using System.Data;
using System.Diagnostics;
using System.Web;

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
            DataTable dt = new DataTable();
            dt = DbManager.Get("SELECT * FROM [User] WHERE username='"+ txtUsername.Text +"' AND password='"+ txtPassword.Text +"'");
            
            if (dt.Rows.Count > 0)
            {
                //User adminUser = new User()
                //{
                //    Username = dt.Rows[0]["username"].ToString(),
                //    Name = dt.Rows[0]["name"].ToString(),
                //    Password = dt.Rows[0]["password"].ToString(),
                //    Role = dt.Rows[0]["Role"].ToString(),
                //    Birthday = DateTime.Parse(dt.Rows[0]["birthday"].ToString())
                //};
                User adminUser = new User();
                adminUser.username = dt.Rows[0]["username"].ToString();
                adminUser.name = dt.Rows[0]["name"].ToString();
                adminUser.password = dt.Rows[0]["password"].ToString();
                adminUser.role = dt.Rows[0]["Role"].ToString();
                adminUser.birthday = DateTime.Parse(dt.Rows[0]["birthday"].ToString());

                Session.Add("auth_user", adminUser);

                if (checkBoxRemember.Checked)
                {
                    HttpCookie cookie = new HttpCookie("auth_user", adminUser.username);
                    cookie.Expires = DateTime.Now.AddHours(1.0);
                    Response.Cookies.Add(cookie);
                }

                //if (Application["count_user"] == null)
                //    Application["count_user"] = 1;
                //else

                Application["count_user"] = ((int)Application["count_user"]) + 1;
                
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
