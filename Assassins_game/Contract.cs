using MySql.Data.MySqlClient;
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
        private List<Missions> missions;
        private ListView listViewMissions;
        private MySqlConnection connection;
        private Stockholm_City_Missions stockholmCityMissions;


        public Contract(List<Missions> missions, ListView listViewMissions, Stockholm_City_Missions stockholmCityMissions, string missionDescription)
        {

            InitializeComponent();
            this.missions = missions;
            this.listViewMissions = listViewMissions;
            this.connection = connection;
            this.stockholmCityMissions = stockholmCityMissions;
            missionDescriptionTextBoxAdd.Text = missionDescription;
            missionNameTextBox.Text = missionDescription;


        }

        public void AddButtonPress_Click(object sender, EventArgs e)
        {
            try
            {
                string missionName = missionNameTextBox.Text;
                string missionsDescription = missionDescriptionTextBoxAdd.Text;

                int maxId = missions.Count > 0 ? missions.Max(m => m.missionId) : 0;
                int newMissionId = maxId + 1;

                Missions newMission = new Missions(newMissionId, missionName, missionsDescription, "");
                missions.Add(newMission);

                string filePath = "mission.json";
                MissionManager.SaveMissionsToJson(missions, filePath);

                stockholmCityMissions.PopulateListViewWithMissions();

                missionNameTextBox.Clear();
                missionDescriptionTextBoxAdd.Clear();
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
