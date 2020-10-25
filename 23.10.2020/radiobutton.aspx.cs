using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class radiobutton : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}

	protected void Label3_Click(object sender, EventArgs e)
	{
		colorid.Text = "";
		if (RadioButton1.Checked)
			colorid.Text = "You are" + RadioButton1.Text;
		else
			colorid.Text = "You are" + RadioButton2.Text;
	}


	protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
		Response.Write("This is red");

	}

	protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		Response.Write("This is blue");
	}

	protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
		Response.Write("This is green");
	}




	protected void Button1_Click(object sender, EventArgs e)
	{

	}
}