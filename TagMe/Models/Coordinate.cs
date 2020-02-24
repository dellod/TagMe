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

        #region Constructors
        /// <summary>
        /// Default constructor (necessary for deserialization).
        /// </summary>
        public Coordinate()
        {
        }

        /// <summary>
        /// Field constructor.
        /// </summary>
        /// <param name="lat"> Latitude argument </param>
        /// <param name="lon"> Longitude argument </param>
        public Coordinate(double lat, double lon)
        {
            latitude = lat;
            longitude = lon;
        }

        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="instance"> Instance that is being copied </param>
        public Coordinate(Coordinate instance): this(instance.latitude, instance.longitude)
        {
        }
        #endregion

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
