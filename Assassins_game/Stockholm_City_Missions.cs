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

namespace Assassins_game
{
    public partial class Stockholm_City_Missions : Form
    {
        DB Database = new DB();
        public Stockholm_City_Missions()
        {
            InitializeComponent();
        }

        private void LabelName_Click(object sender, EventArgs e)
        {

        }

        private void Stockholm_City_Missions_Load(object sender, EventArgs e)
        {
            populateListViewWithMissions();
        }

        private void populateListViewWithMissions()
        {
            listViewMissions.Items.Clear();

            List<Missions> missions = Database.GetMissions();

            foreach (Missions mission in missions)
            {
                ListViewItem item = new ListViewItem(mission.Mission_id.ToString());
                item.SubItems.Add(mission.Mission_name);
                item.SubItems.Add(mission.Mission_description);
                item.SubItems.Add(mission.Mission_duration.ToString());

                listViewMissions.Items.Add(item);
            }
        }

        private void LabelId_Click(object sender, EventArgs e)
        {

        }

        private void LabelDescription_Click(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {

        }

        private void listViewMissions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMissions.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewMissions.SelectedItems[0];

                int missionId = int.Parse(selectedItem.SubItems[0].Text);
                string missionName = selectedItem.SubItems[1].Text;
                string missionDescritption = selectedItem.SubItems[2].Text;
                string missionDuration = selectedItem.SubItems[3].Text;

                LabelId.Text = "ID: " + missionId.ToString();
                LabelName.Text = "Name: " + missionName;
                LabelDescription.Text = "Descritption: " + missionDescription;
                LabelDuration.Text = "Duration: " + missionDuration;

                listViewMissions.SelectedIndexChanged += listViewMissions_SelectedIndexChanged;
            }
        }
    }
}
