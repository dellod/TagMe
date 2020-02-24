using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagMe.Models
{
    public class Address
    {
        private string city;
        private string country;
        private string provinceOrState;
        private string street;
        private Coordinate coordinates;

        public Address(string ci, string co, string pos, double lat, double lon)
        {
            city = ci;
            country = co;
            provinceOrState = pos;
            coordinates = new Coordinate(lat, lon);
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string ProvOrState
        {
            get { return provinceOrState; }
            set { provinceOrState = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public Coordinate Coordinates
        {
            get { return coordinates; }
            set { coordinates = value; }
        }
    }
}
