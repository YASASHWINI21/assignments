using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookie
{
    public partial class httpcookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("emp_name");
            HttpCookie cookie1 = new HttpCookie("emp_designation");
            HttpCookie cookie2 = new HttpCookie("emp_id");
            HttpCookie cookie3 = new HttpCookie("emp_email");
            HttpCookie cookie4 = new HttpCookie("emp_cntctno");

            //assign value to the created cookie
            cookie.Value = "yasashwini";
            cookie1.Value = "Associate Professional";
            cookie2.Value = "12342445";
            cookie3.Value = "prathyusha.vol@gmail.com";
            cookie4.Value = "1234567890";

            //add cookie to the response instance

                Response.Cookies.Add(cookie);
            Response.Cookies.Add(cookie1);
            Response.Cookies.Add(cookie2);
            Response.Cookies.Add(cookie3);
            Response.Cookies.Add(cookie4);

            //fetch the cookie created
                var cookie_value = Response.Cookies["emp_name"].Value;
            var cookie1_value = Response.Cookies["emp_designation"].Value;
            var cookie2_value = Response.Cookies["emp_id"].Value;
            var cookie3_value = Response.Cookies["emp_email"].Value;
            var cookie4_value = Response.Cookies["emp_cntctno"].Value;

            label1.Text = cookie_value;
            label2.Text = cookie1_value;
            label3.Text = cookie2_value;
            label4.Text = cookie3_value;
            label5.Text = cookie4_value;//label returning with cookie information
        }
    }
    
}