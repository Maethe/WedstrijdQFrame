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
        private SqlConnection connectie;
        private DBConnection instance;

        public SqlConnection Connectie { get; }

        private DBConnection()
        {
            connectie = new SqlConnection(CONNSTRING);
        }

        public DBConnection getInstance()
        {
            if (instance == null)
            {
                instance = new DBConnection();
            }
            return instance;
        }
    }
}