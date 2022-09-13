using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp.Abstraction
{
    internal class Series:BaseClass
    {
        public List<Serie> SerieList { get; set; }

        public override void GiveStar(int number)
        {
            Console.WriteLine("Seriala-a " + number + " ulduz verdiniz");
        }
    }
}
