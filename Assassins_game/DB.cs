﻿using MySql.Data.MySqlClient;
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

        private string connectionString = "server=localhost;uid=root;password=arjan123;database=Assassins_DB;";
        
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
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

        
    }
}
