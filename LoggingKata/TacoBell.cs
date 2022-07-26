using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingKata
{
    internal class TacoBell : ITrackable
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Name { get; set ; }
        public Point Location { get ; set ; }
    }
}
