using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.UpdateOperation.Types;

namespace Assassins_game
{
    public class DB
    {
        public Assassins Assassins;
        public Missions mission;

        private string connectionString = "server=localhost;uid=root;password=;database=Assassins_DB;";
        
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public int GetAssassinId(int missionId)
        {
            int assassinId = -1;

            try
            {
                string assassinQuery = "SELECT assassin_id FROM mission WHERE mission_id = @missionId";
                using (MySqlConnection connection = GetConnection())
                using (MySqlCommand assassinCommand = new MySqlCommand(assassinQuery, connection))
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
            return assassinId;
        }

        public List<Missions> GetMissions()
        {
            List<Missions> missions = new List<Missions>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand("SELECT * FROM mission", connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int missionId = reader.GetInt32("mission_id");
                            string missionName = reader.GetString("mission_name");
                            string missionDescription = reader.GetString("mission_description");
                            string missionLocation = reader.GetString("mission_location");

                            Missions mission = new Missions(missionName, missionDescription, missionLocation);
                            missions.Add(mission);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retriving missions: " + ex.Message);
            }
            return missions;
        }

        public void MoveMissionToHistory(int missionId, MySqlConnection connection)
        {
            try
            {
                int assassinId = GetAssassinId(missionId);

                if (assassinId != -1)
                {
                    using (MySqlCommand moveToHistory = connection.CreateCommand())
                    {
                        moveToHistory.CommandText = "INSERT INTO mission_history (assassin_id, mission_id) VALUES (@assassinId, @missionId)";
                        moveToHistory.Parameters.AddWithValue("@assassinId", assassinId);
                        moveToHistory.Parameters.AddWithValue("@missionId", missionId);

                        connection.Open();
                        moveToHistory.ExecuteNonQuery();
                    }
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

        public void PopulateListViewUserMissions(ListView listViewUserMissions)
        {
            listViewUserMissions.Items.Clear();

            try
            {
                using (MySqlConnection connection = GetConnection())
                using (MySqlCommand command = new MySqlCommand("SELECT * FROM user_mission", connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string missionName = reader.GetString("mission_name");
                            string missionDescription = reader.GetString("mission_description");
                            ListViewItem item = new ListViewItem(missionName);
                            item.SubItems.Add(missionDescription);
                            listViewUserMissions.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving user missions: " + ex.Message);
            }
        }

        public void PopulateListViewHistoryMissions(ListView listViewHistoryMissions, MySqlConnection connection)
        {
            listViewHistoryMissions.Items.Clear();

            try
            {
                string historyQuery = "SELECT a.assassin_name, m.mission_name " +
                                      "FROM mission_history mh " +
                                      "JOIN assassins a ON mh.assassin_id = a.assassin_id " +
                                      "JOIN mission m ON mh.mission_id = m.mission_id";


                MySqlCommand historycommand = new MySqlCommand(historyQuery, connection);

                connection.Open();

                using(MySqlDataReader historyReader = historycommand.ExecuteReader())
                {
                    while (historyReader.Read())
                    {
                        string assassinName = historyReader.GetString("assassin_name");
                        string missionName = historyReader.GetString("mission_name");

                        string historyInfo = $"{assassinName} - {missionName}";
                        ListViewItem historyItem = new ListViewItem(historyInfo);
                        listViewHistoryMissions.Items.Add(historyItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
