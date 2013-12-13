using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SamenSterker.Core.DataLayer
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public Company Company { get; set; }

        public User(int id, string username, int companyid)
        {
            this.Id = id;
            this.UserName = username;

        }
    }
}