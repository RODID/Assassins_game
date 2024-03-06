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
    public partial class Contract : Form
    {
        private List<Missions> missions = new List<Missions>();
        private int missionId = 1;
        public Contract()
        {
            InitializeComponent();
        }
        public void AddMissionsToList()
        {
            string missionName = missionNameTextBox.Text;
            string missionDescription = missionDescriptionTextBoxAdd.Text;

            if (!string.IsNullOrEmpty(missionName) && !string.IsNullOrEmpty(missionDescription))
            {
                Missions newMission = new Missions (0, missionName,missionDescription, "");
                missions.Add(newMission);
                missionId++;

                UpdateMissionListUI();

                missionNameTextBox.Clear();
                missionDescriptionTextBoxAdd.Clear();
            }
            else
            {
                MessageBox.Show("Please fill in the both mission name and description. ");
            }
        }

        private void UpdateMissionListUI()
        {
            throw new NotImplementedException();
        }
    }
}
