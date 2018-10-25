using HOL__PSD.Model;
using HOL__PSD.Util;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace HOL__PSD.View
{
    public partial class ManageUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove("user_to_edit");

            DataTable dt = DbManager.Get("SELECT * FROM [User]");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TableRow newRow = new TableRow();
                UserTable.Controls.Add(newRow);

                TableCell numberCell = new TableCell();
                numberCell.Controls.Add(new Label() { Text = (i + 1) + "." });
                newRow.Cells.Add(numberCell);

                TableCell usernameCell = new TableCell();
                usernameCell.Controls.Add(new Label() { Text = dt.Rows[i]["username"].ToString() });
                newRow.Cells.Add(usernameCell);

                TableCell nameCell = new TableCell();
                nameCell.Controls.Add(new Label() { Text = dt.Rows[i]["name"].ToString() });
                newRow.Cells.Add(nameCell);

                TableCell passwordCell = new TableCell();
                passwordCell.Controls.Add(new Label() { Text = dt.Rows[i]["password"].ToString() });
                newRow.Cells.Add(passwordCell);

                TableCell roleCell = new TableCell();
                roleCell.Controls.Add(new Label() { Text = dt.Rows[i]["role"].ToString() });
                newRow.Cells.Add(roleCell);

                TableCell birthdayCell = new TableCell();
                birthdayCell.Controls.Add(new Label() { Text = dt.Rows[i]["birthday"].ToString() });
                newRow.Cells.Add(birthdayCell);

                TableCell editButtonCell = new TableCell();
                Button editButton = new Button() { ID = (i + 1) + "_E", Text = "Edit", CssClass = "btn btn-warning" };
                editButton.Click += EditButton_Click;
                editButtonCell.Controls.Add(editButton);
                newRow.Cells.Add(editButtonCell);

                TableCell deleteButtonCell = new TableCell();
                Button deleteButton = new Button() { ID = (i + 1) + "_D", Text = "Delete", CssClass = "btn btn-danger" };
                deleteButton.Click += DeleteButton_Click;
                deleteButtonCell.Controls.Add(deleteButton);
                newRow.Cells.Add(deleteButtonCell);
            }
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            int selectedRowIndex = 0;
            if (int.TryParse(currentButton.ID.Substring(0, currentButton.ID.Length - 2), out selectedRowIndex))
            {
                string username = ((Label)UserTable.Rows[selectedRowIndex].Cells[1].Controls[0]).Text;
                DbManager.Execute("DELETE FROM [User] WHERE username='" + username + "'");
                Response.Redirect(Request.RawUrl);
            }
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            int selectedRowIndex = 0;
            if (int.TryParse(currentButton.ID.Substring(0, currentButton.ID.Length - 2), out selectedRowIndex))
            {
                User user = new User();
                user.username = ((Label)UserTable.Rows[selectedRowIndex].Cells[1].Controls[0]).Text;
                user.name = ((Label)UserTable.Rows[selectedRowIndex].Cells[2].Controls[0]).Text;
                user.password = ((Label)UserTable.Rows[selectedRowIndex].Cells[3].Controls[0]).Text;
                user.role = ((Label)UserTable.Rows[selectedRowIndex].Cells[4].Controls[0]).Text;
                user.birthday = DateTime.Parse(((Label)UserTable.Rows[selectedRowIndex].Cells[5].Controls[0]).Text);

                Session.Add("user_to_edit", user);
                Response.Redirect("MasterUser.aspx");
            }
        }

        protected void btnAddNewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("MasterUser.aspx");
        }
    }
}