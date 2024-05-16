using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public abstract class Vehicle
    {
        public int VehicleId { get; set; }
        public int SeatCount { get; set; }
        public string FuelType { get; set; }
        public double FuelConsumptionRate { get; set; }

        
        public double CalculateFuelCost(double distance)
        {
            return distance * FuelConsumptionRate;
        }
    }

    
    public class Bus : Vehicle
    {
        public Bus(int vehicleId, int seatCount, string fuelType, double fuelConsumptionRate)
        {
            VehicleId = vehicleId;
            SeatCount = seatCount;
            FuelType = fuelType;
            FuelConsumptionRate = fuelConsumptionRate;
        }
    }

    
    public class Train : Vehicle
    {
        public Train(int vehicleId, int seatCount, string fuelType, double fuelConsumptionRate)
        {
            VehicleId = vehicleId;
            SeatCount = seatCount;
            FuelType = fuelType;
            FuelConsumptionRate = fuelConsumptionRate;
        }
    }

    
    public class Airplane : Vehicle
    {
        public Airplane(int vehicleId, int seatCount, string fuelType, double fuelConsumptionRate)
        {
            VehicleId = vehicleId;
            SeatCount = seatCount;
            FuelType = fuelType;
            FuelConsumptionRate = fuelConsumptionRate;
        }
    }
    
}