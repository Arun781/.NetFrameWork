using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreateDBAndSaveDataFromWebServer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String s= WebConfigurationManager.ConnectionStrings["Save"].ToString();
        void SaveList()
        {
            SqlConnection SqlCon= new SqlConnection(s);
            SqlDataAdapter SqlDataAdapter = new SqlDataAdapter("Select * From Employees", SqlCon);
            DataSet ds = new DataSet();
            SqlDataAdapter.Fill(ds);
           
           
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) SaveList();
            else Response.Write("No Table Found");
        }
    }
}