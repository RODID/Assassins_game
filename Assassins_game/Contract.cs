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


        public Contract(List<Missions>missions, ListView listViewMissions, Stockholm_City_Missions stockholmCityMissions, string missionDescription)
        {
           
            InitializeComponent();
            this.missions = missions;
            this.listViewMissions = listViewMissions;
            this.connection = connection;
            this.stockholmCityMissions = stockholmCityMissions;
            missionDescriptionTextBoxAdd.Text = missionDescription;
            

        } 

        public void AddButtonPress_Click(object sender, EventArgs e)
        {
            try
            {
                string missionName = missionNameTextBox.Text;
                string missionDescription = missionDescriptionTextBoxAdd.Text;

                MissionManager.AddMission(missions, missionName, missionDescription, "");

                string filePath = "mission.json";
                stockholmCityMissions.PopulateJsonMissions(filePath);MissionManager.SaveMissionsToJson(missions, filePath);

                missionNameTextBox.Clear();
                missionDescriptionTextBoxAdd.Clear();

                stockholmCityMissions.PopulateListViewWithMissions();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }

        
    }
}
