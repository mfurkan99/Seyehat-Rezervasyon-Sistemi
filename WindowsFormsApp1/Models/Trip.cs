using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Trip
    {
        public int TripId { get; set; }
        public Vehicle SelectedVehicle { get; set; }
        public Route TripRoute { get; set; }
        public int VehicleId => SelectedVehicle.VehicleId;
        public DateTime TripTime { get; set; }
        public double Price { get; set; }

        public Trip(int tripId, Vehicle selectedVehicle, Route tripRoute, DateTime tripTime, double price)
        {
            TripId = tripId;
            SelectedVehicle = selectedVehicle;
            TripRoute = tripRoute;
            TripTime = tripTime;
            Price = price;
        }
    }
}
