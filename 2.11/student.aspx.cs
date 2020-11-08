using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ASPControls
{
	public partial class Student : System.Web.UI.Page
	{
		SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentTableConnectionString"].ConnectionString);

		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
				Bind();
			}
		}
		public void Bind()
		{
			
			SqlCommand Cmd = new SqlCommand("Select * from StudentTable", Conn);
			SqlDataAdapter adpt = new SqlDataAdapter(Cmd);
			DataSet Ds = new DataSet();
			adpt.Fill(Ds, "StudentTable");
			RP2.DataSource = Ds.Tables[0];
			RP2.DataBind();
			
		}
	}
}
