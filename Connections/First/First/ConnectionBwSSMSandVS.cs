using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace First
{
    internal class ConnectionBwSSMSandVS
    {
        static SqlConnection Connection()
        {
            String connections = ConfigurationManager.ConnectionStrings["CompanyConnections"].ToString();
            SqlConnection MyConnection = new SqlConnection(connections);

            return MyConnection;

        }
        public static void Display()
        {
            Console.WriteLine("Displaying Rows and Columns From DB...");
            SqlConnection connections = Connection();
            connections.Open();

            SqlCommand cmd = new SqlCommand("Select * From Employees", connections);
            //Sql returns all rows and columns
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                while (reader.Read())
                {
                    //one row at a time
                    //string sql = reader.GetString(0);
                    string firstColumn = reader[0].ToString();
                    string secondColumn = reader[1].ToString();
                    Console.WriteLine("{0}\t{1}", firstColumn, secondColumn);
                }

            }

        }
        public static void DisplayWithDataset()//disconneted Mode
        {
            SqlConnection connection = Connection();
            SqlDataAdapter adpter = new SqlDataAdapter("select * from Employees", connection);
            DataSet set = new DataSet();//null 
            adpter.Fill(set, "emp1");//2 parameter is optional alias
            //now dataset has a table filled by adapter 's Fill () Table[0]
            // display row by row from table
            DataTable table = set.Tables["emp1"];//set.tables[0]
            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
            }
            //Fill will open connection, reads table , and saves all rows in dataset , in same same table format, closes connection
        }
        static void Main(string[] args)
        {
           // Display();
            DisplayWithDataset();
        }
    }
}
