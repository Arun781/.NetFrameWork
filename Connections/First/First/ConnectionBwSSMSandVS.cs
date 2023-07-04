using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Xml.Linq;

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
        public static void DmlWithDataSet()
        {
            SqlConnection connection = Connection();
            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.Text;// StoredProcedure;// Text;
            //command.CommandText = "select * from Employees";
            //command.Connection = connection;
            SqlCommand command = new SqlCommand("select * from Employees", connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            //SqlDataAdapter adapter = new SqlDataAdapter("select * from emp", connection);
            DataSet set = new DataSet();
            adapter.Fill(set, "e");//e is alias name to datatable in dataset 
            SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
            DataTable table1 = set.Tables["e"];
            // to insert a row create a row to datatable
            DataRow row = table1.NewRow();
            //row each column we give values
            row[0] = 110;
            row["eName"] = "Mani";
            row[2] = "Bhimavaram";
            row[3] = 252525;
            //row[0] = 115;
            //row["eName"] = "Ajitha";
            //row[2] = "Hyderbad";
            //row[3] = 32323232;
           // add row to table
            table1.Rows.Add(row);
            //to delete a row 
            DataRow row1 = table1.Rows[2];
            table1.Rows.RemoveAt(2);
            set.Tables["e"].Rows[2].Delete();
            // update  a row 
            // now the changes to save in Database emp table
           // adapter.Update(table1);
            Console.WriteLine("saved changes");
            
        }
        public static void InsertWithSP()
        {
            using (SqlConnection connection = Connection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "prc_insertemp";//insert procedure name 
                command.Connection = connection;
                // @id parameter in SP
                SqlParameter pmId = new SqlParameter();
                pmId.ParameterName = "@eId";//in Stored procedure
                pmId.DbType = DbType.Int32;// CLR data type
                pmId.Direction = ParameterDirection.Input;
                pmId.Value = 110;
                // assign pmId to command
                command.Parameters.Add(pmId);
                //@name
                SqlParameter pmName = new SqlParameter("@eName", SqlDbType.Char);
                pmName.Size = 5;//must 
                pmName.Direction = ParameterDirection.Input;// from 
                Console.WriteLine("enter name");
                pmName.Value = Console.ReadLine();// komal
                command.Parameters.Add(pmName);
                //@city
                SqlParameter pmCity = new SqlParameter("@eAddress", SqlDbType.VarChar, 20);
                pmCity.Direction = ParameterDirection.Input;
                Console.WriteLine("enter city ");
                pmCity.Value = Console.ReadLine();
                command.Parameters.Add(pmCity);
                //@salary
                SqlParameter pmSalary = new SqlParameter("@eSalary", SqlDbType.Decimal);
                pmSalary.Direction = ParameterDirection.Input;
                pmSalary.Value = 7676;
                command.Parameters.Add(pmSalary);
                // now we must execute SP with the help of COmmand methods  ?
               
                command.ExecuteNonQuery();
                Console.WriteLine("success ");


            }// connection object will be released from memory
        }
        public static string SelectNameWithSP(int id)
        {
            using (SqlConnection conn = Connection())
            {
                conn.Open();
                //read id from user
                Console.WriteLine("enter a id");
                id = Convert.ToInt32(Console.ReadLine());
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "prc_selectname";//procedure name
                // @id,@name parameters but @name output parameter 
                command.Parameters.AddWithValue("@eId", id);
                SqlParameter pmName = new SqlParameter("@eName", SqlDbType.Char, 10);
                pmName.Direction = ParameterDirection.Output;//must 
                command.Parameters.Add(pmName);
                // call command 's method ExecuteScalar() 
                command.ExecuteScalar();
                object obj = pmName.Value;
                string name = obj.ToString();
                return name;
            }
        }
        public static void DisplayAllEmps()
        {
            using (SqlConnection conn = Connection())
            {
                //  SqlCommand command = new SqlCommand();
                conn.Open();
                //  command.CommandType = CommandType.StoredProcedure;
                //   command.CommandText = "prc_empselectall";//select * from emp
                //   command.Connection = conn;
                SqlCommand command1 = new SqlCommand("prc_empselectall", conn);
                SqlDataReader reader = command1.ExecuteReader();
                //display
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                    }
                }


            }// end of using block releases connection from memory
             //  Console.WriteLine(conn);
        }
        static void Main(string[] args)
        {
            // Display();
            // DisplayWithDataset();
            // DmlWithDataSet();
             //SelectNameWithSP(110);
            //DisplayAllEmps();
            InsertWithSP();


        }
    }
}
