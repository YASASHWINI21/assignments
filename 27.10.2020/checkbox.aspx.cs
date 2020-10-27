using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookie
{
    public partial class checkboxcookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies["Mobiles"].Expires = DateTime.Now.AddDays(-1).AddHours(3).AddMinutes(30);
        }
    

        protected void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = " ";
            //adding cookies
            if (checkbox1.Checked)
                Response.Cookies["Mobiles"]["iphone"] = "u have checked for iphone and cookie triggered";

            if (checkbox2.Checked)
                Response.Cookies["Mobiles"]["samsung"] = "u have checked for samsung and cookie triggered";

            if (checkbox3.Checked)
                Response.Cookies["Mobiles"]["Lenovo"] = "u have checked for Lenovo and cookie triggered";

            if (checkbox4.Checked)
                Response.Cookies["Mobiles"]["Redmi"] = "u have checked for Redmi and cookie triggered";

            if (checkbox5.Checked)
                Response.Cookies["Mobiles"]["realme"] = "u have checked for realme and cookie triggered";

            if (checkbox6.Checked)
                Response.Cookies["Mobiles"]["Oppo"] = "u have checked for Oppo and cookie triggered";


            if (checkbox7.Checked)
                Response.Cookies["Mobiles"]["Vivo"] = "u have checked for Vivo and cookie triggered";

            if (checkbox8.Checked)
                Response.Cookies["Mobiles"]["infinix"] = "u have checked for infinix and cookie triggered";

            if (checkbox9.Checked)
                Response.Cookies["Mobiles"]["Motrola"] = "u have checked for Motrola and cookie triggered ";

            if (checkbox10.Checked)
                Response.Cookies["Mobiles"]["Nokia"] = "u have checked for Nokia and cookie triggered ";

            //fetching cookies
            if (Request.Cookies["Mobiles"].Values.ToString() != null)
            {
                if (Request.Cookies["Mobiles"]["iphone"] != null)
                    label2.Text = label2.Text + Response.Cookies["Mobiles"]["iphone"] + " " + " "+"<br>";

                if (Request.Cookies["Mobiles"]["samsung"] != null)
                    label2.Text = label2.Text + Response.Cookies["Mobiles"]["samsung"] + " " + " "+"<br>";


                if (Request.Cookies["Mobiles"]["Lenovo"] != null)
                    label2.Text = label2.Text + Response.Cookies["Mobiles"]["Lenovo"] + " " + " " + "<br>";


                if (Request.Cookies["Mobiles"]["Redmi"] != null)
                    label2.Text = label2.Text + Response.Cookies["Mobiles"]["Redmi"] + " " + " " + "<br>";


                if (Request.Cookies["Mobiles"]["realme"] != null)
                    label2.Text = label2.Text + Response.Cookies["Mobiles"]["realme"] + " " + " " + "<br>";

                if (Request.Cookies["Mobiles"]["Oppo"] != null)
                    label2.Text = label2.Text + Response.Cookies["Mobiles"]["Oppo"] + " " + " " + "<br>";

                if (Request.Cookies["Mobiles"]["Vivo"] != null)
                    label2.Text = label2.Text + Response.Cookies["Mobiles"]["Vivo"] + " " + " " + "<br>";

                if (Request.Cookies["Mobiles"]["infinix"] != null)
                    label2.Text = label2.Text + Response.Cookies["Mobiles"]["infinix"] + " " + " " + "<br>";

                if (Request.Cookies["Mobiles"]["Motrola"] != null)
                    label2.Text = label2.Text + Response.Cookies["Mobiles"]["Motrola"] + " " + " " + "<br>";

                if (Request.Cookies["Mobiles"]["Nokia"] != null)
                    label2.Text = label2.Text + Response.Cookies["Mobiles"]["Nokia"] + " " + " " + "<br>";



            }
            else
            {
                label2.Text = "please select your choice";
                Response.Cookies["Mobiles"].Expires = DateTime.Now.AddDays(-1);
            }
        }
    }
}
