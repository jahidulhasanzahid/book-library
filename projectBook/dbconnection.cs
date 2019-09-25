using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace projectBook
{
    public class dbconnection
    {
        String connectionStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public DataTable GetDataTable(String _query)
        {
            SqlConnection conn = new SqlConnection(connectionStr);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(_query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int ExecuteQuery(String _query)
        {
            SqlConnection conn = new SqlConnection(connectionStr);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(_query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException e)
            {
                e.GetBaseException();
                return 0;
            }
        }

    }
}