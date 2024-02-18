using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assassins_game
{
    internal class DB
    {
        private string conectionstring = "server=localhost;uid=root;password=<arjan123>;database=<Assassins_DB>";

        public List<Missions> GetMissions()
        {
            List<Missions> missions = new List<Missions>();

            using (MySqlConnection connection = new MySqlConnection(conectionstring))
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
                        TimeSpan missionDuration = TimeSpan.Parse(reader["mission_time"].ToString()); ;
                        
                        Missions mission = new Missions(missionId, missionName, missionDescription, missionDuration);
                        missions.Add(mission);
                    }
                }
            }
            return missions;
        }
    }
}
