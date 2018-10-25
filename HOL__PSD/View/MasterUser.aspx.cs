using HOL__PSD.Model;
using HOL__PSD.Util;
using System;

namespace HOL__PSD.View
{
    public partial class MasterUser : System.Web.UI.Page
    {
        private User selectedUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager1.RegisterAsyncPostBackControl(calendarTanggalLahir);

            if (Session["user_to_edit"] != null)
            {
                selectedUser = (User)Session["user_to_edit"];
                txtUsername.Text = selectedUser.username;
                txtName.Text = selectedUser.name;
                txtPassword.Attributes.Add("value", selectedUser.password);
                roleDropDownList.SelectedValue = selectedUser.role;
                calendarTanggalLahir.SelectedDate = (DateTime) selectedUser.birthday;
            }
        }

        protected void btnProcess_Click(object Sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string name = txtName.Text;
            string password = txtPassword.Text;
            string role = roleDropDownList.SelectedValue;
            string birthday = calendarTanggalLahir.SelectedDate.ToString("yyyy-MM-dd");

            if (Session["user_to_edit"] != null)
            {
                // Operasi Update
                DbManager.Execute("UPDATE [User] SET username='" + username + "', name='" + name + "',password='" + password + "',role='" + role + "', birthday='" + birthday + "' WHERE username='" + selectedUser.username + "'");
                PageUtility.Alert(this, "Pembaruan Data User Berhasil!");
            }
            else
            {
                // Operasi Insert
                DbManager.Execute("INSERT INTO [User] VALUES ('" + username + "','" + name + "','" + password + "','" + role + "','" + birthday + "')");
                PageUtility.Alert(this, "Pemambahan User Baru Berhasil!");
            }

            Response.Redirect("ManageUser.aspx");
        }
    }
}