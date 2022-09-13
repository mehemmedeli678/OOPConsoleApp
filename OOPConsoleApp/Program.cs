using OOPConsoleApp.Abstraction;
using OOPConsoleApp.Encapsulation;
using OOPConsoleApp.Inheritance;
using OOPConsoleApp.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Encaptilation
            //User user = new User();
            // user.Name = "Murad";
            // user.Token = "";
            // user.GenerateToken(user.Name);
            // user.GenerateToken(user.Name);

            // Console.WriteLine(user.Token);

            // Abstraction
            //BaseClass bases = new Film();
            // bases.Name = "FilmName";
            // bases.GiveStar(10);
            // Console.WriteLine(bases.Name);

            // Inheritance
            Employee employee = new Manager(2, 10);
            Console.WriteLine(employee.Salary);


        }
    }
}
