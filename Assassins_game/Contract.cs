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

        public static List<Missions> GetAddedMissions()
        {
            throw new NotImplementedException();
        }

        public void AddButtonPress_Click(object sender, EventArgs e)
        {
            try
            {
                string missionName = missionNameTextBox.Text;
                string missionsDescription = missionDescriptionTextBoxAdd.Text;

                string filePath = "mission.json";
                List<Missions> missionFromJson = MissionManager.LoadMissionsFromJson(filePath);

                if(missionFromJson == null) 
                {
                    missionFromJson = new List<Missions>();
                }
                if(missionFromJson.Any(m => m.missionName == missionName))
                {
                    MessageBox.Show("mission witht the same nae already exist in JSON.");
                    return;
                }
                int maxId = missionFromJson.Count > 0 ? missionFromJson.Max(m => m.missionId) : 0;
                int newMissionId = maxId + 1;

                missionFromJson.Add(new Missions(newMissionId, missionName, missionsDescription, ""));

                MissionManager.SaveMissionsToJson(missionFromJson, filePath);

                stockholmCityMissions.PopulateListViewUserMissionsFormJson();
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
