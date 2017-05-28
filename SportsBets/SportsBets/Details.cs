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
    public partial class Details : Form
    {
        public Details(string details)
        {
            InitializeComponent();
            fillDetails(details);
        }

        public void fillDetails(string name)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Data Source=DESKTOP-2LG7BAH\\SQLEXPRESS;Initial Catalog=Fudbalski Timovi;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM " + name + "";

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(dt);
                gvDetails.DataSource = dt;

                command.ExecuteNonQuery();
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
    }
}
