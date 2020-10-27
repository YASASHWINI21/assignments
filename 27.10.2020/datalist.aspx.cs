using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace cookie
{
    public partial class datalist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable Table = new DataTable();//created an instance
            Table.Columns.Add("FirstName");
            Table.Columns.Add("SecondName");
            Table.Columns.Add("Designation");
            Table.Columns.Add("Location");
            Table.Columns.Add("Country");


            Table.Rows.Add("Voleti", " Amal prathyusha", "Project Manager","visakhapatnam","India");
            Table.Rows.Add("shaik", "firdos", "sales manager", "hyderabad", "India");
            Table.Rows.Add("sarvasiddi", "Ramya", "HR", "chennai", "India");
            Table.Rows.Add("savithini", "sravani", "executive officer", "Banglore", "India");
            Table.Rows.Add("sikha", "hemasree", "Admin", "karnataka", "India");
            Table.Rows.Add("Kolli ", "Vakula devi", "HR", "Noida", "India");
            Table.Rows.Add("sommadula", "Tulasi", "Finance department", "Delhi", "India");
            Table.Rows.Add("syed", "Nayeema", "IT Head", "Punjab", "India");
            Table.Rows.Add("Neelapu", "Keerthi", "Team Leader", "Pune", "India");
            Table.Rows.Add("Ponnana", "Lalitha", "Manager", "Mumbai", "India");


            datalist1.DataSource = Table;
            datalist1.DataBind();
        }
    }
}