using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SportsBets
{
    public partial class TicketsView : Form
    {
        private Ticket ticket;
        private string FileName;

        public TicketsView(string date, List<Match> matches, float reward)
        {
            InitializeComponent();
            fillMatches(matches, date, reward);
        }

        public void fillMatches(List<Match> matches, string date, float reward)
        {
            ticket = new Ticket(reward, date);
            foreach (Match match in matches)
            {
                Team homeTeam = new Team(match.HomeTeam.Name, match.HomeTeam.Country, match.HomeTeam.Rank);
                Team awayTeam = new Team(match.AwayTeam.Name, match.AwayTeam.Country, match.AwayTeam.Rank);
                lstMatch.Items.Add(match);
                ticket.AddMatch(homeTeam, awayTeam, match.Tip, match.Koef);
            }
            lblReward.Text = "Добивка:" + ticket.Reward + "денари";
            lblVremeNaTiket.Text = ticket.Date;
        }

        private void btnSaveTicket_Click(object sender, EventArgs e)
        {
            saveTicket();
        }

        private void saveTicket()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save a file";
                saveFileDialog.Filter = "Type of a save (*.tic)|tic";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formater = new BinaryFormatter();
                    formater.Serialize(fileStream, ticket);
                }
            }
        }

        private void btnOpenTicket_Click(object sender, EventArgs e)
        {
            openTicket();
            lstMatch.Items.Clear();
            lblReward.Text = "Добивка:" + ticket.Reward + "денари";
            lblVremeNaTiket.Text = ticket.Date;
            foreach (Match match in ticket.Matches)
            {
                lstMatch.Items.Add(match);
            }
        }

        private void openTicket()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open a ticket";
            openFileDialog.Filter = "Type of a save (*.tic)|tic";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    FileName = openFileDialog.FileName;

                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        ticket = (Ticket)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Cannot open file: ", FileName);
                    FileName = null;
                    return;
                }
            }
        }

    }
}
