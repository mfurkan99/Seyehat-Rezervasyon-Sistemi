using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public abstract class User : ILoginable
    {
        public string Username { get; set; }
        public string Password { get; set; }

        
        protected User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        
        public bool Login(string enteredUsername, string enteredPassword)
        {
            return Username == enteredUsername && Password == enteredPassword;
        }
    }

    public class Admin : User
    {
        public Admin() : base("admin", "1234")
        {
            
        }



        
    }

    public class Company : User
    {
        public string CompanyName { get; set; }
        public int CompanyFee { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Route> Routes { get; set; }
        public List<Trip> Trips { get; set; }


        private int vehicleIdCounter = 1;

        private int busIdCounter = 1;
        private int trainIdCounter = 1;
        private int airplaneIdCounter = 1;

        public Company(string username, string password, string companyName, int companyFee)
            : base(username, password)
        {
            this.Username = username;
            this.Password = password;
            this.CompanyName = companyName;
            this.CompanyFee = companyFee;
            this.Vehicles = new List<Vehicle>();
            this.Routes = new List<Route>();
            this.Trips = new List<Trip>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            
            switch (vehicle)
            {
                case Bus _:
                    vehicle.VehicleId = busIdCounter++;
                    break;

                case Train _:
                    vehicle.VehicleId = trainIdCounter++;
                    break;

                case Airplane _:
                    vehicle.VehicleId = airplaneIdCounter++;
                    break;
            }

            Vehicles.Add(vehicle);
        }

        public void AddRoute(Route route)
        {
            Routes.Add(route);
        }

        
        public void AddTrip(Trip trip)
        {
            Trips.Add(trip);
        }

        



        
    }
}
