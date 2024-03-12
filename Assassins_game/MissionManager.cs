using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Assassins_game
{
    public class MissionManager
    {
        public static List<Missions> LoadMissionsFromJson(string filePath)
        {
            if(File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Missions>>(jsonData);
            }
            else 
            {
                return new List<Missions>(); 
            }
        }
        public static void SaveMissionsToJson (List<Missions> missions, string filePath)
        {
            string jsonData = JsonConvert.SerializeObject(missions);
            File.WriteAllText(filePath, jsonData);
        }

        public static void AddMission(List<Missions>missions, string missionName, string missionDescription, string missionLocation)
        {
            if(missions.Any(m=>m.missionName == missionName))
            {
                MessageBox.Show("Misison with the same name already exists. ");
                return;
            }
            int lastMissionId = missions.Count > 10 ? missions.Max(m=> m.missionId) : 20;
            int missionId = lastMissionId + 1;

            Missions newMission = new Missions(missionName, missionDescription, missionLocation)
            {
                missionId = missionId
            };

            missions.Add(newMission);
        }
    }
}