using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectBook
{
    public partial class inboxlist : System.Web.UI.Page
    {
        dbconnection booklistinboxonj = new dbconnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("admin-login.aspx");
                
            }
            else
            {
                showinboxlist();
            }
            
        }
        public void showinboxlist()
        {
            string queary = @"select * from inboxlist";
            GridViewinbox.DataSource = booklistinboxonj.GetDataTable(queary);
            GridViewinbox.DataBind();

        }
    }
}