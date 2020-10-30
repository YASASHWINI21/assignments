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
    public partial class DataGridEx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection Connect = new SqlConnection("data source=IN-PG00N524;database= priscilla1; Integrated Security=true"))
            {
                SqlDataAdapter SDA = new SqlDataAdapter("Select * from Bank", Connect);
                DataSet ds = new DataSet();

                SDA.Fill(ds);
                DataGrid1.DataSource = ds;
                DataGrid1.DataBind();

            }


        }

        protected void DataGrid1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}