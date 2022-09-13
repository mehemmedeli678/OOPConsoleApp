using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp.Abstraction
{
    internal abstract class BaseClass
    {
        public BaseClass()
        {

        }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public string Trailer { get; set; }
        public abstract void GiveStar(int number);

    }
}
