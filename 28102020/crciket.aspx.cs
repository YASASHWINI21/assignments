using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Aspgrid
{
    public partial class Cricket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection Connect = new SqlConnection("data source=IN-PG00N524;database= priscilla1; Integrated Security=true"))
            {
                SqlDataAdapter SD = new SqlDataAdapter("select * from CricketTeam", Connect);
                DataSet ds = new DataSet();

                SD.Fill(ds);
                DataGrid1.DataSource = ds;
                DataGrid1.DataBind();


            }
        }

        protected void DataGrid1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}