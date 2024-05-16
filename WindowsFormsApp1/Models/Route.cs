using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Route
    {
        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }
        public double Distance { get; set; }
        public List<string> Stops { get; set; }

        public Route(string departurePoint, string destinationPoint, double distance)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            Distance = distance;
            
        }
    }
}
