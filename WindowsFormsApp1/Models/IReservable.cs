using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public interface IReservable
    {
        bool[] SeatStatus { get; set; }  

        bool ReserveSeat(int seatNumber);  
        bool CancelReservation(int seatNumber);  
    }
}
