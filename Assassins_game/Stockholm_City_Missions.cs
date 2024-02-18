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
    public partial class Stockholm_City_Missions : Form
    {
        DB db = new DB();
        public Stockholm_City_Missions()
        {
            InitializeComponent();
        }

        private void LabelName_Click(object sender, EventArgs e)
        {

        }

        private void Stockholm_City_Missions_Load(object sender, EventArgs e)
        {
            
        }

        private void listViewMissions_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewMissions.Items.Clear();

            List<Missions> CityMissions = GetItemWithSpecificID(mission_id));

            foreach (var mission in CityMissions)
            {
                ListViewItem listItem = new ListViewItem(mission.Mission_id.ToString());
                listItem.SubItems.Add(mission.Mission_name);

                if (CityMissions ==)
            }
            
        }

        private List<Missions> GetItemWithSpecificID(object mission_id)
        {
            throw new NotImplementedException();
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
