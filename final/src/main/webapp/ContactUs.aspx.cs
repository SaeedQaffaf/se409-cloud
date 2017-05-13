using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class bootstrap_shop_ContactUs : System.Web.UI.Page
{
    public Label Label1;

    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text =
            DateTime.Now.ToLocalTime().ToLongTimeString();
    }
}