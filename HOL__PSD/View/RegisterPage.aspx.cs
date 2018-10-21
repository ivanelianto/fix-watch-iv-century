using HOL__PSD.Util;
using System;
using System.Web.UI;

namespace HOL__PSD.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                calendarTanggalLahir.SelectedDate = DateTime.Now.Date;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String name = txtName.Text;
            String password = txtPassword.Text;
            String birthday = calendarTanggalLahir.SelectedDate.ToString("yyyy-MM-dd");

            DbManager.Execute("INSERT INTO [User] VALUES ('" + username + "','" + name + "','" + password + "','User','" + birthday + "')");

            PageUtility.Alert(this, "Registrasi Berhasil!");

            Response.Redirect("LoginPage.aspx");
        }
    }
}
