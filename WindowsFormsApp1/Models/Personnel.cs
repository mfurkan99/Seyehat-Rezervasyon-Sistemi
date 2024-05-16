using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Personnel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Personnel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class CarDriver : Personnel
    {
        public decimal Salary { get; set; }

        public CarDriver(string firstName, string lastName, decimal salary)
            : base(firstName, lastName)
        {
            Salary = salary;
        }
    }

    public class ServicePersonnel : Personnel
    {
        public decimal Salary { get; set; }

        public ServicePersonnel(string firstName, string lastName, decimal salary)
            : base(firstName, lastName)
        {
            Salary = salary;
        }
    }

}
