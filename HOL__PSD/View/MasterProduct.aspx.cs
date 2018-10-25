using HOL__PSD.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HOL__PSD.View
{
    public partial class MasterProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProcess_Click(object sender, EventArgs e)
        {
            Page.Validate();
        }

        protected void priceValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int price = 0;
            if (int.TryParse(args.Value, out price))
            {
                if (price < 1000)
                {
                    ((CustomValidator)source).ErrorMessage = "Harga Minimal adalah 1000";
                    args.IsValid = false;
                }
            }
            else
            {
                ((CustomValidator)source).ErrorMessage = "Harga Harus Diisi dan Adalah Nilai";
                args.IsValid = false;
            }
        }

        protected void stockValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }
    }
}