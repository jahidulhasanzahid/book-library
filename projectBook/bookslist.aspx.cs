using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace projectBook
{
   
    public partial class bookslist : System.Web.UI.Page
    {
        dbconnection booklistonj = new dbconnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("admin-login.aspx");
                
            }
            else
            {
                showbooklist();
            }
            
        }
        public void showbooklist()
        {
            string queary = @"select * from booklist";
            GridView1.DataSource = booklistonj.GetDataTable(queary);
            GridView1.DataBind();
           
        }
    }
}