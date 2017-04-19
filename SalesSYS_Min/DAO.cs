using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace SalesSYS_Min
{
    public class DAO
    {
        private SqlConnection connection;
        private String connectionString;


        public DAO()
        {
            try
            {
                ConnectingToSQL();
            }catch(BadImageFormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private SqlConnection GetConnection()
        {
            return connection;
        }

        private string GetConnectionString()
        {
            String connString = "Data Source=thescores.c5aic797mmyq.eu-west-1.rds.amazonaws.com,1433;Initial Catalog=salessys-min;User ID=inly;Password=134679iL";
            return connString;
        }

        private void ConnectingToSQL()
        {
            connectionString = GetConnectionString();
            connection = new SqlConnection(connectionString);
           
        }
        public DataTable GetByCategory(String category)
        {
            string sql = "select * from dbo.Stock where Category = '" + category+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            connection.Open();
            DataTable dt = new DataTable();
            MessageBox.Show(category);
            da.Fill(dt);
            connection.Close();
            return dt;
        }
        public DataSet getUser()
        {
            string sql = "SELECT user_name()";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            DataSet dataset = new DataSet();
            connection.Open();
            da.Fill(dataset);
            connection.Close();

            return dataset;

        }
        public DataTable GetStock()

        {
            string sql = "SELECT * FROM dbo.Stock";
            SqlDataAdapter da = new SqlDataAdapter(sql,connection);
            connection.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
           
            connection.Close();
            

            return dt;
        }
        public DataSet GetStock(String category)

        {
            string sql = "SELECT * FROM Stock WHERE category ="+category;
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            DataSet dataset = new DataSet();
            connection.Open();
            da.Fill(dataset, "Stock");
            connection.Close();
            connection.Close();
            MessageBox.Show(dataset.Tables.Count.ToString());
            return dataset;
        }

    }
}
