using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Reservation
    {
        public Passenger Passenger { get; set; }
        public Vehicle Vehicle { get; set; }
        public int SeatNumber { get; set; }

        public Reservation(Passenger passenger, Vehicle vehicle, int seatNumber)
        {
            Passenger = passenger;
            Vehicle = vehicle;
            SeatNumber = seatNumber;
        }
    }
}
