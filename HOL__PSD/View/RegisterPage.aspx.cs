using System;
using System.Diagnostics;
using System.Web.UI;

namespace HOL__PSD
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
            Debug.WriteLine(txtUsername.Text + " : " +
                txtPassword.Text + " : " +
                calendarTanggalLahir.SelectedDate + " : " +
                fileUploadFoto.FileName);
        }
    }
}
