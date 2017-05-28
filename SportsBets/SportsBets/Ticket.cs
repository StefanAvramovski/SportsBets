using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsBets
{
    [Serializable]
    public class Ticket
    {
        public List<Match> Matches;
        public float Reward { get; set; }
        public string Date { get; set; }


        public Ticket()
        {
            Matches = new List<Match>();
        }

        public Ticket(float reward, string date)
        {
            Reward = reward;
            Date = date;
            Matches = new List<Match>();
        }

        public void AddMatch(Team homeTeam, Team awayTeam, string tip, float koef)
        {
            Matches.Add(new Match(homeTeam, awayTeam, tip, koef));
        }
    }
}
