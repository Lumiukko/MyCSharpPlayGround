using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSTest
{
    public class GeoLocation
    {

        public double Longitude { get; private set; }
        public double Latitude { get; private set; }

        public GeoLocation(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }
        

    }
}
