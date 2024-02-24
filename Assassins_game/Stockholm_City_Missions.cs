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
            listViewMissions.View = View.List;

            listViewMissions.SelectedIndexChanged += listViewMissions_SelectedIndexChanged;
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

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    listViewMissions.Items.Clear();

                    while (reader.Read())
                    {
                        int missionId = reader.GetInt32("mission_id");
                        string missionName = reader.GetString("mission_name");
                        string missionInfo = $"{missionId} {missionName}";

                        listViewMissions.Items.Add(missionInfo);
                    }
                }
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
            Close();

        }


        private void MissionLoadButton_Click(object sender, EventArgs e)
        {
            populateListViewWithMissions();
        }

        private void listViewMissions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMissions.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewMissions.SelectedItems[0];

                string[] missionInfo = selectedItem.Text.Split(',');
                string missionId = missionInfo[0];
                string missionName = string.Join(" ", missionInfo.Skip(1));

                string missionDescription = GetMissionDescription(missionId);

                // Set the wrapped description to the TextBox
                missionDescriptionTextBox.Text = missionDescription;
            }
        }


        private string GetMissionDescription(string missionId)
        {
            string missionDescription = "";

            try
            {
                string query = "SELECT mission_description FROM mission WHERE mission_id = @missionId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@missionId", missionId);

                connection.Open();
                missionDescription = command.ExecuteScalar()?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return missionDescription;


        }

    }
}
