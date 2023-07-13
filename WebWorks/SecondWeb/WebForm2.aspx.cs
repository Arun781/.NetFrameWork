using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SecondWeb
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)// must click on button then code executes button click is must
        {
            if (TextBox5.Text == "hello")
                CustomValidator1.IsValid = true;
            else Response.Write("wrong data ");
        }
    }
}