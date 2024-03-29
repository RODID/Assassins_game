﻿using MySql.Data.MySqlClient;

namespace Assassins_game
{
    public partial class Stockholm_City_Missions : Form
    {
        public MySqlConnection connection;
        public DB db = new();
        public List<Assassins> assassinslist = new List<Assassins>();
        public List<History> historylist = new List<History>();
        public List<Missions> missions = new List<Missions>();
        public int remainingSeconds = 5;
        public Assassin_Scandinavia assassinScandinavia;



        public Stockholm_City_Missions(MySqlConnection mySqlConnection)
        {
            InitializeComponent();

            this.connection = mySqlConnection;

            listViewMissions.View = View.List;
            listViewMissions.SelectedIndexChanged += listViewMissions_SelectedIndexChanged;



        }

        public void Stockholm_City_Missions_Load(object sender, EventArgs e)
        {
            PopulateListViewWithMissions();
            RefreshLiListViewWithNewAssassins();


        }
        private void RefreshLiListViewWithNewAssassins()
        {
            ListAssassinsForMissions.Items.Clear();
            PopulateAssassinsListView();
        }

        public void PopulateAssassinsListView()
        {
            HashSet<int> existingAssassinIds = new HashSet<int>();
            existingAssassinIds.Clear();
            ListAssassinsForMissions.Clear();
            try
            {

                string assassinQuery = "SELECT assassin_id, assassin_name, assassin_rank FROM assassins ORDER BY assassin_id;";
                MySqlCommand assassinCommand = new MySqlCommand(assassinQuery, connection);

                connection.Open();

                using (MySqlDataReader assassinReader = assassinCommand.ExecuteReader())
                {
                    while (assassinReader.Read())
                    {
                        int assassinId = assassinReader.GetInt32("assassin_id");
                        string assassinName = assassinReader.GetString("assassin_name");
                        string assassinRank = assassinReader.GetString("assassin_rank");

                        existingAssassinIds.Add(assassinId);

                        string assassinInfo = $"{assassinName} - Rank: {assassinRank}";
                        ListAssassinsForMissions.Items.Add(assassinInfo);
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

        public void PopulateListViewWithMissions()
        {
            HashSet<int> missionIds = new HashSet<int>();
            listViewMissions.Items.Clear();
            try
            {
                string missionQuery = "SELECT mission_id, mission_name FROM mission ORDER BY mission_id";
                MySqlCommand missionCommand = new MySqlCommand(missionQuery, connection);

                connection.Open();

                using (MySqlDataReader missionReader = missionCommand.ExecuteReader())
                {
                    while (missionReader.Read())
                    {
                        int missionId = missionReader.GetInt32("mission_id");
                        string missionName = missionReader.GetString("mission_name");


                        if (!missionIds.Contains(missionId))
                        {
                            Missions newMission = new Missions();
                            newMission.missionId = missionId;
                            newMission.missionName = missionName;
                            missions.Add(newMission);

                            string missionInfo = $"{missionId} - {missionName}";
                            ListViewItem misisonItem = new ListViewItem(missionInfo);
                            listViewMissions.Items.Add(missionInfo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }


        

        public void SendButton_Click(object sender, EventArgs e)
        {
            if (ListAssassinsForMissions.SelectedItems.Count > 0 && listViewMissions.SelectedItems.Count > 0)
            {
                string selectedAssassinInfo = ListAssassinsForMissions.SelectedItems[0].Text;
                string selectedMissionInfo = listViewMissions.SelectedItems[0].Text;

                string assassinName = selectedAssassinInfo.Split('-')[0].Trim();
                string missionName = selectedMissionInfo.Split('-')[1].Trim();

                InsertMissionHistory(assassinName, missionName);

                listViewMissions.Items.Remove(listViewMissions.SelectedItems[0]);

                listViewHistoryMission.Items.Add(selectedMissionInfo);
            }
            else if (ListAssassinsForMissions.SelectedItems.Count > 0 && listViewUserMissions.SelectedItems.Count > 0)
            {
                string selectedAssassinInfo = ListAssassinsForMissions.SelectedItems[0].Text;
                string selectedMissionInfo = listViewUserMissions.SelectedItems[0].Text;

                string assassinName = selectedAssassinInfo.Split('-')[0].Trim();
                string missionName = GetMissionName(selectedMissionInfo);

                InsertMissionHistory(assassinName, missionName);
                
                listViewUserMissions.Items.Remove(listViewUserMissions.SelectedItems[0]);

                listViewHistoryMission.Items.Add(selectedMissionInfo);
            }
            else
            {
                MessageBox.Show("Please select an assassin and a mission.");
            }
        }

        private string GetMissionName(string selectedMissionInfo)
        {
            if (selectedMissionInfo.Contains('-'))
            {
                return selectedMissionInfo.Split('-')[1].Trim();
            }
            else 
            { 
                return selectedMissionInfo;
            }
        }

        public void InsertMissionHistory(string assassinName, string missionName)
        {
            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    string assassinIdQuery = "SELECT assassin_id FROM assassins WHERE assassin_name = @assassinName";
                    MySqlCommand assassinIdCommand = new MySqlCommand(assassinIdQuery, connection);
                    assassinIdCommand.Parameters.AddWithValue("@assassinName", assassinName);

                    connection.Open();
                    object result = assassinIdCommand.ExecuteScalar();

                    if (result != null)
                    {
                        int assassinId = Convert.ToInt32(result);

                        string missionIdQuery = "SELECT mission_id FROM mission WHERE mission_name = @missionName";
                        MySqlCommand missionIdCommand = new MySqlCommand(missionIdQuery, connection);
                        missionIdCommand.Parameters.AddWithValue("@missionName", missionName);

                        result = missionIdCommand.ExecuteScalar();

                        if (result != null)
                        {
                            int missionId = Convert.ToInt32(result);

                            string insertQuery = "INSERT INTO mission_history (assassin_id, mission_id) VALUES (@assassinId, @missionId)";
                            MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                            insertCommand.Parameters.AddWithValue("@assassinId", assassinId);
                            insertCommand.Parameters.AddWithValue("@missionId", missionId);

                            int rowsAffected = insertCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Mission history inserted successfully!");

                                string historyInfo = $"{assassinName} - {missionName}";
                                ListViewItem historyItem = new ListViewItem(historyInfo);
                                listViewHistoryMission.Items.Add(historyItem);
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert mission history");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting mission history: " + ex.Message);
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Close();

        }


        public void MissionLoadButton_Click(object sender, EventArgs e)
        {
            PopulateListViewWithMissions();
            PopulateAssassinsListView();
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

        private void ListViewUserMissions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUserMissions.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewUserMissions.SelectedItems[0];

                try
                {
                    string[] missionInfo = selectedItem.Text.Split('-');

                    if (missionInfo.Length > 0)
                    {
                        string missionId = missionInfo[0];
                        string missionName = string.Join(" ", missionInfo.Skip(1));

                        string missionDescription = GetMissionDescription(missionId);

                        missionDescriptionTextBox.Text = missionDescription;
                    }
                    else
                    {
                        MessageBox.Show("Invalid format for mission information. ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while selecting mission: " + ex.Message);
                }

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

        private void missionDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddingMissions_Click(object sender, EventArgs e)
        {
            string missionDescription = missionDescriptionTextBox.Text;

            Contract contract = new Contract(missions, listViewMissions, this, missionDescription, listViewUserMissions);
            contract.ShowDialog();


        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            PopulateAssassinsListView();
            PopulateListViewWithMissions();
            db.PopulateListViewUserMissions(listViewUserMissions);
        }

        

        private void HotToPlay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
