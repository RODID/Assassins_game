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
using System.Linq.Expressions;

namespace Assassins_game
{
    public partial class Stockholm_City_Missions : Form
    {
        private MySqlConnection connection;


        public Stockholm_City_Missions(MySqlConnection mySqlConnection)
        {
            InitializeComponent();
            MissionLoadButton.Click += MissionLoadButton_Click;


            this.connection = mySqlConnection;
            populateListViewWithMissions();
            populateListViewHistoryMissions();
            listViewMissions.View = View.List;
            
            listViewMissions.SelectedIndexChanged += listViewMissions_SelectedIndexChanged;
        }

        private void UpdateMissionStatus(string missionId)
        {
            try
            {
                string query = "UPDATE mission SET mission_status = 'Completed' WHERE mission_id = @missionId";
                MySqlCommand updateTime = new MySqlCommand(query, connection);
                updateTime.Parameters.AddWithValue("@missionId", missionId);

                connection.Open();
                updateTime.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating mission status: " + ex.Message);
            }
            finally 
            {
                connection.Close();
            }
        }
        private void populateListViewHistoryMissions()
        {
            try
            {
                string query = "SELECT mission_id, mission_name FROM mission where mission_status = 'Completed'";
                MySqlCommand updateTime = new MySqlCommand(query, connection);

                connection.Open();

                using (MySqlDataReader reader = updateTime.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int missionId = reader.GetInt32("mission_id");
                        string missionName = reader.GetString("mission_name");
                        string missionInfo = $"{missionId}{missionName}";

                        listViewMissions.Items.Add(missionInfo);
                    }
                }
                
            }
            catch ( Exception ex ) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally 
            { 
                connection.Close();
            }
          
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
            if (listViewMissions.SelectedItems.Count > 0)
            {
                string selectedItemText = listViewMissions.SelectedItems[0].Text;
                int missionId = int.Parse(selectedItemText.Split(' ')[0];

                CountdownTimer.Tag = missionId;
                CountdownTimer.Start();
            }
            else
            {
                MessageBox.Show("Please select a mission to start! ");
            }

            
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

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (CountdownTimer.Tag != null)
            {
                int missionId = (int)CountdownTimer.Tag;
                int remainingTime = GetRemainingTimeForMission(missionId);

                remainingTime--;

                UppdateRemainingTimeForMission(missionId, remainingTime);
                
                if (remainingTime <= 0)
                {
                    UpdateMissionStatus(missionId.ToString());

                    MoveMissionToHistory(missionId);

                    SendButton.Enabled = true;

                    MessageBox.Show("mission Completed!");
                    CountdownTimer.Stop();
                }
            }

            populateListViewWithMissions();
            populateListViewHistoryMissions();
        }

        private void MoveMissionToHistory(int missionId)
        {
            try
            {
                string query = "INSERT INTO mission_history (assassin_id, mission_id) VALEUS (@assassinId, @missionId)";
                MySqlCommand moveToHistory = new MySqlCommand(query, connection);
                moveToHistory.Parameters.AddWithValue("@assassinId", GetAssassinId());
                moveToHistory.Parameters.AddWithValue("@missionId", missionId);

                connection.Open();
                moveToHistory.ExecuteNonQuery();
            }
        }

        private void UppdateRemainingTimeForMission(int missionId, int remainingTime)
        {
            try
            {
                string query = "UPDATE mission SET mission_time = @remainingTime WHERE mission_id = @missionId";
                MySqlCommand timeUpdate = new MySqlCommand(query, connection);
                timeUpdate.Parameters.AddWithValue("@remainingTime", remainingTime);
                timeUpdate.Parameters.AddWithValue("@missionId", missionId);

                connection.Open();
                timeUpdate.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error updating remaining time for mission: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private int GetRemainingTimeForMission(int missionId)
        {
            int remainingTime = 0;
            try
            {
                string query = "SELECT missions_time FROM mission WHERE mission_id = @missionId";
                MySqlCommand getTime = new MySqlCommand(query, connection);
                getTime.Parameters.AddWithValue("@missionId", missionId);

                connection.Open();
                remainingTime = Convert.ToInt32(getTime.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return remainingTime;
        }

        private void missionDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
