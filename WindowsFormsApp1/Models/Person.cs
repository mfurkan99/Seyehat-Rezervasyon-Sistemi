using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class Personel : Person, IPersonnel
    {
        
        public string Department { get; set; }

        public Personel(string firstName, string lastName, string department)
        : base(firstName, lastName)
        {
            Department = department;
        }

        public decimal CalculateSalary()
        {
            
            return 0; 
        }
    }







    
    public class Passenger : Person
    {
        public string tc_id { get; set; }
        public string ContactNumber { get; set; }

        public Passenger(string firstName, string lastName, string tc_Id, string contactNumber)
            : base(firstName, lastName)
        {
            tc_id = tc_Id;
            ContactNumber = contactNumber;
        }
    }
}
