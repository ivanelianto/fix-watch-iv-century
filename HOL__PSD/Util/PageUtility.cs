using System.Web.UI;

namespace HOL__PSD.Util
{
    public static class PageUtility
    {
        public static void Alert(Control control, string message)
        {
            ScriptManager.RegisterClientScriptBlock(control, control.GetType(),
                        "alertMessage",
                        "alert('" + message + "')",
                        true);
        }
    }
}
