using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication5
{
    public partial class EmployeeUsingRepeater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString);
             con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            SqlDataReader rd = cmd.ExecuteReader();
            rp1.DataSource = rd;
            rp1.DataBind();
            con.Close();
 

        }
    }
}