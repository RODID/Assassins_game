using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Assassins_game
{
    public partial class Stockholm_City_Missions : Form
    {
        DB Database = new DB();
        public Stockholm_City_Missions()
        {
            InitializeComponent();
            MissionLoadButton.Click += MissionLoadButton_Click;
            populateListViewWithMissions();
        }

        private void Stockholm_City_Missions_Load(object sender, EventArgs e)
        {
            populateListViewWithMissions();
        }

        private void populateListViewWithMissions()
        {
            ListBoxMissions.Items.Clear();

            List<Missions> missions = Database.GetMissions();

            foreach (Missions mission in missions)
            {
                string missionInfo = $"ID: {mission.Mission_id}, Name: {mission.Mission_name}, {mission.Mission_description}, Duration: {mission.Mission_duration};"

                ListBoxMissions.Items.Add(missionInfo);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {

        }


        private void MissionLoadButton_Click(object sender, EventArgs e)
        {
            populateListViewWithMissions();
        }
    }
}
