using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SamenSterker
{
    public class DBConnection
    {
        private const string CONNSTRING = @"Server=10.107.1.34 ;Database=WTC; User Id=sa; Password=gregory;";
        private SqlConnection connection;
        private static DBConnection instance;

        public SqlConnection Connection { get; set; }

        private DBConnection()
        {
            connection = new SqlConnection(CONNSTRING);
        }

        public static DBConnection getInstance()
        {
            if (instance == null)
            {
                instance = new DBConnection();
            }
            return instance;
        }

        public DataSet GetTable(string table)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@"Select * from WTC." + table, Connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }
    }
}