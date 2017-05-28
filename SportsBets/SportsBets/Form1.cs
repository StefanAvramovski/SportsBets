using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SportsBets
{
    public partial class Form1 : Form
    {
        private string details = "";
        private string baseName ="";
        private bool flagAdded;

        public Form1()
        {
            InitializeComponent();
            updateReward();
            clearCoef();
            cbCountry.Enabled = false;
            lblNumber.Enabled = false;
            lblNumber.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedIndex != -1)
            {
                if (lstSelectedTeams.Items.Count < 2)
                {
                    Team team = lstTeams.SelectedItem as Team;
                    if (lstSelectedTeams.Items.Count != 0)
                    {
                        Team team1 = lstSelectedTeams.Items[0] as Team;
                        if (team != team1)
                        {
                            lstSelectedTeams.Items.Add(team);
                        }
                        else
                        {
                            MessageBox.Show("Овој учесник е веќе додаден");
                        }
                    }
                    else
                    {
                        lstSelectedTeams.Items.Add(team);
                    }
                }
                else
                {
                    MessageBox.Show("Можете да изберете само 2 учесника во мечот");
                }
            }
            else
            {
                MessageBox.Show("Немате селектирано учесник");
            }

            if (lstSelectedTeams.Items.Count == 2 && flagAdded)
            {
                flagAdded = false;
                Team homeTeam = lstSelectedTeams.Items[0] as Team;
                Team awayTeam = lstSelectedTeams.Items[1] as Team;
                lblMatch.Text = homeTeam.Name + "-" + awayTeam.Name;
                generateKoef();
            }
        }

        public void generateKoef()
        {
            Random random = new Random();

            Team t1 = lstSelectedTeams.Items[0] as Team;
            Team t2 = lstSelectedTeams.Items[1] as Team;
            int rankDifference = t1.Rank - t2.Rank;

            if (rankDifference > 0)
            {
                if (rankDifference > 200)
                {
                    txtCoef1.Text = string.Format("{0:0.00}", (random.Next(8, 10) + random.NextDouble()));
                    txtCoefX.Text = string.Format("{0:0.00}", (random.Next(2, 4) + random.NextDouble()));
                    txtCoef2.Text = string.Format("{0:0.00}", 1.10);
                }
                else if(rankDifference > 50)
                {
                    txtCoef1.Text = string.Format("{0:0.00}", (random.Next(2, 5) + random.NextDouble()));
                    txtCoefX.Text = string.Format("{0:0.00}", (2 + random.NextDouble()));
                    txtCoef2.Text = string.Format("{0:0.00}", (1 + random.NextDouble()) + 0.2);
                }
                else if(rankDifference > 10)
                {
                    txtCoef1.Text = string.Format("{0:0.00}", (2 + random.NextDouble()));
                    txtCoefX.Text = string.Format("{0:0.00}", (2 + random.NextDouble()));
                    txtCoef2.Text = string.Format("{0:0.00}", (2 + random.NextDouble()) - 0.4);
                }
                else
                {
                    txtCoef1.Text = string.Format("{0:0.00}", (2 + random.NextDouble()) - 0.4);
                    txtCoefX.Text = string.Format("{0:0.00}", (2 + random.NextDouble()));
                    txtCoef2.Text = string.Format("{0:0.00}", (2 + random.NextDouble()));
                }
            }
            else
            {
                if (rankDifference < -200)
                {
                    txtCoef1.Text = string.Format("{0:0.00}", 1.05);
                    txtCoefX.Text = string.Format("{0:0.00}", (random.Next(3, 5) + random.NextDouble()));
                    txtCoef2.Text = string.Format("{0:0.00}", (random.Next(10, 15) + random.NextDouble()));
                }
                else if(rankDifference < -50)
                {
                    txtCoef1.Text = string.Format("{0:0.00}", 1.30);
                    txtCoefX.Text = string.Format("{0:0.00}", (random.Next(2, 4) + random.NextDouble()));
                    txtCoef2.Text = string.Format("{0:0.00}", (random.Next(8, 13) + random.NextDouble()));
                }
                else if (rankDifference < -10)
                {
                    txtCoef1.Text = string.Format("{0:0.00}", (1 + random.NextDouble()));
                    txtCoefX.Text = string.Format("{0:0.00}", (2 + random.NextDouble()));
                    txtCoef2.Text = string.Format("{0:0.00}", (2 + random.NextDouble()));
                }
                else
                {
                    txtCoef1.Text = string.Format("{0:0.00}", (2 + random.NextDouble()) - 0.4);
                    txtCoefX.Text = string.Format("{0:0.00}", (2 + random.NextDouble()));
                    txtCoef2.Text = string.Format("{0:0.00}", (2 + random.NextDouble()));
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstSelectedTeams.SelectedIndex != -1)
            {
                lstSelectedTeams.Items.RemoveAt(lstSelectedTeams.SelectedIndex);
                lblMatch.Text = "";
                txtCoef1.Text = " ";
                txtCoef2.Text = " ";
                txtCoefX.Text = " ";
                flagAdded = true;
            }
            else
            {
                MessageBox.Show("Нема селектиран учесник за биршење");
            }
        }

        private void btnGenerateMatch_Click(object sender, EventArgs e)
        {
            if (lstSelectedTeams.Items.Count == 2)
            {
                if (txtTip.Text != "1" && txtTip.Text != "X" && txtTip.Text != "2")
                {
                    errorProvider1.SetError(txtTip, "Невалиден тип");
                }
                else if (lstMatch.Items.Count < 20)
                {
                    errorProvider1.SetError(txtTip, null);
                    float koef = 0;
                    if (txtTip.Text == "1")
                    {
                        koef = (float)Convert.ToDouble(txtCoef1.Text);
                    }
                    else if (txtTip.Text == "X")
                    {
                        koef = (float)Convert.ToDouble(txtCoefX.Text);
                    }
                    else if (txtTip.Text == "2")
                    {
                        koef = (float)Convert.ToDouble(txtCoef2.Text);
                    }
                    Match match = new Match(lstSelectedTeams.Items[0] as Team, lstSelectedTeams.Items[1] as Team, txtTip.Text, koef);
                    if (!contains(match))
                    {
                        lstMatch.Items.Add(match);
                        lblNumber.Text = lstMatch.Items.Count + "/20";
                        lblNumber.Visible = true;
                        pbMatches.Value += 5;
                        float fullCoef = (float)Convert.ToDouble(txtFullCoef.Text) * koef;
                        txtFullCoef.Text = fullCoef.ToString("F");
                        updateReward();
                        lstSelectedTeams.Items.Clear();
                        txtTip.Text = "";
                        txtCoef1.Text = " ";
                        txtCoef2.Text = " ";
                        txtCoefX.Text = " ";
                        lblMatch.Text = "";
                        flagAdded = true;
                    }
                    else
                    {
                        lstSelectedTeams.Items.Clear();
                        txtTip.Text = "";
                        MessageBox.Show("Не е дозволено да има исти учесник во повеќе натпревари");
                    }
                }
                else
                {
                    MessageBox.Show("Можете да одиграте максимум 20 мечеви");
                }
            }
            else
            {
                MessageBox.Show("Нема селектирано два учесници во натпреварот");
            }
        }

        public bool contains(Match newMatch) 
        {
            for (int i = 0; i < lstMatch.Items.Count; i++)
            {
                Match match = lstMatch.Items[i] as Match;
                if (match.HomeTeam == newMatch.HomeTeam || match.HomeTeam == newMatch.AwayTeam || match.AwayTeam == newMatch.HomeTeam || match.AwayTeam == newMatch.AwayTeam)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnDeleteMatch_Click(object sender, EventArgs e)
        {
            if (lstMatch.SelectedIndex != -1)
            {
                lblMatchTips.Text = "";
                pbMatches.Value -= 5;
                Match match = lstMatch.Items[lstMatch.SelectedIndex] as Match;
                float fullCoef = (float)Convert.ToDouble(txtFullCoef.Text) / (float)match.Koef;
                txtFullCoef.Text = fullCoef.ToString("F");
                lstMatch.Items.RemoveAt(lstMatch.SelectedIndex);
                lblNumber.Text = lstMatch.Items.Count + "/20";
            }
            else
            {
                MessageBox.Show("Нема селектиран меч за биршење");
            }
        }

        public void updateReward()
        {
            txtReward.Text = ((int)((float)Convert.ToDouble(txtBid.Text) * (float)Convert.ToDouble(txtFullCoef.Text))).ToString();
        }

        private void txtBid_TextChanged(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(txtBid.Text, out n);
            int granica = 100000;
            if (!isNumeric)
            {
                errorProvider1.SetError(txtBid, "Невалидна уплата");
            }
            else if (Convert.ToInt32(txtBid.Text) > granica)
            {
                errorProvider1.SetError(txtBid, "Невалидна уплата");
            }
            else
            {
                updateReward();
                errorProvider1.SetError(txtBid, null);
            }
        }

        private void btnCreateNewTicket_Click(object sender, EventArgs e)
        {
            List<Match> matches = new List<Match>();
            
            for (int i = 0; i < lstMatch.Items.Count; i++)
            {
                matches.Add(lstMatch.Items[i] as Match);
            }
            if (matches.Count != 0)
            {
                TicketsView tv = new TicketsView(DateTime.Now.ToString("M/d/yyyy"), matches, (float)Convert.ToDouble(txtReward.Text));
                tv.Show();
            }
        }

        public void fillListOfContenders(string name)
        {
            lstTeams.Items.Clear();
            lstSelectedTeams.Items.Clear();

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Data Source=DESKTOP-2LG7BAH\\SQLEXPRESS;Initial Catalog=Fudbalski Timovi;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT Rank, Name, Country FROM "+ name +"";

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (name == "handball_db")
                    {
                        Team team = new Team(reader["Name"].ToString(), "", Convert.ToInt32(reader["Rank"]));
                        lstTeams.Items.Add(team);
                    }
                    else {
                        Team team = new Team(reader["Name"].ToString(), reader["Country"].ToString(), Convert.ToInt32(reader["Rank"]));
                        lstTeams.Items.Add(team);
                    }
                    
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnFootball_Click(object sender, EventArgs e)
        {
            details = "football_db";
            lblGender.Visible = false;
            cbGender.Visible = false;
            fillListOfContenders("football_db");
            baseName = "football_db";
            clearCoef();
        }

        private void btnBasketball_Click(object sender, EventArgs e)
        {
            details = "basketball_db";
            lblGender.Visible = false;
            cbGender.Visible = false;
            fillListOfContenders("basketball_db");
            baseName = "basketball_db";
            clearCoef();
            cbCountry.Enabled = false;
        }

        private void btnHandball_Click(object sender, EventArgs e)
        {
            details = "handball_db";
            lblGender.Visible = false;
            cbGender.Visible = false;
            fillListOfContenders("handball_db");
            baseName = "handball_db";
            clearCoef();
            cbCountry.Enabled = false;
        }

        private void btnTennis_Click(object sender, EventArgs e)
        {
            lstTeams.Items.Clear();
            lstSelectedTeams.Items.Clear();
            lblGender.Visible = true;
            cbGender.Visible = true;
            cbCountry.SelectedIndex = -1;
            clearCoef();
            cbCountry.Enabled = false;
            cbGender.Text = "";
        }

        private void btnSnooker_Click(object sender, EventArgs e)
        {
            details = "snooker_db";
            lblGender.Visible = false;
            cbGender.Visible = false;
            fillListOfContenders("snooker_db");
            baseName = "snooker_db";
            clearCoef();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTeams.Items.Clear();
            cbCountry.Enabled = true;
            if (cbGender.SelectedItem.ToString() == "Мажи")
            {
                details = "tennis_atp_db";
                fillListOfContenders("tennis_atp_db");
                baseName = "tennis_atp_db";
                clearCoef();
            }
            else if (cbGender.SelectedItem.ToString() == "Жени")
            {
                details = "tennis_wta_db";
                fillListOfContenders("tennis_wta_db");
                baseName = "tennis_wta_db";
                clearCoef();
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCountry.SelectedIndex != -1)
            {
                lstTeams.Items.Clear();
                string country = cbCountry.SelectedItem.ToString();
                findCountry(baseName, country);
            }
            else
            {
                //fillListOfContenders(baseName);
            }
        }

        private void findCountry(string name, string country)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Data Source=DESKTOP-2LG7BAH\\SQLEXPRESS;Initial Catalog=Fudbalski Timovi;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select Rank, Name from " + name + " where Country=@country";
            command.Parameters.AddWithValue("@country", country);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (name == "handball_db")
                    {
                        Team team = new Team(reader["Name"].ToString(), "", Convert.ToInt32(reader["Rank"]));
                        lstTeams.Items.Add(team);
                    }
                    else
                    {
                        Team team = new Team(reader["Name"].ToString(), country, Convert.ToInt32(reader["Rank"]));
                        lstTeams.Items.Add(team);
                    }

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Details fd = new Details(details);
            fd.Show();
        }

        private void clearCoef()
        {
            lblMatch.Text = " ";
            txtCoef1.Text = " ";
            txtCoef2.Text = " ";
            txtCoefX.Text = " ";
            cbCountry.Enabled = true;
            cbCountry.SelectedIndex = -1;
            flagAdded = true;
        }
    }
}
