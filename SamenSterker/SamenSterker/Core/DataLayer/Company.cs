using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SamenSterker.Core.DataLayer
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public int Zipcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Employees { get; set; }

        public Company(int id, string name, string street, int zipcode, string city, string country, string email, string phone, int employees)
        {
            this.Id = id;
            this.Name = name;
            this.Street = street;
            this.Zipcode = zipcode;
            this.City = city;
            this.Country = country;
            this.Email = email;
            this.Phone = phone;
            this.Employees = employees;
        }

        public bool Equals(Company obj)
        {
            return obj.Id == this.Id;
        }

    }
}