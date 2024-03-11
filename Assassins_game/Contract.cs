using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.IsisMtt.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assassins_game
{
    public partial class Contract : Form
    {
        private DB db = new DB();
        private List<Missions> missions;
        private ListView listViewMissions;
        private ListView listViewUserMissions;
        private MySqlConnection connection;
        private Stockholm_City_Missions stockholmCityMissions;


        public Contract(List<Missions> missions, ListView listViewMissions , Stockholm_City_Missions stockholmCityMissions, string missionDescription, ListView listViewUserMissions)
        {

            InitializeComponent();
            this.missions = missions;
            this.listViewMissions = listViewMissions;
            this.connection = connection;
            this.stockholmCityMissions = stockholmCityMissions;
            this.listViewUserMissions = listViewUserMissions;
            missionDescriptionTextBoxAdd.Text = missionDescription;
            missionNameTextBox.Text = missionDescription;


        }

        public void AddButtonPress_Click(object sender, EventArgs e)
        {
            
            try
            {
                string missionName = missionNameTextBox.Text;
                string missionDescription = missionDescriptionTextBoxAdd.Text;

                using (MySqlConnection connection = db.GetConnection())
                {
                    string insertQuery = "INSERT INTO user_mission (mission_name, mission_description) VALUES (@missionName, @missionDescription)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@missionName", missionName);
                    insertCommand.Parameters.AddWithValue("@missionDescription", missionDescription);

                    connection.Open();
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if(rowsAffected >0)
                    {
                        MessageBox.Show("Mission added successfully!");
                        
                        db.PopulateListViewUserMissions(listViewUserMissions);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void missionNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
