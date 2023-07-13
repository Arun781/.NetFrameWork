using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
namespace FrontToVsToDB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String a1= WebConfigurationManager.ConnectionStrings["MyCon"].ToString();

        void EmployeesFill()
        {
            SqlConnection c = new SqlConnection(a1);
             SqlDataAdapter adapter = new SqlDataAdapter("Select * from Employees", c);
             DataSet set = new DataSet();
            adapter.Fill(set);//all records are set as database[0]
             //for display
            GridView1.DataSource = set.Tables[0];
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) EmployeesFill();
            else Response.Write("No Table");
        }
    }
}