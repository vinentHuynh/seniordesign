using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace Senior_Design
{
    public class ConnectionDB
    {
        public SqlConnectionStringBuilder builder;
        public string ConnectionString = "Server=tcp:sam-database.database.windows.net,1433;Initial Catalog=Assets;Persist Security Info=False;User ID=samadmin;Password=SeniorDesign2022;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";



        SqlConnection con;

        public void OpenConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "sam-database.database.windows.net";
            builder.UserID = "samadmin";
            builder.Password = "Seniordesign2022";
            builder.InitialCatalog = "Assets";
            ConnectionString = builder.ConnectionString;
            con = new SqlConnection(ConnectionString);
            con.Open();
        }


        public void CloseConnection()
        {
            con.Close();
        }
        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }

        public int ExecuteScalar(string query)
        {            
            int count = 0;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "sam-database.database.windows.net";
            builder.UserID = "samadmin";
            builder.Password = "Seniordesign2022";
            builder.InitialCatalog = "Assets";
            ConnectionString = builder.ConnectionString;
            con = new SqlConnection(ConnectionString);
            
            using (SqlCommand cmdCount = new SqlCommand(query, con))
            {
                con.Open();
                count = (int)cmdCount.ExecuteScalar();
            }
         
            return count;
        }
        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public DataTable DataAdapter(string Query_,string user)
        {
            SqlCommand cmd= new SqlCommand(Query_, con);
            cmd.Parameters.AddWithValue("@username", user);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public void sqlBulkAdd(DataTable csvData)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "sam-database.database.windows.net";
            builder.UserID = "samadmin";
            builder.Password = "Seniordesign2022";
            builder.InitialCatalog = "Assets";
            ConnectionString = builder.ConnectionString;
            con = new SqlConnection(ConnectionString);
            con.Open();
            using (SqlBulkCopy s = new SqlBulkCopy(con))
            {
                    
                s.DestinationTableName = "asset";
                foreach (var column in csvData.Columns)
                    s.ColumnMappings.Add(column.ToString(), column.ToString());
                s.WriteToServer(csvData);
            }
            


        }
    
        




    }
}
