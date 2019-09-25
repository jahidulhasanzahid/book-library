using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//we use this after on a class
using System.Data.SqlClient;
using System.Data;


namespace projectBook
{
    public partial class admin_login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false; // this use for hide something from design
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-N5BN03N\SQLEXPRESS;Initial Catalog=bookproject;Integrated Security=True"))
            {
                sqlCon.Open();
                string queary = @"SELECT COUNT(1) FROM adminlogintwo WHERE username = @username AND password = @password";
                SqlCommand sqlCmd = new SqlCommand(queary, sqlCon);
                sqlCmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    Session["username"] = txtUserName.Text.Trim();
                    Response.Redirect("Default.aspx");

                }
                else
                {
                    lblErrorMessage.Visible = true;
                }
            }

        }
    }
}