using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsBets
{
    [Serializable]
    public class Match
    {
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public string Tip { get; set; }
        public float Koef { get; set; }

        public Match(Team homeTeam, Team awayTeam, string tip, float koef)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            Tip = tip;
            Koef = koef;
        }

        public Match(Match match)
        {
            HomeTeam = match.HomeTeam;
            AwayTeam = match.AwayTeam;
            Tip = match.Tip;
            Koef = match.Koef;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}    тип:{2}({3})", HomeTeam.Name, AwayTeam.Name, Tip, Koef);
        }
    }
}
