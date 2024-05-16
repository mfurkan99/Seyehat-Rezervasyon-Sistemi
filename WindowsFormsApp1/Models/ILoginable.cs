using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public interface ILoginable
    {
        string Username { get; set; }
        string Password { get; set; }

        bool Login(string enteredUsername, string enteredPassword);
    }




}
