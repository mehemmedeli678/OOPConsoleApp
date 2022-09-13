using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp.Abstraction
{
    internal class Film :BaseClass
    {
        public Film(string name)
        {
            this.Name=name;
        }
        public string Time { get; set; }

        public override void GiveStar(int number)
        {
            Console.WriteLine("Film-e " + number + " ulduz verdiniz");
        }
    }
}
