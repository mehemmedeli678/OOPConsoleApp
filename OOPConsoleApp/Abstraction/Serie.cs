using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp.Abstraction
{
    internal class Serie
    {
        public string SerieName { get; set; }
        public string SerieVersion { get; set; }
        public string Time { get; set; }
        public DateTime PublishDate { get; set; }
        public Series  Series { get; set; }
    }
}
