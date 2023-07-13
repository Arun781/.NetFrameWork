using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SecondWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool b1 = Page.IsPostBack;// like property 
            if (IsPostBack == false)
            //if (!IsPostBack)// first request 
            {
                DropDownList1.Items.Add("choose an item");
                string[] elements = { "oceans", "rivers", "Continents" };
                foreach (string s in elements) { DropDownList1.Items.Add(s); }
            }
            TextBox1.AutoPostBack = true;
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {// double click on DDL
            ListBox1.Items.Clear();//will remove prevoius 
            int choice = DropDownList1.SelectedIndex;
            switch (choice)
            {
                case 1: { ListBox1.Items.Add("Pacific"); ListBox1.Items.Add("Atlantic"); break; }
                case 2: { ListBox1.Items.Add("amazon"); ListBox1.Items.Add("Nile"); break; }
                case 3: { ListBox1.Items.Add("asia"); ListBox1.Items.Add("Europe"); break; }
            }

        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = ListBox1.SelectedValue;
        }
    }
}