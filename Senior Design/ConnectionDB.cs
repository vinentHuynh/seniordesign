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
        public string ConnectionString = "Server=tcp:sam-database.database.windows.net,1433;Initial Catalog=Assets;Persist Security Info=False;User ID=samadmin;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        
            
        
        SqlConnection con;

        public void OpenConection()
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


        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }




    }
}
