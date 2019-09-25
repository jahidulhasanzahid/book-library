using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectBook
{
    public partial class searchbooks : System.Web.UI.Page
    {
        dbconnection booklistsearchobj = new dbconnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("admin-login.aspx");
                
            }
        }
        public void bookslistsearch()
        {
            //for data base data type indentification
            int id;
            Boolean b = false;

            try
            {
                id = int.Parse(Searchbuttonbooklisttext.Text); //convirt int to string
                b = true;

            }
            catch (Exception expt)
            {
                string nametext = Searchbuttonbooklist.Text;
            }

            String searchM = "";
            if (!b)
            {
                searchM = @"select * from booklist where (booklist.Bookname like '%" + Searchbuttonbooklisttext.Text + "%')";
            }
            else if(!b)
            {
                searchM = @"select * from booklist where (booklist.Bookwritername like '%" + Searchbuttonbooklisttext.Text + "%')";
            }
            else
            {
                Response.Write("Data Not Found!");
            }
            if (booklistsearchobj.ExecuteQuery(searchM) == 1)
            {
                GridViewSearch.DataSource = booklistsearchobj.GetDataTable(searchM);
                GridViewSearch.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Wrong String');</script>");
            }

        }

        protected void Searchbuttonbooklist_Click(object sender, EventArgs e)
        {
            
                bookslistsearch();
            
            
        }
    }
}