using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SamenSterker.Core.DataLayer;

namespace SamenSterker.Core.DBLayer
{
    public class DBController
    {
        private DBConnection conn = DBConnection.getInstance();

        public Company getCompanyById(int id)
        {
            DataSet companies = conn.GetTable("Company");
        }
    }
}