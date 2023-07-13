using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.Form["textbox1"];
            string s1 = Request.Form["textbox2"];
            Label1.Text = "Hello  "+s+s1;
        }
    }
}