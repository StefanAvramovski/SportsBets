using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsBets
{
    public class FullDetails
    {
        public string Rank { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Points { get; set; }

        public FullDetails(string rank, string name, string country, string points)
        {
            Rank = rank;
            Name = name;
            Country = country;
            Points = points;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1} \t\t {2} \t\t {3}", Rank, Name, Country, Points);
        }
    }
}
