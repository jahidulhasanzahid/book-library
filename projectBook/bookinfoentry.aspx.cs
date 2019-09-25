using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace projectBook
{
    public partial class bookinfoentry : System.Web.UI.Page
    {
        dbconnection bookinfoinsertobj = new dbconnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("admin-login.aspx");
            }
            
        }
        public int bookinfomethod()
        {
            string queary = @"INSERT INTO [dbo].[booklist]
                                               ([Bookname]
                                               ,[Bookwritername]
                                               ,[Publishername]
                                               ,[Publicationname]
                                               ,[Pagenumber]
                                               ,[Price])
                                         VALUES ('"+TextBox1.Text+ "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')";
            if (bookinfoinsertobj.ExecuteQuery(queary) == 1)
            {
                return 1;
            }
            else
            {
                Response.Write("Data Insert is Not Done!");
                return 0;
            }
        }

        protected void bookdatainsertbtn_Click(object sender, EventArgs e)
        {
            bookinfomethod();
        }
    }
}