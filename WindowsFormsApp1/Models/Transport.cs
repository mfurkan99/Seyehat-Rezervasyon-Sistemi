using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Transport : IReservable
    {
        public bool[] SeatStatus { get; set; }
        public List<Company> Companies { get; set; }
        public List<Route> Routes { get; set; }
        public List<Trip> Trips { get; set; }

        public Transport(int numberOfSeats)
        {
            SeatStatus = new bool[numberOfSeats];  
        }

        public bool ReserveSeat(int seatNumber)
        {
            if (seatNumber >= 0 && seatNumber < SeatStatus.Length && !SeatStatus[seatNumber])
            {
                SeatStatus[seatNumber] = true;  
                return true;
            }
            return false;  
        }

        public bool CancelReservation(int seatNumber)
        {
            if (seatNumber >= 0 && seatNumber < SeatStatus.Length && SeatStatus[seatNumber])
            {
                SeatStatus[seatNumber] = false;  
                return true;
            }
            return false;  
        }


        public Transport()
        {
            Companies = new List<Company>();
            Routes = new List<Route>();
            Trips = new List<Trip>();
        }

        
    }
}
