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
using System.Timers;

namespace Assassins_game
{
    public partial class Stockholm_City_Missions : Form
    {
        private MySqlConnection connection;
        DB db = new DB();
        private System.Windows.Forms.Timer missionTimer;

        public Stockholm_City_Missions(MySqlConnection mySqlConnection)
        {
            InitializeComponent();
            MissionLoadButton.Click += MissionLoadButton_Click;


            this.connection = mySqlConnection;
            PopulateListViewWithMissions();
            PopulateListViewHistoryMissions();
            listViewMissions.View = View.List;
            listViewMissions.SelectedIndexChanged += listViewMissions_SelectedIndexChanged;

            missionTimer = new System.Windows.Forms.Timer();
            missionTimer.Enabled = true;
            missionTimer.Interval = 1000;
            missionTimer.Tick += MissionTimer_Tick;

            
        }

        public void MissionTimer_Tick(object? sender, EventArgs e)
        {
            int missionId = (int)missionTimer.Tag;
            int missionDurationInSeconds = db.GetMissionDuration(missionId);

            missionTimer.Interval = missionDurationInSeconds * 1000;

            missionTimer.Start();

            if(db.GetMissionDuration(missionId) <= 0 ) 
            {
                
            }
        }

        private void PopulateListViewHistoryMissions()
        {
            try
            {
                string query = "SELECT mission_id, mission_name FROM mission where completed = '1'";
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
                    reader.Close();
                }
                connection.Close();
                
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

        }

        private void PopulateListViewWithMissions()
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
                int missionId = int.Parse(selectedItemText.Split(' ')[0]);

                int missionDurationInSeconds = db.GetMissionDuration(missionId);
                if(missionDurationInSeconds > 0)
                {
                    missionTimer.Tag = missionId;

                    missionTimer.Start();

                }
                else
                {
                    MessageBox.Show("Mission Duration is not valid. come back to this mission later!");
                }
            }
            else
            {
                MessageBox.Show("Please select a mission to start! ");
            }
        }

        

        private void StartMissionTimer(int missionId, int missionDurrationInSeconds)
        {
            missionTimer.Start();

            missionTimer.Tag = missionId;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Close();

        }


        private void MissionLoadButton_Click(object sender, EventArgs e)
        {
            PopulateListViewWithMissions();
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

        

        public void MoveMissionToHistory(int missionId)
        {
            try
            {
                int assassinId = (int)GetAssassinId(missionId);

                if(assassinId != -1)
                {
                    string query = "INSERT INTO mission_history (assassin_id, mission_id) VALUES (@assassinId, @missionId)";
                    MySqlCommand moveToHistory = new MySqlCommand(query, connection);
                    moveToHistory.Parameters.AddWithValue("@assassinId", assassinId);
                    moveToHistory.Parameters.AddWithValue("@missionId", missionId);

                    connection.Open();
                    moveToHistory.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Assassin ID not found for mission ID: " + missionId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error moving mission to history: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private object GetAssassinId(int missionId)
        {
            int assassinId = -1;

            try
            {
                string assassinQuery = "SELECT assassin_id FROM mission WHERE mission_id =@missionId;";
                using (MySqlCommand assassinCommand = new MySqlCommand (assassinQuery, connection))
                {
                    assassinCommand.Parameters.AddWithValue("@missionId", missionId);

                    connection.Open();
                    object result = assassinCommand.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        assassinId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting assassin ID: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return assassinId;
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
