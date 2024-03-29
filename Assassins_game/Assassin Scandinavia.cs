﻿using System;
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
        private Stockholm_City_Missions stockholm_City_Missions;
        private readonly DB db = new DB();
        public List<Missions> Missions = new List<Missions>();
        public Contract contract;

        public Assassin_Scandinavia()
        {
            InitializeComponent();
            stockholm_City_Missions = new Stockholm_City_Missions(db.GetConnection());
            
        }

        private void Assassin_Scandinavia_Load(object sender, EventArgs e)
        {
            
        }

        private void Stockholm_Mission_Button_Click(object sender, EventArgs e)
        {
            Stockholm_City_Missions stockholm_City_Missions = new Stockholm_City_Missions(db.GetConnection());
            stockholm_City_Missions.ShowDialog();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            RefreshMissions();
        }

        private void RefreshMissions()
        {
            List<Missions> allMissions = db.GetMissions();
            Missions = allMissions;

            RefreshButtonMissionList(Stockholm_Mission_Button, Missions);

        }

        public void RefreshButtonMissionList (Button button, List<Missions> missions)
        {
            button.Text = string.Empty;

            foreach (Missions mission in missions)
            {
                button.Text += mission.missionName + Environment.NewLine;
            }
        }

        
    }
}
