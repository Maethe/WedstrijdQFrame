using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SamenSterker.Core.DBLayer
{
    public class DBConnection
    {
        private const string CONNSTRING = @"Server=10.107.1.34 ;Database=WTC; User Id=sa; Password=gregory;";
        private static DBConnection instance = new DBConnection();

        public SqlConnection Connection { get; set; }

        private DBConnection()
        {
            Connection = new SqlConnection(CONNSTRING);
        }

        public static DBConnection getInstance()
        {
            return instance;
        }

        public DataSet GetTable(string table)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@"Select * from WTC.dbo." + table, Connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }
    }
}