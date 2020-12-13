using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando.Entities
{
    class CovidRecords
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public int Day { get; set; }
        public int Cases { get; set; }
        public int Death { get; set; }
        public string Country { get; set; }
        public int popData { get; set; }
        public string Continent { get; set; }
        public double last14DaysPer100000 { get; set; }
    }
}
