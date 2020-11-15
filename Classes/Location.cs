using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentleForm
{
    class Location
    {
        public string Street { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Location(string Street, string Zipcode, string City, string Country)
        {
            this.Street = Street;
            this.Zipcode = Zipcode;
            this.City = City;
            this.Country = Country;
        }
    }
}
