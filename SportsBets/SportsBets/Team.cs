using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsBets
{
    [Serializable]
    public class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Rank { get; set; }

        public Team(string name, string country, int rank)
        {
            Name = name;
            Country = country;
            Rank = rank;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, Country);
        }
    }
}
