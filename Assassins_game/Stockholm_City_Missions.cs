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
                item.SubItems.Add(mission.Mission_duration.ToString());

                listViewMissions.Items.Add(item);
            }
        }

        private void ListViewMissions(object sender, EventArgs e)
        {
            
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
    }
}
