using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Assassins_game
{
    public class Missions
    {
        DB db = new DB();

        
        public static int lastMissionId = 0;

        [JsonConstructor]
        public Missions(int missionId, string missionName, string missionDescription, string missionLocation)
        {
            this.missionId = lastMissionId;
            this.missionName = missionName;
            this.missionDescription = missionDescription;
            this.missionLocation = missionLocation;
            lastMissionId++;
        }

        public Missions(string missionName = "", string missionDescription = "", string missionLocation = "")
        {
            this.missionId = lastMissionId;
            this.missionName = missionName;
            this.missionDescription = missionDescription;
            this.missionLocation = missionLocation;
            lastMissionId++;
        }

        public int missionId { get; set; }
        public string missionName { get; set; }
        public string missionDescription { get; set; }
        public string missionLocation { get; set; }


    }

}
