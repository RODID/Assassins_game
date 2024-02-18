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
    public partial class Assassin_Scandinavia : Form
    {
        private readonly DB db = new DB();
        private List<Missions> StockholmMissions = new List<Missions>();
        private List<Missions> HelsinkiMissions = new List<Missions>();
        private List<Missions> GotlandMissions = new List<Missions>();
        public Assassin_Scandinavia()
        {
            InitializeComponent();
        }

        private void Assassin_Scandinavia_Load(object sender, EventArgs e)
        {
            RefreshMissions();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Stockholm_Mission_Button_Click(object sender, EventArgs e)
        {

        }

        private void Helsinki_Mission_Button_Click(object sender, EventArgs e)
        {

        }

        private void Gotland_Mission_Button_Click(object sender, EventArgs e)
        {

        }

        private void Goteborg_Mission_Button_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            RefreshMissions();
        }

        private void RefreshMissions()
        {
            List<Missions> allMissions = db.GetMissions();
            StockholmMissions = allMissions.Where(m => m.Mission_Location == "Stockholm").ToList();
            HelsinkiMissions = allMissions.Where(m => m.Mission_Location == "Helsinki").ToList();
            GotlandMissions = allMissions.Where(m => m.Mission_Location == "Gotland").ToList() ;

            RefreshButtonMissionList(Stockholm_Mission_Button, StockholmMissions);
            RefreshButtonMissionList(Helsinki_Mission_Button, HelsinkiMissions);
            RefreshButtonMissionList(Gotland_Mission_Button, GotlandMissions);
        }

        private void RefreshButtonMissionList (Button button, List<Missions> missions)
        {
            button.Text = string.Empty;

            foreach (Missions mission in missions)
            {
                button.Text += mission.Mission_name + Environment.NewLine;
            }
        }

        
    }
}
