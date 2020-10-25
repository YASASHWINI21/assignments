using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sample1code : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		TextBox1.Focus();
	}

	protected void TextBox1_TextChanged(object sender, EventArgs e)
	{
		string a = "Hello" + TextBox1.Text;
		Response.Write(a);
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		Response.Write("You Clicked me");
	}
}