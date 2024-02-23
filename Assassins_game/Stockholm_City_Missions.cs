using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Assassins_game
{
    public partial class Stockholm_City_Missions : Form
    {
        private readonly MySqlConnection connection;
        public Stockholm_City_Missions(MySqlConnection mySqlConnection)
        {
            InitializeComponent();
            MissionLoadButton.Click += MissionLoadButton_Click;
            this.connection = mySqlConnection;
            populateListViewWithMissions();
        }

        private void Stockholm_City_Missions_Load(object sender, EventArgs e)
        {
            populateListViewWithMissions();
        }

        private void populateListViewWithMissions()
        {
            try
            {
                string query = "SELECT mission_id, mission_name FROM mission";
                MySqlCommand command = new MySqlCommand(query, connection);

                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {

        }


        private void MissionLoadButton_Click(object sender, EventArgs e)
        {
            populateListViewWithMissions();
        }

        private void ListBoxMissions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
