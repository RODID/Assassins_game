using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.UpdateOperation.Types;

namespace Assassins_game
{
    public class DB
    {
        public Assassins Assassins;
        public Missions mission;

        private string connectionString = "server=localhost;uid=root;password=arjan123;database=Assassins_DB;";
        
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

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM mission;";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int missionId = Convert.ToInt32(reader["mission_id"]);
                        string missionName = reader["mission_name"].ToString();
                        string missionDescription = reader["mission_description"].ToString();
                        string missionLocation = reader["mission_location"].ToString();

                        Missions mission = new Missions(missionName, missionDescription, missionLocation);
                        missions.Add(mission);
                    }
                }
            }
            return missions;
        }

        

        
        public void MoveMissionToHistory(int missionId, MySqlConnection connection)
        {
            try
            {
                int assassinId = (int)GetAssassinId(missionId);

                if (assassinId != -1)
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
    }
}
