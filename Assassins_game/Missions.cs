using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assassins_game
{
    public class Missions
    {
        DB db = new DB();

        public Missions(int missionId, string missionName, string missionDescription, string missionLocation)
        {
            this.missionId = missionId;
            this.missionName = missionName;
            this.missionDescription = missionDescription;
            this.missionLocation = missionLocation;
        }

        public int missionId { get; set; }
        public string missionName { get; set; }
        public string missionDescription { get; set; }
        public string missionLocation { get; set; }


    }

}
