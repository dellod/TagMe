using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagMe.Models
{
    public class Coordinate
    {
        private double latitude;
        private double longitude;

        public Coordinate(double lat, double lon)
        {
            latitude = lat;
            longitude = lon;
        }

        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
    }
}
