using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello Arun");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string FirstName = TextBox1.Text;
            string LastName = TextBox2.Text;

            if (FirstName == "Arun" && LastName == "Veerapur")

                Label3.Text = "Hello" + FirstName + LastName;
            else Label3.Text = "Please Check you input "+FirstName + LastName; 
             
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm1.aspx");
            Response.Redirect("WebForm1.aspx");
        }
    }
}