using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando.Entities
{
    public class CovidRecord
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Cases { get; set; }
        public int Deaths { get; set; }
        public string Country { get; set; }
        public int popData { get; set; }
        public string Continent { get; set; }
        public double last14DaysPer100000 { get; set; }
    }
}
