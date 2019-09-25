using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectBook
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
                Response.Redirect("admin-login.aspx");

            lblUserDetails.Text = "এডমিন  "+Session["username"];

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon(); //clear all session value
            Response.Redirect("admin-login.aspx");
        }
    }
}