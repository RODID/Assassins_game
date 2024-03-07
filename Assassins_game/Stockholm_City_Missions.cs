using MySql.Data.MySqlClient;

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

        public void AddMissionsToList(List<Missions> list)
        {
            foreach (Missions mission in list)
            {
                string missionInfo = $"{mission.missionId}: {mission.missionName}";
                listViewMissions.Items.Add(missionInfo);
            }
        }

        public void AddMissionsToHistoryList(List<Missions> list)
        {
            foreach (Missions mission in list)
            {
                string missionInfo = $"{mission.missionId}: {mission.missionName}";
                listViewHistoryMission.Items.Add(missionInfo);
            }
        }

        public void Stockholm_City_Missions_Load(object sender, EventArgs e)
        {
            PopulateListViewWithMissions();
            RefreshLiListViewWithNewAssassins();


        }

        public void PopulateAssassinsListView()
        {
            HashSet<int> existingAssassinIds = new HashSet<int>();
            existingAssassinIds.Clear();
            ListAssassinsForMissions.Clear();
            try
            {

                string assassinQuery = "SELECT assassin_id, assassin_name, assassin_rank FROM assassins;";
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
            try
            {
                string missionQuery = "SELECT mission_id, mission_name FROM mission";
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
                            missionIds.Add(missionId);
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

        public void PopulateJsonMissions(string filePath)
        {
            listViewMissions.Items.Clear();

            List<Missions> missions = MissionManager.LoadMissionsFromJson(filePath);

            foreach (Missions missions1 in missions)
            {
                string missionInfo = $"{missions1.missionId} - {missions1.missionName}";
                ListViewItem missionItem = new ListViewItem(missionInfo);
                listViewMissions.Items.Add(missionItem);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListAssassinsForMissions.SelectedItems.Count > 0 && listViewMissions.SelectedItems.Count > 0)
                {
                    ListViewItem selectedMisionItem = listViewMissions.SelectedItems[0];
                    ListViewItem selectedAssassinItem = ListAssassinsForMissions.SelectedItems[0];

                    string[] missionInfo = selectedMisionItem.SubItems[0].Text.Split(' ');
                    string[] assassinInfo = selectedAssassinItem.SubItems[0].Text.Split(' ');

                    string missionId = missionInfo[0];
                    string missionName = missionInfo[2];
                    string assassinName = assassinInfo[1];
                    string missionAssassinInfo = $"{missionId} - {missionName} - {assassinName}";

                    listViewHistoryMission.Items.Add(missionAssassinInfo);

                    listViewMissions.Items.Remove(selectedMisionItem);



                }

                else
                {
                    MessageBox.Show("Please select a mission and a assassin. ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return;
        }


        public void InsertMissionHistory(string missionName, string assassinName)
        {
            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    string missionIdQuery = "SELECT mission_id FROM mission WHERE mission_name = @missionName;";
                    MySqlCommand missionIdCommand = new MySqlCommand(missionIdQuery, connection);
                    missionIdCommand.Parameters.AddWithValue("@missionName", missionName);

                    string assassinIdQuery = "SELECT assassin_id FROM assassins WHERE assassin_name = @assassinName;";
                    MySqlCommand assassinIdCommand = new MySqlCommand(assassinIdQuery, connection);
                    assassinIdCommand.Parameters.AddWithValue("@assassinName", assassinName);

                    connection.Open();

                    int missionId = Convert.ToInt32(missionIdCommand.ExecuteScalar());
                    int assassinId = Convert.ToInt32(assassinIdCommand.ExecuteScalar());

                    string insertQuery = "INSERT INTO mission_history (assassin_id, mission_id) VALUES (@assassinId, @missionId);";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@assassinId", assassinId);
                    insertCommand.Parameters.AddWithValue("@missionId", missionId);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Mission history inserted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert mission history");
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
            string filePath = "mission.json";
            PopulateJsonMissions(filePath);

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

            Contract contract = new Contract(missions, listViewMissions, this, missionDescription);
            contract.ShowDialog();

        }

        private void RetriveJsonMissionsUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void RefreshLiListViewWithNewAssassins()
        {
            ListAssassinsForMissions.Items.Clear();

            PopulateAssassinsListView();
        }
    }
}
