﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assassins_game
{
    internal class DB
    {
        private string connectionString = "server=localhost;uid=root;password=arjan123;database=Assassins_DB";
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
        public List<Missions> GetMissions()
        {
            List<Missions> missions = new List<Missions>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM mission";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int missionId = Convert.ToInt32(reader["mission_id"]);
                        string missionName = reader["mission_name"].ToString();
                        string missionDescription = reader["mission_description"].ToString();
                        string missionLocation = reader["mission_location"].ToString();
                        TimeSpan missionDuration = TimeSpan.Parse(reader["mission_time"].ToString()); ;
                        
                        Missions mission = new Missions(missionId, missionName, missionDescription, missionLocation, missionDuration);
                        missions.Add(mission);
                    }
                }
            }
            return missions;
        }

        public int GetAssassinId(string username)
        {
            int assassinId = -1; // Default value if assassin ID is not found

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT assassin_id FROM assassins WHERE assassin_name = @username";
                    MySqlCommand getAssassinId = new MySqlCommand(query, connection);
                    getAssassinId.Parameters.AddWithValue("@username", username);

                    object result = getAssassinId.ExecuteScalar();
                    if (result != null)
                    {
                        assassinId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error getting assassin ID: " + ex.Message);
                }
            }

            return assassinId;
        }
    }
}
