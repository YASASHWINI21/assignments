using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace RapidApplication
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Registration Successful";

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            var InsertQuery = "insert into RegistrationTable(Name,Email,Password,Gender,City) values(@N,@E,@P,@G,@C)";
            SqlCommand cmd = new SqlCommand(InsertQuery, con);

            cmd.Parameters.AddWithValue("@N", TextBox1.Text);
            cmd.Parameters.AddWithValue("@E", TextBox2.Text);
            cmd.Parameters.AddWithValue("@P", TextBox3.Text);
            if (RadioButton1.Checked)
            {
                cmd.Parameters.AddWithValue("@G", RadioButton1.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@G", RadioButton2.Text);
            }
            cmd.Parameters.AddWithValue("@C", DropDownList1.SelectedItem.ToString());
            cmd.ExecuteNonQuery();


            con.Close();
            Response.Redirect("Admin.aspx");



        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}