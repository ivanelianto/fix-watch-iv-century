using HOL__PSD.Model;
using HOL__PSD.Util;
using HOL__PSD.WebService;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HOL__PSD.View
{
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        protected static List<HeaderTransaction> headerTransactions = new List<HeaderTransaction>();

        protected void Page_Load(object sender, EventArgs e)
        {
            using (MainService service = new MainService())
            {
                if (Session["auth_user"] != null)
                {
                    User user = (User)Session["auth_user"];

                    String json = service.GetTransaction(user.username);

                    headerTransactions = JsonHandler.Decode<List<HeaderTransaction>>(json);
                }
            }
        }
    }
}